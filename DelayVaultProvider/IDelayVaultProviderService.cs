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
using poolz.finance.csharp.contracts.DelayVaultProvider.ContractDefinition;

namespace poolz.finance.csharp.contracts.DelayVaultProvider
{
    public interface IDelayVaultProviderService
    {
        Task<BigInteger> BalanceOfQueryAsync(long chainId, Enum contractType, BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null);

        Task<BigInteger> BalanceOfQueryAsync(long chainId, Enum contractType, string user, BlockParameter blockParameter = null);

        Task<string> BeforeTransferRequestAsync(long chainId, Enum contractType, BeforeTransferFunction beforeTransferFunction);

        Task<TransactionReceipt> BeforeTransferRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BeforeTransferFunction beforeTransferFunction, CancellationTokenSource cancellationToken = null);

        Task<string> BeforeTransferRequestAsync(long chainId, Enum contractType, string from, string to, BigInteger poolId);

        Task<TransactionReceipt> BeforeTransferRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string from, string to, BigInteger poolId, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewDelayVaultRequestAsync(long chainId, Enum contractType, CreateNewDelayVaultFunction createNewDelayVaultFunction);

        Task<TransactionReceipt> CreateNewDelayVaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CreateNewDelayVaultFunction createNewDelayVaultFunction, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewDelayVaultRequestAsync(long chainId, Enum contractType, string owner, List<BigInteger> @params);

        Task<TransactionReceipt> CreateNewDelayVaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string owner, List<BigInteger> @params, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewDelayVaultWithSignatureRequestAsync(long chainId, Enum contractType, CreateNewDelayVaultWithSignatureFunction createNewDelayVaultWithSignatureFunction);

        Task<TransactionReceipt> CreateNewDelayVaultWithSignatureRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CreateNewDelayVaultWithSignatureFunction createNewDelayVaultWithSignatureFunction, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewDelayVaultWithSignatureRequestAsync(long chainId, Enum contractType, string owner, List<BigInteger> @params, byte[] signature);

