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
using poolz.finance.csharp.contracts.LockDealNFT.ContractDefinition;

namespace poolz.finance.csharp.contracts.LockDealNFT
{
    public interface ILockDealNFTService
    {
        public Task<string> ApproveRequestAsync(ApproveFunction approveFunction);

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> ApproveRequestAsync(string to, BigInteger tokenId);

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null);

        public Task<string> ApprovePoolTransfersRequestAsync(ApprovePoolTransfersFunction approvePoolTransfersFunction);

        public Task<TransactionReceipt> ApprovePoolTransfersRequestAndWaitForReceiptAsync(ApprovePoolTransfersFunction approvePoolTransfersFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> ApprovePoolTransfersRequestAsync(bool status);

        public Task<TransactionReceipt> ApprovePoolTransfersRequestAndWaitForReceiptAsync(bool status, CancellationTokenSource cancellationToken = null);

        public Task<bool> ApprovedContractsQueryAsync(ApprovedContractsFunction approvedContractsFunction, BlockParameter blockParameter = null);

        public Task<bool> ApprovedContractsQueryAsync(string returnValue1, BlockParameter blockParameter = null);

        public Task<bool> ApprovedPoolUserTransfersQueryAsync(ApprovedPoolUserTransfersFunction approvedPoolUserTransfersFunction, BlockParameter blockParameter = null);

        public Task<bool> ApprovedPoolUserTransfersQueryAsync(string returnValue1, BlockParameter blockParameter = null);

        public Task<BigInteger> BalanceOfQueryAsync(BalanceOf1Function balanceOf1Function, BlockParameter blockParameter = null);

        public Task<BigInteger> BalanceOfQueryAsync(string owner, List<string> tokens, BlockParameter blockParameter = null);

        public Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> BalanceOfQueryAsync(string owner, BlockParameter blockParameter = null);

        public Task<string> BaseURIQueryAsync(BaseURIFunction baseURIFunction, BlockParameter blockParameter = null);

        public Task<string> BaseURIQueryAsync(BlockParameter blockParameter = null);

        public Task<string> CloneVaultIdRequestAsync(CloneVaultIdFunction cloneVaultIdFunction);

        public Task<TransactionReceipt> CloneVaultIdRequestAndWaitForReceiptAsync(CloneVaultIdFunction cloneVaultIdFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> CloneVaultIdRequestAsync(BigInteger destinationPoolId, BigInteger sourcePoolId);

        public Task<TransactionReceipt> CloneVaultIdRequestAndWaitForReceiptAsync(BigInteger destinationPoolId, BigInteger sourcePoolId, CancellationTokenSource cancellationToken = null);

        public Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        public Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null);

        public Task<string> GetApprovedQueryAsync(GetApprovedFunction getApprovedFunction, BlockParameter blockParameter = null);

        public Task<string> GetApprovedQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null);

        public Task<GetDataOutputDTO> GetDataQueryAsync(GetDataFunction getDataFunction, BlockParameter blockParameter = null);

        public Task<GetDataOutputDTO> GetDataQueryAsync(BigInteger poolId, BlockParameter blockParameter = null);

        public Task<GetFullDataOutputDTO> GetFullDataQueryAsync(GetFullDataFunction getFullDataFunction, BlockParameter blockParameter = null);

        public Task<GetFullDataOutputDTO> GetFullDataQueryAsync(BigInteger poolId, BlockParameter blockParameter = null);

        public Task<GetUserDataByTokensOutputDTO> GetUserDataByTokensQueryAsync(GetUserDataByTokensFunction getUserDataByTokensFunction, BlockParameter blockParameter = null);

        public Task<GetUserDataByTokensOutputDTO> GetUserDataByTokensQueryAsync(string user, List<string> tokens, BigInteger from, BigInteger to, BlockParameter blockParameter = null);

