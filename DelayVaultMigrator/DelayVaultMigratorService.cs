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
using NethereumGenerators.Interfaces;
using poolz.finance.csharp.contracts.DelayVaultMigrator.ContractDefinition;

namespace poolz.finance.csharp.contracts.DelayVaultMigrator
{
    public partial class DelayVaultMigratorService : IDelayVaultMigratorService
    {
        public IChainProvider ChainProvider { get; }

        public DelayVaultMigratorService(IChainProvider chainProvider)
        {
            ChainProvider = chainProvider;
        }

        private ContractHandler InitializeContractHandler(long chainId, Enum contractType)
        {
            var contractAddress = ChainProvider.ContractAddress(chainId, contractType);
            var web3 = ChainProvider.Web3(chainId);
            var contractHandler = web3.Eth.GetContractHandler(contractAddress);
            return contractHandler;
        }

        public virtual Task<string> CreateNewPoolRequestAsync(long chainId, Enum contractType, CreateNewPoolFunction createNewPoolFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewPoolFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CreateNewPoolFunction createNewPoolFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewPoolFunction, cancellationToken);
        }

        public virtual Task<string> CreateNewPoolRequestAsync(long chainId, Enum contractType, string token, BigInteger returnValue2, BigInteger returnValue3, BigInteger returnValue4, BigInteger startAmount, string owner)
        {
            var createNewPoolFunction = new CreateNewPoolFunction();
                createNewPoolFunction.Token = token;
                createNewPoolFunction.ReturnValue2 = returnValue2;
                createNewPoolFunction.ReturnValue3 = returnValue3;
                createNewPoolFunction.ReturnValue4 = returnValue4;
                createNewPoolFunction.StartAmount = startAmount;
                createNewPoolFunction.Owner = owner;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewPoolFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string token, BigInteger returnValue2, BigInteger returnValue3, BigInteger returnValue4, BigInteger startAmount, string owner, CancellationTokenSource cancellationToken = null)
        {
            var createNewPoolFunction = new CreateNewPoolFunction();
                createNewPoolFunction.Token = token;
                createNewPoolFunction.ReturnValue2 = returnValue2;
                createNewPoolFunction.ReturnValue3 = returnValue3;
                createNewPoolFunction.ReturnValue4 = returnValue4;
                createNewPoolFunction.StartAmount = startAmount;
                createNewPoolFunction.Owner = owner;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewPoolFunction, cancellationToken);
        }

        public virtual Task<string> FinalizeRequestAsync(long chainId, Enum contractType, FinalizeFunction finalizeFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(finalizeFunction);
        }

        public virtual Task<TransactionReceipt> FinalizeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, FinalizeFunction finalizeFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(finalizeFunction, cancellationToken);
        }

        public virtual Task<string> FinalizeRequestAsync(long chainId, Enum contractType, string newVault)
        {
            var finalizeFunction = new FinalizeFunction();
                finalizeFunction.NewVault = newVault;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(finalizeFunction);
        }

        public virtual Task<TransactionReceipt> FinalizeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string newVault, CancellationTokenSource cancellationToken = null)
        {
            var finalizeFunction = new FinalizeFunction();
                finalizeFunction.NewVault = newVault;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(finalizeFunction, cancellationToken);
        }

        public virtual Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<FirewallAdminFunction, string>(firewallAdminFunction, blockParameter);
        }

        public virtual Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<FirewallAdminFunction, string>(null, blockParameter);
        }

        public virtual Task<string> FullMigrateRequestAsync(long chainId, Enum contractType, FullMigrateFunction fullMigrateFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(fullMigrateFunction);
        }

        public virtual Task<string> FullMigrateRequestAsync(long chainId, Enum contractType)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync<FullMigrateFunction>();
        }

        public virtual Task<TransactionReceipt> FullMigrateRequestAndWaitForReceiptAsync(long chainId, Enum contractType, FullMigrateFunction fullMigrateFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(fullMigrateFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> FullMigrateRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync<FullMigrateFunction>(null, cancellationToken);
        }

        public virtual Task<BigInteger> GetUserV1AmountQueryAsync(long chainId, Enum contractType, GetUserV1AmountFunction getUserV1AmountFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetUserV1AmountFunction, BigInteger>(getUserV1AmountFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetUserV1AmountQueryAsync(long chainId, Enum contractType, string user, BlockParameter blockParameter = null)
        {
            var getUserV1AmountFunction = new GetUserV1AmountFunction();
                getUserV1AmountFunction.User = user;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetUserV1AmountFunction, BigInteger>(getUserV1AmountFunction, blockParameter);
        }

        public virtual Task<string> LockDealNFTQueryAsync(long chainId, Enum contractType, LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<LockDealNFTFunction, string>(lockDealNFTFunction, blockParameter);
        }

        public virtual Task<string> LockDealNFTQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<LockDealNFTFunction, string>(null, blockParameter);
        }

        public virtual Task<string> NewVaultQueryAsync(long chainId, Enum contractType, NewVaultFunction newVaultFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<NewVaultFunction, string>(newVaultFunction, blockParameter);
        }

        public virtual Task<string> NewVaultQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<NewVaultFunction, string>(null, blockParameter);
        }

        public virtual Task<string> OldVaultQueryAsync(long chainId, Enum contractType, OldVaultFunction oldVaultFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<OldVaultFunction, string>(oldVaultFunction, blockParameter);
        }

        public virtual Task<string> OldVaultQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<OldVaultFunction, string>(null, blockParameter);
        }

        public virtual Task<string> OwnerQueryAsync(long chainId, Enum contractType, OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        public virtual Task<string> OwnerQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public virtual Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, string firewall)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewall, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, string firewallAdmin)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> TokenQueryAsync(long chainId, Enum contractType, TokenFunction tokenFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenFunction, string>(tokenFunction, blockParameter);
        }

        public virtual Task<string> TokenQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenFunction, string>(null, blockParameter);
        }

        public virtual Task<string> WithdrawTokensFromV1VaultRequestAsync(long chainId, Enum contractType, WithdrawTokensFromV1VaultFunction withdrawTokensFromV1VaultFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawTokensFromV1VaultFunction);
        }

        public virtual Task<string> WithdrawTokensFromV1VaultRequestAsync(long chainId, Enum contractType)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync<WithdrawTokensFromV1VaultFunction>();
        }

        public virtual Task<TransactionReceipt> WithdrawTokensFromV1VaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, WithdrawTokensFromV1VaultFunction withdrawTokensFromV1VaultFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawTokensFromV1VaultFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> WithdrawTokensFromV1VaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync<WithdrawTokensFromV1VaultFunction>(null, cancellationToken);
        }
    }
}
