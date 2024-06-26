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
using poolz.finance.csharp.contracts.DelayVaultMigrator.ContractDefinition;

namespace poolz.finance.csharp.contracts.DelayVaultMigrator
{
    public partial class DelayVaultMigratorService : IDelayVaultMigratorService
    {
        protected virtual IWeb3 Web3 { get; private set; }

        public virtual ContractHandler ContractHandler { get; private set; }

        public DelayVaultMigratorService() { }

        public DelayVaultMigratorService(Web3 web3, string contractAddress)
        {
            Initialize(web3, contractAddress);
        }

        public DelayVaultMigratorService(IWeb3 web3, string contractAddress)
        {
            Initialize(web3, contractAddress);
        }

        public void Initialize(IWeb3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        private void EnsureInitialized()
        {
            if (Web3 == null || ContractHandler == null)
            {
                throw new InvalidOperationException("The service has not been initialized. Please call the Initialize method with a valid IWeb3 instance and contract address.");
            }
        }

        public virtual Task<string> CreateNewPoolRequestAsync(CreateNewPoolFunction createNewPoolFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(createNewPoolFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(CreateNewPoolFunction createNewPoolFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewPoolFunction, cancellationToken);
        }

        public virtual Task<string> CreateNewPoolRequestAsync(string token, BigInteger returnValue2, BigInteger returnValue3, BigInteger returnValue4, BigInteger startAmount, string owner)
        {
            EnsureInitialized();
            var createNewPoolFunction = new CreateNewPoolFunction();
                createNewPoolFunction.Token = token;
                createNewPoolFunction.ReturnValue2 = returnValue2;
                createNewPoolFunction.ReturnValue3 = returnValue3;
                createNewPoolFunction.ReturnValue4 = returnValue4;
                createNewPoolFunction.StartAmount = startAmount;
                createNewPoolFunction.Owner = owner;
            
            return ContractHandler.SendRequestAsync(createNewPoolFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(string token, BigInteger returnValue2, BigInteger returnValue3, BigInteger returnValue4, BigInteger startAmount, string owner, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var createNewPoolFunction = new CreateNewPoolFunction();
                createNewPoolFunction.Token = token;
                createNewPoolFunction.ReturnValue2 = returnValue2;
                createNewPoolFunction.ReturnValue3 = returnValue3;
                createNewPoolFunction.ReturnValue4 = returnValue4;
                createNewPoolFunction.StartAmount = startAmount;
                createNewPoolFunction.Owner = owner;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewPoolFunction, cancellationToken);
        }

        public virtual Task<string> FinalizeRequestAsync(FinalizeFunction finalizeFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(finalizeFunction);
        }

        public virtual Task<TransactionReceipt> FinalizeRequestAndWaitForReceiptAsync(FinalizeFunction finalizeFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(finalizeFunction, cancellationToken);
        }

        public virtual Task<string> FinalizeRequestAsync(string newVault)
        {
            EnsureInitialized();
            var finalizeFunction = new FinalizeFunction();
                finalizeFunction.NewVault = newVault;
            
            return ContractHandler.SendRequestAsync(finalizeFunction);
        }

        public virtual Task<TransactionReceipt> FinalizeRequestAndWaitForReceiptAsync(string newVault, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var finalizeFunction = new FinalizeFunction();
                finalizeFunction.NewVault = newVault;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(finalizeFunction, cancellationToken);
        }

        public virtual Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(firewallAdminFunction, blockParameter);
        }

        public virtual Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(null, blockParameter);
        }

        public virtual Task<string> FullMigrateRequestAsync(FullMigrateFunction fullMigrateFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(fullMigrateFunction);
        }

        public virtual Task<string> FullMigrateRequestAsync()
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync<FullMigrateFunction>();
        }

        public virtual Task<TransactionReceipt> FullMigrateRequestAndWaitForReceiptAsync(FullMigrateFunction fullMigrateFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(fullMigrateFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> FullMigrateRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync<FullMigrateFunction>(null, cancellationToken);
        }

        public virtual Task<BigInteger> GetUserV1AmountQueryAsync(GetUserV1AmountFunction getUserV1AmountFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<GetUserV1AmountFunction, BigInteger>(getUserV1AmountFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetUserV1AmountQueryAsync(string user, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var getUserV1AmountFunction = new GetUserV1AmountFunction();
                getUserV1AmountFunction.User = user;
            
            return ContractHandler.QueryAsync<GetUserV1AmountFunction, BigInteger>(getUserV1AmountFunction, blockParameter);
        }

        public virtual Task<string> LockDealNFTQueryAsync(LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<LockDealNFTFunction, string>(lockDealNFTFunction, blockParameter);
        }

        public virtual Task<string> LockDealNFTQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<LockDealNFTFunction, string>(null, blockParameter);
        }

        public virtual Task<string> NewVaultQueryAsync(NewVaultFunction newVaultFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<NewVaultFunction, string>(newVaultFunction, blockParameter);
        }

        public virtual Task<string> NewVaultQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<NewVaultFunction, string>(null, blockParameter);
        }

        public virtual Task<string> OldVaultQueryAsync(OldVaultFunction oldVaultFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<OldVaultFunction, string>(oldVaultFunction, blockParameter);
        }

        public virtual Task<string> OldVaultQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<OldVaultFunction, string>(null, blockParameter);
        }

        public virtual Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        public virtual Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public virtual Task<string> SetFirewallRequestAsync(SetFirewallFunction setFirewallFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(string firewall)
        {
            EnsureInitialized();
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(string firewall, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(SetFirewallAdminFunction setFirewallAdminFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(string firewallAdmin)
        {
            EnsureInitialized();
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(string firewallAdmin, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> TokenQueryAsync(TokenFunction tokenFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<TokenFunction, string>(tokenFunction, blockParameter);
        }

        public virtual Task<string> TokenQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<TokenFunction, string>(null, blockParameter);
        }

        public virtual Task<string> WithdrawTokensFromV1VaultRequestAsync(WithdrawTokensFromV1VaultFunction withdrawTokensFromV1VaultFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(withdrawTokensFromV1VaultFunction);
        }

        public virtual Task<string> WithdrawTokensFromV1VaultRequestAsync()
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync<WithdrawTokensFromV1VaultFunction>();
        }

        public virtual Task<TransactionReceipt> WithdrawTokensFromV1VaultRequestAndWaitForReceiptAsync(WithdrawTokensFromV1VaultFunction withdrawTokensFromV1VaultFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawTokensFromV1VaultFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> WithdrawTokensFromV1VaultRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync<WithdrawTokensFromV1VaultFunction>(null, cancellationToken);
        }
    }
}