        public Task<BigInteger> GetWithdrawableAmountQueryAsync(GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> GetWithdrawableAmountQueryAsync(BigInteger poolId, BlockParameter blockParameter = null);

        public Task<bool> IsApprovedForAllQueryAsync(IsApprovedForAllFunction isApprovedForAllFunction, BlockParameter blockParameter = null);

        public Task<bool> IsApprovedForAllQueryAsync(string owner, string @operator, BlockParameter blockParameter = null);

        public Task<string> MintAndTransferRequestAsync(MintAndTransferFunction mintAndTransferFunction);

        public Task<TransactionReceipt> MintAndTransferRequestAndWaitForReceiptAsync(MintAndTransferFunction mintAndTransferFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> MintAndTransferRequestAsync(string owner, string token, BigInteger amount, string provider);

        public Task<TransactionReceipt> MintAndTransferRequestAndWaitForReceiptAsync(string owner, string token, BigInteger amount, string provider, CancellationTokenSource cancellationToken = null);

        public Task<string> MintForProviderRequestAsync(MintForProviderFunction mintForProviderFunction);

        public Task<TransactionReceipt> MintForProviderRequestAndWaitForReceiptAsync(MintForProviderFunction mintForProviderFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> MintForProviderRequestAsync(string owner, string provider);

        public Task<TransactionReceipt> MintForProviderRequestAndWaitForReceiptAsync(string owner, string provider, CancellationTokenSource cancellationToken = null);

        public Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null);

        public Task<string> NameQueryAsync(BlockParameter blockParameter = null);

        public Task<string> OnERC721ReceivedRequestAsync(OnERC721ReceivedFunction onERC721ReceivedFunction);

        public Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(OnERC721ReceivedFunction onERC721ReceivedFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> OnERC721ReceivedRequestAsync(string returnValue1, string from, BigInteger poolId, byte[] data);

        public Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(string returnValue1, string from, BigInteger poolId, byte[] data, CancellationTokenSource cancellationToken = null);

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null);

        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null);

        public Task<string> OwnerOfQueryAsync(OwnerOfFunction ownerOfFunction, BlockParameter blockParameter = null);

        public Task<string> OwnerOfQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null);

        public Task<string> PoolIdToProviderQueryAsync(PoolIdToProviderFunction poolIdToProviderFunction, BlockParameter blockParameter = null);

