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
        Task<string> ApproveRequestAsync(long chainId, Enum contractType, ApproveFunction approveFunction);

        Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(long chainId, Enum contractType, ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null);

        Task<string> ApproveRequestAsync(long chainId, Enum contractType, string to, BigInteger tokenId);

        Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null);

        Task<string> ApprovePoolTransfersRequestAsync(long chainId, Enum contractType, ApprovePoolTransfersFunction approvePoolTransfersFunction);

        Task<TransactionReceipt> ApprovePoolTransfersRequestAndWaitForReceiptAsync(long chainId, Enum contractType, ApprovePoolTransfersFunction approvePoolTransfersFunction, CancellationTokenSource cancellationToken = null);

        Task<string> ApprovePoolTransfersRequestAsync(long chainId, Enum contractType, bool status);

        Task<TransactionReceipt> ApprovePoolTransfersRequestAndWaitForReceiptAsync(long chainId, Enum contractType, bool status, CancellationTokenSource cancellationToken = null);

        Task<bool> ApprovedContractsQueryAsync(long chainId, Enum contractType, ApprovedContractsFunction approvedContractsFunction, BlockParameter blockParameter = null);

        Task<bool> ApprovedContractsQueryAsync(long chainId, Enum contractType, string returnValue1, BlockParameter blockParameter = null);

        Task<bool> ApprovedPoolUserTransfersQueryAsync(long chainId, Enum contractType, ApprovedPoolUserTransfersFunction approvedPoolUserTransfersFunction, BlockParameter blockParameter = null);

        Task<bool> ApprovedPoolUserTransfersQueryAsync(long chainId, Enum contractType, string returnValue1, BlockParameter blockParameter = null);

        Task<BigInteger> BalanceOfQueryAsync(long chainId, Enum contractType, BalanceOf1Function balanceOf1Function, BlockParameter blockParameter = null);

        Task<BigInteger> BalanceOfQueryAsync(long chainId, Enum contractType, string owner, List<string> tokens, BlockParameter blockParameter = null);

        Task<BigInteger> BalanceOfQueryAsync(long chainId, Enum contractType, BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null);

        Task<BigInteger> BalanceOfQueryAsync(long chainId, Enum contractType, string owner, BlockParameter blockParameter = null);

        Task<string> BaseURIQueryAsync(long chainId, Enum contractType, BaseURIFunction baseURIFunction, BlockParameter blockParameter = null);

        Task<string> BaseURIQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> CloneVaultIdRequestAsync(long chainId, Enum contractType, CloneVaultIdFunction cloneVaultIdFunction);

        Task<TransactionReceipt> CloneVaultIdRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CloneVaultIdFunction cloneVaultIdFunction, CancellationTokenSource cancellationToken = null);

        Task<string> CloneVaultIdRequestAsync(long chainId, Enum contractType, BigInteger destinationPoolId, BigInteger sourcePoolId);

        Task<TransactionReceipt> CloneVaultIdRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger destinationPoolId, BigInteger sourcePoolId, CancellationTokenSource cancellationToken = null);

        Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> GetApprovedQueryAsync(long chainId, Enum contractType, GetApprovedFunction getApprovedFunction, BlockParameter blockParameter = null);

        Task<string> GetApprovedQueryAsync(long chainId, Enum contractType, BigInteger tokenId, BlockParameter blockParameter = null);

        Task<GetDataOutputDTO> GetDataQueryAsync(long chainId, Enum contractType, GetDataFunction getDataFunction, BlockParameter blockParameter = null);

        Task<GetDataOutputDTO> GetDataQueryAsync(long chainId, Enum contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<GetFullDataOutputDTO> GetFullDataQueryAsync(long chainId, Enum contractType, GetFullDataFunction getFullDataFunction, BlockParameter blockParameter = null);

        Task<GetFullDataOutputDTO> GetFullDataQueryAsync(long chainId, Enum contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<GetUserDataByTokensOutputDTO> GetUserDataByTokensQueryAsync(long chainId, Enum contractType, GetUserDataByTokensFunction getUserDataByTokensFunction, BlockParameter blockParameter = null);

        Task<GetUserDataByTokensOutputDTO> GetUserDataByTokensQueryAsync(long chainId, Enum contractType, string user, List<string> tokens, BigInteger from, BigInteger to, BlockParameter blockParameter = null);

        Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, Enum contractType, GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, Enum contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<bool> IsApprovedForAllQueryAsync(long chainId, Enum contractType, IsApprovedForAllFunction isApprovedForAllFunction, BlockParameter blockParameter = null);

        Task<bool> IsApprovedForAllQueryAsync(long chainId, Enum contractType, string owner, string @operator, BlockParameter blockParameter = null);

        Task<string> MintAndTransferRequestAsync(long chainId, Enum contractType, MintAndTransferFunction mintAndTransferFunction);

        Task<TransactionReceipt> MintAndTransferRequestAndWaitForReceiptAsync(long chainId, Enum contractType, MintAndTransferFunction mintAndTransferFunction, CancellationTokenSource cancellationToken = null);

        Task<string> MintAndTransferRequestAsync(long chainId, Enum contractType, string owner, string token, BigInteger amount, string provider);

        Task<TransactionReceipt> MintAndTransferRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string owner, string token, BigInteger amount, string provider, CancellationTokenSource cancellationToken = null);

        Task<string> MintForProviderRequestAsync(long chainId, Enum contractType, MintForProviderFunction mintForProviderFunction);

        Task<TransactionReceipt> MintForProviderRequestAndWaitForReceiptAsync(long chainId, Enum contractType, MintForProviderFunction mintForProviderFunction, CancellationTokenSource cancellationToken = null);

        Task<string> MintForProviderRequestAsync(long chainId, Enum contractType, string owner, string provider);

        Task<TransactionReceipt> MintForProviderRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string owner, string provider, CancellationTokenSource cancellationToken = null);

        Task<string> NameQueryAsync(long chainId, Enum contractType, NameFunction nameFunction, BlockParameter blockParameter = null);

        Task<string> NameQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> OnERC721ReceivedRequestAsync(long chainId, Enum contractType, OnERC721ReceivedFunction onERC721ReceivedFunction);

        Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(long chainId, Enum contractType, OnERC721ReceivedFunction onERC721ReceivedFunction, CancellationTokenSource cancellationToken = null);

        Task<string> OnERC721ReceivedRequestAsync(long chainId, Enum contractType, string returnValue1, string from, BigInteger poolId, byte[] data);

        Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string returnValue1, string from, BigInteger poolId, byte[] data, CancellationTokenSource cancellationToken = null);

        Task<string> OwnerQueryAsync(long chainId, Enum contractType, OwnerFunction ownerFunction, BlockParameter blockParameter = null);

        Task<string> OwnerQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> OwnerOfQueryAsync(long chainId, Enum contractType, OwnerOfFunction ownerOfFunction, BlockParameter blockParameter = null);

        Task<string> OwnerOfQueryAsync(long chainId, Enum contractType, BigInteger tokenId, BlockParameter blockParameter = null);

        Task<string> PoolIdToProviderQueryAsync(long chainId, Enum contractType, PoolIdToProviderFunction poolIdToProviderFunction, BlockParameter blockParameter = null);

        Task<string> PoolIdToProviderQueryAsync(long chainId, Enum contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<BigInteger> PoolIdToVaultIdQueryAsync(long chainId, Enum contractType, PoolIdToVaultIdFunction poolIdToVaultIdFunction, BlockParameter blockParameter = null);

        Task<BigInteger> PoolIdToVaultIdQueryAsync(long chainId, Enum contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<string> RenounceOwnershipRequestAsync(long chainId, Enum contractType, RenounceOwnershipFunction renounceOwnershipFunction);

        Task<string> RenounceOwnershipRequestAsync(long chainId, Enum contractType);

        Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null);

        Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CancellationTokenSource cancellationToken = null);

        Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(long chainId, Enum contractType, RoyaltyInfoFunction royaltyInfoFunction, BlockParameter blockParameter = null);

        Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(long chainId, Enum contractType, BigInteger tokenId, BigInteger salePrice, BlockParameter blockParameter = null);

        Task<string> SafeMintAndTransferRequestAsync(long chainId, Enum contractType, SafeMintAndTransferFunction safeMintAndTransferFunction);

        Task<TransactionReceipt> SafeMintAndTransferRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SafeMintAndTransferFunction safeMintAndTransferFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SafeMintAndTransferRequestAsync(long chainId, Enum contractType, string owner, string token, string from, BigInteger amount, string provider, byte[] data);

        Task<TransactionReceipt> SafeMintAndTransferRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string owner, string token, string from, BigInteger amount, string provider, byte[] data, CancellationTokenSource cancellationToken = null);

        Task<string> SafeTransferFromRequestAsync(long chainId, Enum contractType, SafeTransferFromFunction safeTransferFromFunction);

        Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SafeTransferFromFunction safeTransferFromFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SafeTransferFromRequestAsync(long chainId, Enum contractType, string from, string to, BigInteger tokenId);

        Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null);

        Task<string> SafeTransferFromRequestAsync(long chainId, Enum contractType, SafeTransferFrom1Function safeTransferFrom1Function);

        Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SafeTransferFrom1Function safeTransferFrom1Function, CancellationTokenSource cancellationToken = null);

        Task<string> SafeTransferFromRequestAsync(long chainId, Enum contractType, string from, string to, BigInteger tokenId, byte[] data);

        Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string from, string to, BigInteger tokenId, byte[] data, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovalForAllRequestAsync(long chainId, Enum contractType, SetApprovalForAllFunction setApprovalForAllFunction);

        Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetApprovalForAllFunction setApprovalForAllFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovalForAllRequestAsync(long chainId, Enum contractType, string @operator, bool approved);

        Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string @operator, bool approved, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovedContractRequestAsync(long chainId, Enum contractType, SetApprovedContractFunction setApprovedContractFunction);

        Task<TransactionReceipt> SetApprovedContractRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetApprovedContractFunction setApprovedContractFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovedContractRequestAsync(long chainId, Enum contractType, string contractAddress, bool status);

        Task<TransactionReceipt> SetApprovedContractRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string contractAddress, bool status, CancellationTokenSource cancellationToken = null);

        Task<string> SetBaseURIRequestAsync(long chainId, Enum contractType, SetBaseURIFunction setBaseURIFunction);

        Task<TransactionReceipt> SetBaseURIRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetBaseURIFunction setBaseURIFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetBaseURIRequestAsync(long chainId, Enum contractType, string newBaseURI);

        Task<TransactionReceipt> SetBaseURIRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string newBaseURI, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, string firewall);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewall, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, string firewallAdmin);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, Enum contractType, SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, Enum contractType, byte[] interfaceId, BlockParameter blockParameter = null);

        Task<string> SymbolQueryAsync(long chainId, Enum contractType, SymbolFunction symbolFunction, BlockParameter blockParameter = null);

        Task<string> SymbolQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<BigInteger> TokenByIndexQueryAsync(long chainId, Enum contractType, TokenByIndexFunction tokenByIndexFunction, BlockParameter blockParameter = null);

        Task<BigInteger> TokenByIndexQueryAsync(long chainId, Enum contractType, BigInteger index, BlockParameter blockParameter = null);

        Task<string> TokenOfQueryAsync(long chainId, Enum contractType, TokenOfFunction tokenOfFunction, BlockParameter blockParameter = null);

        Task<string> TokenOfQueryAsync(long chainId, Enum contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, Enum contractType, TokenOfOwnerByIndexFunction tokenOfOwnerByIndexFunction, BlockParameter blockParameter = null);

        Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, Enum contractType, string owner, BigInteger index, BlockParameter blockParameter = null);

        Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, Enum contractType, TokenOfOwnerByIndex1Function tokenOfOwnerByIndex1Function, BlockParameter blockParameter = null);

        Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, Enum contractType, string owner, List<string> tokens, BigInteger index, BlockParameter blockParameter = null);

        Task<string> TokenURIQueryAsync(long chainId, Enum contractType, TokenURIFunction tokenURIFunction, BlockParameter blockParameter = null);

        Task<string> TokenURIQueryAsync(long chainId, Enum contractType, BigInteger tokenId, BlockParameter blockParameter = null);

        Task<BigInteger> TotalSupplyQueryAsync(long chainId, Enum contractType, TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null);

        Task<BigInteger> TotalSupplyQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> TransferFromRequestAsync(long chainId, Enum contractType, TransferFromFunction transferFromFunction);

        Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(long chainId, Enum contractType, TransferFromFunction transferFromFunction, CancellationTokenSource cancellationToken = null);

        Task<string> TransferFromRequestAsync(long chainId, Enum contractType, string from, string to, BigInteger tokenId);

        Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null);

        Task<string> TransferOwnershipRequestAsync(long chainId, Enum contractType, TransferOwnershipFunction transferOwnershipFunction);

        Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null);

        Task<string> TransferOwnershipRequestAsync(long chainId, Enum contractType, string newOwner);

        Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string newOwner, CancellationTokenSource cancellationToken = null);

        Task<string> UpdateAllMetadataRequestAsync(long chainId, Enum contractType, UpdateAllMetadataFunction updateAllMetadataFunction);

        Task<string> UpdateAllMetadataRequestAsync(long chainId, Enum contractType);

        Task<TransactionReceipt> UpdateAllMetadataRequestAndWaitForReceiptAsync(long chainId, Enum contractType, UpdateAllMetadataFunction updateAllMetadataFunction, CancellationTokenSource cancellationToken = null);

        Task<TransactionReceipt> UpdateAllMetadataRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CancellationTokenSource cancellationToken = null);

        Task<string> VaultManagerQueryAsync(long chainId, Enum contractType, VaultManagerFunction vaultManagerFunction, BlockParameter blockParameter = null);

        Task<string> VaultManagerQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);
    }
}
