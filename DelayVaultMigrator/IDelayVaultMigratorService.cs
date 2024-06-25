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
    public interface IDelayVaultMigratorService
    {
        public Task<string> CreateNewPoolRequestAsync(CreateNewPoolFunction createNewPoolFunction);

        public Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(CreateNewPoolFunction createNewPoolFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewPoolRequestAsync(string token, BigInteger returnValue2, BigInteger returnValue3, BigInteger returnValue4, BigInteger startAmount, string owner);

        public Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(string token, BigInteger returnValue2, BigInteger returnValue3, BigInteger returnValue4, BigInteger startAmount, string owner, CancellationTokenSource cancellationToken = null);

        public Task<string> FinalizeRequestAsync(FinalizeFunction finalizeFunction);

        public Task<TransactionReceipt> FinalizeRequestAndWaitForReceiptAsync(FinalizeFunction finalizeFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> FinalizeRequestAsync(string newVault);

        public Task<TransactionReceipt> FinalizeRequestAndWaitForReceiptAsync(string newVault, CancellationTokenSource cancellationToken = null);

        public Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        public Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null);

        public Task<string> FullMigrateRequestAsync(FullMigrateFunction fullMigrateFunction);

        public Task<string> FullMigrateRequestAsync();

        public Task<TransactionReceipt> FullMigrateRequestAndWaitForReceiptAsync(FullMigrateFunction fullMigrateFunction, CancellationTokenSource cancellationToken = null);

        public Task<TransactionReceipt> FullMigrateRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null);

        public Task<BigInteger> GetUserV1AmountQueryAsync(GetUserV1AmountFunction getUserV1AmountFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> GetUserV1AmountQueryAsync(string user, BlockParameter blockParameter = null);

        public Task<string> LockDealNFTQueryAsync(LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null);

        public Task<string> LockDealNFTQueryAsync(BlockParameter blockParameter = null);

        public Task<string> NewVaultQueryAsync(NewVaultFunction newVaultFunction, BlockParameter blockParameter = null);

        public Task<string> NewVaultQueryAsync(BlockParameter blockParameter = null);

        public Task<string> OldVaultQueryAsync(OldVaultFunction oldVaultFunction, BlockParameter blockParameter = null);

        public Task<string> OldVaultQueryAsync(BlockParameter blockParameter = null);

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null);

        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null);

        public Task<string> SetFirewallRequestAsync(SetFirewallFunction setFirewallFunction);

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallRequestAsync(string firewall);

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(string firewall, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallAdminRequestAsync(SetFirewallAdminFunction setFirewallAdminFunction);

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallAdminRequestAsync(string firewallAdmin);

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(string firewallAdmin, CancellationTokenSource cancellationToken = null);

        public Task<string> TokenQueryAsync(TokenFunction tokenFunction, BlockParameter blockParameter = null);

        public Task<string> TokenQueryAsync(BlockParameter blockParameter = null);

        public Task<string> WithdrawTokensFromV1VaultRequestAsync(WithdrawTokensFromV1VaultFunction withdrawTokensFromV1VaultFunction);

        public Task<string> WithdrawTokensFromV1VaultRequestAsync();

        public Task<TransactionReceipt> WithdrawTokensFromV1VaultRequestAndWaitForReceiptAsync(WithdrawTokensFromV1VaultFunction withdrawTokensFromV1VaultFunction, CancellationTokenSource cancellationToken = null);

        public Task<TransactionReceipt> WithdrawTokensFromV1VaultRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null);

        public void Initialize(IWeb3 web3, string contractAddress);
    }
}
