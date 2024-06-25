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
    public partial class LockDealNFTService : ILockDealNFTService
    {
        protected virtual IWeb3 Web3 { get; private set; }

        public virtual ContractHandler ContractHandler { get; private set; }

        public LockDealNFTService() { }

        public LockDealNFTService(Web3 web3, string contractAddress)
        {
            Initialize(web3, contractAddress);
        }

        public LockDealNFTService(IWeb3 web3, string contractAddress)
        {
            Initialize(web3, contractAddress);
        }

        public void Initialize(IWeb3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        private void EnsureInitialized()
        {
            if (Web3 == null || ContractHandler == null)
            {
                throw new InvalidOperationException("The service has not been initialized. Please call the Initialize method with a valid IWeb3 instance and contract address.");
            }
        }

        public virtual Task<string> ApproveRequestAsync(ApproveFunction approveFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(approveFunction);
        }

        public virtual Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public virtual Task<string> ApproveRequestAsync(string to, BigInteger tokenId)
        {
            EnsureInitialized();
            var approveFunction = new ApproveFunction();
                approveFunction.To = to;
                approveFunction.TokenId = tokenId;
            
            return ContractHandler.SendRequestAsync(approveFunction);
        }

        public virtual Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var approveFunction = new ApproveFunction();
                approveFunction.To = to;
                approveFunction.TokenId = tokenId;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public virtual Task<string> ApprovePoolTransfersRequestAsync(ApprovePoolTransfersFunction approvePoolTransfersFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(approvePoolTransfersFunction);
        }

        public virtual Task<TransactionReceipt> ApprovePoolTransfersRequestAndWaitForReceiptAsync(ApprovePoolTransfersFunction approvePoolTransfersFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(approvePoolTransfersFunction, cancellationToken);
        }

        public virtual Task<string> ApprovePoolTransfersRequestAsync(bool status)
        {
            EnsureInitialized();
            var approvePoolTransfersFunction = new ApprovePoolTransfersFunction();
                approvePoolTransfersFunction.Status = status;
            
            return ContractHandler.SendRequestAsync(approvePoolTransfersFunction);
        }

        public virtual Task<TransactionReceipt> ApprovePoolTransfersRequestAndWaitForReceiptAsync(bool status, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var approvePoolTransfersFunction = new ApprovePoolTransfersFunction();
                approvePoolTransfersFunction.Status = status;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(approvePoolTransfersFunction, cancellationToken);
        }

        public virtual Task<bool> ApprovedContractsQueryAsync(ApprovedContractsFunction approvedContractsFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<ApprovedContractsFunction, bool>(approvedContractsFunction, blockParameter);
        }

        public virtual Task<bool> ApprovedContractsQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var approvedContractsFunction = new ApprovedContractsFunction();
                approvedContractsFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<ApprovedContractsFunction, bool>(approvedContractsFunction, blockParameter);
        }

        public virtual Task<bool> ApprovedPoolUserTransfersQueryAsync(ApprovedPoolUserTransfersFunction approvedPoolUserTransfersFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<ApprovedPoolUserTransfersFunction, bool>(approvedPoolUserTransfersFunction, blockParameter);
        }

        public virtual Task<bool> ApprovedPoolUserTransfersQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var approvedPoolUserTransfersFunction = new ApprovedPoolUserTransfersFunction();
                approvedPoolUserTransfersFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<ApprovedPoolUserTransfersFunction, bool>(approvedPoolUserTransfersFunction, blockParameter);
        }

        public virtual Task<BigInteger> BalanceOfQueryAsync(BalanceOf1Function balanceOf1Function, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<BalanceOf1Function, BigInteger>(balanceOf1Function, blockParameter);
        }

        public virtual Task<BigInteger> BalanceOfQueryAsync(string owner, List<string> tokens, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var balanceOf1Function = new BalanceOf1Function();
                balanceOf1Function.Owner = owner;
                balanceOf1Function.Tokens = tokens;
            
            return ContractHandler.QueryAsync<BalanceOf1Function, BigInteger>(balanceOf1Function, blockParameter);
        }

        public virtual Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        public virtual Task<BigInteger> BalanceOfQueryAsync(string owner, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var balanceOfFunction = new BalanceOfFunction();
                balanceOfFunction.Owner = owner;
            
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        public virtual Task<string> BaseURIQueryAsync(BaseURIFunction baseURIFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<BaseURIFunction, string>(baseURIFunction, blockParameter);
        }

        public virtual Task<string> BaseURIQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<BaseURIFunction, string>(null, blockParameter);
        }

        public virtual Task<string> CloneVaultIdRequestAsync(CloneVaultIdFunction cloneVaultIdFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(cloneVaultIdFunction);
        }

        public virtual Task<TransactionReceipt> CloneVaultIdRequestAndWaitForReceiptAsync(CloneVaultIdFunction cloneVaultIdFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(cloneVaultIdFunction, cancellationToken);
        }

        public virtual Task<string> CloneVaultIdRequestAsync(BigInteger destinationPoolId, BigInteger sourcePoolId)
        {
            EnsureInitialized();
            var cloneVaultIdFunction = new CloneVaultIdFunction();
                cloneVaultIdFunction.DestinationPoolId = destinationPoolId;
                cloneVaultIdFunction.SourcePoolId = sourcePoolId;
            
            return ContractHandler.SendRequestAsync(cloneVaultIdFunction);
        }

        public virtual Task<TransactionReceipt> CloneVaultIdRequestAndWaitForReceiptAsync(BigInteger destinationPoolId, BigInteger sourcePoolId, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var cloneVaultIdFunction = new CloneVaultIdFunction();
                cloneVaultIdFunction.DestinationPoolId = destinationPoolId;
                cloneVaultIdFunction.SourcePoolId = sourcePoolId;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(cloneVaultIdFunction, cancellationToken);
        }

        public virtual Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(firewallAdminFunction, blockParameter);
        }

        public virtual Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(null, blockParameter);
        }

        public virtual Task<string> GetApprovedQueryAsync(GetApprovedFunction getApprovedFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<GetApprovedFunction, string>(getApprovedFunction, blockParameter);
        }

        public virtual Task<string> GetApprovedQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var getApprovedFunction = new GetApprovedFunction();
                getApprovedFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<GetApprovedFunction, string>(getApprovedFunction, blockParameter);
        }

        public virtual Task<GetDataOutputDTO> GetDataQueryAsync(GetDataFunction getDataFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryDeserializingToObjectAsync<GetDataFunction, GetDataOutputDTO>(getDataFunction, blockParameter);
        }

        public virtual Task<GetDataOutputDTO> GetDataQueryAsync(BigInteger poolId, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var getDataFunction = new GetDataFunction();
                getDataFunction.PoolId = poolId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetDataFunction, GetDataOutputDTO>(getDataFunction, blockParameter);
        }

        public virtual Task<GetFullDataOutputDTO> GetFullDataQueryAsync(GetFullDataFunction getFullDataFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryDeserializingToObjectAsync<GetFullDataFunction, GetFullDataOutputDTO>(getFullDataFunction, blockParameter);
        }

        public virtual Task<GetFullDataOutputDTO> GetFullDataQueryAsync(BigInteger poolId, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var getFullDataFunction = new GetFullDataFunction();
                getFullDataFunction.PoolId = poolId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetFullDataFunction, GetFullDataOutputDTO>(getFullDataFunction, blockParameter);
        }

        public virtual Task<GetUserDataByTokensOutputDTO> GetUserDataByTokensQueryAsync(GetUserDataByTokensFunction getUserDataByTokensFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryDeserializingToObjectAsync<GetUserDataByTokensFunction, GetUserDataByTokensOutputDTO>(getUserDataByTokensFunction, blockParameter);
        }

        public virtual Task<GetUserDataByTokensOutputDTO> GetUserDataByTokensQueryAsync(string user, List<string> tokens, BigInteger from, BigInteger to, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var getUserDataByTokensFunction = new GetUserDataByTokensFunction();
                getUserDataByTokensFunction.User = user;
                getUserDataByTokensFunction.Tokens = tokens;
                getUserDataByTokensFunction.From = from;
                getUserDataByTokensFunction.To = to;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetUserDataByTokensFunction, GetUserDataByTokensOutputDTO>(getUserDataByTokensFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(BigInteger poolId, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var getWithdrawableAmountFunction = new GetWithdrawableAmountFunction();
                getWithdrawableAmountFunction.PoolId = poolId;
            
            return ContractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        public virtual Task<bool> IsApprovedForAllQueryAsync(IsApprovedForAllFunction isApprovedForAllFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<IsApprovedForAllFunction, bool>(isApprovedForAllFunction, blockParameter);
        }

        public virtual Task<bool> IsApprovedForAllQueryAsync(string owner, string @operator, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var isApprovedForAllFunction = new IsApprovedForAllFunction();
                isApprovedForAllFunction.Owner = owner;
                isApprovedForAllFunction.Operator = @operator;
            
            return ContractHandler.QueryAsync<IsApprovedForAllFunction, bool>(isApprovedForAllFunction, blockParameter);
        }

        public virtual Task<string> MintAndTransferRequestAsync(MintAndTransferFunction mintAndTransferFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(mintAndTransferFunction);
        }

        public virtual Task<TransactionReceipt> MintAndTransferRequestAndWaitForReceiptAsync(MintAndTransferFunction mintAndTransferFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(mintAndTransferFunction, cancellationToken);
        }

        public virtual Task<string> MintAndTransferRequestAsync(string owner, string token, BigInteger amount, string provider)
        {
            EnsureInitialized();
            var mintAndTransferFunction = new MintAndTransferFunction();
                mintAndTransferFunction.Owner = owner;
                mintAndTransferFunction.Token = token;
                mintAndTransferFunction.Amount = amount;
                mintAndTransferFunction.Provider = provider;
            
            return ContractHandler.SendRequestAsync(mintAndTransferFunction);
        }

        public virtual Task<TransactionReceipt> MintAndTransferRequestAndWaitForReceiptAsync(string owner, string token, BigInteger amount, string provider, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var mintAndTransferFunction = new MintAndTransferFunction();
                mintAndTransferFunction.Owner = owner;
                mintAndTransferFunction.Token = token;
                mintAndTransferFunction.Amount = amount;
                mintAndTransferFunction.Provider = provider;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(mintAndTransferFunction, cancellationToken);
        }

        public virtual Task<string> MintForProviderRequestAsync(MintForProviderFunction mintForProviderFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(mintForProviderFunction);
        }

        public virtual Task<TransactionReceipt> MintForProviderRequestAndWaitForReceiptAsync(MintForProviderFunction mintForProviderFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(mintForProviderFunction, cancellationToken);
        }

        public virtual Task<string> MintForProviderRequestAsync(string owner, string provider)
        {
            EnsureInitialized();
            var mintForProviderFunction = new MintForProviderFunction();
                mintForProviderFunction.Owner = owner;
                mintForProviderFunction.Provider = provider;
            
            return ContractHandler.SendRequestAsync(mintForProviderFunction);
        }

        public virtual Task<TransactionReceipt> MintForProviderRequestAndWaitForReceiptAsync(string owner, string provider, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var mintForProviderFunction = new MintForProviderFunction();
                mintForProviderFunction.Owner = owner;
                mintForProviderFunction.Provider = provider;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(mintForProviderFunction, cancellationToken);
        }

        public virtual Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
        }

        public virtual Task<string> NameQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
        }

        public virtual Task<string> OnERC721ReceivedRequestAsync(OnERC721ReceivedFunction onERC721ReceivedFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public virtual Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(OnERC721ReceivedFunction onERC721ReceivedFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }

        public virtual Task<string> OnERC721ReceivedRequestAsync(string returnValue1, string from, BigInteger poolId, byte[] data)
        {
            EnsureInitialized();
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.ReturnValue1 = returnValue1;
                onERC721ReceivedFunction.From = from;
                onERC721ReceivedFunction.PoolId = poolId;
                onERC721ReceivedFunction.Data = data;
            
            return ContractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public virtual Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(string returnValue1, string from, BigInteger poolId, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.ReturnValue1 = returnValue1;
                onERC721ReceivedFunction.From = from;
                onERC721ReceivedFunction.PoolId = poolId;
                onERC721ReceivedFunction.Data = data;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }

        public virtual Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        public virtual Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public virtual Task<string> OwnerOfQueryAsync(OwnerOfFunction ownerOfFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
        }

        public virtual Task<string> OwnerOfQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var ownerOfFunction = new OwnerOfFunction();
                ownerOfFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
        }

        public virtual Task<string> PoolIdToProviderQueryAsync(PoolIdToProviderFunction poolIdToProviderFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<PoolIdToProviderFunction, string>(poolIdToProviderFunction, blockParameter);
        }

        public virtual Task<string> PoolIdToProviderQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var poolIdToProviderFunction = new PoolIdToProviderFunction();
                poolIdToProviderFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PoolIdToProviderFunction, string>(poolIdToProviderFunction, blockParameter);
        }

        public virtual Task<BigInteger> PoolIdToVaultIdQueryAsync(PoolIdToVaultIdFunction poolIdToVaultIdFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<PoolIdToVaultIdFunction, BigInteger>(poolIdToVaultIdFunction, blockParameter);
        }

        public virtual Task<BigInteger> PoolIdToVaultIdQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var poolIdToVaultIdFunction = new PoolIdToVaultIdFunction();
                poolIdToVaultIdFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PoolIdToVaultIdFunction, BigInteger>(poolIdToVaultIdFunction, blockParameter);
        }

        public virtual Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(renounceOwnershipFunction);
        }

        public virtual Task<string> RenounceOwnershipRequestAsync()
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync<RenounceOwnershipFunction>();
        }

        public virtual Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceOwnershipFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync<RenounceOwnershipFunction>(null, cancellationToken);
        }

        public virtual Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(RoyaltyInfoFunction royaltyInfoFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryDeserializingToObjectAsync<RoyaltyInfoFunction, RoyaltyInfoOutputDTO>(royaltyInfoFunction, blockParameter);
        }

        public virtual Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(BigInteger tokenId, BigInteger salePrice, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var royaltyInfoFunction = new RoyaltyInfoFunction();
                royaltyInfoFunction.TokenId = tokenId;
                royaltyInfoFunction.SalePrice = salePrice;
            
            return ContractHandler.QueryDeserializingToObjectAsync<RoyaltyInfoFunction, RoyaltyInfoOutputDTO>(royaltyInfoFunction, blockParameter);
        }

        public virtual Task<string> SafeMintAndTransferRequestAsync(SafeMintAndTransferFunction safeMintAndTransferFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(safeMintAndTransferFunction);
        }

        public virtual Task<TransactionReceipt> SafeMintAndTransferRequestAndWaitForReceiptAsync(SafeMintAndTransferFunction safeMintAndTransferFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(safeMintAndTransferFunction, cancellationToken);
        }

        public virtual Task<string> SafeMintAndTransferRequestAsync(string owner, string token, string from, BigInteger amount, string provider, byte[] data)
        {
            EnsureInitialized();
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
            EnsureInitialized();
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
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(safeTransferFromFunction);
        }

        public virtual Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(SafeTransferFromFunction safeTransferFromFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
        }

        public virtual Task<string> SafeTransferFromRequestAsync(string from, string to, BigInteger tokenId)
        {
            EnsureInitialized();
            var safeTransferFromFunction = new SafeTransferFromFunction();
                safeTransferFromFunction.From = from;
                safeTransferFromFunction.To = to;
                safeTransferFromFunction.TokenId = tokenId;
            
            return ContractHandler.SendRequestAsync(safeTransferFromFunction);
        }

        public virtual Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var safeTransferFromFunction = new SafeTransferFromFunction();
                safeTransferFromFunction.From = from;
                safeTransferFromFunction.To = to;
                safeTransferFromFunction.TokenId = tokenId;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
        }

        public virtual Task<string> SafeTransferFromRequestAsync(SafeTransferFrom1Function safeTransferFrom1Function)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(safeTransferFrom1Function);
        }

        public virtual Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(SafeTransferFrom1Function safeTransferFrom1Function, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFrom1Function, cancellationToken);
        }

        public virtual Task<string> SafeTransferFromRequestAsync(string from, string to, BigInteger tokenId, byte[] data)
        {
            EnsureInitialized();
            var safeTransferFrom1Function = new SafeTransferFrom1Function();
                safeTransferFrom1Function.From = from;
                safeTransferFrom1Function.To = to;
                safeTransferFrom1Function.TokenId = tokenId;
                safeTransferFrom1Function.Data = data;
            
            return ContractHandler.SendRequestAsync(safeTransferFrom1Function);
        }

        public virtual Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var safeTransferFrom1Function = new SafeTransferFrom1Function();
                safeTransferFrom1Function.From = from;
                safeTransferFrom1Function.To = to;
                safeTransferFrom1Function.TokenId = tokenId;
                safeTransferFrom1Function.Data = data;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFrom1Function, cancellationToken);
        }

        public virtual Task<string> SetApprovalForAllRequestAsync(SetApprovalForAllFunction setApprovalForAllFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setApprovalForAllFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(SetApprovalForAllFunction setApprovalForAllFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovalForAllFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovalForAllRequestAsync(string @operator, bool approved)
        {
            EnsureInitialized();
            var setApprovalForAllFunction = new SetApprovalForAllFunction();
                setApprovalForAllFunction.Operator = @operator;
                setApprovalForAllFunction.Approved = approved;
            
            return ContractHandler.SendRequestAsync(setApprovalForAllFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(string @operator, bool approved, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setApprovalForAllFunction = new SetApprovalForAllFunction();
                setApprovalForAllFunction.Operator = @operator;
                setApprovalForAllFunction.Approved = approved;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovalForAllFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovedContractRequestAsync(SetApprovedContractFunction setApprovedContractFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setApprovedContractFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovedContractRequestAndWaitForReceiptAsync(SetApprovedContractFunction setApprovedContractFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovedContractFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovedContractRequestAsync(string contractAddress, bool status)
        {
            EnsureInitialized();
            var setApprovedContractFunction = new SetApprovedContractFunction();
                setApprovedContractFunction.ContractAddress = contractAddress;
                setApprovedContractFunction.Status = status;
            
            return ContractHandler.SendRequestAsync(setApprovedContractFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovedContractRequestAndWaitForReceiptAsync(string contractAddress, bool status, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setApprovedContractFunction = new SetApprovedContractFunction();
                setApprovedContractFunction.ContractAddress = contractAddress;
                setApprovedContractFunction.Status = status;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovedContractFunction, cancellationToken);
        }

        public virtual Task<string> SetBaseURIRequestAsync(SetBaseURIFunction setBaseURIFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setBaseURIFunction);
        }

        public virtual Task<TransactionReceipt> SetBaseURIRequestAndWaitForReceiptAsync(SetBaseURIFunction setBaseURIFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setBaseURIFunction, cancellationToken);
        }

        public virtual Task<string> SetBaseURIRequestAsync(string newBaseURI)
        {
            EnsureInitialized();
            var setBaseURIFunction = new SetBaseURIFunction();
                setBaseURIFunction.NewBaseURI = newBaseURI;
            
            return ContractHandler.SendRequestAsync(setBaseURIFunction);
        }

        public virtual Task<TransactionReceipt> SetBaseURIRequestAndWaitForReceiptAsync(string newBaseURI, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setBaseURIFunction = new SetBaseURIFunction();
                setBaseURIFunction.NewBaseURI = newBaseURI;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setBaseURIFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(SetFirewallFunction setFirewallFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(string firewall)
        {
            EnsureInitialized();
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(string firewall, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(SetFirewallAdminFunction setFirewallAdminFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(string firewallAdmin)
        {
            EnsureInitialized();
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(string firewallAdmin, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<bool> SupportsInterfaceQueryAsync(SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public virtual Task<bool> SupportsInterfaceQueryAsync(byte[] interfaceId, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var supportsInterfaceFunction = new SupportsInterfaceFunction();
                supportsInterfaceFunction.InterfaceId = interfaceId;
            
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public virtual Task<string> SymbolQueryAsync(SymbolFunction symbolFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<SymbolFunction, string>(symbolFunction, blockParameter);
        }

        public virtual Task<string> SymbolQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<SymbolFunction, string>(null, blockParameter);
        }

        public virtual Task<BigInteger> TokenByIndexQueryAsync(TokenByIndexFunction tokenByIndexFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<TokenByIndexFunction, BigInteger>(tokenByIndexFunction, blockParameter);
        }

        public virtual Task<BigInteger> TokenByIndexQueryAsync(BigInteger index, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var tokenByIndexFunction = new TokenByIndexFunction();
                tokenByIndexFunction.Index = index;
            
            return ContractHandler.QueryAsync<TokenByIndexFunction, BigInteger>(tokenByIndexFunction, blockParameter);
        }

        public virtual Task<string> TokenOfQueryAsync(TokenOfFunction tokenOfFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<TokenOfFunction, string>(tokenOfFunction, blockParameter);
        }

        public virtual Task<string> TokenOfQueryAsync(BigInteger poolId, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var tokenOfFunction = new TokenOfFunction();
                tokenOfFunction.PoolId = poolId;
            
            return ContractHandler.QueryAsync<TokenOfFunction, string>(tokenOfFunction, blockParameter);
        }

        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(TokenOfOwnerByIndexFunction tokenOfOwnerByIndexFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
        }

        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(string owner, BigInteger index, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var tokenOfOwnerByIndexFunction = new TokenOfOwnerByIndexFunction();
                tokenOfOwnerByIndexFunction.Owner = owner;
                tokenOfOwnerByIndexFunction.Index = index;
            
            return ContractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
        }

        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(TokenOfOwnerByIndex1Function tokenOfOwnerByIndex1Function, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<TokenOfOwnerByIndex1Function, BigInteger>(tokenOfOwnerByIndex1Function, blockParameter);
        }

        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(string owner, List<string> tokens, BigInteger index, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var tokenOfOwnerByIndex1Function = new TokenOfOwnerByIndex1Function();
                tokenOfOwnerByIndex1Function.Owner = owner;
                tokenOfOwnerByIndex1Function.Tokens = tokens;
                tokenOfOwnerByIndex1Function.Index = index;
            
            return ContractHandler.QueryAsync<TokenOfOwnerByIndex1Function, BigInteger>(tokenOfOwnerByIndex1Function, blockParameter);
        }

        public virtual Task<string> TokenURIQueryAsync(TokenURIFunction tokenURIFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<TokenURIFunction, string>(tokenURIFunction, blockParameter);
        }

        public virtual Task<string> TokenURIQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var tokenURIFunction = new TokenURIFunction();
                tokenURIFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<TokenURIFunction, string>(tokenURIFunction, blockParameter);
        }

        public virtual Task<BigInteger> TotalSupplyQueryAsync(TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(totalSupplyFunction, blockParameter);
        }

        public virtual Task<BigInteger> TotalSupplyQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> TransferFromRequestAsync(TransferFromFunction transferFromFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public virtual Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(TransferFromFunction transferFromFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }

        public virtual Task<string> TransferFromRequestAsync(string from, string to, BigInteger tokenId)
        {
            EnsureInitialized();
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.TokenId = tokenId;
            
            return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public virtual Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.TokenId = tokenId;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }

        public virtual Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public virtual Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public virtual Task<string> TransferOwnershipRequestAsync(string newOwner)
        {
            EnsureInitialized();
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
            return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public virtual Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public virtual Task<string> UpdateAllMetadataRequestAsync(UpdateAllMetadataFunction updateAllMetadataFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(updateAllMetadataFunction);
        }

        public virtual Task<string> UpdateAllMetadataRequestAsync()
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync<UpdateAllMetadataFunction>();
        }

        public virtual Task<TransactionReceipt> UpdateAllMetadataRequestAndWaitForReceiptAsync(UpdateAllMetadataFunction updateAllMetadataFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(updateAllMetadataFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> UpdateAllMetadataRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync<UpdateAllMetadataFunction>(null, cancellationToken);
        }

        public virtual Task<string> VaultManagerQueryAsync(VaultManagerFunction vaultManagerFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<VaultManagerFunction, string>(vaultManagerFunction, blockParameter);
        }

        public virtual Task<string> VaultManagerQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<VaultManagerFunction, string>(null, blockParameter);
        }
    }
}
