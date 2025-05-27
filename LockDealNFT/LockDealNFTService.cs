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
using NethereumGenerators.Interfaces;
using poolz.finance.csharp.contracts.LockDealNFT.ContractDefinition;

namespace poolz.finance.csharp.contracts.LockDealNFT
{
    public partial class LockDealNFTService<TContractType> : ILockDealNFTService<TContractType>
        where TContractType : Enum
    {
        public IChainProvider<TContractType> ChainProvider { get; }

        public LockDealNFTService(IChainProvider<TContractType> chainProvider)
        {
            ChainProvider = chainProvider;
        }

        private ContractHandler InitializeContractHandler(long chainId, TContractType contractType)
        {
            var contractAddress = ChainProvider.ContractAddress(chainId, contractType);
            var web3 = ChainProvider.Web3(chainId);
            var contractHandler = web3.Eth.GetContractHandler(contractAddress);
            return contractHandler;
        }

        public virtual Task<string> ApproveRequestAsync(long chainId, TContractType contractType, ApproveFunction approveFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(approveFunction);
        }

        public virtual Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public virtual Task<string> ApproveRequestAsync(long chainId, TContractType contractType, string to, BigInteger tokenId)
        {
            var approveFunction = new ApproveFunction();
                approveFunction.To = to;
                approveFunction.TokenId = tokenId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(approveFunction);
        }

        public virtual Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var approveFunction = new ApproveFunction();
                approveFunction.To = to;
                approveFunction.TokenId = tokenId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public virtual Task<string> ApprovePoolTransfersRequestAsync(long chainId, TContractType contractType, ApprovePoolTransfersFunction approvePoolTransfersFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(approvePoolTransfersFunction);
        }

        public virtual Task<TransactionReceipt> ApprovePoolTransfersRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, ApprovePoolTransfersFunction approvePoolTransfersFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(approvePoolTransfersFunction, cancellationToken);
        }

        public virtual Task<string> ApprovePoolTransfersRequestAsync(long chainId, TContractType contractType, bool status)
        {
            var approvePoolTransfersFunction = new ApprovePoolTransfersFunction();
                approvePoolTransfersFunction.Status = status;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(approvePoolTransfersFunction);
        }