        public Task<string> PoolIdToProviderQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null);

        public Task<BigInteger> PoolIdToVaultIdQueryAsync(PoolIdToVaultIdFunction poolIdToVaultIdFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> PoolIdToVaultIdQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null);

        public Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction);

        public Task<string> RenounceOwnershipRequestAsync();

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null);

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null);

        public Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(RoyaltyInfoFunction royaltyInfoFunction, BlockParameter blockParameter = null);

        public Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(BigInteger tokenId, BigInteger salePrice, BlockParameter blockParameter = null);

        public Task<string> SafeMintAndTransferRequestAsync(SafeMintAndTransferFunction safeMintAndTransferFunction);

        public Task<TransactionReceipt> SafeMintAndTransferRequestAndWaitForReceiptAsync(SafeMintAndTransferFunction safeMintAndTransferFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SafeMintAndTransferRequestAsync(string owner, string token, string from, BigInteger amount, string provider, byte[] data);

        public Task<TransactionReceipt> SafeMintAndTransferRequestAndWaitForReceiptAsync(string owner, string token, string from, BigInteger amount, string provider, byte[] data, CancellationTokenSource cancellationToken = null);

        public Task<string> SafeTransferFromRequestAsync(SafeTransferFromFunction safeTransferFromFunction);

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(SafeTransferFromFunction safeTransferFromFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SafeTransferFromRequestAsync(string from, string to, BigInteger tokenId);

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null);

        public Task<string> SafeTransferFromRequestAsync(SafeTransferFrom1Function safeTransferFrom1Function);

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(SafeTransferFrom1Function safeTransferFrom1Function, CancellationTokenSource cancellationToken = null);

        public Task<string> SafeTransferFromRequestAsync(string from, string to, BigInteger tokenId, byte[] data);

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, byte[] data, CancellationTokenSource cancellationToken = null);

        public Task<string> SetApprovalForAllRequestAsync(SetApprovalForAllFunction setApprovalForAllFunction);

        public Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(SetApprovalForAllFunction setApprovalForAllFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetApprovalForAllRequestAsync(string @operator, bool approved);

        public Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(string @operator, bool approved, CancellationTokenSource cancellationToken = null);

        public Task<string> SetApprovedContractRequestAsync(SetApprovedContractFunction setApprovedContractFunction);

        public Task<TransactionReceipt> SetApprovedContractRequestAndWaitForReceiptAsync(SetApprovedContractFunction setApprovedContractFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetApprovedContractRequestAsync(string contractAddress, bool status);

        public Task<TransactionReceipt> SetApprovedContractRequestAndWaitForReceiptAsync(string contractAddress, bool status, CancellationTokenSource cancellationToken = null);

        public Task<string> SetBaseURIRequestAsync(SetBaseURIFunction setBaseURIFunction);

        public Task<TransactionReceipt> SetBaseURIRequestAndWaitForReceiptAsync(SetBaseURIFunction setBaseURIFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetBaseURIRequestAsync(string newBaseURI);

        public Task<TransactionReceipt> SetBaseURIRequestAndWaitForReceiptAsync(string newBaseURI, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallRequestAsync(SetFirewallFunction setFirewallFunction);

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallRequestAsync(string firewall);

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(string firewall, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallAdminRequestAsync(SetFirewallAdminFunction setFirewallAdminFunction);

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallAdminRequestAsync(string firewallAdmin);

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(string firewallAdmin, CancellationTokenSource cancellationToken = null);

        public Task<bool> SupportsInterfaceQueryAsync(SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null);

        public Task<bool> SupportsInterfaceQueryAsync(byte[] interfaceId, BlockParameter blockParameter = null);

        public Task<string> SymbolQueryAsync(SymbolFunction symbolFunction, BlockParameter blockParameter = null);

        public Task<string> SymbolQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> TokenByIndexQueryAsync(TokenByIndexFunction tokenByIndexFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> TokenByIndexQueryAsync(BigInteger index, BlockParameter blockParameter = null);

        public Task<string> TokenOfQueryAsync(TokenOfFunction tokenOfFunction, BlockParameter blockParameter = null);

        public Task<string> TokenOfQueryAsync(BigInteger poolId, BlockParameter blockParameter = null);

        public Task<BigInteger> TokenOfOwnerByIndexQueryAsync(TokenOfOwnerByIndexFunction tokenOfOwnerByIndexFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> TokenOfOwnerByIndexQueryAsync(string owner, BigInteger index, BlockParameter blockParameter = null);

        public Task<BigInteger> TokenOfOwnerByIndexQueryAsync(TokenOfOwnerByIndex1Function tokenOfOwnerByIndex1Function, BlockParameter blockParameter = null);

        public Task<BigInteger> TokenOfOwnerByIndexQueryAsync(string owner, List<string> tokens, BigInteger index, BlockParameter blockParameter = null);

        public Task<string> TokenURIQueryAsync(TokenURIFunction tokenURIFunction, BlockParameter blockParameter = null);

        public Task<string> TokenURIQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null);

        public Task<BigInteger> TotalSupplyQueryAsync(TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> TotalSupplyQueryAsync(BlockParameter blockParameter = null);

        public Task<string> TransferFromRequestAsync(TransferFromFunction transferFromFunction);

        public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(TransferFromFunction transferFromFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> TransferFromRequestAsync(string from, string to, BigInteger tokenId);

        public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null);

        public Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction);

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> TransferOwnershipRequestAsync(string newOwner);

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null);

        public Task<string> UpdateAllMetadataRequestAsync(UpdateAllMetadataFunction updateAllMetadataFunction);

        public Task<string> UpdateAllMetadataRequestAsync();

        public Task<TransactionReceipt> UpdateAllMetadataRequestAndWaitForReceiptAsync(UpdateAllMetadataFunction updateAllMetadataFunction, CancellationTokenSource cancellationToken = null);

        public Task<TransactionReceipt> UpdateAllMetadataRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null);

        public Task<string> VaultManagerQueryAsync(VaultManagerFunction vaultManagerFunction, BlockParameter blockParameter = null);

        public Task<string> VaultManagerQueryAsync(BlockParameter blockParameter = null);

        public void Initialize(IWeb3 web3, string contractAddress);
    }
}
