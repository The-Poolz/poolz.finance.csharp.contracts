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
using poolz.finance.csharp.contracts.PoolzBack.ContractDefinition;

namespace poolz.finance.csharp.contracts.PoolzBack
{
    public partial class PoolzBackService : IPoolzBackService
    {
        public IChainProvider ChainProvider { get; }

        public PoolzBackService(IChainProvider chainProvider)
        {
            ChainProvider = chainProvider;
        }

        private ContractHandler InitializeContractHandler(long chainId, Enum contractType)
        {
            var contractAddress = ChainProvider.ContractAddress(chainId, contractType);
            var web3 = ChainProvider.Web3(chainId);
            var contractHandler = web3.Eth.GetContractHandler(contractAddress);
            return contractHandler;
        }

        public virtual Task<string> BenefitAddressQueryAsync(long chainId, Enum contractType, BenefitAddressFunction benefitAddressFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<BenefitAddressFunction, string>(benefitAddressFunction, blockParameter);
        }

        public virtual Task<string> BenefitAddressQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<BenefitAddressFunction, string>(null, blockParameter);
        }

        public virtual Task<string> CreatePoolRequestAsync(long chainId, Enum contractType, CreatePoolFunction createPoolFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createPoolFunction);
        }

        public virtual Task<TransactionReceipt> CreatePoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CreatePoolFunction createPoolFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createPoolFunction, cancellationToken);
        }

        public virtual Task<string> CreatePoolRequestAsync(long chainId, Enum contractType, string token, BigInteger finishTime, BigInteger rate, BigInteger pOZRate, BigInteger startAmount, ulong lockedUntil, string mainCoin, bool is21Decimal, BigInteger now, BigInteger whiteListId)
        {
            var createPoolFunction = new CreatePoolFunction();
                createPoolFunction.Token = token;
                createPoolFunction.FinishTime = finishTime;
                createPoolFunction.Rate = rate;
                createPoolFunction.POZRate = pOZRate;
                createPoolFunction.StartAmount = startAmount;
                createPoolFunction.LockedUntil = lockedUntil;
                createPoolFunction.MainCoin = mainCoin;
                createPoolFunction.Is21Decimal = is21Decimal;
                createPoolFunction.Now = now;
                createPoolFunction.WhiteListId = whiteListId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createPoolFunction);
        }

        public virtual Task<TransactionReceipt> CreatePoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string token, BigInteger finishTime, BigInteger rate, BigInteger pOZRate, BigInteger startAmount, ulong lockedUntil, string mainCoin, bool is21Decimal, BigInteger now, BigInteger whiteListId, CancellationTokenSource cancellationToken = null)
        {
            var createPoolFunction = new CreatePoolFunction();
                createPoolFunction.Token = token;
                createPoolFunction.FinishTime = finishTime;
                createPoolFunction.Rate = rate;
                createPoolFunction.POZRate = pOZRate;
                createPoolFunction.StartAmount = startAmount;
                createPoolFunction.LockedUntil = lockedUntil;
                createPoolFunction.MainCoin = mainCoin;
                createPoolFunction.Is21Decimal = is21Decimal;
                createPoolFunction.Now = now;
                createPoolFunction.WhiteListId = whiteListId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createPoolFunction, cancellationToken);
        }

        public virtual Task<BigInteger> FeeQueryAsync(long chainId, Enum contractType, FeeFunction feeFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<FeeFunction, BigInteger>(feeFunction, blockParameter);
        }

        public virtual Task<BigInteger> FeeQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<FeeFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<GetInvestmentDataOutputDTO> GetInvestmentDataQueryAsync(long chainId, Enum contractType, GetInvestmentDataFunction getInvestmentDataFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetInvestmentDataFunction, GetInvestmentDataOutputDTO>(getInvestmentDataFunction, blockParameter);
        }

        public virtual Task<GetInvestmentDataOutputDTO> GetInvestmentDataQueryAsync(long chainId, Enum contractType, BigInteger id, BlockParameter blockParameter = null)
        {
            var getInvestmentDataFunction = new GetInvestmentDataFunction();
                getInvestmentDataFunction.Id = id;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetInvestmentDataFunction, GetInvestmentDataOutputDTO>(getInvestmentDataFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetMyInvestmentIdsQueryAsync(long chainId, Enum contractType, GetMyInvestmentIdsFunction getMyInvestmentIdsFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetMyInvestmentIdsFunction, List<BigInteger>>(getMyInvestmentIdsFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetMyInvestmentIdsQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetMyInvestmentIdsFunction, List<BigInteger>>(null, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetMyPoolsIdQueryAsync(long chainId, Enum contractType, GetMyPoolsIdFunction getMyPoolsIdFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetMyPoolsIdFunction, List<BigInteger>>(getMyPoolsIdFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetMyPoolsIdQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetMyPoolsIdFunction, List<BigInteger>>(null, blockParameter);
        }

        public virtual Task<GetPoolBaseDataOutputDTO> GetPoolBaseDataQueryAsync(long chainId, Enum contractType, GetPoolBaseDataFunction getPoolBaseDataFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetPoolBaseDataFunction, GetPoolBaseDataOutputDTO>(getPoolBaseDataFunction, blockParameter);
        }

        public virtual Task<GetPoolBaseDataOutputDTO> GetPoolBaseDataQueryAsync(long chainId, Enum contractType, BigInteger id, BlockParameter blockParameter = null)
        {
            var getPoolBaseDataFunction = new GetPoolBaseDataFunction();
                getPoolBaseDataFunction.Id = id;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetPoolBaseDataFunction, GetPoolBaseDataOutputDTO>(getPoolBaseDataFunction, blockParameter);
        }

        public virtual Task<GetPoolExtraDataOutputDTO> GetPoolExtraDataQueryAsync(long chainId, Enum contractType, GetPoolExtraDataFunction getPoolExtraDataFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetPoolExtraDataFunction, GetPoolExtraDataOutputDTO>(getPoolExtraDataFunction, blockParameter);
        }

        public virtual Task<GetPoolExtraDataOutputDTO> GetPoolExtraDataQueryAsync(long chainId, Enum contractType, BigInteger id, BlockParameter blockParameter = null)
        {
            var getPoolExtraDataFunction = new GetPoolExtraDataFunction();
                getPoolExtraDataFunction.Id = id;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetPoolExtraDataFunction, GetPoolExtraDataOutputDTO>(getPoolExtraDataFunction, blockParameter);
        }

        public virtual Task<GetPoolMoreDataOutputDTO> GetPoolMoreDataQueryAsync(long chainId, Enum contractType, GetPoolMoreDataFunction getPoolMoreDataFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetPoolMoreDataFunction, GetPoolMoreDataOutputDTO>(getPoolMoreDataFunction, blockParameter);
        }

        public virtual Task<GetPoolMoreDataOutputDTO> GetPoolMoreDataQueryAsync(long chainId, Enum contractType, BigInteger id, BlockParameter blockParameter = null)
        {
            var getPoolMoreDataFunction = new GetPoolMoreDataFunction();
                getPoolMoreDataFunction.Id = id;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetPoolMoreDataFunction, GetPoolMoreDataOutputDTO>(getPoolMoreDataFunction, blockParameter);
        }

        public virtual Task<byte> GetPoolStatusQueryAsync(long chainId, Enum contractType, GetPoolStatusFunction getPoolStatusFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetPoolStatusFunction, byte>(getPoolStatusFunction, blockParameter);
        }

        public virtual Task<byte> GetPoolStatusQueryAsync(long chainId, Enum contractType, BigInteger id, BlockParameter blockParameter = null)
        {
            var getPoolStatusFunction = new GetPoolStatusFunction();
                getPoolStatusFunction.Id = id;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetPoolStatusFunction, byte>(getPoolStatusFunction, blockParameter);
        }

        public virtual Task<string> GovernerContractQueryAsync(long chainId, Enum contractType, GovernerContractFunction governerContractFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GovernerContractFunction, string>(governerContractFunction, blockParameter);
        }

        public virtual Task<string> GovernerContractQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GovernerContractFunction, string>(null, blockParameter);
        }

        public virtual Task<string> InvestERC20RequestAsync(long chainId, Enum contractType, InvestERC20Function investERC20Function)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(investERC20Function);
        }

        public virtual Task<TransactionReceipt> InvestERC20RequestAndWaitForReceiptAsync(long chainId, Enum contractType, InvestERC20Function investERC20Function, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(investERC20Function, cancellationToken);
        }

        public virtual Task<string> InvestERC20RequestAsync(long chainId, Enum contractType, BigInteger poolId, BigInteger amount)
        {
            var investERC20Function = new InvestERC20Function();
                investERC20Function.PoolId = poolId;
                investERC20Function.Amount = amount;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(investERC20Function);
        }

        public virtual Task<TransactionReceipt> InvestERC20RequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger poolId, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var investERC20Function = new InvestERC20Function();
                investERC20Function.PoolId = poolId;
                investERC20Function.Amount = amount;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(investERC20Function, cancellationToken);
        }

        public virtual Task<string> InvestETHRequestAsync(long chainId, Enum contractType, InvestETHFunction investETHFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(investETHFunction);
        }

        public virtual Task<TransactionReceipt> InvestETHRequestAndWaitForReceiptAsync(long chainId, Enum contractType, InvestETHFunction investETHFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(investETHFunction, cancellationToken);
        }

        public virtual Task<string> InvestETHRequestAsync(long chainId, Enum contractType, BigInteger poolId)
        {
            var investETHFunction = new InvestETHFunction();
                investETHFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(investETHFunction);
        }

        public virtual Task<TransactionReceipt> InvestETHRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger poolId, CancellationTokenSource cancellationToken = null)
        {
            var investETHFunction = new InvestETHFunction();
                investETHFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(investETHFunction, cancellationToken);
        }

        public virtual Task<bool> IsERC20MaincoinQueryAsync(long chainId, Enum contractType, IsERC20MaincoinFunction isERC20MaincoinFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsERC20MaincoinFunction, bool>(isERC20MaincoinFunction, blockParameter);
        }

        public virtual Task<bool> IsERC20MaincoinQueryAsync(long chainId, Enum contractType, string address, BlockParameter blockParameter = null)
        {
            var isERC20MaincoinFunction = new IsERC20MaincoinFunction();
                isERC20MaincoinFunction.Address = address;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsERC20MaincoinFunction, bool>(isERC20MaincoinFunction, blockParameter);
        }

        public virtual Task<bool> IsPaybleQueryAsync(long chainId, Enum contractType, IsPaybleFunction isPaybleFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsPaybleFunction, bool>(isPaybleFunction, blockParameter);
        }

        public virtual Task<bool> IsPaybleQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsPaybleFunction, bool>(null, blockParameter);
        }

        public virtual Task<bool> IsReadyWithdrawInvestmentQueryAsync(long chainId, Enum contractType, IsReadyWithdrawInvestmentFunction isReadyWithdrawInvestmentFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsReadyWithdrawInvestmentFunction, bool>(isReadyWithdrawInvestmentFunction, blockParameter);
        }

        public virtual Task<bool> IsReadyWithdrawInvestmentQueryAsync(long chainId, Enum contractType, BigInteger id, BlockParameter blockParameter = null)
        {
            var isReadyWithdrawInvestmentFunction = new IsReadyWithdrawInvestmentFunction();
                isReadyWithdrawInvestmentFunction.Id = id;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsReadyWithdrawInvestmentFunction, bool>(isReadyWithdrawInvestmentFunction, blockParameter);
        }

        public virtual Task<bool> IsReadyWithdrawLeftOversQueryAsync(long chainId, Enum contractType, IsReadyWithdrawLeftOversFunction isReadyWithdrawLeftOversFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsReadyWithdrawLeftOversFunction, bool>(isReadyWithdrawLeftOversFunction, blockParameter);
        }

        public virtual Task<bool> IsReadyWithdrawLeftOversQueryAsync(long chainId, Enum contractType, BigInteger poolId, BlockParameter blockParameter = null)
        {
            var isReadyWithdrawLeftOversFunction = new IsReadyWithdrawLeftOversFunction();
                isReadyWithdrawLeftOversFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsReadyWithdrawLeftOversFunction, bool>(isReadyWithdrawLeftOversFunction, blockParameter);
        }

        public virtual Task<bool> IsTokenFilterOnQueryAsync(long chainId, Enum contractType, IsTokenFilterOnFunction isTokenFilterOnFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsTokenFilterOnFunction, bool>(isTokenFilterOnFunction, blockParameter);
        }

        public virtual Task<bool> IsTokenFilterOnQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsTokenFilterOnFunction, bool>(null, blockParameter);
        }

        public virtual Task<bool> IsValidTokenQueryAsync(long chainId, Enum contractType, IsValidTokenFunction isValidTokenFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsValidTokenFunction, bool>(isValidTokenFunction, blockParameter);
        }

        public virtual Task<bool> IsValidTokenQueryAsync(long chainId, Enum contractType, string address, BlockParameter blockParameter = null)
        {
            var isValidTokenFunction = new IsValidTokenFunction();
                isValidTokenFunction.Address = address;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsValidTokenFunction, bool>(isValidTokenFunction, blockParameter);
        }

        public virtual Task<BigInteger> MCWhitelistIdQueryAsync(long chainId, Enum contractType, MCWhitelistIdFunction mCWhitelistIdFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<MCWhitelistIdFunction, BigInteger>(mCWhitelistIdFunction, blockParameter);
        }

        public virtual Task<BigInteger> MCWhitelistIdQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<MCWhitelistIdFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> MaxDurationQueryAsync(long chainId, Enum contractType, MaxDurationFunction maxDurationFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<MaxDurationFunction, BigInteger>(maxDurationFunction, blockParameter);
        }

        public virtual Task<BigInteger> MaxDurationQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<MaxDurationFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> MaxETHInvestQueryAsync(long chainId, Enum contractType, MaxETHInvestFunction maxETHInvestFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<MaxETHInvestFunction, BigInteger>(maxETHInvestFunction, blockParameter);
        }

        public virtual Task<BigInteger> MaxETHInvestQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<MaxETHInvestFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> MinDurationQueryAsync(long chainId, Enum contractType, MinDurationFunction minDurationFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<MinDurationFunction, BigInteger>(minDurationFunction, blockParameter);
        }

        public virtual Task<BigInteger> MinDurationQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<MinDurationFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> MinETHInvestQueryAsync(long chainId, Enum contractType, MinETHInvestFunction minETHInvestFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<MinETHInvestFunction, BigInteger>(minETHInvestFunction, blockParameter);
        }

        public virtual Task<BigInteger> MinETHInvestQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<MinETHInvestFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> PoolPriceQueryAsync(long chainId, Enum contractType, PoolPriceFunction poolPriceFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PoolPriceFunction, BigInteger>(poolPriceFunction, blockParameter);
        }

        public virtual Task<BigInteger> PoolPriceQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PoolPriceFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> PozFeeQueryAsync(long chainId, Enum contractType, PozFeeFunction pozFeeFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PozFeeFunction, BigInteger>(pozFeeFunction, blockParameter);
        }

        public virtual Task<BigInteger> PozFeeQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PozFeeFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> PozTimerQueryAsync(long chainId, Enum contractType, PozTimerFunction pozTimerFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PozTimerFunction, BigInteger>(pozTimerFunction, blockParameter);
        }

        public virtual Task<BigInteger> PozTimerQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PozTimerFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> SetbenefitAddressRequestAsync(long chainId, Enum contractType, SetbenefitAddressFunction setbenefitAddressFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setbenefitAddressFunction);
        }

        public virtual Task<TransactionReceipt> SetbenefitAddressRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetbenefitAddressFunction setbenefitAddressFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setbenefitAddressFunction, cancellationToken);
        }

        public virtual Task<string> SetbenefitAddressRequestAsync(long chainId, Enum contractType, string benefitAddress)
        {
            var setbenefitAddressFunction = new SetbenefitAddressFunction();
                setbenefitAddressFunction.BenefitAddress = benefitAddress;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setbenefitAddressFunction);
        }

        public virtual Task<TransactionReceipt> SetbenefitAddressRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string benefitAddress, CancellationTokenSource cancellationToken = null)
        {
            var setbenefitAddressFunction = new SetbenefitAddressFunction();
                setbenefitAddressFunction.BenefitAddress = benefitAddress;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setbenefitAddressFunction, cancellationToken);
        }

        public virtual Task<string> SetFeeRequestAsync(long chainId, Enum contractType, SetFeeFunction setFeeFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFeeFunction);
        }

        public virtual Task<TransactionReceipt> SetFeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFeeFunction setFeeFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFeeFunction, cancellationToken);
        }

        public virtual Task<string> SetFeeRequestAsync(long chainId, Enum contractType, BigInteger fee)
        {
            var setFeeFunction = new SetFeeFunction();
                setFeeFunction.Fee = fee;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFeeFunction);
        }

        public virtual Task<TransactionReceipt> SetFeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger fee, CancellationTokenSource cancellationToken = null)
        {
            var setFeeFunction = new SetFeeFunction();
                setFeeFunction.Fee = fee;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFeeFunction, cancellationToken);
        }

        public virtual Task<string> SetMinMaxDurationRequestAsync(long chainId, Enum contractType, SetMinMaxDurationFunction setMinMaxDurationFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setMinMaxDurationFunction);
        }

        public virtual Task<TransactionReceipt> SetMinMaxDurationRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetMinMaxDurationFunction setMinMaxDurationFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setMinMaxDurationFunction, cancellationToken);
        }

        public virtual Task<string> SetMinMaxDurationRequestAsync(long chainId, Enum contractType, BigInteger minDuration, BigInteger maxDuration)
        {
            var setMinMaxDurationFunction = new SetMinMaxDurationFunction();
                setMinMaxDurationFunction.MinDuration = minDuration;
                setMinMaxDurationFunction.MaxDuration = maxDuration;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setMinMaxDurationFunction);
        }

        public virtual Task<TransactionReceipt> SetMinMaxDurationRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger minDuration, BigInteger maxDuration, CancellationTokenSource cancellationToken = null)
        {
            var setMinMaxDurationFunction = new SetMinMaxDurationFunction();
                setMinMaxDurationFunction.MinDuration = minDuration;
                setMinMaxDurationFunction.MaxDuration = maxDuration;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setMinMaxDurationFunction, cancellationToken);
        }

        public virtual Task<string> SetMinMaxETHInvestRequestAsync(long chainId, Enum contractType, SetMinMaxETHInvestFunction setMinMaxETHInvestFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setMinMaxETHInvestFunction);
        }

        public virtual Task<TransactionReceipt> SetMinMaxETHInvestRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetMinMaxETHInvestFunction setMinMaxETHInvestFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setMinMaxETHInvestFunction, cancellationToken);
        }

        public virtual Task<string> SetMinMaxETHInvestRequestAsync(long chainId, Enum contractType, BigInteger minETHInvest, BigInteger maxETHInvest)
        {
            var setMinMaxETHInvestFunction = new SetMinMaxETHInvestFunction();
                setMinMaxETHInvestFunction.MinETHInvest = minETHInvest;
                setMinMaxETHInvestFunction.MaxETHInvest = maxETHInvest;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setMinMaxETHInvestFunction);
        }

        public virtual Task<TransactionReceipt> SetMinMaxETHInvestRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger minETHInvest, BigInteger maxETHInvest, CancellationTokenSource cancellationToken = null)
        {
            var setMinMaxETHInvestFunction = new SetMinMaxETHInvestFunction();
                setMinMaxETHInvestFunction.MinETHInvest = minETHInvest;
                setMinMaxETHInvestFunction.MaxETHInvest = maxETHInvest;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setMinMaxETHInvestFunction, cancellationToken);
        }

        public virtual Task<string> SetPOZFeeRequestAsync(long chainId, Enum contractType, SetPOZFeeFunction setPOZFeeFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setPOZFeeFunction);
        }

        public virtual Task<TransactionReceipt> SetPOZFeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetPOZFeeFunction setPOZFeeFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setPOZFeeFunction, cancellationToken);
        }

        public virtual Task<string> SetPOZFeeRequestAsync(long chainId, Enum contractType, BigInteger fee)
        {
            var setPOZFeeFunction = new SetPOZFeeFunction();
                setPOZFeeFunction.Fee = fee;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setPOZFeeFunction);
        }

        public virtual Task<TransactionReceipt> SetPOZFeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger fee, CancellationTokenSource cancellationToken = null)
        {
            var setPOZFeeFunction = new SetPOZFeeFunction();
                setPOZFeeFunction.Fee = fee;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setPOZFeeFunction, cancellationToken);
        }

        public virtual Task<string> SetPoolPriceRequestAsync(long chainId, Enum contractType, SetPoolPriceFunction setPoolPriceFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setPoolPriceFunction);
        }

        public virtual Task<TransactionReceipt> SetPoolPriceRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetPoolPriceFunction setPoolPriceFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setPoolPriceFunction, cancellationToken);
        }

        public virtual Task<string> SetPoolPriceRequestAsync(long chainId, Enum contractType, BigInteger poolPrice)
        {
            var setPoolPriceFunction = new SetPoolPriceFunction();
                setPoolPriceFunction.PoolPrice = poolPrice;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setPoolPriceFunction);
        }

        public virtual Task<TransactionReceipt> SetPoolPriceRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger poolPrice, CancellationTokenSource cancellationToken = null)
        {
            var setPoolPriceFunction = new SetPoolPriceFunction();
                setPoolPriceFunction.PoolPrice = poolPrice;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setPoolPriceFunction, cancellationToken);
        }

        public virtual Task<string> SetPozTimerRequestAsync(long chainId, Enum contractType, SetPozTimerFunction setPozTimerFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setPozTimerFunction);
        }

        public virtual Task<TransactionReceipt> SetPozTimerRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetPozTimerFunction setPozTimerFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setPozTimerFunction, cancellationToken);
        }

        public virtual Task<string> SetPozTimerRequestAsync(long chainId, Enum contractType, BigInteger pozTimer)
        {
            var setPozTimerFunction = new SetPozTimerFunction();
                setPozTimerFunction.PozTimer = pozTimer;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setPozTimerFunction);
        }

        public virtual Task<TransactionReceipt> SetPozTimerRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger pozTimer, CancellationTokenSource cancellationToken = null)
        {
            var setPozTimerFunction = new SetPozTimerFunction();
                setPozTimerFunction.PozTimer = pozTimer;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setPozTimerFunction, cancellationToken);
        }

        public virtual Task<string> SetwhitelistAddressRequestAsync(long chainId, Enum contractType, SetwhitelistAddressFunction setwhitelistAddressFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setwhitelistAddressFunction);
        }

        public virtual Task<TransactionReceipt> SetwhitelistAddressRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetwhitelistAddressFunction setwhitelistAddressFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setwhitelistAddressFunction, cancellationToken);
        }

        public virtual Task<string> SetwhitelistAddressRequestAsync(long chainId, Enum contractType, string whitelistAddress)
        {
            var setwhitelistAddressFunction = new SetwhitelistAddressFunction();
                setwhitelistAddressFunction.WhitelistAddress = whitelistAddress;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setwhitelistAddressFunction);
        }

        public virtual Task<TransactionReceipt> SetwhitelistAddressRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string whitelistAddress, CancellationTokenSource cancellationToken = null)
        {
            var setwhitelistAddressFunction = new SetwhitelistAddressFunction();
                setwhitelistAddressFunction.WhitelistAddress = whitelistAddress;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setwhitelistAddressFunction, cancellationToken);
        }

        public virtual Task<string> SwapTokenFilterRequestAsync(long chainId, Enum contractType, SwapTokenFilterFunction swapTokenFilterFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(swapTokenFilterFunction);
        }

        public virtual Task<string> SwapTokenFilterRequestAsync(long chainId, Enum contractType)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync<SwapTokenFilterFunction>();
        }

        public virtual Task<TransactionReceipt> SwapTokenFilterRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SwapTokenFilterFunction swapTokenFilterFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(swapTokenFilterFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> SwapTokenFilterRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync<SwapTokenFilterFunction>(null, cancellationToken);
        }

        public virtual Task<string> SwitchIsPaybleRequestAsync(long chainId, Enum contractType, SwitchIsPaybleFunction switchIsPaybleFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(switchIsPaybleFunction);
        }

        public virtual Task<string> SwitchIsPaybleRequestAsync(long chainId, Enum contractType)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync<SwitchIsPaybleFunction>();
        }

        public virtual Task<TransactionReceipt> SwitchIsPaybleRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SwitchIsPaybleFunction switchIsPaybleFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(switchIsPaybleFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> SwitchIsPaybleRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync<SwitchIsPaybleFunction>(null, cancellationToken);
        }

        public virtual Task<BigInteger> TokenWhitelistIdQueryAsync(long chainId, Enum contractType, TokenWhitelistIdFunction tokenWhitelistIdFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenWhitelistIdFunction, BigInteger>(tokenWhitelistIdFunction, blockParameter);
        }

        public virtual Task<BigInteger> TokenWhitelistIdQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenWhitelistIdFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> WhitelistAddressQueryAsync(long chainId, Enum contractType, WhitelistAddressFunction whitelistAddressFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<WhitelistAddressFunction, string>(whitelistAddressFunction, blockParameter);
        }

        public virtual Task<string> WhitelistAddressQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<WhitelistAddressFunction, string>(null, blockParameter);
        }

        public virtual Task<string> WithdrawInvestmentRequestAsync(long chainId, Enum contractType, WithdrawInvestmentFunction withdrawInvestmentFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawInvestmentFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawInvestmentRequestAndWaitForReceiptAsync(long chainId, Enum contractType, WithdrawInvestmentFunction withdrawInvestmentFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawInvestmentFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawInvestmentRequestAsync(long chainId, Enum contractType, BigInteger id)
        {
            var withdrawInvestmentFunction = new WithdrawInvestmentFunction();
                withdrawInvestmentFunction.Id = id;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawInvestmentFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawInvestmentRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger id, CancellationTokenSource cancellationToken = null)
        {
            var withdrawInvestmentFunction = new WithdrawInvestmentFunction();
                withdrawInvestmentFunction.Id = id;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawInvestmentFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawLeftOversRequestAsync(long chainId, Enum contractType, WithdrawLeftOversFunction withdrawLeftOversFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawLeftOversFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawLeftOversRequestAndWaitForReceiptAsync(long chainId, Enum contractType, WithdrawLeftOversFunction withdrawLeftOversFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawLeftOversFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawLeftOversRequestAsync(long chainId, Enum contractType, BigInteger poolId)
        {
            var withdrawLeftOversFunction = new WithdrawLeftOversFunction();
                withdrawLeftOversFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawLeftOversFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawLeftOversRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger poolId, CancellationTokenSource cancellationToken = null)
        {
            var withdrawLeftOversFunction = new WithdrawLeftOversFunction();
                withdrawLeftOversFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawLeftOversFunction, cancellationToken);
        }

        public virtual Task<BigInteger> GetTotalInvestorQueryAsync(long chainId, Enum contractType, GetTotalInvestorFunction getTotalInvestorFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetTotalInvestorFunction, BigInteger>(getTotalInvestorFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetTotalInvestorQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetTotalInvestorFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<bool> IsPoolLockedQueryAsync(long chainId, Enum contractType, IsPoolLockedFunction isPoolLockedFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsPoolLockedFunction, bool>(isPoolLockedFunction, blockParameter);
        }

        public virtual Task<bool> IsPoolLockedQueryAsync(long chainId, Enum contractType, BigInteger id, BlockParameter blockParameter = null)
        {
            var isPoolLockedFunction = new IsPoolLockedFunction();
                isPoolLockedFunction.Id = id;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsPoolLockedFunction, bool>(isPoolLockedFunction, blockParameter);
        }

        public virtual Task<string> OwnerQueryAsync(long chainId, Enum contractType, OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        public virtual Task<string> OwnerQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public virtual Task<bool> PausedQueryAsync(long chainId, Enum contractType, PausedFunction pausedFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PausedFunction, bool>(pausedFunction, blockParameter);
        }

        public virtual Task<bool> PausedQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PausedFunction, bool>(null, blockParameter);
        }

        public virtual Task<BigInteger> PoolsCountQueryAsync(long chainId, Enum contractType, PoolsCountFunction poolsCountFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PoolsCountFunction, BigInteger>(poolsCountFunction, blockParameter);
        }

        public virtual Task<BigInteger> PoolsCountQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PoolsCountFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> RenounceOwnershipRequestAsync(long chainId, Enum contractType, RenounceOwnershipFunction renounceOwnershipFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(renounceOwnershipFunction);
        }

        public virtual Task<string> RenounceOwnershipRequestAsync(long chainId, Enum contractType)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync<RenounceOwnershipFunction>();
        }

        public virtual Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(renounceOwnershipFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync<RenounceOwnershipFunction>(null, cancellationToken);
        }

        public virtual Task<string> SetGovernerContractRequestAsync(long chainId, Enum contractType, SetGovernerContractFunction setGovernerContractFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setGovernerContractFunction);
        }

        public virtual Task<TransactionReceipt> SetGovernerContractRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetGovernerContractFunction setGovernerContractFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setGovernerContractFunction, cancellationToken);
        }

        public virtual Task<string> SetGovernerContractRequestAsync(long chainId, Enum contractType, string address)
        {
            var setGovernerContractFunction = new SetGovernerContractFunction();
                setGovernerContractFunction.Address = address;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setGovernerContractFunction);
        }

        public virtual Task<TransactionReceipt> SetGovernerContractRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string address, CancellationTokenSource cancellationToken = null)
        {
            var setGovernerContractFunction = new SetGovernerContractFunction();
                setGovernerContractFunction.Address = address;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setGovernerContractFunction, cancellationToken);
        }

        public virtual Task<string> SetMCWhitelistIdRequestAsync(long chainId, Enum contractType, SetMCWhitelistIdFunction setMCWhitelistIdFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setMCWhitelistIdFunction);
        }

        public virtual Task<TransactionReceipt> SetMCWhitelistIdRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetMCWhitelistIdFunction setMCWhitelistIdFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setMCWhitelistIdFunction, cancellationToken);
        }

        public virtual Task<string> SetMCWhitelistIdRequestAsync(long chainId, Enum contractType, BigInteger whiteListId)
        {
            var setMCWhitelistIdFunction = new SetMCWhitelistIdFunction();
                setMCWhitelistIdFunction.WhiteListId = whiteListId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setMCWhitelistIdFunction);
        }

        public virtual Task<TransactionReceipt> SetMCWhitelistIdRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger whiteListId, CancellationTokenSource cancellationToken = null)
        {
            var setMCWhitelistIdFunction = new SetMCWhitelistIdFunction();
                setMCWhitelistIdFunction.WhiteListId = whiteListId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setMCWhitelistIdFunction, cancellationToken);
        }

        public virtual Task<string> SetTokenWhitelistIdRequestAsync(long chainId, Enum contractType, SetTokenWhitelistIdFunction setTokenWhitelistIdFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setTokenWhitelistIdFunction);
        }

        public virtual Task<TransactionReceipt> SetTokenWhitelistIdRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetTokenWhitelistIdFunction setTokenWhitelistIdFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setTokenWhitelistIdFunction, cancellationToken);
        }

        public virtual Task<string> SetTokenWhitelistIdRequestAsync(long chainId, Enum contractType, BigInteger whiteListId)
        {
            var setTokenWhitelistIdFunction = new SetTokenWhitelistIdFunction();
                setTokenWhitelistIdFunction.WhiteListId = whiteListId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setTokenWhitelistIdFunction);
        }

        public virtual Task<TransactionReceipt> SetTokenWhitelistIdRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger whiteListId, CancellationTokenSource cancellationToken = null)
        {
            var setTokenWhitelistIdFunction = new SetTokenWhitelistIdFunction();
                setTokenWhitelistIdFunction.WhiteListId = whiteListId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setTokenWhitelistIdFunction, cancellationToken);
        }

        public virtual Task<string> TransferOwnershipRequestAsync(long chainId, Enum contractType, TransferOwnershipFunction transferOwnershipFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public virtual Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public virtual Task<string> TransferOwnershipRequestAsync(long chainId, Enum contractType, string newOwner)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public virtual Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string newOwner, CancellationTokenSource cancellationToken = null)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawETHFeeRequestAsync(long chainId, Enum contractType, WithdrawETHFeeFunction withdrawETHFeeFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawETHFeeFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawETHFeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, WithdrawETHFeeFunction withdrawETHFeeFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawETHFeeFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawETHFeeRequestAsync(long chainId, Enum contractType, string to)
        {
            var withdrawETHFeeFunction = new WithdrawETHFeeFunction();
                withdrawETHFeeFunction.To = to;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawETHFeeFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawETHFeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string to, CancellationTokenSource cancellationToken = null)
        {
            var withdrawETHFeeFunction = new WithdrawETHFeeFunction();
                withdrawETHFeeFunction.To = to;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawETHFeeFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawERC20FeeRequestAsync(long chainId, Enum contractType, WithdrawERC20FeeFunction withdrawERC20FeeFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawERC20FeeFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawERC20FeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, WithdrawERC20FeeFunction withdrawERC20FeeFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawERC20FeeFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawERC20FeeRequestAsync(long chainId, Enum contractType, string token, string to)
        {
            var withdrawERC20FeeFunction = new WithdrawERC20FeeFunction();
                withdrawERC20FeeFunction.Token = token;
                withdrawERC20FeeFunction.To = to;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawERC20FeeFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawERC20FeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string token, string to, CancellationTokenSource cancellationToken = null)
        {
            var withdrawERC20FeeFunction = new WithdrawERC20FeeFunction();
                withdrawERC20FeeFunction.Token = token;
                withdrawERC20FeeFunction.To = to;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawERC20FeeFunction, cancellationToken);
        }
    }
}
