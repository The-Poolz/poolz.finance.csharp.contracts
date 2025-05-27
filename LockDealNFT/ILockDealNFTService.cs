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
    public interface ILockDealNFTService<in TContractType>
        where TContractType : Enum
    {
        Task<string> ApproveRequestAsync(long chainId, TContractType contractType, ApproveFunction approveFunction);

        Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null);

        Task<string> ApproveRequestAsync(long chainId, TContractType contractType, string to, BigInteger tokenId);

        Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null);

        Task<string> ApprovePoolTransfersRequestAsync(long chainId, TContractType contractType, ApprovePoolTransfersFunction approvePoolTransfersFunction);

        Task<TransactionReceipt> ApprovePoolTransfersRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, ApprovePoolTransfersFunction approvePoolTransfersFunction, CancellationTokenSource cancellationToken = null);

        Task<string> ApprovePoolTransfersRequestAsync(long chainId, TContractType contractType, bool status);

        Task<TransactionReceipt> ApprovePoolTransfersRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, bool status, CancellationTokenSource cancellationToken = null);

        Task<bool> ApprovedContractsQueryAsync(long chainId, TContractType contractType, ApprovedContractsFunction approvedContractsFunction, BlockParameter blockParameter = null);

        Task<bool> ApprovedContractsQueryAsync(long chainId, TContractType contractType, string returnValue1, BlockParameter blockParameter = null);

        Task<bool> ApprovedPoolUserTransfersQueryAsync(long chainId, TContractType contractType, ApprovedPoolUserTransfersFunction approvedPoolUserTransfersFunction, BlockParameter blockParameter = null);

        Task<bool> ApprovedPoolUserTransfersQueryAsync(long chainId, TContractType contractType, string returnValue1, BlockParameter blockParameter = null);

        Task<BigInteger> BalanceOfQueryAsync(long chainId, TContractType contractType, BalanceOf1Function balanceOf1Function, BlockParameter blockParameter = null);

        Task<BigInteger> BalanceOfQueryAsync(long chainId, TContractType contractType, string owner, List<string> tokens, BlockParameter blockParameter = null);

        Task<BigInteger> BalanceOfQueryAsync(long chainId, TContractType contractType, BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null);

        Task<BigInteger> BalanceOfQueryAsync(long chainId, TContractType contractType, string owner, BlockParameter blockParameter = null);

        Task<string> BaseURIQueryAsync(long chainId, TContractType contractType, BaseURIFunction baseURIFunction, BlockParameter blockParameter = null);

        Task<string> BaseURIQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> CloneVaultIdRequestAsync(long chainId, TContractType contractType, CloneVaultIdFunction cloneVaultIdFunction);

        Task<TransactionReceipt> CloneVaultIdRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CloneVaultIdFunction cloneVaultIdFunction, CancellationTokenSource cancellationToken = null);

        Task<string> CloneVaultIdRequestAsync(long chainId, TContractType contractType, BigInteger destinationPoolId, BigInteger sourcePoolId);

        Task<TransactionReceipt> CloneVaultIdRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger destinationPoolId, BigInteger sourcePoolId, CancellationTokenSource cancellationToken = null);

        Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> GetApprovedQueryAsync(long chainId, TContractType contractType, GetApprovedFunction getApprovedFunction, BlockParameter blockParameter = null);

        Task<string> GetApprovedQueryAsync(long chainId, TContractType contractType, BigInteger tokenId, BlockParameter blockParameter = null);

        Task<GetDataOutputDTO> GetDataQueryAsync(long chainId, TContractType contractType, GetDataFunction getDataFunction, BlockParameter blockParameter = null);

        Task<GetDataOutputDTO> GetDataQueryAsync(long chainId, TContractType contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<GetFullDataOutputDTO> GetFullDataQueryAsync(long chainId, TContractType contractType, GetFullDataFunction getFullDataFunction, BlockParameter blockParameter = null);

        Task<GetFullDataOutputDTO> GetFullDataQueryAsync(long chainId, TContractType contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<GetUserDataByTokensOutputDTO> GetUserDataByTokensQueryAsync(long chainId, TContractType contractType, GetUserDataByTokensFunction getUserDataByTokensFunction, BlockParameter blockParameter = null);

        Task<GetUserDataByTokensOutputDTO> GetUserDataByTokensQueryAsync(long chainId, TContractType contractType, string user, List<string> tokens, BigInteger from, BigInteger to, BlockParameter blockParameter = null);

        Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, TContractType contractType, GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, TContractType contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<bool> IsApprovedForAllQueryAsync(long chainId, TContractType contractType, IsApprovedForAllFunction isApprovedForAllFunction, BlockParameter blockParameter = null);

        Task<bool> IsApprovedForAllQueryAsync(long chainId, TContractType contractType, string owner, string @operator, BlockParameter blockParameter = null);

        Task<string> MintAndTransferRequestAsync(long chainId, TContractType contractType, MintAndTransferFunction mintAndTransferFunction);

        Task<TransactionReceipt> MintAndTransferRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, MintAndTransferFunction mintAndTransferFunction, CancellationTokenSource cancellationToken = null);

        Task<string> MintAndTransferRequestAsync(long chainId, TContractType contractType, string owner, string token, BigInteger amount, string provider);

        Task<TransactionReceipt> MintAndTransferRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string owner, string token, BigInteger amount, string provider, CancellationTokenSource cancellationToken = null);

        Task<string> MintForProviderRequestAsync(long chainId, TContractType contractType, MintForProviderFunction mintForProviderFunction);

        Task<TransactionReceipt> MintForProviderRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, MintForProviderFunction mintForProviderFunction, CancellationTokenSource cancellationToken = null);

        Task<string> MintForProviderRequestAsync(long chainId, TContractType contractType, string owner, string provider);

        Task<TransactionReceipt> MintForProviderRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string owner, string provider, CancellationTokenSource cancellationToken = null);

        Task<string> NameQueryAsync(long chainId, TContractType contractType, NameFunction nameFunction, BlockParameter blockParameter = null);

        Task<string> NameQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> OnERC721ReceivedRequestAsync(long chainId, TContractType contractType, OnERC721ReceivedFunction onERC721ReceivedFunction);

        Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, OnERC721ReceivedFunction onERC721ReceivedFunction, CancellationTokenSource cancellationToken = null);

        Task<string> OnERC721ReceivedRequestAsync(long chainId, TContractType contractType, string returnValue1, string from, BigInteger poolId, byte[] data);

        Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string returnValue1, string from, BigInteger poolId, byte[] data, CancellationTokenSource cancellationToken = null);

        Task<string> OwnerQueryAsync(long chainId, TContractType contractType, OwnerFunction ownerFunction, BlockParameter blockParameter = null);

        Task<string> OwnerQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> OwnerOfQueryAsync(long chainId, TContractType contractType, OwnerOfFunction ownerOfFunction, BlockParameter blockParameter = null);

        Task<string> OwnerOfQueryAsync(long chainId, TContractType contractType, BigInteger tokenId, BlockParameter blockParameter = null);

        Task<string> PoolIdToProviderQueryAsync(long chainId, TContractType contractType, PoolIdToProviderFunction poolIdToProviderFunction, BlockParameter blockParameter = null);

        Task<string> PoolIdToProviderQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<BigInteger> PoolIdToVaultIdQueryAsync(long chainId, TContractType contractType, PoolIdToVaultIdFunction poolIdToVaultIdFunction, BlockParameter blockParameter = null);

        Task<BigInteger> PoolIdToVaultIdQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<string> RenounceOwnershipRequestAsync(long chainId, TContractType contractType, RenounceOwnershipFunction renounceOwnershipFunction);

        Task<string> RenounceOwnershipRequestAsync(long chainId, TContractType contractType);

        Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null);

        Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CancellationTokenSource cancellationToken = null);

        Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(long chainId, TContractType contractType, RoyaltyInfoFunction royaltyInfoFunction, BlockParameter blockParameter = null);

        Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(long chainId, TContractType contractType, BigInteger tokenId, BigInteger salePrice, BlockParameter blockParameter = null);

        Task<string> SafeMintAndTransferRequestAsync(long chainId, TContractType contractType, SafeMintAndTransferFunction safeMintAndTransferFunction);

        Task<TransactionReceipt> SafeMintAndTransferRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SafeMintAndTransferFunction safeMintAndTransferFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SafeMintAndTransferRequestAsync(long chainId, TContractType contractType, string owner, string token, string from, BigInteger amount, string provider, byte[] data);

        Task<TransactionReceipt> SafeMintAndTransferRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string owner, string token, string from, BigInteger amount, string provider, byte[] data, CancellationTokenSource cancellationToken = null);

        Task<string> SafeTransferFromRequestAsync(long chainId, TContractType contractType, SafeTransferFromFunction safeTransferFromFunction);

        Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SafeTransferFromFunction safeTransferFromFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SafeTransferFromRequestAsync(long chainId, TContractType contractType, string from, string to, BigInteger tokenId);

        Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null);

        Task<string> SafeTransferFromRequestAsync(long chainId, TContractType contractType, SafeTransferFrom1Function safeTransferFrom1Function);

        Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SafeTransferFrom1Function safeTransferFrom1Function, CancellationTokenSource cancellationToken = null);

        Task<string> SafeTransferFromRequestAsync(long chainId, TContractType contractType, string from, string to, BigInteger tokenId, byte[] data);

        Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string from, string to, BigInteger tokenId, byte[] data, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovalForAllRequestAsync(long chainId, TContractType contractType, SetApprovalForAllFunction setApprovalForAllFunction);

        Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetApprovalForAllFunction setApprovalForAllFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovalForAllRequestAsync(long chainId, TContractType contractType, string @operator, bool approved);

        Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string @operator, bool approved, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovedContractRequestAsync(long chainId, TContractType contractType, SetApprovedContractFunction setApprovedContractFunction);

        Task<TransactionReceipt> SetApprovedContractRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetApprovedContractFunction setApprovedContractFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovedContractRequestAsync(long chainId, TContractType contractType, string contractAddress, bool status);

        Task<TransactionReceipt> SetApprovedContractRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string contractAddress, bool status, CancellationTokenSource cancellationToken = null);

        Task<string> SetBaseURIRequestAsync(long chainId, TContractType contractType, SetBaseURIFunction setBaseURIFunction);

        Task<TransactionReceipt> SetBaseURIRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetBaseURIFunction setBaseURIFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetBaseURIRequestAsync(long chainId, TContractType contractType, string newBaseURI);

        Task<TransactionReceipt> SetBaseURIRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string newBaseURI, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, string firewall);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewall, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, string firewallAdmin);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, TContractType contractType, SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, TContractType contractType, byte[] interfaceId, BlockParameter blockParameter = null);

        Task<string> SymbolQueryAsync(long chainId, TContractType contractType, SymbolFunction symbolFunction, BlockParameter blockParameter = null);

        Task<string> SymbolQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<BigInteger> TokenByIndexQueryAsync(long chainId, TContractType contractType, TokenByIndexFunction tokenByIndexFunction, BlockParameter blockParameter = null);

        Task<BigInteger> TokenByIndexQueryAsync(long chainId, TContractType contractType, BigInteger index, BlockParameter blockParameter = null);

        Task<string> TokenOfQueryAsync(long chainId, TContractType contractType, TokenOfFunction tokenOfFunction, BlockParameter blockParameter = null);

        Task<string> TokenOfQueryAsync(long chainId, TContractType contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, TContractType contractType, TokenOfOwnerByIndexFunction tokenOfOwnerByIndexFunction, BlockParameter blockParameter = null);

        Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, TContractType contractType, string owner, BigInteger index, BlockParameter blockParameter = null);

        Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, TContractType contractType, TokenOfOwnerByIndex1Function tokenOfOwnerByIndex1Function, BlockParameter blockParameter = null);

        Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, TContractType contractType, string owner, List<string> tokens, BigInteger index, BlockParameter blockParameter = null);

        Task<string> TokenURIQueryAsync(long chainId, TContractType contractType, TokenURIFunction tokenURIFunction, BlockParameter blockParameter = null);

        Task<string> TokenURIQueryAsync(long chainId, TContractType contractType, BigInteger tokenId, BlockParameter blockParameter = null);

        Task<BigInteger> TotalSupplyQueryAsync(long chainId, TContractType contractType, TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null);

        Task<BigInteger> TotalSupplyQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> TransferFromRequestAsync(long chainId, TContractType contractType, TransferFromFunction transferFromFunction);

        Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, TransferFromFunction transferFromFunction, CancellationTokenSource cancellationToken = null);

        Task<string> TransferFromRequestAsync(long chainId, TContractType contractType, string from, string to, BigInteger tokenId);

        Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null);

        Task<string> TransferOwnershipRequestAsync(long chainId, TContractType contractType, TransferOwnershipFunction transferOwnershipFunction);

        Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null);

        Task<string> TransferOwnershipRequestAsync(long chainId, TContractType contractType, string newOwner);

        Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string newOwner, CancellationTokenSource cancellationToken = null);

        Task<string> UpdateAllMetadataRequestAsync(long chainId, TContractType contractType, UpdateAllMetadataFunction updateAllMetadataFunction);

        Task<string> UpdateAllMetadataRequestAsync(long chainId, TContractType contractType);

        Task<TransactionReceipt> UpdateAllMetadataRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, UpdateAllMetadataFunction updateAllMetadataFunction, CancellationTokenSource cancellationToken = null);

        Task<TransactionReceipt> UpdateAllMetadataRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CancellationTokenSource cancellationToken = null);

        Task<string> VaultManagerQueryAsync(long chainId, TContractType contractType, VaultManagerFunction vaultManagerFunction, BlockParameter blockParameter = null);

        Task<string> VaultManagerQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);
    }
}