        public virtual Task<TransactionReceipt> ApprovePoolTransfersRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, bool status, CancellationTokenSource cancellationToken = null)
        {
            var approvePoolTransfersFunction = new ApprovePoolTransfersFunction();
                approvePoolTransfersFunction.Status = status;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(approvePoolTransfersFunction, cancellationToken);
        }

        public virtual Task<bool> ApprovedContractsQueryAsync(long chainId, TContractType contractType, ApprovedContractsFunction approvedContractsFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<ApprovedContractsFunction, bool>(approvedContractsFunction, blockParameter);
        }

        public virtual Task<bool> ApprovedContractsQueryAsync(long chainId, TContractType contractType, string returnValue1, BlockParameter blockParameter = null)
        {
            var approvedContractsFunction = new ApprovedContractsFunction();
                approvedContractsFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<ApprovedContractsFunction, bool>(approvedContractsFunction, blockParameter);
        }

        public virtual Task<bool> ApprovedPoolUserTransfersQueryAsync(long chainId, TContractType contractType, ApprovedPoolUserTransfersFunction approvedPoolUserTransfersFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<ApprovedPoolUserTransfersFunction, bool>(approvedPoolUserTransfersFunction, blockParameter);
        }

        public virtual Task<bool> ApprovedPoolUserTransfersQueryAsync(long chainId, TContractType contractType, string returnValue1, BlockParameter blockParameter = null)
        {
            var approvedPoolUserTransfersFunction = new ApprovedPoolUserTransfersFunction();
                approvedPoolUserTransfersFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<ApprovedPoolUserTransfersFunction, bool>(approvedPoolUserTransfersFunction, blockParameter);
        }

        public virtual Task<BigInteger> BalanceOfQueryAsync(long chainId, TContractType contractType, BalanceOf1Function balanceOf1Function, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<BalanceOf1Function, BigInteger>(balanceOf1Function, blockParameter);
        }

        public virtual Task<BigInteger> BalanceOfQueryAsync(long chainId, TContractType contractType, string owner, List<string> tokens, BlockParameter blockParameter = null)
        {
            var balanceOf1Function = new BalanceOf1Function();
                balanceOf1Function.Owner = owner;
                balanceOf1Function.Tokens = tokens;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<BalanceOf1Function, BigInteger>(balanceOf1Function, blockParameter);
        }

        public virtual Task<BigInteger> BalanceOfQueryAsync(long chainId, TContractType contractType, BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        public virtual Task<BigInteger> BalanceOfQueryAsync(long chainId, TContractType contractType, string owner, BlockParameter blockParameter = null)
        {
            var balanceOfFunction = new BalanceOfFunction();
                balanceOfFunction.Owner = owner;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        public virtual Task<string> BaseURIQueryAsync(long chainId, TContractType contractType, BaseURIFunction baseURIFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<BaseURIFunction, string>(baseURIFunction, blockParameter);
        }

        public virtual Task<string> BaseURIQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<BaseURIFunction, string>(null, blockParameter);
        }

        public virtual Task<string> CloneVaultIdRequestAsync(long chainId, TContractType contractType, CloneVaultIdFunction cloneVaultIdFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(cloneVaultIdFunction);
        }

        public virtual Task<TransactionReceipt> CloneVaultIdRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CloneVaultIdFunction cloneVaultIdFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(cloneVaultIdFunction, cancellationToken);
        }

        public virtual Task<string> CloneVaultIdRequestAsync(long chainId, TContractType contractType, BigInteger destinationPoolId, BigInteger sourcePoolId)
        {
            var cloneVaultIdFunction = new CloneVaultIdFunction();
                cloneVaultIdFunction.DestinationPoolId = destinationPoolId;
                cloneVaultIdFunction.SourcePoolId = sourcePoolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(cloneVaultIdFunction);
        }

        public virtual Task<TransactionReceipt> CloneVaultIdRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger destinationPoolId, BigInteger sourcePoolId, CancellationTokenSource cancellationToken = null)
        {
            var cloneVaultIdFunction = new CloneVaultIdFunction();
                cloneVaultIdFunction.DestinationPoolId = destinationPoolId;
                cloneVaultIdFunction.SourcePoolId = sourcePoolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(cloneVaultIdFunction, cancellationToken);
        }

        public virtual Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<FirewallAdminFunction, string>(firewallAdminFunction, blockParameter);
        }

        public virtual Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<FirewallAdminFunction, string>(null, blockParameter);
        }

        public virtual Task<string> GetApprovedQueryAsync(long chainId, TContractType contractType, GetApprovedFunction getApprovedFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetApprovedFunction, string>(getApprovedFunction, blockParameter);
        }

        public virtual Task<string> GetApprovedQueryAsync(long chainId, TContractType contractType, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getApprovedFunction = new GetApprovedFunction();
                getApprovedFunction.TokenId = tokenId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetApprovedFunction, string>(getApprovedFunction, blockParameter);
        }

        public virtual Task<GetDataOutputDTO> GetDataQueryAsync(long chainId, TContractType contractType, GetDataFunction getDataFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetDataFunction, GetDataOutputDTO>(getDataFunction, blockParameter);
        }

        public virtual Task<GetDataOutputDTO> GetDataQueryAsync(long chainId, TContractType contractType, BigInteger poolId, BlockParameter blockParameter = null)
        {
            var getDataFunction = new GetDataFunction();
                getDataFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetDataFunction, GetDataOutputDTO>(getDataFunction, blockParameter);
        }

        public virtual Task<GetFullDataOutputDTO> GetFullDataQueryAsync(long chainId, TContractType contractType, GetFullDataFunction getFullDataFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetFullDataFunction, GetFullDataOutputDTO>(getFullDataFunction, blockParameter);
        }

        public virtual Task<GetFullDataOutputDTO> GetFullDataQueryAsync(long chainId, TContractType contractType, BigInteger poolId, BlockParameter blockParameter = null)
        {
            var getFullDataFunction = new GetFullDataFunction();
                getFullDataFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetFullDataFunction, GetFullDataOutputDTO>(getFullDataFunction, blockParameter);
        }

        public virtual Task<GetUserDataByTokensOutputDTO> GetUserDataByTokensQueryAsync(long chainId, TContractType contractType, GetUserDataByTokensFunction getUserDataByTokensFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetUserDataByTokensFunction, GetUserDataByTokensOutputDTO>(getUserDataByTokensFunction, blockParameter);
        }

        public virtual Task<GetUserDataByTokensOutputDTO> GetUserDataByTokensQueryAsync(long chainId, TContractType contractType, string user, List<string> tokens, BigInteger from, BigInteger to, BlockParameter blockParameter = null)
        {
            var getUserDataByTokensFunction = new GetUserDataByTokensFunction();
                getUserDataByTokensFunction.User = user;
                getUserDataByTokensFunction.Tokens = tokens;
                getUserDataByTokensFunction.From = from;
                getUserDataByTokensFunction.To = to;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetUserDataByTokensFunction, GetUserDataByTokensOutputDTO>(getUserDataByTokensFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, TContractType contractType, GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, TContractType contractType, BigInteger poolId, BlockParameter blockParameter = null)
        {
            var getWithdrawableAmountFunction = new GetWithdrawableAmountFunction();
                getWithdrawableAmountFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        public virtual Task<bool> IsApprovedForAllQueryAsync(long chainId, TContractType contractType, IsApprovedForAllFunction isApprovedForAllFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsApprovedForAllFunction, bool>(isApprovedForAllFunction, blockParameter);
        }

        public virtual Task<bool> IsApprovedForAllQueryAsync(long chainId, TContractType contractType, string owner, string @operator, BlockParameter blockParameter = null)
        {
            var isApprovedForAllFunction = new IsApprovedForAllFunction();
                isApprovedForAllFunction.Owner = owner;
                isApprovedForAllFunction.Operator = @operator;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsApprovedForAllFunction, bool>(isApprovedForAllFunction, blockParameter);
        }

        public virtual Task<string> MintAndTransferRequestAsync(long chainId, TContractType contractType, MintAndTransferFunction mintAndTransferFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(mintAndTransferFunction);
        }

        public virtual Task<TransactionReceipt> MintAndTransferRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, MintAndTransferFunction mintAndTransferFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(mintAndTransferFunction, cancellationToken);
        }

        public virtual Task<string> MintAndTransferRequestAsync(long chainId, TContractType contractType, string owner, string token, BigInteger amount, string provider)
        {
            var mintAndTransferFunction = new MintAndTransferFunction();
                mintAndTransferFunction.Owner = owner;
                mintAndTransferFunction.Token = token;
                mintAndTransferFunction.Amount = amount;
                mintAndTransferFunction.Provider = provider;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(mintAndTransferFunction);
        }

        public virtual Task<TransactionReceipt> MintAndTransferRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string owner, string token, BigInteger amount, string provider, CancellationTokenSource cancellationToken = null)
        {
            var mintAndTransferFunction = new MintAndTransferFunction();
                mintAndTransferFunction.Owner = owner;
                mintAndTransferFunction.Token = token;
                mintAndTransferFunction.Amount = amount;
                mintAndTransferFunction.Provider = provider;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(mintAndTransferFunction, cancellationToken);
        }

        public virtual Task<string> MintForProviderRequestAsync(long chainId, TContractType contractType, MintForProviderFunction mintForProviderFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(mintForProviderFunction);
        }

        public virtual Task<TransactionReceipt> MintForProviderRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, MintForProviderFunction mintForProviderFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(mintForProviderFunction, cancellationToken);
        }

        public virtual Task<string> MintForProviderRequestAsync(long chainId, TContractType contractType, string owner, string provider)
        {
            var mintForProviderFunction = new MintForProviderFunction();
                mintForProviderFunction.Owner = owner;
                mintForProviderFunction.Provider = provider;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(mintForProviderFunction);
        }

        public virtual Task<TransactionReceipt> MintForProviderRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string owner, string provider, CancellationTokenSource cancellationToken = null)
        {
            var mintForProviderFunction = new MintForProviderFunction();
                mintForProviderFunction.Owner = owner;
                mintForProviderFunction.Provider = provider;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(mintForProviderFunction, cancellationToken);
        }

        public virtual Task<string> NameQueryAsync(long chainId, TContractType contractType, NameFunction nameFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
        }

        public virtual Task<string> NameQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
        }

        public virtual Task<string> OnERC721ReceivedRequestAsync(long chainId, TContractType contractType, OnERC721ReceivedFunction onERC721ReceivedFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public virtual Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, OnERC721ReceivedFunction onERC721ReceivedFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }

        public virtual Task<string> OnERC721ReceivedRequestAsync(long chainId, TContractType contractType, string returnValue1, string from, BigInteger poolId, byte[] data)
        {
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.ReturnValue1 = returnValue1;
                onERC721ReceivedFunction.From = from;
                onERC721ReceivedFunction.PoolId = poolId;
                onERC721ReceivedFunction.Data = data;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public virtual Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string returnValue1, string from, BigInteger poolId, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.ReturnValue1 = returnValue1;
                onERC721ReceivedFunction.From = from;
                onERC721ReceivedFunction.PoolId = poolId;
                onERC721ReceivedFunction.Data = data;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }

        public virtual Task<string> OwnerQueryAsync(long chainId, TContractType contractType, OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        public virtual Task<string> OwnerQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public virtual Task<string> OwnerOfQueryAsync(long chainId, TContractType contractType, OwnerOfFunction ownerOfFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
        }

        public virtual Task<string> OwnerOfQueryAsync(long chainId, TContractType contractType, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var ownerOfFunction = new OwnerOfFunction();
                ownerOfFunction.TokenId = tokenId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
        }

        public virtual Task<string> PoolIdToProviderQueryAsync(long chainId, TContractType contractType, PoolIdToProviderFunction poolIdToProviderFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PoolIdToProviderFunction, string>(poolIdToProviderFunction, blockParameter);
        }

        public virtual Task<string> PoolIdToProviderQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var poolIdToProviderFunction = new PoolIdToProviderFunction();
                poolIdToProviderFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PoolIdToProviderFunction, string>(poolIdToProviderFunction, blockParameter);
        }

        public virtual Task<BigInteger> PoolIdToVaultIdQueryAsync(long chainId, TContractType contractType, PoolIdToVaultIdFunction poolIdToVaultIdFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PoolIdToVaultIdFunction, BigInteger>(poolIdToVaultIdFunction, blockParameter);
        }

        public virtual Task<BigInteger> PoolIdToVaultIdQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var poolIdToVaultIdFunction = new PoolIdToVaultIdFunction();
                poolIdToVaultIdFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PoolIdToVaultIdFunction, BigInteger>(poolIdToVaultIdFunction, blockParameter);
        }

        public virtual Task<string> RenounceOwnershipRequestAsync(long chainId, TContractType contractType, RenounceOwnershipFunction renounceOwnershipFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(renounceOwnershipFunction);
        }

        public virtual Task<string> RenounceOwnershipRequestAsync(long chainId, TContractType contractType)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync<RenounceOwnershipFunction>();
        }

        public virtual Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(renounceOwnershipFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync<RenounceOwnershipFunction>(null, cancellationToken);
        }

        public virtual Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(long chainId, TContractType contractType, RoyaltyInfoFunction royaltyInfoFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<RoyaltyInfoFunction, RoyaltyInfoOutputDTO>(royaltyInfoFunction, blockParameter);
        }

        public virtual Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(long chainId, TContractType contractType, BigInteger tokenId, BigInteger salePrice, BlockParameter blockParameter = null)
        {
            var royaltyInfoFunction = new RoyaltyInfoFunction();
                royaltyInfoFunction.TokenId = tokenId;
                royaltyInfoFunction.SalePrice = salePrice;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<RoyaltyInfoFunction, RoyaltyInfoOutputDTO>(royaltyInfoFunction, blockParameter);
        }

        public virtual Task<string> SafeMintAndTransferRequestAsync(long chainId, TContractType contractType, SafeMintAndTransferFunction safeMintAndTransferFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(safeMintAndTransferFunction);
        }

        public virtual Task<TransactionReceipt> SafeMintAndTransferRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SafeMintAndTransferFunction safeMintAndTransferFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(safeMintAndTransferFunction, cancellationToken);
        }

        public virtual Task<string> SafeMintAndTransferRequestAsync(long chainId, TContractType contractType, string owner, string token, string from, BigInteger amount, string provider, byte[] data)
        {
            var safeMintAndTransferFunction = new SafeMintAndTransferFunction();
                safeMintAndTransferFunction.Owner = owner;
                safeMintAndTransferFunction.Token = token;
                safeMintAndTransferFunction.From = from;
                safeMintAndTransferFunction.Amount = amount;
                safeMintAndTransferFunction.Provider = provider;
                safeMintAndTransferFunction.Data = data;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(safeMintAndTransferFunction);
        }

        public virtual Task<TransactionReceipt> SafeMintAndTransferRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string owner, string token, string from, BigInteger amount, string provider, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            var safeMintAndTransferFunction = new SafeMintAndTransferFunction();
                safeMintAndTransferFunction.Owner = owner;
                safeMintAndTransferFunction.Token = token;
                safeMintAndTransferFunction.From = from;
                safeMintAndTransferFunction.Amount = amount;
                safeMintAndTransferFunction.Provider = provider;
                safeMintAndTransferFunction.Data = data;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(safeMintAndTransferFunction, cancellationToken);
        }

        public virtual Task<string> SafeTransferFromRequestAsync(long chainId, TContractType contractType, SafeTransferFromFunction safeTransferFromFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(safeTransferFromFunction);
        }

        public virtual Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SafeTransferFromFunction safeTransferFromFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
        }

        public virtual Task<string> SafeTransferFromRequestAsync(long chainId, TContractType contractType, string from, string to, BigInteger tokenId)
        {
            var safeTransferFromFunction = new SafeTransferFromFunction();
                safeTransferFromFunction.From = from;
                safeTransferFromFunction.To = to;
                safeTransferFromFunction.TokenId = tokenId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(safeTransferFromFunction);
        }

        public virtual Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var safeTransferFromFunction = new SafeTransferFromFunction();
                safeTransferFromFunction.From = from;
                safeTransferFromFunction.To = to;
                safeTransferFromFunction.TokenId = tokenId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
        }

        public virtual Task<string> SafeTransferFromRequestAsync(long chainId, TContractType contractType, SafeTransferFrom1Function safeTransferFrom1Function)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(safeTransferFrom1Function);
        }

        public virtual Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SafeTransferFrom1Function safeTransferFrom1Function, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFrom1Function, cancellationToken);
        }

        public virtual Task<string> SafeTransferFromRequestAsync(long chainId, TContractType contractType, string from, string to, BigInteger tokenId, byte[] data)
        {
            var safeTransferFrom1Function = new SafeTransferFrom1Function();
                safeTransferFrom1Function.From = from;
                safeTransferFrom1Function.To = to;
                safeTransferFrom1Function.TokenId = tokenId;
                safeTransferFrom1Function.Data = data;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(safeTransferFrom1Function);
        }

        public virtual Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string from, string to, BigInteger tokenId, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            var safeTransferFrom1Function = new SafeTransferFrom1Function();
                safeTransferFrom1Function.From = from;
                safeTransferFrom1Function.To = to;
                safeTransferFrom1Function.TokenId = tokenId;
                safeTransferFrom1Function.Data = data;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFrom1Function, cancellationToken);
        }

        public virtual Task<string> SetApprovalForAllRequestAsync(long chainId, TContractType contractType, SetApprovalForAllFunction setApprovalForAllFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setApprovalForAllFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetApprovalForAllFunction setApprovalForAllFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setApprovalForAllFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovalForAllRequestAsync(long chainId, TContractType contractType, string @operator, bool approved)
        {
            var setApprovalForAllFunction = new SetApprovalForAllFunction();
                setApprovalForAllFunction.Operator = @operator;
                setApprovalForAllFunction.Approved = approved;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setApprovalForAllFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string @operator, bool approved, CancellationTokenSource cancellationToken = null)
        {
            var setApprovalForAllFunction = new SetApprovalForAllFunction();
                setApprovalForAllFunction.Operator = @operator;
                setApprovalForAllFunction.Approved = approved;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setApprovalForAllFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovedContractRequestAsync(long chainId, TContractType contractType, SetApprovedContractFunction setApprovedContractFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setApprovedContractFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovedContractRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetApprovedContractFunction setApprovedContractFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setApprovedContractFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovedContractRequestAsync(long chainId, TContractType contractType, string contractAddress, bool status)
        {
            var setApprovedContractFunction = new SetApprovedContractFunction();
                setApprovedContractFunction.ContractAddress = contractAddress;
                setApprovedContractFunction.Status = status;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setApprovedContractFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovedContractRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string contractAddress, bool status, CancellationTokenSource cancellationToken = null)
        {
            var setApprovedContractFunction = new SetApprovedContractFunction();
                setApprovedContractFunction.ContractAddress = contractAddress;
                setApprovedContractFunction.Status = status;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setApprovedContractFunction, cancellationToken);
        }

        public virtual Task<string> SetBaseURIRequestAsync(long chainId, TContractType contractType, SetBaseURIFunction setBaseURIFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setBaseURIFunction);
        }

        public virtual Task<TransactionReceipt> SetBaseURIRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetBaseURIFunction setBaseURIFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setBaseURIFunction, cancellationToken);
        }

        public virtual Task<string> SetBaseURIRequestAsync(long chainId, TContractType contractType, string newBaseURI)
        {
            var setBaseURIFunction = new SetBaseURIFunction();
                setBaseURIFunction.NewBaseURI = newBaseURI;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setBaseURIFunction);
        }

        public virtual Task<TransactionReceipt> SetBaseURIRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string newBaseURI, CancellationTokenSource cancellationToken = null)
        {
            var setBaseURIFunction = new SetBaseURIFunction();
                setBaseURIFunction.NewBaseURI = newBaseURI;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setBaseURIFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, string firewall)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewall, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, string firewallAdmin)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<bool> SupportsInterfaceQueryAsync(long chainId, TContractType contractType, SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public virtual Task<bool> SupportsInterfaceQueryAsync(long chainId, TContractType contractType, byte[] interfaceId, BlockParameter blockParameter = null)
        {
            var supportsInterfaceFunction = new SupportsInterfaceFunction();
                supportsInterfaceFunction.InterfaceId = interfaceId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public virtual Task<string> SymbolQueryAsync(long chainId, TContractType contractType, SymbolFunction symbolFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<SymbolFunction, string>(symbolFunction, blockParameter);
        }

        public virtual Task<string> SymbolQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<SymbolFunction, string>(null, blockParameter);
        }

        public virtual Task<BigInteger> TokenByIndexQueryAsync(long chainId, TContractType contractType, TokenByIndexFunction tokenByIndexFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenByIndexFunction, BigInteger>(tokenByIndexFunction, blockParameter);
        }

        public virtual Task<BigInteger> TokenByIndexQueryAsync(long chainId, TContractType contractType, BigInteger index, BlockParameter blockParameter = null)
        {
            var tokenByIndexFunction = new TokenByIndexFunction();
                tokenByIndexFunction.Index = index;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenByIndexFunction, BigInteger>(tokenByIndexFunction, blockParameter);
        }

        public virtual Task<string> TokenOfQueryAsync(long chainId, TContractType contractType, TokenOfFunction tokenOfFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenOfFunction, string>(tokenOfFunction, blockParameter);
        }

        public virtual Task<string> TokenOfQueryAsync(long chainId, TContractType contractType, BigInteger poolId, BlockParameter blockParameter = null)
        {
            var tokenOfFunction = new TokenOfFunction();
                tokenOfFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenOfFunction, string>(tokenOfFunction, blockParameter);
        }

        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, TContractType contractType, TokenOfOwnerByIndexFunction tokenOfOwnerByIndexFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
        }

        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, TContractType contractType, string owner, BigInteger index, BlockParameter blockParameter = null)
        {
            var tokenOfOwnerByIndexFunction = new TokenOfOwnerByIndexFunction();
                tokenOfOwnerByIndexFunction.Owner = owner;
                tokenOfOwnerByIndexFunction.Index = index;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
        }

        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, TContractType contractType, TokenOfOwnerByIndex1Function tokenOfOwnerByIndex1Function, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenOfOwnerByIndex1Function, BigInteger>(tokenOfOwnerByIndex1Function, blockParameter);
        }

        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, TContractType contractType, string owner, List<string> tokens, BigInteger index, BlockParameter blockParameter = null)
        {
            var tokenOfOwnerByIndex1Function = new TokenOfOwnerByIndex1Function();
                tokenOfOwnerByIndex1Function.Owner = owner;
                tokenOfOwnerByIndex1Function.Tokens = tokens;
                tokenOfOwnerByIndex1Function.Index = index;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenOfOwnerByIndex1Function, BigInteger>(tokenOfOwnerByIndex1Function, blockParameter);
        }

        public virtual Task<string> TokenURIQueryAsync(long chainId, TContractType contractType, TokenURIFunction tokenURIFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenURIFunction, string>(tokenURIFunction, blockParameter);
        }

        public virtual Task<string> TokenURIQueryAsync(long chainId, TContractType contractType, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var tokenURIFunction = new TokenURIFunction();
                tokenURIFunction.TokenId = tokenId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenURIFunction, string>(tokenURIFunction, blockParameter);
        }

        public virtual Task<BigInteger> TotalSupplyQueryAsync(long chainId, TContractType contractType, TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(totalSupplyFunction, blockParameter);
        }

        public virtual Task<BigInteger> TotalSupplyQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> TransferFromRequestAsync(long chainId, TContractType contractType, TransferFromFunction transferFromFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(transferFromFunction);
        }

        public virtual Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, TransferFromFunction transferFromFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }

        public virtual Task<string> TransferFromRequestAsync(long chainId, TContractType contractType, string from, string to, BigInteger tokenId)
        {
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.TokenId = tokenId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(transferFromFunction);
        }

        public virtual Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.TokenId = tokenId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }

        public virtual Task<string> TransferOwnershipRequestAsync(long chainId, TContractType contractType, TransferOwnershipFunction transferOwnershipFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public virtual Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public virtual Task<string> TransferOwnershipRequestAsync(long chainId, TContractType contractType, string newOwner)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public virtual Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string newOwner, CancellationTokenSource cancellationToken = null)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public virtual Task<string> UpdateAllMetadataRequestAsync(long chainId, TContractType contractType, UpdateAllMetadataFunction updateAllMetadataFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(updateAllMetadataFunction);
        }

        public virtual Task<string> UpdateAllMetadataRequestAsync(long chainId, TContractType contractType)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync<UpdateAllMetadataFunction>();
        }

        public virtual Task<TransactionReceipt> UpdateAllMetadataRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, UpdateAllMetadataFunction updateAllMetadataFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(updateAllMetadataFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> UpdateAllMetadataRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync<UpdateAllMetadataFunction>(null, cancellationToken);
        }

        public virtual Task<string> VaultManagerQueryAsync(long chainId, TContractType contractType, VaultManagerFunction vaultManagerFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<VaultManagerFunction, string>(vaultManagerFunction, blockParameter);
        }

        public virtual Task<string> VaultManagerQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<VaultManagerFunction, string>(null, blockParameter);
        }
    }
}