        Task<TransactionReceipt> CreateNewDelayVaultWithSignatureRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string owner, List<BigInteger> @params, byte[] signature, CancellationTokenSource cancellationToken = null);

        Task<BigInteger> CurrentParamsTargetLengthQueryAsync(long chainId, Enum contractType, CurrentParamsTargetLengthFunction currentParamsTargetLengthFunction, BlockParameter blockParameter = null);

        Task<BigInteger> CurrentParamsTargetLengthQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetParamsQueryAsync(long chainId, Enum contractType, GetParamsFunction getParamsFunction, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetParamsQueryAsync(long chainId, Enum contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(long chainId, Enum contractType, GetSubProvidersPoolIdsFunction getSubProvidersPoolIdsFunction, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(long chainId, Enum contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<BigInteger> GetTotalAmountQueryAsync(long chainId, Enum contractType, GetTotalAmountFunction getTotalAmountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetTotalAmountQueryAsync(long chainId, Enum contractType, string user, BlockParameter blockParameter = null);

        Task<GetTypeToProviderDataOutputDTO> GetTypeToProviderDataQueryAsync(long chainId, Enum contractType, GetTypeToProviderDataFunction getTypeToProviderDataFunction, BlockParameter blockParameter = null);

        Task<GetTypeToProviderDataOutputDTO> GetTypeToProviderDataQueryAsync(long chainId, Enum contractType, byte theType, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetWithdrawPoolParamsQueryAsync(long chainId, Enum contractType, GetWithdrawPoolParamsFunction getWithdrawPoolParamsFunction, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetWithdrawPoolParamsQueryAsync(long chainId, Enum contractType, BigInteger amount, byte theType, BlockParameter blockParameter = null);

        Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, Enum contractType, GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, Enum contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<string> LockDealNFTQueryAsync(long chainId, Enum contractType, LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null);

        Task<string> LockDealNFTQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> MigratorQueryAsync(long chainId, Enum contractType, MigratorFunction migratorFunction, BlockParameter blockParameter = null);

        Task<string> MigratorQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> NameQueryAsync(long chainId, Enum contractType, NameFunction nameFunction, BlockParameter blockParameter = null);

        Task<string> NameQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<BigInteger> PoolIdToAmountQueryAsync(long chainId, Enum contractType, PoolIdToAmountFunction poolIdToAmountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> PoolIdToAmountQueryAsync(long chainId, Enum contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<string> RegisterPoolRequestAsync(long chainId, Enum contractType, RegisterPoolFunction registerPoolFunction);

        Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, RegisterPoolFunction registerPoolFunction, CancellationTokenSource cancellationToken = null);

        Task<string> RegisterPoolRequestAsync(long chainId, Enum contractType, BigInteger poolId, List<BigInteger> @params);

        Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger poolId, List<BigInteger> @params, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, string firewall);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewall, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, string firewallAdmin);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null);

        Task<string> SplitRequestAsync(long chainId, Enum contractType, SplitFunction splitFunction);

        Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SplitFunction splitFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SplitRequestAsync(long chainId, Enum contractType, BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio);

        Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio, CancellationTokenSource cancellationToken = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, Enum contractType, SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, Enum contractType, byte[] interfaceId, BlockParameter blockParameter = null);

        Task<byte> TheTypeOfQueryAsync(long chainId, Enum contractType, TheTypeOfFunction theTypeOfFunction, BlockParameter blockParameter = null);

        Task<byte> TheTypeOfQueryAsync(long chainId, Enum contractType, BigInteger amount, BlockParameter blockParameter = null);

        Task<string> TokenQueryAsync(long chainId, Enum contractType, TokenFunction tokenFunction, BlockParameter blockParameter = null);

        Task<string> TokenQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, Enum contractType, TokenOfOwnerByIndexFunction tokenOfOwnerByIndexFunction, BlockParameter blockParameter = null);

        Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, Enum contractType, string user, BigInteger index, BlockParameter blockParameter = null);

        Task<TypeToProviderDataOutputDTO> TypeToProviderDataQueryAsync(long chainId, Enum contractType, TypeToProviderDataFunction typeToProviderDataFunction, BlockParameter blockParameter = null);

        Task<TypeToProviderDataOutputDTO> TypeToProviderDataQueryAsync(long chainId, Enum contractType, byte returnValue1, BlockParameter blockParameter = null);

        Task<byte> TypesCountQueryAsync(long chainId, Enum contractType, TypesCountFunction typesCountFunction, BlockParameter blockParameter = null);

        Task<byte> TypesCountQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> UpgradeTypeRequestAsync(long chainId, Enum contractType, UpgradeTypeFunction upgradeTypeFunction);

        Task<TransactionReceipt> UpgradeTypeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, UpgradeTypeFunction upgradeTypeFunction, CancellationTokenSource cancellationToken = null);

        Task<string> UpgradeTypeRequestAsync(long chainId, Enum contractType, byte newType);

        Task<TransactionReceipt> UpgradeTypeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, byte newType, CancellationTokenSource cancellationToken = null);

        Task<BigInteger> UserToAmountQueryAsync(long chainId, Enum contractType, UserToAmountFunction userToAmountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> UserToAmountQueryAsync(long chainId, Enum contractType, string returnValue1, BlockParameter blockParameter = null);

        Task<byte> UserToTypeQueryAsync(long chainId, Enum contractType, UserToTypeFunction userToTypeFunction, BlockParameter blockParameter = null);

        Task<byte> UserToTypeQueryAsync(long chainId, Enum contractType, string returnValue1, BlockParameter blockParameter = null);

        Task<string> WithdrawRequestAsync(long chainId, Enum contractType, WithdrawFunction withdrawFunction);

        Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, Enum contractType, WithdrawFunction withdrawFunction, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawRequestAsync(long chainId, Enum contractType, BigInteger tokenId);

        Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger tokenId, CancellationTokenSource cancellationToken = null);
    }
}
