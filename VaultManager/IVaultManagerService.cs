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
        public Task<string> CreateNewVaultRequestAsync(CreateNewVault3Function createNewVault3Function);

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(CreateNewVault3Function createNewVault3Function, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewVaultRequestAsync(string tokenAddress, BigInteger tradeStartTime, string royaltyReceiver, BigInteger feeNumerator);

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(string tokenAddress, BigInteger tradeStartTime, string royaltyReceiver, BigInteger feeNumerator, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewVaultRequestAsync(CreateNewVault2Function createNewVault2Function);

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(CreateNewVault2Function createNewVault2Function, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewVaultRequestAsync(string tokenAddress, string royaltyReceiver, BigInteger feeNumerator);

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(string tokenAddress, string royaltyReceiver, BigInteger feeNumerator, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewVaultRequestAsync(CreateNewVault1Function createNewVault1Function);

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(CreateNewVault1Function createNewVault1Function, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewVaultRequestAsync(string tokenAddress, BigInteger tradeStartTime);

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(string tokenAddress, BigInteger tradeStartTime, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewVaultRequestAsync(CreateNewVaultFunction createNewVaultFunction);

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(CreateNewVaultFunction createNewVaultFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewVaultRequestAsync(string tokenAddress);

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(string tokenAddress, CancellationTokenSource cancellationToken = null);

        public Task<string> DepositByTokenRequestAsync(DepositByTokenFunction depositByTokenFunction);

        public Task<TransactionReceipt> DepositByTokenRequestAndWaitForReceiptAsync(DepositByTokenFunction depositByTokenFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> DepositByTokenRequestAsync(string tokenAddress, BigInteger amount);

        public Task<TransactionReceipt> DepositByTokenRequestAndWaitForReceiptAsync(string tokenAddress, BigInteger amount, CancellationTokenSource cancellationToken = null);

        public Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        public Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> GetAllVaultBalanceByTokenQueryAsync(GetAllVaultBalanceByTokenFunction getAllVaultBalanceByTokenFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> GetAllVaultBalanceByTokenQueryAsync(string tokenAddress, BigInteger from, BigInteger count, BlockParameter blockParameter = null);

        public Task<BigInteger> GetCurrentVaultBalanceByTokenQueryAsync(GetCurrentVaultBalanceByTokenFunction getCurrentVaultBalanceByTokenFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> GetCurrentVaultBalanceByTokenQueryAsync(string tokenAddress, BlockParameter blockParameter = null);

        public Task<BigInteger> GetCurrentVaultIdByTokenQueryAsync(GetCurrentVaultIdByTokenFunction getCurrentVaultIdByTokenFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> GetCurrentVaultIdByTokenQueryAsync(string tokenAddress, BlockParameter blockParameter = null);

        public Task<BigInteger> GetTotalVaultsByTokenQueryAsync(GetTotalVaultsByTokenFunction getTotalVaultsByTokenFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> GetTotalVaultsByTokenQueryAsync(string tokenAddress, BlockParameter blockParameter = null);

        public Task<BigInteger> GetVaultBalanceByVaultIdQueryAsync(GetVaultBalanceByVaultIdFunction getVaultBalanceByVaultIdFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> GetVaultBalanceByVaultIdQueryAsync(BigInteger vaultId, BlockParameter blockParameter = null);

        public Task<bool> IsDepositActiveForVaultIdQueryAsync(IsDepositActiveForVaultIdFunction isDepositActiveForVaultIdFunction, BlockParameter blockParameter = null);

        public Task<bool> IsDepositActiveForVaultIdQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null);

        public Task<bool> IsWithdrawalActiveForVaultIdQueryAsync(IsWithdrawalActiveForVaultIdFunction isWithdrawalActiveForVaultIdFunction, BlockParameter blockParameter = null);

        public Task<bool> IsWithdrawalActiveForVaultIdQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null);

        public Task<BigInteger> NoncesQueryAsync(NoncesFunction noncesFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> NoncesQueryAsync(string returnValue1, BlockParameter blockParameter = null);

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null);

        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null);

        public Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction);

        public Task<string> RenounceOwnershipRequestAsync();

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null);

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null);

        public Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(RoyaltyInfoFunction royaltyInfoFunction, BlockParameter blockParameter = null);

        public Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(BigInteger tokenId, BigInteger salePrice, BlockParameter blockParameter = null);

        public Task<string> SafeDepositRequestAsync(SafeDepositFunction safeDepositFunction);

        public Task<TransactionReceipt> SafeDepositRequestAndWaitForReceiptAsync(SafeDepositFunction safeDepositFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SafeDepositRequestAsync(string tokenAddress, BigInteger amount, string from, byte[] signature);

        public Task<TransactionReceipt> SafeDepositRequestAndWaitForReceiptAsync(string tokenAddress, BigInteger amount, string from, byte[] signature, CancellationTokenSource cancellationToken = null);

        public Task<string> SetActiveStatusForVaultIdRequestAsync(SetActiveStatusForVaultIdFunction setActiveStatusForVaultIdFunction);

        public Task<TransactionReceipt> SetActiveStatusForVaultIdRequestAndWaitForReceiptAsync(SetActiveStatusForVaultIdFunction setActiveStatusForVaultIdFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetActiveStatusForVaultIdRequestAsync(BigInteger vaultId, bool depositStatus, bool withdrawStatus);

        public Task<TransactionReceipt> SetActiveStatusForVaultIdRequestAndWaitForReceiptAsync(BigInteger vaultId, bool depositStatus, bool withdrawStatus, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallRequestAsync(SetFirewallFunction setFirewallFunction);

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallRequestAsync(string firewall);

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(string firewall, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallAdminRequestAsync(SetFirewallAdminFunction setFirewallAdminFunction);

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallAdminRequestAsync(string firewallAdmin);

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(string firewallAdmin, CancellationTokenSource cancellationToken = null);

        public Task<string> SetTradeStartTimeRequestAsync(SetTradeStartTimeFunction setTradeStartTimeFunction);

        public Task<TransactionReceipt> SetTradeStartTimeRequestAndWaitForReceiptAsync(SetTradeStartTimeFunction setTradeStartTimeFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetTradeStartTimeRequestAsync(BigInteger vaultId, BigInteger tradeStartTime);

        public Task<TransactionReceipt> SetTradeStartTimeRequestAndWaitForReceiptAsync(BigInteger vaultId, BigInteger tradeStartTime, CancellationTokenSource cancellationToken = null);

        public Task<string> SetTrusteeRequestAsync(SetTrusteeFunction setTrusteeFunction);

        public Task<TransactionReceipt> SetTrusteeRequestAndWaitForReceiptAsync(SetTrusteeFunction setTrusteeFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetTrusteeRequestAsync(string address);

        public Task<TransactionReceipt> SetTrusteeRequestAndWaitForReceiptAsync(string address, CancellationTokenSource cancellationToken = null);

        public Task<bool> SupportsInterfaceQueryAsync(SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null);

        public Task<bool> SupportsInterfaceQueryAsync(byte[] interfaceId, BlockParameter blockParameter = null);

        public Task<BigInteger> TokenToVaultIdsQueryAsync(TokenToVaultIdsFunction tokenToVaultIdsFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> TokenToVaultIdsQueryAsync(string returnValue1, BigInteger returnValue2, BlockParameter blockParameter = null);

        public Task<BigInteger> TotalVaultsQueryAsync(TotalVaultsFunction totalVaultsFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> TotalVaultsQueryAsync(BlockParameter blockParameter = null);

        public Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction);

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> TransferOwnershipRequestAsync(string newOwner);

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null);

        public Task<string> TrusteeQueryAsync(TrusteeFunction trusteeFunction, BlockParameter blockParameter = null);

        public Task<string> TrusteeQueryAsync(BlockParameter blockParameter = null);

        public Task<string> UpdateTrusteeRequestAsync(UpdateTrusteeFunction updateTrusteeFunction);

        public Task<TransactionReceipt> UpdateTrusteeRequestAndWaitForReceiptAsync(UpdateTrusteeFunction updateTrusteeFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> UpdateTrusteeRequestAsync(string address);

        public Task<TransactionReceipt> UpdateTrusteeRequestAndWaitForReceiptAsync(string address, CancellationTokenSource cancellationToken = null);

        public Task<string> VaultIdToTokenAddressQueryAsync(VaultIdToTokenAddressFunction vaultIdToTokenAddressFunction, BlockParameter blockParameter = null);

        public Task<string> VaultIdToTokenAddressQueryAsync(BigInteger vaultId, BlockParameter blockParameter = null);

        public Task<BigInteger> VaultIdToTradeStartTimeQueryAsync(VaultIdToTradeStartTimeFunction vaultIdToTradeStartTimeFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> VaultIdToTradeStartTimeQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null);

        public Task<string> VaultIdToVaultQueryAsync(VaultIdToVaultFunction vaultIdToVaultFunction, BlockParameter blockParameter = null);

        public Task<string> VaultIdToVaultQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null);

        public Task<string> WithdrawByVaultIdRequestAsync(WithdrawByVaultIdFunction withdrawByVaultIdFunction);

        public Task<TransactionReceipt> WithdrawByVaultIdRequestAndWaitForReceiptAsync(WithdrawByVaultIdFunction withdrawByVaultIdFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> WithdrawByVaultIdRequestAsync(BigInteger vaultId, string to, BigInteger amount);

        public Task<TransactionReceipt> WithdrawByVaultIdRequestAndWaitForReceiptAsync(BigInteger vaultId, string to, BigInteger amount, CancellationTokenSource cancellationToken = null);

        public void Initialize(IWeb3 web3, string contractAddress);
    }
}
