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
        public Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> BalanceOfQueryAsync(string user, BlockParameter blockParameter = null);

        public Task<string> BeforeTransferRequestAsync(BeforeTransferFunction beforeTransferFunction);

        public Task<TransactionReceipt> BeforeTransferRequestAndWaitForReceiptAsync(BeforeTransferFunction beforeTransferFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> BeforeTransferRequestAsync(string from, string to, BigInteger poolId);

        public Task<TransactionReceipt> BeforeTransferRequestAndWaitForReceiptAsync(string from, string to, BigInteger poolId, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewDelayVaultRequestAsync(CreateNewDelayVaultFunction createNewDelayVaultFunction);

        public Task<TransactionReceipt> CreateNewDelayVaultRequestAndWaitForReceiptAsync(CreateNewDelayVaultFunction createNewDelayVaultFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewDelayVaultRequestAsync(string owner, List<BigInteger> @params);

        public Task<TransactionReceipt> CreateNewDelayVaultRequestAndWaitForReceiptAsync(string owner, List<BigInteger> @params, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewDelayVaultWithSignatureRequestAsync(CreateNewDelayVaultWithSignatureFunction createNewDelayVaultWithSignatureFunction);

        public Task<TransactionReceipt> CreateNewDelayVaultWithSignatureRequestAndWaitForReceiptAsync(CreateNewDelayVaultWithSignatureFunction createNewDelayVaultWithSignatureFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewDelayVaultWithSignatureRequestAsync(string owner, List<BigInteger> @params, byte[] signature);

        public Task<TransactionReceipt> CreateNewDelayVaultWithSignatureRequestAndWaitForReceiptAsync(string owner, List<BigInteger> @params, byte[] signature, CancellationTokenSource cancellationToken = null);

        public Task<BigInteger> CurrentParamsTargetLengthQueryAsync(CurrentParamsTargetLengthFunction currentParamsTargetLengthFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> CurrentParamsTargetLengthQueryAsync(BlockParameter blockParameter = null);

        public Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        public Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetParamsQueryAsync(GetParamsFunction getParamsFunction, BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetParamsQueryAsync(BigInteger poolId, BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(GetSubProvidersPoolIdsFunction getSubProvidersPoolIdsFunction, BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null);

        public Task<BigInteger> GetTotalAmountQueryAsync(GetTotalAmountFunction getTotalAmountFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> GetTotalAmountQueryAsync(string user, BlockParameter blockParameter = null);

        public Task<GetTypeToProviderDataOutputDTO> GetTypeToProviderDataQueryAsync(GetTypeToProviderDataFunction getTypeToProviderDataFunction, BlockParameter blockParameter = null);

        public Task<GetTypeToProviderDataOutputDTO> GetTypeToProviderDataQueryAsync(byte theType, BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetWithdrawPoolParamsQueryAsync(GetWithdrawPoolParamsFunction getWithdrawPoolParamsFunction, BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetWithdrawPoolParamsQueryAsync(BigInteger amount, byte theType, BlockParameter blockParameter = null);

        public Task<BigInteger> GetWithdrawableAmountQueryAsync(GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> GetWithdrawableAmountQueryAsync(BigInteger poolId, BlockParameter blockParameter = null);

        public Task<string> LockDealNFTQueryAsync(LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null);

        public Task<string> LockDealNFTQueryAsync(BlockParameter blockParameter = null);

        public Task<string> MigratorQueryAsync(MigratorFunction migratorFunction, BlockParameter blockParameter = null);

        public Task<string> MigratorQueryAsync(BlockParameter blockParameter = null);

        public Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null);

        public Task<string> NameQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> PoolIdToAmountQueryAsync(PoolIdToAmountFunction poolIdToAmountFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> PoolIdToAmountQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null);

        public Task<string> RegisterPoolRequestAsync(RegisterPoolFunction registerPoolFunction);

        public Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(RegisterPoolFunction registerPoolFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> RegisterPoolRequestAsync(BigInteger poolId, List<BigInteger> @params);

        public Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(BigInteger poolId, List<BigInteger> @params, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallRequestAsync(SetFirewallFunction setFirewallFunction);

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallRequestAsync(string firewall);

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(string firewall, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallAdminRequestAsync(SetFirewallAdminFunction setFirewallAdminFunction);

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallAdminRequestAsync(string firewallAdmin);

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(string firewallAdmin, CancellationTokenSource cancellationToken = null);

        public Task<string> SplitRequestAsync(SplitFunction splitFunction);

        public Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(SplitFunction splitFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SplitRequestAsync(BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio);

        public Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio, CancellationTokenSource cancellationToken = null);

        public Task<bool> SupportsInterfaceQueryAsync(SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null);

        public Task<bool> SupportsInterfaceQueryAsync(byte[] interfaceId, BlockParameter blockParameter = null);

        public Task<byte> TheTypeOfQueryAsync(TheTypeOfFunction theTypeOfFunction, BlockParameter blockParameter = null);

        public Task<byte> TheTypeOfQueryAsync(BigInteger amount, BlockParameter blockParameter = null);

        public Task<string> TokenQueryAsync(TokenFunction tokenFunction, BlockParameter blockParameter = null);

        public Task<string> TokenQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> TokenOfOwnerByIndexQueryAsync(TokenOfOwnerByIndexFunction tokenOfOwnerByIndexFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> TokenOfOwnerByIndexQueryAsync(string user, BigInteger index, BlockParameter blockParameter = null);

        public Task<TypeToProviderDataOutputDTO> TypeToProviderDataQueryAsync(TypeToProviderDataFunction typeToProviderDataFunction, BlockParameter blockParameter = null);

        public Task<TypeToProviderDataOutputDTO> TypeToProviderDataQueryAsync(byte returnValue1, BlockParameter blockParameter = null);

        public Task<byte> TypesCountQueryAsync(TypesCountFunction typesCountFunction, BlockParameter blockParameter = null);

        public Task<byte> TypesCountQueryAsync(BlockParameter blockParameter = null);

        public Task<string> UpgradeTypeRequestAsync(UpgradeTypeFunction upgradeTypeFunction);

        public Task<TransactionReceipt> UpgradeTypeRequestAndWaitForReceiptAsync(UpgradeTypeFunction upgradeTypeFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> UpgradeTypeRequestAsync(byte newType);

        public Task<TransactionReceipt> UpgradeTypeRequestAndWaitForReceiptAsync(byte newType, CancellationTokenSource cancellationToken = null);

        public Task<BigInteger> UserToAmountQueryAsync(UserToAmountFunction userToAmountFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> UserToAmountQueryAsync(string returnValue1, BlockParameter blockParameter = null);

        public Task<byte> UserToTypeQueryAsync(UserToTypeFunction userToTypeFunction, BlockParameter blockParameter = null);

        public Task<byte> UserToTypeQueryAsync(string returnValue1, BlockParameter blockParameter = null);

        public Task<string> WithdrawRequestAsync(WithdrawFunction withdrawFunction);

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(WithdrawFunction withdrawFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> WithdrawRequestAsync(BigInteger tokenId);

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(BigInteger tokenId, CancellationTokenSource cancellationToken = null);

        public void Initialize(IWeb3 web3, string contractAddress);
    }
}
