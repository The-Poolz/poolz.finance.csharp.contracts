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
using poolz.finance.csharp.contracts.VaultManager.ContractDefinition;

namespace poolz.finance.csharp.contracts.VaultManager
{
    public interface IVaultManagerService
    {
        Task<string> CreateNewVaultRequestAsync(long chainId, Enum contractType, CreateNewVault3Function createNewVault3Function);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CreateNewVault3Function createNewVault3Function, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewVaultRequestAsync(long chainId, Enum contractType, string tokenAddress, BigInteger tradeStartTime, string royaltyReceiver, BigInteger feeNumerator);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string tokenAddress, BigInteger tradeStartTime, string royaltyReceiver, BigInteger feeNumerator, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewVaultRequestAsync(long chainId, Enum contractType, CreateNewVault2Function createNewVault2Function);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CreateNewVault2Function createNewVault2Function, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewVaultRequestAsync(long chainId, Enum contractType, string tokenAddress, string royaltyReceiver, BigInteger feeNumerator);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string tokenAddress, string royaltyReceiver, BigInteger feeNumerator, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewVaultRequestAsync(long chainId, Enum contractType, CreateNewVault1Function createNewVault1Function);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CreateNewVault1Function createNewVault1Function, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewVaultRequestAsync(long chainId, Enum contractType, string tokenAddress, BigInteger tradeStartTime);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string tokenAddress, BigInteger tradeStartTime, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewVaultRequestAsync(long chainId, Enum contractType, CreateNewVaultFunction createNewVaultFunction);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CreateNewVaultFunction createNewVaultFunction, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewVaultRequestAsync(long chainId, Enum contractType, string tokenAddress);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string tokenAddress, CancellationTokenSource cancellationToken = null);

        Task<string> DepositByTokenRequestAsync(long chainId, Enum contractType, DepositByTokenFunction depositByTokenFunction);

        Task<TransactionReceipt> DepositByTokenRequestAndWaitForReceiptAsync(long chainId, Enum contractType, DepositByTokenFunction depositByTokenFunction, CancellationTokenSource cancellationToken = null);

        Task<string> DepositByTokenRequestAsync(long chainId, Enum contractType, string tokenAddress, BigInteger amount);

