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
        Task<string> CreateNewPoolRequestAsync(long chainId, Enum contractType, CreateNewPoolFunction createNewPoolFunction);

        Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CreateNewPoolFunction createNewPoolFunction, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewPoolRequestAsync(long chainId, Enum contractType, string token, BigInteger returnValue2, BigInteger returnValue3, BigInteger returnValue4, BigInteger startAmount, string owner);

        Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string token, BigInteger returnValue2, BigInteger returnValue3, BigInteger returnValue4, BigInteger startAmount, string owner, CancellationTokenSource cancellationToken = null);

        Task<string> FinalizeRequestAsync(long chainId, Enum contractType, FinalizeFunction finalizeFunction);

        Task<TransactionReceipt> FinalizeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, FinalizeFunction finalizeFunction, CancellationTokenSource cancellationToken = null);

        Task<string> FinalizeRequestAsync(long chainId, Enum contractType, string newVault);

        Task<TransactionReceipt> FinalizeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string newVault, CancellationTokenSource cancellationToken = null);

        Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> FullMigrateRequestAsync(long chainId, Enum contractType, FullMigrateFunction fullMigrateFunction);

        Task<string> FullMigrateRequestAsync(long chainId, Enum contractType);

        Task<TransactionReceipt> FullMigrateRequestAndWaitForReceiptAsync(long chainId, Enum contractType, FullMigrateFunction fullMigrateFunction, CancellationTokenSource cancellationToken = null);

        Task<TransactionReceipt> FullMigrateRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CancellationTokenSource cancellationToken = null);

        Task<BigInteger> GetUserV1AmountQueryAsync(long chainId, Enum contractType, GetUserV1AmountFunction getUserV1AmountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetUserV1AmountQueryAsync(long chainId, Enum contractType, string user, BlockParameter blockParameter = null);

        Task<string> LockDealNFTQueryAsync(long chainId, Enum contractType, LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null);

        Task<string> LockDealNFTQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> NewVaultQueryAsync(long chainId, Enum contractType, NewVaultFunction newVaultFunction, BlockParameter blockParameter = null);

        Task<string> NewVaultQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> OldVaultQueryAsync(long chainId, Enum contractType, OldVaultFunction oldVaultFunction, BlockParameter blockParameter = null);

        Task<string> OldVaultQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> OwnerQueryAsync(long chainId, Enum contractType, OwnerFunction ownerFunction, BlockParameter blockParameter = null);

        Task<string> OwnerQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, string firewall);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewall, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, string firewallAdmin);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null);

        Task<string> TokenQueryAsync(long chainId, Enum contractType, TokenFunction tokenFunction, BlockParameter blockParameter = null);

        Task<string> TokenQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> WithdrawTokensFromV1VaultRequestAsync(long chainId, Enum contractType, WithdrawTokensFromV1VaultFunction withdrawTokensFromV1VaultFunction);

        Task<string> WithdrawTokensFromV1VaultRequestAsync(long chainId, Enum contractType);

        Task<TransactionReceipt> WithdrawTokensFromV1VaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, WithdrawTokensFromV1VaultFunction withdrawTokensFromV1VaultFunction, CancellationTokenSource cancellationToken = null);

        Task<TransactionReceipt> WithdrawTokensFromV1VaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CancellationTokenSource cancellationToken = null);
    }
}
