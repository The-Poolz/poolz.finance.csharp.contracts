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
    public interface IDelayVaultProviderService<in TContractType>
        where TContractType : Enum
    {
        Task<BigInteger> BalanceOfQueryAsync(long chainId, TContractType contractType, BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null);

        Task<BigInteger> BalanceOfQueryAsync(long chainId, TContractType contractType, string user, BlockParameter blockParameter = null);

        Task<string> BeforeTransferRequestAsync(long chainId, TContractType contractType, BeforeTransferFunction beforeTransferFunction);

        Task<TransactionReceipt> BeforeTransferRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BeforeTransferFunction beforeTransferFunction, CancellationTokenSource cancellationToken = null);

        Task<string> BeforeTransferRequestAsync(long chainId, TContractType contractType, string from, string to, BigInteger poolId);

        Task<TransactionReceipt> BeforeTransferRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string from, string to, BigInteger poolId, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewDelayVaultRequestAsync(long chainId, TContractType contractType, CreateNewDelayVaultFunction createNewDelayVaultFunction);

        Task<TransactionReceipt> CreateNewDelayVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CreateNewDelayVaultFunction createNewDelayVaultFunction, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewDelayVaultRequestAsync(long chainId, TContractType contractType, string owner, List<BigInteger> @params);

        Task<TransactionReceipt> CreateNewDelayVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string owner, List<BigInteger> @params, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewDelayVaultWithSignatureRequestAsync(long chainId, TContractType contractType, CreateNewDelayVaultWithSignatureFunction createNewDelayVaultWithSignatureFunction);

        Task<TransactionReceipt> CreateNewDelayVaultWithSignatureRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CreateNewDelayVaultWithSignatureFunction createNewDelayVaultWithSignatureFunction, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewDelayVaultWithSignatureRequestAsync(long chainId, TContractType contractType, string owner, List<BigInteger> @params, byte[] signature);

        Task<TransactionReceipt> CreateNewDelayVaultWithSignatureRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string owner, List<BigInteger> @params, byte[] signature, CancellationTokenSource cancellationToken = null);

        Task<BigInteger> CurrentParamsTargetLengthQueryAsync(long chainId, TContractType contractType, CurrentParamsTargetLengthFunction currentParamsTargetLengthFunction, BlockParameter blockParameter = null);

        Task<BigInteger> CurrentParamsTargetLengthQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetParamsQueryAsync(long chainId, TContractType contractType, GetParamsFunction getParamsFunction, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetParamsQueryAsync(long chainId, TContractType contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(long chainId, TContractType contractType, GetSubProvidersPoolIdsFunction getSubProvidersPoolIdsFunction, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<BigInteger> GetTotalAmountQueryAsync(long chainId, TContractType contractType, GetTotalAmountFunction getTotalAmountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetTotalAmountQueryAsync(long chainId, TContractType contractType, string user, BlockParameter blockParameter = null);

        Task<GetTypeToProviderDataOutputDTO> GetTypeToProviderDataQueryAsync(long chainId, TContractType contractType, GetTypeToProviderDataFunction getTypeToProviderDataFunction, BlockParameter blockParameter = null);

        Task<GetTypeToProviderDataOutputDTO> GetTypeToProviderDataQueryAsync(long chainId, TContractType contractType, byte theType, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetWithdrawPoolParamsQueryAsync(long chainId, TContractType contractType, GetWithdrawPoolParamsFunction getWithdrawPoolParamsFunction, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetWithdrawPoolParamsQueryAsync(long chainId, TContractType contractType, BigInteger amount, byte theType, BlockParameter blockParameter = null);

        Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, TContractType contractType, GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, TContractType contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<string> LockDealNFTQueryAsync(long chainId, TContractType contractType, LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null);

        Task<string> LockDealNFTQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> MigratorQueryAsync(long chainId, TContractType contractType, MigratorFunction migratorFunction, BlockParameter blockParameter = null);

        Task<string> MigratorQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> NameQueryAsync(long chainId, TContractType contractType, NameFunction nameFunction, BlockParameter blockParameter = null);

        Task<string> NameQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<BigInteger> PoolIdToAmountQueryAsync(long chainId, TContractType contractType, PoolIdToAmountFunction poolIdToAmountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> PoolIdToAmountQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<string> RegisterPoolRequestAsync(long chainId, TContractType contractType, RegisterPoolFunction registerPoolFunction);

        Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, RegisterPoolFunction registerPoolFunction, CancellationTokenSource cancellationToken = null);

        Task<string> RegisterPoolRequestAsync(long chainId, TContractType contractType, BigInteger poolId, List<BigInteger> @params);

        Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger poolId, List<BigInteger> @params, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, string firewall);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewall, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, string firewallAdmin);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null);

        Task<string> SplitRequestAsync(long chainId, TContractType contractType, SplitFunction splitFunction);

        Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SplitFunction splitFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SplitRequestAsync(long chainId, TContractType contractType, BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio);

        Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio, CancellationTokenSource cancellationToken = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, TContractType contractType, SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, TContractType contractType, byte[] interfaceId, BlockParameter blockParameter = null);

        Task<byte> TheTypeOfQueryAsync(long chainId, TContractType contractType, TheTypeOfFunction theTypeOfFunction, BlockParameter blockParameter = null);

        Task<byte> TheTypeOfQueryAsync(long chainId, TContractType contractType, BigInteger amount, BlockParameter blockParameter = null);

        Task<string> TokenQueryAsync(long chainId, TContractType contractType, TokenFunction tokenFunction, BlockParameter blockParameter = null);

        Task<string> TokenQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, TContractType contractType, TokenOfOwnerByIndexFunction tokenOfOwnerByIndexFunction, BlockParameter blockParameter = null);

        Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, TContractType contractType, string user, BigInteger index, BlockParameter blockParameter = null);

        Task<TypeToProviderDataOutputDTO> TypeToProviderDataQueryAsync(long chainId, TContractType contractType, TypeToProviderDataFunction typeToProviderDataFunction, BlockParameter blockParameter = null);

        Task<TypeToProviderDataOutputDTO> TypeToProviderDataQueryAsync(long chainId, TContractType contractType, byte returnValue1, BlockParameter blockParameter = null);

        Task<byte> TypesCountQueryAsync(long chainId, TContractType contractType, TypesCountFunction typesCountFunction, BlockParameter blockParameter = null);

        Task<byte> TypesCountQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> UpgradeTypeRequestAsync(long chainId, TContractType contractType, UpgradeTypeFunction upgradeTypeFunction);

        Task<TransactionReceipt> UpgradeTypeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, UpgradeTypeFunction upgradeTypeFunction, CancellationTokenSource cancellationToken = null);

        Task<string> UpgradeTypeRequestAsync(long chainId, TContractType contractType, byte newType);

        Task<TransactionReceipt> UpgradeTypeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, byte newType, CancellationTokenSource cancellationToken = null);

        Task<BigInteger> UserToAmountQueryAsync(long chainId, TContractType contractType, UserToAmountFunction userToAmountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> UserToAmountQueryAsync(long chainId, TContractType contractType, string returnValue1, BlockParameter blockParameter = null);

        Task<byte> UserToTypeQueryAsync(long chainId, TContractType contractType, UserToTypeFunction userToTypeFunction, BlockParameter blockParameter = null);

        Task<byte> UserToTypeQueryAsync(long chainId, TContractType contractType, string returnValue1, BlockParameter blockParameter = null);

        Task<string> WithdrawRequestAsync(long chainId, TContractType contractType, WithdrawFunction withdrawFunction);

        Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, WithdrawFunction withdrawFunction, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawRequestAsync(long chainId, TContractType contractType, BigInteger tokenId);

        Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger tokenId, CancellationTokenSource cancellationToken = null);
    }
}
