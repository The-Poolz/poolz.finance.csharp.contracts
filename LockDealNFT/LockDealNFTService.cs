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
    public partial class LockDealNFTService
    {
        protected virtual Nethereum.Web3.IWeb3 Web3 { get; }

        public virtual ContractHandler ContractHandler { get; }

        public LockDealNFTService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public LockDealNFTService(Nethereum.Web3.IWeb3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public virtual Task<string> ApproveRequestAsync(ApproveFunction approveFunction)
        {
             return ContractHandler.SendRequestAsync(approveFunction);
        }

        public virtual Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public virtual Task<string> ApproveRequestAsync(string to, BigInteger tokenId)
        {
            var approveFunction = new ApproveFunction();
                approveFunction.To = to;
                approveFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(approveFunction);
        }

        public virtual Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var approveFunction = new ApproveFunction();
                approveFunction.To = to;
                approveFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public virtual Task<string> ApprovePoolTransfersRequestAsync(ApprovePoolTransfersFunction approvePoolTransfersFunction)
        {
             return ContractHandler.SendRequestAsync(approvePoolTransfersFunction);
        }

        public virtual Task<TransactionReceipt> ApprovePoolTransfersRequestAndWaitForReceiptAsync(ApprovePoolTransfersFunction approvePoolTransfersFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(approvePoolTransfersFunction, cancellationToken);
        }

        public virtual Task<string> ApprovePoolTransfersRequestAsync(bool status)
        {
            var approvePoolTransfersFunction = new ApprovePoolTransfersFunction();
                approvePoolTransfersFunction.Status = status;
            
             return ContractHandler.SendRequestAsync(approvePoolTransfersFunction);
        }

        public virtual Task<TransactionReceipt> ApprovePoolTransfersRequestAndWaitForReceiptAsync(bool status, CancellationTokenSource cancellationToken = null)
        {
            var approvePoolTransfersFunction = new ApprovePoolTransfersFunction();
                approvePoolTransfersFunction.Status = status;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(approvePoolTransfersFunction, cancellationToken);
        }

        public virtual Task<bool> ApprovedContractsQueryAsync(ApprovedContractsFunction approvedContractsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ApprovedContractsFunction, bool>(approvedContractsFunction, blockParameter);
        }

        
        public virtual Task<bool> ApprovedContractsQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var approvedContractsFunction = new ApprovedContractsFunction();
                approvedContractsFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<ApprovedContractsFunction, bool>(approvedContractsFunction, blockParameter);
        }

        public virtual Task<bool> ApprovedPoolUserTransfersQueryAsync(ApprovedPoolUserTransfersFunction approvedPoolUserTransfersFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ApprovedPoolUserTransfersFunction, bool>(approvedPoolUserTransfersFunction, blockParameter);
        }

        
        public virtual Task<bool> ApprovedPoolUserTransfersQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var approvedPoolUserTransfersFunction = new ApprovedPoolUserTransfersFunction();
                approvedPoolUserTransfersFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<ApprovedPoolUserTransfersFunction, bool>(approvedPoolUserTransfersFunction, blockParameter);
        }

        public virtual Task<BigInteger> BalanceOfQueryAsync(BalanceOf1Function balanceOf1Function, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BalanceOf1Function, BigInteger>(balanceOf1Function, blockParameter);
        }

        
        public virtual Task<BigInteger> BalanceOfQueryAsync(string owner, List<string> tokens, BlockParameter blockParameter = null)
        {
            var balanceOf1Function = new BalanceOf1Function();
                balanceOf1Function.Owner = owner;
                balanceOf1Function.Tokens = tokens;
            
            return ContractHandler.QueryAsync<BalanceOf1Function, BigInteger>(balanceOf1Function, blockParameter);
        }

        public virtual Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> BalanceOfQueryAsync(string owner, BlockParameter blockParameter = null)
        {
            var balanceOfFunction = new BalanceOfFunction();
                balanceOfFunction.Owner = owner;
            
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        public virtual Task<string> BaseURIQueryAsync(BaseURIFunction baseURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BaseURIFunction, string>(baseURIFunction, blockParameter);
        }

        
        public virtual Task<string> BaseURIQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BaseURIFunction, string>(null, blockParameter);
        }

        public virtual Task<string> CloneVaultIdRequestAsync(CloneVaultIdFunction cloneVaultIdFunction)
        {
             return ContractHandler.SendRequestAsync(cloneVaultIdFunction);
        }

        public virtual Task<TransactionReceipt> CloneVaultIdRequestAndWaitForReceiptAsync(CloneVaultIdFunction cloneVaultIdFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(cloneVaultIdFunction, cancellationToken);
        }

        public virtual Task<string> CloneVaultIdRequestAsync(BigInteger destinationPoolId, BigInteger sourcePoolId)
        {
            var cloneVaultIdFunction = new CloneVaultIdFunction();
                cloneVaultIdFunction.DestinationPoolId = destinationPoolId;
                cloneVaultIdFunction.SourcePoolId = sourcePoolId;
            
             return ContractHandler.SendRequestAsync(cloneVaultIdFunction);
        }

        public virtual Task<TransactionReceipt> CloneVaultIdRequestAndWaitForReceiptAsync(BigInteger destinationPoolId, BigInteger sourcePoolId, CancellationTokenSource cancellationToken = null)
        {
            var cloneVaultIdFunction = new CloneVaultIdFunction();
                cloneVaultIdFunction.DestinationPoolId = destinationPoolId;
                cloneVaultIdFunction.SourcePoolId = sourcePoolId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(cloneVaultIdFunction, cancellationToken);
        }

        public virtual Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(firewallAdminFunction, blockParameter);
        }

        
        public virtual Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(null, blockParameter);
        }

        public virtual Task<string> GetApprovedQueryAsync(GetApprovedFunction getApprovedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetApprovedFunction, string>(getApprovedFunction, blockParameter);
        }

        
        public virtual Task<string> GetApprovedQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getApprovedFunction = new GetApprovedFunction();
                getApprovedFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<GetApprovedFunction, string>(getApprovedFunction, blockParameter);
        }

        public virtual Task<GetDataOutputDTO> GetDataQueryAsync(GetDataFunction getDataFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetDataFunction, GetDataOutputDTO>(getDataFunction, blockParameter);
        }

        public virtual Task<GetDataOutputDTO> GetDataQueryAsync(BigInteger poolId, BlockParameter blockParameter = null)
        {
            var getDataFunction = new GetDataFunction();
                getDataFunction.PoolId = poolId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetDataFunction, GetDataOutputDTO>(getDataFunction, blockParameter);
        }

        public virtual Task<GetFullDataOutputDTO> GetFullDataQueryAsync(GetFullDataFunction getFullDataFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetFullDataFunction, GetFullDataOutputDTO>(getFullDataFunction, blockParameter);
        }

        public virtual Task<GetFullDataOutputDTO> GetFullDataQueryAsync(BigInteger poolId, BlockParameter blockParameter = null)
        {
            var getFullDataFunction = new GetFullDataFunction();
                getFullDataFunction.PoolId = poolId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetFullDataFunction, GetFullDataOutputDTO>(getFullDataFunction, blockParameter);
        }

        public virtual Task<GetUserDataByTokensOutputDTO> GetUserDataByTokensQueryAsync(GetUserDataByTokensFunction getUserDataByTokensFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetUserDataByTokensFunction, GetUserDataByTokensOutputDTO>(getUserDataByTokensFunction, blockParameter);
        }

        public virtual Task<GetUserDataByTokensOutputDTO> GetUserDataByTokensQueryAsync(string user, List<string> tokens, BigInteger from, BigInteger to, BlockParameter blockParameter = null)
        {
            var getUserDataByTokensFunction = new GetUserDataByTokensFunction();
                getUserDataByTokensFunction.User = user;
                getUserDataByTokensFunction.Tokens = tokens;
                getUserDataByTokensFunction.From = from;
                getUserDataByTokensFunction.To = to;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetUserDataByTokensFunction, GetUserDataByTokensOutputDTO>(getUserDataByTokensFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(BigInteger poolId, BlockParameter blockParameter = null)
        {
            var getWithdrawableAmountFunction = new GetWithdrawableAmountFunction();
                getWithdrawableAmountFunction.PoolId = poolId;
            
            return ContractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        public virtual Task<bool> IsApprovedForAllQueryAsync(IsApprovedForAllFunction isApprovedForAllFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsApprovedForAllFunction, bool>(isApprovedForAllFunction, blockParameter);
        }

        
        public virtual Task<bool> IsApprovedForAllQueryAsync(string owner, string @operator, BlockParameter blockParameter = null)
        {
            var isApprovedForAllFunction = new IsApprovedForAllFunction();
                isApprovedForAllFunction.Owner = owner;
                isApprovedForAllFunction.Operator = @operator;
            
            return ContractHandler.QueryAsync<IsApprovedForAllFunction, bool>(isApprovedForAllFunction, blockParameter);
        }

        public virtual Task<string> MintAndTransferRequestAsync(MintAndTransferFunction mintAndTransferFunction)
        {
             return ContractHandler.SendRequestAsync(mintAndTransferFunction);
        }

        public virtual Task<TransactionReceipt> MintAndTransferRequestAndWaitForReceiptAsync(MintAndTransferFunction mintAndTransferFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintAndTransferFunction, cancellationToken);
        }

        public virtual Task<string> MintAndTransferRequestAsync(string owner, string token, BigInteger amount, string provider)
        {
            var mintAndTransferFunction = new MintAndTransferFunction();
                mintAndTransferFunction.Owner = owner;
                mintAndTransferFunction.Token = token;
                mintAndTransferFunction.Amount = amount;
                mintAndTransferFunction.Provider = provider;
            
             return ContractHandler.SendRequestAsync(mintAndTransferFunction);
        }

        public virtual Task<TransactionReceipt> MintAndTransferRequestAndWaitForReceiptAsync(string owner, string token, BigInteger amount, string provider, CancellationTokenSource cancellationToken = null)
        {
            var mintAndTransferFunction = new MintAndTransferFunction();
                mintAndTransferFunction.Owner = owner;
                mintAndTransferFunction.Token = token;
                mintAndTransferFunction.Amount = amount;
                mintAndTransferFunction.Provider = provider;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintAndTransferFunction, cancellationToken);
        }

        public virtual Task<string> MintForProviderRequestAsync(MintForProviderFunction mintForProviderFunction)
        {
             return ContractHandler.SendRequestAsync(mintForProviderFunction);
        }

        public virtual Task<TransactionReceipt> MintForProviderRequestAndWaitForReceiptAsync(MintForProviderFunction mintForProviderFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintForProviderFunction, cancellationToken);
        }

        public virtual Task<string> MintForProviderRequestAsync(string owner, string provider)
        {
            var mintForProviderFunction = new MintForProviderFunction();
                mintForProviderFunction.Owner = owner;
                mintForProviderFunction.Provider = provider;
            
             return ContractHandler.SendRequestAsync(mintForProviderFunction);
        }

        public virtual Task<TransactionReceipt> MintForProviderRequestAndWaitForReceiptAsync(string owner, string provider, CancellationTokenSource cancellationToken = null)
        {
            var mintForProviderFunction = new MintForProviderFunction();
                mintForProviderFunction.Owner = owner;
                mintForProviderFunction.Provider = provider;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintForProviderFunction, cancellationToken);
        }

        public virtual Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
        }

        
        public virtual Task<string> NameQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
        }

        public virtual Task<string> OnERC721ReceivedRequestAsync(OnERC721ReceivedFunction onERC721ReceivedFunction)
        {
             return ContractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public virtual Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(OnERC721ReceivedFunction onERC721ReceivedFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }

        public virtual Task<string> OnERC721ReceivedRequestAsync(string returnValue1, string from, BigInteger poolId, byte[] data)
        {
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.ReturnValue1 = returnValue1;
                onERC721ReceivedFunction.From = from;
                onERC721ReceivedFunction.PoolId = poolId;
                onERC721ReceivedFunction.Data = data;
            
             return ContractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public virtual Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(string returnValue1, string from, BigInteger poolId, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.ReturnValue1 = returnValue1;
                onERC721ReceivedFunction.From = from;
                onERC721ReceivedFunction.PoolId = poolId;
                onERC721ReceivedFunction.Data = data;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }

        public virtual Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        
        public virtual Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public virtual Task<string> OwnerOfQueryAsync(OwnerOfFunction ownerOfFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
        }

        
        public virtual Task<string> OwnerOfQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var ownerOfFunction = new OwnerOfFunction();
                ownerOfFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
        }

        public virtual Task<string> PoolIdToProviderQueryAsync(PoolIdToProviderFunction poolIdToProviderFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolIdToProviderFunction, string>(poolIdToProviderFunction, blockParameter);
        }

        
        public virtual Task<string> PoolIdToProviderQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var poolIdToProviderFunction = new PoolIdToProviderFunction();
                poolIdToProviderFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PoolIdToProviderFunction, string>(poolIdToProviderFunction, blockParameter);
        }

        public virtual Task<BigInteger> PoolIdToVaultIdQueryAsync(PoolIdToVaultIdFunction poolIdToVaultIdFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolIdToVaultIdFunction, BigInteger>(poolIdToVaultIdFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> PoolIdToVaultIdQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var poolIdToVaultIdFunction = new PoolIdToVaultIdFunction();
                poolIdToVaultIdFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PoolIdToVaultIdFunction, BigInteger>(poolIdToVaultIdFunction, blockParameter);
        }

        public virtual Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(renounceOwnershipFunction);
        }

        public virtual Task<string> RenounceOwnershipRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RenounceOwnershipFunction>();
        }

        public virtual Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceOwnershipFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RenounceOwnershipFunction>(null, cancellationToken);
        }

        public virtual Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(RoyaltyInfoFunction royaltyInfoFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<RoyaltyInfoFunction, RoyaltyInfoOutputDTO>(royaltyInfoFunction, blockParameter);
        }

        public virtual Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(BigInteger tokenId, BigInteger salePrice, BlockParameter blockParameter = null)
        {
            var royaltyInfoFunction = new RoyaltyInfoFunction();
                royaltyInfoFunction.TokenId = tokenId;
                royaltyInfoFunction.SalePrice = salePrice;
            
            return ContractHandler.QueryDeserializingToObjectAsync<RoyaltyInfoFunction, RoyaltyInfoOutputDTO>(royaltyInfoFunction, blockParameter);
        }

        public virtual Task<string> SafeMintAndTransferRequestAsync(SafeMintAndTransferFunction safeMintAndTransferFunction)
        {
             return ContractHandler.SendRequestAsync(safeMintAndTransferFunction);
        }

        public virtual Task<TransactionReceipt> SafeMintAndTransferRequestAndWaitForReceiptAsync(SafeMintAndTransferFunction safeMintAndTransferFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeMintAndTransferFunction, cancellationToken);
        }

        public virtual Task<string> SafeMintAndTransferRequestAsync(string owner, string token, string from, BigInteger amount, string provider, byte[] data)
        {
            var safeMintAndTransferFunction = new SafeMintAndTransferFunction();
                safeMintAndTransferFunction.Owner = owner;
                safeMintAndTransferFunction.Token = token;
                safeMintAndTransferFunction.From = from;
                safeMintAndTransferFunction.Amount = amount;
                safeMintAndTransferFunction.Provider = provider;
                safeMintAndTransferFunction.Data = data;
            
             return ContractHandler.SendRequestAsync(safeMintAndTransferFunction);
        }

        public virtual Task<TransactionReceipt> SafeMintAndTransferRequestAndWaitForReceiptAsync(string owner, string token, string from, BigInteger amount, string provider, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            var safeMintAndTransferFunction = new SafeMintAndTransferFunction();
                safeMintAndTransferFunction.Owner = owner;
                safeMintAndTransferFunction.Token = token;
                safeMintAndTransferFunction.From = from;
                safeMintAndTransferFunction.Amount = amount;
                safeMintAndTransferFunction.Provider = provider;
                safeMintAndTransferFunction.Data = data;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeMintAndTransferFunction, cancellationToken);
        }

        public virtual Task<string> SafeTransferFromRequestAsync(SafeTransferFromFunction safeTransferFromFunction)
        {
             return ContractHandler.SendRequestAsync(safeTransferFromFunction);
        }

        public virtual Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(SafeTransferFromFunction safeTransferFromFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
        }

        public virtual Task<string> SafeTransferFromRequestAsync(string from, string to, BigInteger tokenId)
        {
            var safeTransferFromFunction = new SafeTransferFromFunction();
                safeTransferFromFunction.From = from;
                safeTransferFromFunction.To = to;
                safeTransferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(safeTransferFromFunction);
        }

        public virtual Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var safeTransferFromFunction = new SafeTransferFromFunction();
                safeTransferFromFunction.From = from;
                safeTransferFromFunction.To = to;
                safeTransferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
        }

        public virtual Task<string> SafeTransferFromRequestAsync(SafeTransferFrom1Function safeTransferFrom1Function)
        {
             return ContractHandler.SendRequestAsync(safeTransferFrom1Function);
        }

        public virtual Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(SafeTransferFrom1Function safeTransferFrom1Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFrom1Function, cancellationToken);
        }

        public virtual Task<string> SafeTransferFromRequestAsync(string from, string to, BigInteger tokenId, byte[] data)
        {
            var safeTransferFrom1Function = new SafeTransferFrom1Function();
                safeTransferFrom1Function.From = from;
                safeTransferFrom1Function.To = to;
                safeTransferFrom1Function.TokenId = tokenId;
                safeTransferFrom1Function.Data = data;
            
             return ContractHandler.SendRequestAsync(safeTransferFrom1Function);
        }

        public virtual Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            var safeTransferFrom1Function = new SafeTransferFrom1Function();
                safeTransferFrom1Function.From = from;
                safeTransferFrom1Function.To = to;
                safeTransferFrom1Function.TokenId = tokenId;
                safeTransferFrom1Function.Data = data;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFrom1Function, cancellationToken);
        }

        public virtual Task<string> SetApprovalForAllRequestAsync(SetApprovalForAllFunction setApprovalForAllFunction)
        {
             return ContractHandler.SendRequestAsync(setApprovalForAllFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(SetApprovalForAllFunction setApprovalForAllFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovalForAllFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovalForAllRequestAsync(string @operator, bool approved)
        {
            var setApprovalForAllFunction = new SetApprovalForAllFunction();
                setApprovalForAllFunction.Operator = @operator;
                setApprovalForAllFunction.Approved = approved;
            
             return ContractHandler.SendRequestAsync(setApprovalForAllFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(string @operator, bool approved, CancellationTokenSource cancellationToken = null)
        {
            var setApprovalForAllFunction = new SetApprovalForAllFunction();
                setApprovalForAllFunction.Operator = @operator;
                setApprovalForAllFunction.Approved = approved;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovalForAllFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovedContractRequestAsync(SetApprovedContractFunction setApprovedContractFunction)
        {
             return ContractHandler.SendRequestAsync(setApprovedContractFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovedContractRequestAndWaitForReceiptAsync(SetApprovedContractFunction setApprovedContractFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovedContractFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovedContractRequestAsync(string contractAddress, bool status)
        {
            var setApprovedContractFunction = new SetApprovedContractFunction();
                setApprovedContractFunction.ContractAddress = contractAddress;
                setApprovedContractFunction.Status = status;
            
             return ContractHandler.SendRequestAsync(setApprovedContractFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovedContractRequestAndWaitForReceiptAsync(string contractAddress, bool status, CancellationTokenSource cancellationToken = null)
        {
            var setApprovedContractFunction = new SetApprovedContractFunction();
                setApprovedContractFunction.ContractAddress = contractAddress;
                setApprovedContractFunction.Status = status;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovedContractFunction, cancellationToken);
        }

        public virtual Task<string> SetBaseURIRequestAsync(SetBaseURIFunction setBaseURIFunction)
        {
             return ContractHandler.SendRequestAsync(setBaseURIFunction);
        }

        public virtual Task<TransactionReceipt> SetBaseURIRequestAndWaitForReceiptAsync(SetBaseURIFunction setBaseURIFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setBaseURIFunction, cancellationToken);
        }

        public virtual Task<string> SetBaseURIRequestAsync(string newBaseURI)
        {
            var setBaseURIFunction = new SetBaseURIFunction();
                setBaseURIFunction.NewBaseURI = newBaseURI;
            
             return ContractHandler.SendRequestAsync(setBaseURIFunction);
        }

        public virtual Task<TransactionReceipt> SetBaseURIRequestAndWaitForReceiptAsync(string newBaseURI, CancellationTokenSource cancellationToken = null)
        {
            var setBaseURIFunction = new SetBaseURIFunction();
                setBaseURIFunction.NewBaseURI = newBaseURI;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setBaseURIFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(SetFirewallFunction setFirewallFunction)
        {
             return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(string firewall)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
             return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(string firewall, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(SetFirewallAdminFunction setFirewallAdminFunction)
        {
             return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(string firewallAdmin)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
             return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(string firewallAdmin, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<bool> SupportsInterfaceQueryAsync(SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        
        public virtual Task<bool> SupportsInterfaceQueryAsync(byte[] interfaceId, BlockParameter blockParameter = null)
        {
            var supportsInterfaceFunction = new SupportsInterfaceFunction();
                supportsInterfaceFunction.InterfaceId = interfaceId;
            
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public virtual Task<string> SymbolQueryAsync(SymbolFunction symbolFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SymbolFunction, string>(symbolFunction, blockParameter);
        }

        
        public virtual Task<string> SymbolQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SymbolFunction, string>(null, blockParameter);
        }

        public virtual Task<BigInteger> TokenByIndexQueryAsync(TokenByIndexFunction tokenByIndexFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenByIndexFunction, BigInteger>(tokenByIndexFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> TokenByIndexQueryAsync(BigInteger index, BlockParameter blockParameter = null)
        {
            var tokenByIndexFunction = new TokenByIndexFunction();
                tokenByIndexFunction.Index = index;
            
            return ContractHandler.QueryAsync<TokenByIndexFunction, BigInteger>(tokenByIndexFunction, blockParameter);
        }

        public virtual Task<string> TokenOfQueryAsync(TokenOfFunction tokenOfFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenOfFunction, string>(tokenOfFunction, blockParameter);
        }

        
        public virtual Task<string> TokenOfQueryAsync(BigInteger poolId, BlockParameter blockParameter = null)
        {
            var tokenOfFunction = new TokenOfFunction();
                tokenOfFunction.PoolId = poolId;
            
            return ContractHandler.QueryAsync<TokenOfFunction, string>(tokenOfFunction, blockParameter);
        }

        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(TokenOfOwnerByIndexFunction tokenOfOwnerByIndexFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(string owner, BigInteger index, BlockParameter blockParameter = null)
        {
            var tokenOfOwnerByIndexFunction = new TokenOfOwnerByIndexFunction();
                tokenOfOwnerByIndexFunction.Owner = owner;
                tokenOfOwnerByIndexFunction.Index = index;
            
            return ContractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
        }

        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(TokenOfOwnerByIndex1Function tokenOfOwnerByIndex1Function, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenOfOwnerByIndex1Function, BigInteger>(tokenOfOwnerByIndex1Function, blockParameter);
        }

        
        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(string owner, List<string> tokens, BigInteger index, BlockParameter blockParameter = null)
        {
            var tokenOfOwnerByIndex1Function = new TokenOfOwnerByIndex1Function();
                tokenOfOwnerByIndex1Function.Owner = owner;
                tokenOfOwnerByIndex1Function.Tokens = tokens;
                tokenOfOwnerByIndex1Function.Index = index;
            
            return ContractHandler.QueryAsync<TokenOfOwnerByIndex1Function, BigInteger>(tokenOfOwnerByIndex1Function, blockParameter);
        }

        public virtual Task<string> TokenURIQueryAsync(TokenURIFunction tokenURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenURIFunction, string>(tokenURIFunction, blockParameter);
        }

        
        public virtual Task<string> TokenURIQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var tokenURIFunction = new TokenURIFunction();
                tokenURIFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<TokenURIFunction, string>(tokenURIFunction, blockParameter);
        }

        public virtual Task<BigInteger> TotalSupplyQueryAsync(TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(totalSupplyFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> TotalSupplyQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> TransferFromRequestAsync(TransferFromFunction transferFromFunction)
        {
             return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public virtual Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(TransferFromFunction transferFromFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }

        public virtual Task<string> TransferFromRequestAsync(string from, string to, BigInteger tokenId)
        {
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public virtual Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }

        public virtual Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public virtual Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public virtual Task<string> TransferOwnershipRequestAsync(string newOwner)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public virtual Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public virtual Task<string> UpdateAllMetadataRequestAsync(UpdateAllMetadataFunction updateAllMetadataFunction)
        {
             return ContractHandler.SendRequestAsync(updateAllMetadataFunction);
        }

        public virtual Task<string> UpdateAllMetadataRequestAsync()
        {
             return ContractHandler.SendRequestAsync<UpdateAllMetadataFunction>();
        }

        public virtual Task<TransactionReceipt> UpdateAllMetadataRequestAndWaitForReceiptAsync(UpdateAllMetadataFunction updateAllMetadataFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(updateAllMetadataFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> UpdateAllMetadataRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<UpdateAllMetadataFunction>(null, cancellationToken);
        }

        public virtual Task<string> VaultManagerQueryAsync(VaultManagerFunction vaultManagerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<VaultManagerFunction, string>(vaultManagerFunction, blockParameter);
        }

        
        public virtual Task<string> VaultManagerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<VaultManagerFunction, string>(null, blockParameter);
        }
    }
}
