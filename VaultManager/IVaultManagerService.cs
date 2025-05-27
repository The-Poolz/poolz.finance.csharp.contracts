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
    public interface IVaultManagerService<in TContractType>
        where TContractType : Enum
    {
        Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, CreateNewVault3Function createNewVault3Function);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CreateNewVault3Function createNewVault3Function, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger tradeStartTime, string royaltyReceiver, BigInteger feeNumerator);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger tradeStartTime, string royaltyReceiver, BigInteger feeNumerator, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, CreateNewVault2Function createNewVault2Function);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CreateNewVault2Function createNewVault2Function, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, string tokenAddress, string royaltyReceiver, BigInteger feeNumerator);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string tokenAddress, string royaltyReceiver, BigInteger feeNumerator, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, CreateNewVault1Function createNewVault1Function);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CreateNewVault1Function createNewVault1Function, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger tradeStartTime);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger tradeStartTime, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, CreateNewVaultFunction createNewVaultFunction);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CreateNewVaultFunction createNewVaultFunction, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, string tokenAddress);

        Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string tokenAddress, CancellationTokenSource cancellationToken = null);

        Task<string> DepositByTokenRequestAsync(long chainId, TContractType contractType, DepositByTokenFunction depositByTokenFunction);

        Task<TransactionReceipt> DepositByTokenRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, DepositByTokenFunction depositByTokenFunction, CancellationTokenSource cancellationToken = null);

        Task<string> DepositByTokenRequestAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger amount);

        Task<TransactionReceipt> DepositByTokenRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger amount, CancellationTokenSource cancellationToken = null);

        Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<BigInteger> GetAllVaultBalanceByTokenQueryAsync(long chainId, TContractType contractType, GetAllVaultBalanceByTokenFunction getAllVaultBalanceByTokenFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetAllVaultBalanceByTokenQueryAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger from, BigInteger count, BlockParameter blockParameter = null);

        Task<BigInteger> GetCurrentVaultBalanceByTokenQueryAsync(long chainId, TContractType contractType, GetCurrentVaultBalanceByTokenFunction getCurrentVaultBalanceByTokenFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetCurrentVaultBalanceByTokenQueryAsync(long chainId, TContractType contractType, string tokenAddress, BlockParameter blockParameter = null);

        Task<BigInteger> GetCurrentVaultIdByTokenQueryAsync(long chainId, TContractType contractType, GetCurrentVaultIdByTokenFunction getCurrentVaultIdByTokenFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetCurrentVaultIdByTokenQueryAsync(long chainId, TContractType contractType, string tokenAddress, BlockParameter blockParameter = null);

        Task<BigInteger> GetTotalVaultsByTokenQueryAsync(long chainId, TContractType contractType, GetTotalVaultsByTokenFunction getTotalVaultsByTokenFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetTotalVaultsByTokenQueryAsync(long chainId, TContractType contractType, string tokenAddress, BlockParameter blockParameter = null);

        Task<BigInteger> GetVaultBalanceByVaultIdQueryAsync(long chainId, TContractType contractType, GetVaultBalanceByVaultIdFunction getVaultBalanceByVaultIdFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetVaultBalanceByVaultIdQueryAsync(long chainId, TContractType contractType, BigInteger vaultId, BlockParameter blockParameter = null);

        Task<bool> IsDepositActiveForVaultIdQueryAsync(long chainId, TContractType contractType, IsDepositActiveForVaultIdFunction isDepositActiveForVaultIdFunction, BlockParameter blockParameter = null);

        Task<bool> IsDepositActiveForVaultIdQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<bool> IsWithdrawalActiveForVaultIdQueryAsync(long chainId, TContractType contractType, IsWithdrawalActiveForVaultIdFunction isWithdrawalActiveForVaultIdFunction, BlockParameter blockParameter = null);

        Task<bool> IsWithdrawalActiveForVaultIdQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<BigInteger> NoncesQueryAsync(long chainId, TContractType contractType, NoncesFunction noncesFunction, BlockParameter blockParameter = null);

        Task<BigInteger> NoncesQueryAsync(long chainId, TContractType contractType, string returnValue1, BlockParameter blockParameter = null);

        Task<string> OwnerQueryAsync(long chainId, TContractType contractType, OwnerFunction ownerFunction, BlockParameter blockParameter = null);

        Task<string> OwnerQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> RenounceOwnershipRequestAsync(long chainId, TContractType contractType, RenounceOwnershipFunction renounceOwnershipFunction);

        Task<string> RenounceOwnershipRequestAsync(long chainId, TContractType contractType);

        Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null);

        Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CancellationTokenSource cancellationToken = null);

        Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(long chainId, TContractType contractType, RoyaltyInfoFunction royaltyInfoFunction, BlockParameter blockParameter = null);

        Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(long chainId, TContractType contractType, BigInteger tokenId, BigInteger salePrice, BlockParameter blockParameter = null);

        Task<string> SafeDepositRequestAsync(long chainId, TContractType contractType, SafeDepositFunction safeDepositFunction);

        Task<TransactionReceipt> SafeDepositRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SafeDepositFunction safeDepositFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SafeDepositRequestAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger amount, string from, byte[] signature);

        Task<TransactionReceipt> SafeDepositRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger amount, string from, byte[] signature, CancellationTokenSource cancellationToken = null);

        Task<string> SetActiveStatusForVaultIdRequestAsync(long chainId, TContractType contractType, SetActiveStatusForVaultIdFunction setActiveStatusForVaultIdFunction);

        Task<TransactionReceipt> SetActiveStatusForVaultIdRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetActiveStatusForVaultIdFunction setActiveStatusForVaultIdFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetActiveStatusForVaultIdRequestAsync(long chainId, TContractType contractType, BigInteger vaultId, bool depositStatus, bool withdrawStatus);

        Task<TransactionReceipt> SetActiveStatusForVaultIdRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger vaultId, bool depositStatus, bool withdrawStatus, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, string firewall);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewall, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, string firewallAdmin);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null);

        Task<string> SetTradeStartTimeRequestAsync(long chainId, TContractType contractType, SetTradeStartTimeFunction setTradeStartTimeFunction);

        Task<TransactionReceipt> SetTradeStartTimeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetTradeStartTimeFunction setTradeStartTimeFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetTradeStartTimeRequestAsync(long chainId, TContractType contractType, BigInteger vaultId, BigInteger tradeStartTime);

        Task<TransactionReceipt> SetTradeStartTimeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger vaultId, BigInteger tradeStartTime, CancellationTokenSource cancellationToken = null);

        Task<string> SetTrusteeRequestAsync(long chainId, TContractType contractType, SetTrusteeFunction setTrusteeFunction);

        Task<TransactionReceipt> SetTrusteeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetTrusteeFunction setTrusteeFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetTrusteeRequestAsync(long chainId, TContractType contractType, string address);

        Task<TransactionReceipt> SetTrusteeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string address, CancellationTokenSource cancellationToken = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, TContractType contractType, SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, TContractType contractType, byte[] interfaceId, BlockParameter blockParameter = null);

        Task<BigInteger> TokenToVaultIdsQueryAsync(long chainId, TContractType contractType, TokenToVaultIdsFunction tokenToVaultIdsFunction, BlockParameter blockParameter = null);

        Task<BigInteger> TokenToVaultIdsQueryAsync(long chainId, TContractType contractType, string returnValue1, BigInteger returnValue2, BlockParameter blockParameter = null);

        Task<BigInteger> TotalVaultsQueryAsync(long chainId, TContractType contractType, TotalVaultsFunction totalVaultsFunction, BlockParameter blockParameter = null);

        Task<BigInteger> TotalVaultsQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> TransferOwnershipRequestAsync(long chainId, TContractType contractType, TransferOwnershipFunction transferOwnershipFunction);

        Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null);

        Task<string> TransferOwnershipRequestAsync(long chainId, TContractType contractType, string newOwner);

        Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string newOwner, CancellationTokenSource cancellationToken = null);

        Task<string> TrusteeQueryAsync(long chainId, TContractType contractType, TrusteeFunction trusteeFunction, BlockParameter blockParameter = null);

        Task<string> TrusteeQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> UpdateTrusteeRequestAsync(long chainId, TContractType contractType, UpdateTrusteeFunction updateTrusteeFunction);

        Task<TransactionReceipt> UpdateTrusteeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, UpdateTrusteeFunction updateTrusteeFunction, CancellationTokenSource cancellationToken = null);

        Task<string> UpdateTrusteeRequestAsync(long chainId, TContractType contractType, string address);

        Task<TransactionReceipt> UpdateTrusteeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string address, CancellationTokenSource cancellationToken = null);

        Task<string> VaultIdToTokenAddressQueryAsync(long chainId, TContractType contractType, VaultIdToTokenAddressFunction vaultIdToTokenAddressFunction, BlockParameter blockParameter = null);

        Task<string> VaultIdToTokenAddressQueryAsync(long chainId, TContractType contractType, BigInteger vaultId, BlockParameter blockParameter = null);

        Task<BigInteger> VaultIdToTradeStartTimeQueryAsync(long chainId, TContractType contractType, VaultIdToTradeStartTimeFunction vaultIdToTradeStartTimeFunction, BlockParameter blockParameter = null);

        Task<BigInteger> VaultIdToTradeStartTimeQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<string> VaultIdToVaultQueryAsync(long chainId, TContractType contractType, VaultIdToVaultFunction vaultIdToVaultFunction, BlockParameter blockParameter = null);

        Task<string> VaultIdToVaultQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<string> WithdrawByVaultIdRequestAsync(long chainId, TContractType contractType, WithdrawByVaultIdFunction withdrawByVaultIdFunction);

        Task<TransactionReceipt> WithdrawByVaultIdRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, WithdrawByVaultIdFunction withdrawByVaultIdFunction, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawByVaultIdRequestAsync(long chainId, TContractType contractType, BigInteger vaultId, string to, BigInteger amount);

        Task<TransactionReceipt> WithdrawByVaultIdRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger vaultId, string to, BigInteger amount, CancellationTokenSource cancellationToken = null);
    }
}