        Task<TransactionReceipt> DepositByTokenRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string tokenAddress, BigInteger amount, CancellationTokenSource cancellationToken = null);

        Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<BigInteger> GetAllVaultBalanceByTokenQueryAsync(long chainId, Enum contractType, GetAllVaultBalanceByTokenFunction getAllVaultBalanceByTokenFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetAllVaultBalanceByTokenQueryAsync(long chainId, Enum contractType, string tokenAddress, BigInteger from, BigInteger count, BlockParameter blockParameter = null);

        Task<BigInteger> GetCurrentVaultBalanceByTokenQueryAsync(long chainId, Enum contractType, GetCurrentVaultBalanceByTokenFunction getCurrentVaultBalanceByTokenFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetCurrentVaultBalanceByTokenQueryAsync(long chainId, Enum contractType, string tokenAddress, BlockParameter blockParameter = null);

        Task<BigInteger> GetCurrentVaultIdByTokenQueryAsync(long chainId, Enum contractType, GetCurrentVaultIdByTokenFunction getCurrentVaultIdByTokenFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetCurrentVaultIdByTokenQueryAsync(long chainId, Enum contractType, string tokenAddress, BlockParameter blockParameter = null);

        Task<BigInteger> GetTotalVaultsByTokenQueryAsync(long chainId, Enum contractType, GetTotalVaultsByTokenFunction getTotalVaultsByTokenFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetTotalVaultsByTokenQueryAsync(long chainId, Enum contractType, string tokenAddress, BlockParameter blockParameter = null);

        Task<BigInteger> GetVaultBalanceByVaultIdQueryAsync(long chainId, Enum contractType, GetVaultBalanceByVaultIdFunction getVaultBalanceByVaultIdFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetVaultBalanceByVaultIdQueryAsync(long chainId, Enum contractType, BigInteger vaultId, BlockParameter blockParameter = null);

        Task<bool> IsDepositActiveForVaultIdQueryAsync(long chainId, Enum contractType, IsDepositActiveForVaultIdFunction isDepositActiveForVaultIdFunction, BlockParameter blockParameter = null);

        Task<bool> IsDepositActiveForVaultIdQueryAsync(long chainId, Enum contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<bool> IsWithdrawalActiveForVaultIdQueryAsync(long chainId, Enum contractType, IsWithdrawalActiveForVaultIdFunction isWithdrawalActiveForVaultIdFunction, BlockParameter blockParameter = null);

        Task<bool> IsWithdrawalActiveForVaultIdQueryAsync(long chainId, Enum contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<BigInteger> NoncesQueryAsync(long chainId, Enum contractType, NoncesFunction noncesFunction, BlockParameter blockParameter = null);

        Task<BigInteger> NoncesQueryAsync(long chainId, Enum contractType, string returnValue1, BlockParameter blockParameter = null);

        Task<string> OwnerQueryAsync(long chainId, Enum contractType, OwnerFunction ownerFunction, BlockParameter blockParameter = null);

        Task<string> OwnerQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> RenounceOwnershipRequestAsync(long chainId, Enum contractType, RenounceOwnershipFunction renounceOwnershipFunction);

        Task<string> RenounceOwnershipRequestAsync(long chainId, Enum contractType);

        Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null);

        Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CancellationTokenSource cancellationToken = null);

        Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(long chainId, Enum contractType, RoyaltyInfoFunction royaltyInfoFunction, BlockParameter blockParameter = null);

        Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(long chainId, Enum contractType, BigInteger tokenId, BigInteger salePrice, BlockParameter blockParameter = null);

        Task<string> SafeDepositRequestAsync(long chainId, Enum contractType, SafeDepositFunction safeDepositFunction);

        Task<TransactionReceipt> SafeDepositRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SafeDepositFunction safeDepositFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SafeDepositRequestAsync(long chainId, Enum contractType, string tokenAddress, BigInteger amount, string from, byte[] signature);

        Task<TransactionReceipt> SafeDepositRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string tokenAddress, BigInteger amount, string from, byte[] signature, CancellationTokenSource cancellationToken = null);

        Task<string> SetActiveStatusForVaultIdRequestAsync(long chainId, Enum contractType, SetActiveStatusForVaultIdFunction setActiveStatusForVaultIdFunction);

        Task<TransactionReceipt> SetActiveStatusForVaultIdRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetActiveStatusForVaultIdFunction setActiveStatusForVaultIdFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetActiveStatusForVaultIdRequestAsync(long chainId, Enum contractType, BigInteger vaultId, bool depositStatus, bool withdrawStatus);

        Task<TransactionReceipt> SetActiveStatusForVaultIdRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger vaultId, bool depositStatus, bool withdrawStatus, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, string firewall);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewall, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, string firewallAdmin);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null);

        Task<string> SetTradeStartTimeRequestAsync(long chainId, Enum contractType, SetTradeStartTimeFunction setTradeStartTimeFunction);

        Task<TransactionReceipt> SetTradeStartTimeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetTradeStartTimeFunction setTradeStartTimeFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetTradeStartTimeRequestAsync(long chainId, Enum contractType, BigInteger vaultId, BigInteger tradeStartTime);

        Task<TransactionReceipt> SetTradeStartTimeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger vaultId, BigInteger tradeStartTime, CancellationTokenSource cancellationToken = null);

        Task<string> SetTrusteeRequestAsync(long chainId, Enum contractType, SetTrusteeFunction setTrusteeFunction);

        Task<TransactionReceipt> SetTrusteeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetTrusteeFunction setTrusteeFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetTrusteeRequestAsync(long chainId, Enum contractType, string address);

        Task<TransactionReceipt> SetTrusteeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string address, CancellationTokenSource cancellationToken = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, Enum contractType, SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, Enum contractType, byte[] interfaceId, BlockParameter blockParameter = null);

        Task<BigInteger> TokenToVaultIdsQueryAsync(long chainId, Enum contractType, TokenToVaultIdsFunction tokenToVaultIdsFunction, BlockParameter blockParameter = null);

        Task<BigInteger> TokenToVaultIdsQueryAsync(long chainId, Enum contractType, string returnValue1, BigInteger returnValue2, BlockParameter blockParameter = null);

        Task<BigInteger> TotalVaultsQueryAsync(long chainId, Enum contractType, TotalVaultsFunction totalVaultsFunction, BlockParameter blockParameter = null);

        Task<BigInteger> TotalVaultsQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> TransferOwnershipRequestAsync(long chainId, Enum contractType, TransferOwnershipFunction transferOwnershipFunction);

        Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null);

        Task<string> TransferOwnershipRequestAsync(long chainId, Enum contractType, string newOwner);

        Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string newOwner, CancellationTokenSource cancellationToken = null);

        Task<string> TrusteeQueryAsync(long chainId, Enum contractType, TrusteeFunction trusteeFunction, BlockParameter blockParameter = null);

        Task<string> TrusteeQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> UpdateTrusteeRequestAsync(long chainId, Enum contractType, UpdateTrusteeFunction updateTrusteeFunction);

        Task<TransactionReceipt> UpdateTrusteeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, UpdateTrusteeFunction updateTrusteeFunction, CancellationTokenSource cancellationToken = null);

        Task<string> UpdateTrusteeRequestAsync(long chainId, Enum contractType, string address);

        Task<TransactionReceipt> UpdateTrusteeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string address, CancellationTokenSource cancellationToken = null);

        Task<string> VaultIdToTokenAddressQueryAsync(long chainId, Enum contractType, VaultIdToTokenAddressFunction vaultIdToTokenAddressFunction, BlockParameter blockParameter = null);

        Task<string> VaultIdToTokenAddressQueryAsync(long chainId, Enum contractType, BigInteger vaultId, BlockParameter blockParameter = null);

        Task<BigInteger> VaultIdToTradeStartTimeQueryAsync(long chainId, Enum contractType, VaultIdToTradeStartTimeFunction vaultIdToTradeStartTimeFunction, BlockParameter blockParameter = null);

        Task<BigInteger> VaultIdToTradeStartTimeQueryAsync(long chainId, Enum contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<string> VaultIdToVaultQueryAsync(long chainId, Enum contractType, VaultIdToVaultFunction vaultIdToVaultFunction, BlockParameter blockParameter = null);

        Task<string> VaultIdToVaultQueryAsync(long chainId, Enum contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<string> WithdrawByVaultIdRequestAsync(long chainId, Enum contractType, WithdrawByVaultIdFunction withdrawByVaultIdFunction);

        Task<TransactionReceipt> WithdrawByVaultIdRequestAndWaitForReceiptAsync(long chainId, Enum contractType, WithdrawByVaultIdFunction withdrawByVaultIdFunction, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawByVaultIdRequestAsync(long chainId, Enum contractType, BigInteger vaultId, string to, BigInteger amount);

        Task<TransactionReceipt> WithdrawByVaultIdRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger vaultId, string to, BigInteger amount, CancellationTokenSource cancellationToken = null);
    }
}
