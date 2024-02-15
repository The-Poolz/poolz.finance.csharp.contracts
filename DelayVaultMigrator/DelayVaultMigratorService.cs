using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using poolz.finance.csharp.DelayVaultMigrator.ContractDefinition;

namespace poolz.finance.csharp.DelayVaultMigrator
{
    public partial class DelayVaultMigratorService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, DelayVaultMigratorDeployment delayVaultMigratorDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<DelayVaultMigratorDeployment>().SendRequestAndWaitForReceiptAsync(delayVaultMigratorDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, DelayVaultMigratorDeployment delayVaultMigratorDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<DelayVaultMigratorDeployment>().SendRequestAsync(delayVaultMigratorDeployment);
        }

        public static async Task<DelayVaultMigratorService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, DelayVaultMigratorDeployment delayVaultMigratorDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, delayVaultMigratorDeployment, cancellationTokenSource);
            return new DelayVaultMigratorService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.IWeb3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public DelayVaultMigratorService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public DelayVaultMigratorService(Nethereum.Web3.IWeb3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> CreateNewPoolRequestAsync(CreateNewPoolFunction createNewPoolFunction)
        {
             return ContractHandler.SendRequestAsync(createNewPoolFunction);
        }

        public Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(CreateNewPoolFunction createNewPoolFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewPoolFunction, cancellationToken);
        }

        public Task<string> CreateNewPoolRequestAsync(string token, BigInteger returnValue2, BigInteger returnValue3, BigInteger returnValue4, BigInteger startAmount, string owner)
        {
            var createNewPoolFunction = new CreateNewPoolFunction();
                createNewPoolFunction.Token = token;
                createNewPoolFunction.ReturnValue2 = returnValue2;
                createNewPoolFunction.ReturnValue3 = returnValue3;
                createNewPoolFunction.ReturnValue4 = returnValue4;
                createNewPoolFunction.StartAmount = startAmount;
                createNewPoolFunction.Owner = owner;
            
             return ContractHandler.SendRequestAsync(createNewPoolFunction);
        }

        public Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(string token, BigInteger returnValue2, BigInteger returnValue3, BigInteger returnValue4, BigInteger startAmount, string owner, CancellationTokenSource cancellationToken = null)
        {
            var createNewPoolFunction = new CreateNewPoolFunction();
                createNewPoolFunction.Token = token;
                createNewPoolFunction.ReturnValue2 = returnValue2;
                createNewPoolFunction.ReturnValue3 = returnValue3;
                createNewPoolFunction.ReturnValue4 = returnValue4;
                createNewPoolFunction.StartAmount = startAmount;
                createNewPoolFunction.Owner = owner;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewPoolFunction, cancellationToken);
        }

        public Task<string> FinalizeRequestAsync(FinalizeFunction finalizeFunction)
        {
             return ContractHandler.SendRequestAsync(finalizeFunction);
        }

        public Task<TransactionReceipt> FinalizeRequestAndWaitForReceiptAsync(FinalizeFunction finalizeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(finalizeFunction, cancellationToken);
        }

        public Task<string> FinalizeRequestAsync(string newVault)
        {
            var finalizeFunction = new FinalizeFunction();
                finalizeFunction.NewVault = newVault;
            
             return ContractHandler.SendRequestAsync(finalizeFunction);
        }

        public Task<TransactionReceipt> FinalizeRequestAndWaitForReceiptAsync(string newVault, CancellationTokenSource cancellationToken = null)
        {
            var finalizeFunction = new FinalizeFunction();
                finalizeFunction.NewVault = newVault;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(finalizeFunction, cancellationToken);
        }

        public Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(firewallAdminFunction, blockParameter);
        }

        
        public Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(null, blockParameter);
        }

        public Task<string> FullMigrateRequestAsync(FullMigrateFunction fullMigrateFunction)
        {
             return ContractHandler.SendRequestAsync(fullMigrateFunction);
        }

        public Task<string> FullMigrateRequestAsync()
        {
             return ContractHandler.SendRequestAsync<FullMigrateFunction>();
        }

        public Task<TransactionReceipt> FullMigrateRequestAndWaitForReceiptAsync(FullMigrateFunction fullMigrateFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(fullMigrateFunction, cancellationToken);
        }

        public Task<TransactionReceipt> FullMigrateRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<FullMigrateFunction>(null, cancellationToken);
        }

        public Task<BigInteger> GetUserV1AmountQueryAsync(GetUserV1AmountFunction getUserV1AmountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetUserV1AmountFunction, BigInteger>(getUserV1AmountFunction, blockParameter);
        }

        
        public Task<BigInteger> GetUserV1AmountQueryAsync(string user, BlockParameter blockParameter = null)
        {
            var getUserV1AmountFunction = new GetUserV1AmountFunction();
                getUserV1AmountFunction.User = user;
            
            return ContractHandler.QueryAsync<GetUserV1AmountFunction, BigInteger>(getUserV1AmountFunction, blockParameter);
        }

        public Task<string> LockDealNFTQueryAsync(LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<LockDealNFTFunction, string>(lockDealNFTFunction, blockParameter);
        }

        
        public Task<string> LockDealNFTQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<LockDealNFTFunction, string>(null, blockParameter);
        }

        public Task<string> NewVaultQueryAsync(NewVaultFunction newVaultFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NewVaultFunction, string>(newVaultFunction, blockParameter);
        }

        
        public Task<string> NewVaultQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NewVaultFunction, string>(null, blockParameter);
        }

        public Task<string> OldVaultQueryAsync(OldVaultFunction oldVaultFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OldVaultFunction, string>(oldVaultFunction, blockParameter);
        }

        
        public Task<string> OldVaultQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OldVaultFunction, string>(null, blockParameter);
        }

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        
        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public Task<string> SetFirewallRequestAsync(SetFirewallFunction setFirewallFunction)
        {
             return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public Task<string> SetFirewallRequestAsync(string firewall)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
             return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(string firewall, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public Task<string> SetFirewallAdminRequestAsync(SetFirewallAdminFunction setFirewallAdminFunction)
        {
             return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public Task<string> SetFirewallAdminRequestAsync(string firewallAdmin)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
             return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(string firewallAdmin, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public Task<string> TokenQueryAsync(TokenFunction tokenFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenFunction, string>(tokenFunction, blockParameter);
        }

        
        public Task<string> TokenQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenFunction, string>(null, blockParameter);
        }

        public Task<string> WithdrawTokensFromV1VaultRequestAsync(WithdrawTokensFromV1VaultFunction withdrawTokensFromV1VaultFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawTokensFromV1VaultFunction);
        }

        public Task<string> WithdrawTokensFromV1VaultRequestAsync()
        {
             return ContractHandler.SendRequestAsync<WithdrawTokensFromV1VaultFunction>();
        }

        public Task<TransactionReceipt> WithdrawTokensFromV1VaultRequestAndWaitForReceiptAsync(WithdrawTokensFromV1VaultFunction withdrawTokensFromV1VaultFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawTokensFromV1VaultFunction, cancellationToken);
        }

        public Task<TransactionReceipt> WithdrawTokensFromV1VaultRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<WithdrawTokensFromV1VaultFunction>(null, cancellationToken);
        }
    }
}
