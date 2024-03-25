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
using poolz.finance.csharp.contracts.PoolzBack.ContractDefinition;

namespace poolz.finance.csharp.contracts.PoolzBack
{
    public partial class PoolzBackService
    {
        protected virtual Nethereum.Web3.IWeb3 Web3 { get; }

        public virtual ContractHandler ContractHandler { get; }

        public PoolzBackService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public PoolzBackService(Nethereum.Web3.IWeb3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public virtual Task<string> BenefitAddressQueryAsync(BenefitAddressFunction benefitAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BenefitAddressFunction, string>(benefitAddressFunction, blockParameter);
        }

        
        public virtual Task<string> BenefitAddressQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BenefitAddressFunction, string>(null, blockParameter);
        }

        public virtual Task<string> CreatePoolRequestAsync(CreatePoolFunction createPoolFunction)
        {
             return ContractHandler.SendRequestAsync(createPoolFunction);
        }

        public virtual Task<TransactionReceipt> CreatePoolRequestAndWaitForReceiptAsync(CreatePoolFunction createPoolFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createPoolFunction, cancellationToken);
        }

        public virtual Task<string> CreatePoolRequestAsync(string token, BigInteger finishTime, BigInteger rate, BigInteger pOZRate, BigInteger startAmount, ulong lockedUntil, string mainCoin, bool is21Decimal, BigInteger now, BigInteger whiteListId)
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
            
             return ContractHandler.SendRequestAsync(createPoolFunction);
        }

        public virtual Task<TransactionReceipt> CreatePoolRequestAndWaitForReceiptAsync(string token, BigInteger finishTime, BigInteger rate, BigInteger pOZRate, BigInteger startAmount, ulong lockedUntil, string mainCoin, bool is21Decimal, BigInteger now, BigInteger whiteListId, CancellationTokenSource cancellationToken = null)
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
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createPoolFunction, cancellationToken);
        }

        public virtual Task<BigInteger> FeeQueryAsync(FeeFunction feeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<FeeFunction, BigInteger>(feeFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> FeeQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<FeeFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<GetInvestmentDataOutputDTO> GetInvestmentDataQueryAsync(GetInvestmentDataFunction getInvestmentDataFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetInvestmentDataFunction, GetInvestmentDataOutputDTO>(getInvestmentDataFunction, blockParameter);
        }

        public virtual Task<GetInvestmentDataOutputDTO> GetInvestmentDataQueryAsync(BigInteger id, BlockParameter blockParameter = null)
        {
            var getInvestmentDataFunction = new GetInvestmentDataFunction();
                getInvestmentDataFunction.Id = id;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetInvestmentDataFunction, GetInvestmentDataOutputDTO>(getInvestmentDataFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetMyInvestmentIdsQueryAsync(GetMyInvestmentIdsFunction getMyInvestmentIdsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetMyInvestmentIdsFunction, List<BigInteger>>(getMyInvestmentIdsFunction, blockParameter);
        }

        
        public virtual Task<List<BigInteger>> GetMyInvestmentIdsQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetMyInvestmentIdsFunction, List<BigInteger>>(null, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetMyPoolsIdQueryAsync(GetMyPoolsIdFunction getMyPoolsIdFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetMyPoolsIdFunction, List<BigInteger>>(getMyPoolsIdFunction, blockParameter);
        }

        
        public virtual Task<List<BigInteger>> GetMyPoolsIdQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetMyPoolsIdFunction, List<BigInteger>>(null, blockParameter);
        }

        public virtual Task<GetPoolBaseDataOutputDTO> GetPoolBaseDataQueryAsync(GetPoolBaseDataFunction getPoolBaseDataFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetPoolBaseDataFunction, GetPoolBaseDataOutputDTO>(getPoolBaseDataFunction, blockParameter);
        }

        public virtual Task<GetPoolBaseDataOutputDTO> GetPoolBaseDataQueryAsync(BigInteger id, BlockParameter blockParameter = null)
        {
            var getPoolBaseDataFunction = new GetPoolBaseDataFunction();
                getPoolBaseDataFunction.Id = id;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetPoolBaseDataFunction, GetPoolBaseDataOutputDTO>(getPoolBaseDataFunction, blockParameter);
        }

        public virtual Task<GetPoolExtraDataOutputDTO> GetPoolExtraDataQueryAsync(GetPoolExtraDataFunction getPoolExtraDataFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetPoolExtraDataFunction, GetPoolExtraDataOutputDTO>(getPoolExtraDataFunction, blockParameter);
        }

        public virtual Task<GetPoolExtraDataOutputDTO> GetPoolExtraDataQueryAsync(BigInteger id, BlockParameter blockParameter = null)
        {
            var getPoolExtraDataFunction = new GetPoolExtraDataFunction();
                getPoolExtraDataFunction.Id = id;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetPoolExtraDataFunction, GetPoolExtraDataOutputDTO>(getPoolExtraDataFunction, blockParameter);
        }

        public virtual Task<GetPoolMoreDataOutputDTO> GetPoolMoreDataQueryAsync(GetPoolMoreDataFunction getPoolMoreDataFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetPoolMoreDataFunction, GetPoolMoreDataOutputDTO>(getPoolMoreDataFunction, blockParameter);
        }

        public virtual Task<GetPoolMoreDataOutputDTO> GetPoolMoreDataQueryAsync(BigInteger id, BlockParameter blockParameter = null)
        {
            var getPoolMoreDataFunction = new GetPoolMoreDataFunction();
                getPoolMoreDataFunction.Id = id;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetPoolMoreDataFunction, GetPoolMoreDataOutputDTO>(getPoolMoreDataFunction, blockParameter);
        }

        public virtual Task<byte> GetPoolStatusQueryAsync(GetPoolStatusFunction getPoolStatusFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPoolStatusFunction, byte>(getPoolStatusFunction, blockParameter);
        }

        
        public virtual Task<byte> GetPoolStatusQueryAsync(BigInteger id, BlockParameter blockParameter = null)
        {
            var getPoolStatusFunction = new GetPoolStatusFunction();
                getPoolStatusFunction.Id = id;
            
            return ContractHandler.QueryAsync<GetPoolStatusFunction, byte>(getPoolStatusFunction, blockParameter);
        }

        public virtual Task<string> GovernerContractQueryAsync(GovernerContractFunction governerContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GovernerContractFunction, string>(governerContractFunction, blockParameter);
        }

        
        public virtual Task<string> GovernerContractQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GovernerContractFunction, string>(null, blockParameter);
        }

        public virtual Task<string> InvestERC20RequestAsync(InvestERC20Function investERC20Function)
        {
             return ContractHandler.SendRequestAsync(investERC20Function);
        }

        public virtual Task<TransactionReceipt> InvestERC20RequestAndWaitForReceiptAsync(InvestERC20Function investERC20Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(investERC20Function, cancellationToken);
        }

        public virtual Task<string> InvestERC20RequestAsync(BigInteger poolId, BigInteger amount)
        {
            var investERC20Function = new InvestERC20Function();
                investERC20Function.PoolId = poolId;
                investERC20Function.Amount = amount;
            
             return ContractHandler.SendRequestAsync(investERC20Function);
        }

        public virtual Task<TransactionReceipt> InvestERC20RequestAndWaitForReceiptAsync(BigInteger poolId, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var investERC20Function = new InvestERC20Function();
                investERC20Function.PoolId = poolId;
                investERC20Function.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(investERC20Function, cancellationToken);
        }

        public virtual Task<string> InvestETHRequestAsync(InvestETHFunction investETHFunction)
        {
             return ContractHandler.SendRequestAsync(investETHFunction);
        }

        public virtual Task<TransactionReceipt> InvestETHRequestAndWaitForReceiptAsync(InvestETHFunction investETHFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(investETHFunction, cancellationToken);
        }

        public virtual Task<string> InvestETHRequestAsync(BigInteger poolId)
        {
            var investETHFunction = new InvestETHFunction();
                investETHFunction.PoolId = poolId;
            
             return ContractHandler.SendRequestAsync(investETHFunction);
        }

        public virtual Task<TransactionReceipt> InvestETHRequestAndWaitForReceiptAsync(BigInteger poolId, CancellationTokenSource cancellationToken = null)
        {
            var investETHFunction = new InvestETHFunction();
                investETHFunction.PoolId = poolId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(investETHFunction, cancellationToken);
        }

        public virtual Task<bool> IsERC20MaincoinQueryAsync(IsERC20MaincoinFunction isERC20MaincoinFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsERC20MaincoinFunction, bool>(isERC20MaincoinFunction, blockParameter);
        }

        
        public virtual Task<bool> IsERC20MaincoinQueryAsync(string address, BlockParameter blockParameter = null)
        {
            var isERC20MaincoinFunction = new IsERC20MaincoinFunction();
                isERC20MaincoinFunction.Address = address;
            
            return ContractHandler.QueryAsync<IsERC20MaincoinFunction, bool>(isERC20MaincoinFunction, blockParameter);
        }

        public virtual Task<bool> IsPaybleQueryAsync(IsPaybleFunction isPaybleFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsPaybleFunction, bool>(isPaybleFunction, blockParameter);
        }

        
        public virtual Task<bool> IsPaybleQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsPaybleFunction, bool>(null, blockParameter);
        }

        public virtual Task<bool> IsReadyWithdrawInvestmentQueryAsync(IsReadyWithdrawInvestmentFunction isReadyWithdrawInvestmentFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsReadyWithdrawInvestmentFunction, bool>(isReadyWithdrawInvestmentFunction, blockParameter);
        }

        
        public virtual Task<bool> IsReadyWithdrawInvestmentQueryAsync(BigInteger id, BlockParameter blockParameter = null)
        {
            var isReadyWithdrawInvestmentFunction = new IsReadyWithdrawInvestmentFunction();
                isReadyWithdrawInvestmentFunction.Id = id;
            
            return ContractHandler.QueryAsync<IsReadyWithdrawInvestmentFunction, bool>(isReadyWithdrawInvestmentFunction, blockParameter);
        }

        public virtual Task<bool> IsReadyWithdrawLeftOversQueryAsync(IsReadyWithdrawLeftOversFunction isReadyWithdrawLeftOversFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsReadyWithdrawLeftOversFunction, bool>(isReadyWithdrawLeftOversFunction, blockParameter);
        }

        
        public virtual Task<bool> IsReadyWithdrawLeftOversQueryAsync(BigInteger poolId, BlockParameter blockParameter = null)
        {
            var isReadyWithdrawLeftOversFunction = new IsReadyWithdrawLeftOversFunction();
                isReadyWithdrawLeftOversFunction.PoolId = poolId;
            
            return ContractHandler.QueryAsync<IsReadyWithdrawLeftOversFunction, bool>(isReadyWithdrawLeftOversFunction, blockParameter);
        }

        public virtual Task<bool> IsTokenFilterOnQueryAsync(IsTokenFilterOnFunction isTokenFilterOnFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsTokenFilterOnFunction, bool>(isTokenFilterOnFunction, blockParameter);
        }

        
        public virtual Task<bool> IsTokenFilterOnQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsTokenFilterOnFunction, bool>(null, blockParameter);
        }

        public virtual Task<bool> IsValidTokenQueryAsync(IsValidTokenFunction isValidTokenFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsValidTokenFunction, bool>(isValidTokenFunction, blockParameter);
        }

        
        public virtual Task<bool> IsValidTokenQueryAsync(string address, BlockParameter blockParameter = null)
        {
            var isValidTokenFunction = new IsValidTokenFunction();
                isValidTokenFunction.Address = address;
            
            return ContractHandler.QueryAsync<IsValidTokenFunction, bool>(isValidTokenFunction, blockParameter);
        }

        public virtual Task<BigInteger> MCWhitelistIdQueryAsync(MCWhitelistIdFunction mCWhitelistIdFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MCWhitelistIdFunction, BigInteger>(mCWhitelistIdFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> MCWhitelistIdQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MCWhitelistIdFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> MaxDurationQueryAsync(MaxDurationFunction maxDurationFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxDurationFunction, BigInteger>(maxDurationFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> MaxDurationQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxDurationFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> MaxETHInvestQueryAsync(MaxETHInvestFunction maxETHInvestFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxETHInvestFunction, BigInteger>(maxETHInvestFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> MaxETHInvestQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxETHInvestFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> MinDurationQueryAsync(MinDurationFunction minDurationFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MinDurationFunction, BigInteger>(minDurationFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> MinDurationQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MinDurationFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> MinETHInvestQueryAsync(MinETHInvestFunction minETHInvestFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MinETHInvestFunction, BigInteger>(minETHInvestFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> MinETHInvestQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MinETHInvestFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> PoolPriceQueryAsync(PoolPriceFunction poolPriceFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolPriceFunction, BigInteger>(poolPriceFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> PoolPriceQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolPriceFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> PozFeeQueryAsync(PozFeeFunction pozFeeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PozFeeFunction, BigInteger>(pozFeeFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> PozFeeQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PozFeeFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> PozTimerQueryAsync(PozTimerFunction pozTimerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PozTimerFunction, BigInteger>(pozTimerFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> PozTimerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PozTimerFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> SetbenefitAddressRequestAsync(SetbenefitAddressFunction setbenefitAddressFunction)
        {
             return ContractHandler.SendRequestAsync(setbenefitAddressFunction);
        }

        public virtual Task<TransactionReceipt> SetbenefitAddressRequestAndWaitForReceiptAsync(SetbenefitAddressFunction setbenefitAddressFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setbenefitAddressFunction, cancellationToken);
        }

        public virtual Task<string> SetbenefitAddressRequestAsync(string benefitAddress)
        {
            var setbenefitAddressFunction = new SetbenefitAddressFunction();
                setbenefitAddressFunction.BenefitAddress = benefitAddress;
            
             return ContractHandler.SendRequestAsync(setbenefitAddressFunction);
        }

        public virtual Task<TransactionReceipt> SetbenefitAddressRequestAndWaitForReceiptAsync(string benefitAddress, CancellationTokenSource cancellationToken = null)
        {
            var setbenefitAddressFunction = new SetbenefitAddressFunction();
                setbenefitAddressFunction.BenefitAddress = benefitAddress;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setbenefitAddressFunction, cancellationToken);
        }

        public virtual Task<string> SetFeeRequestAsync(SetFeeFunction setFeeFunction)
        {
             return ContractHandler.SendRequestAsync(setFeeFunction);
        }

        public virtual Task<TransactionReceipt> SetFeeRequestAndWaitForReceiptAsync(SetFeeFunction setFeeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFeeFunction, cancellationToken);
        }

        public virtual Task<string> SetFeeRequestAsync(BigInteger fee)
        {
            var setFeeFunction = new SetFeeFunction();
                setFeeFunction.Fee = fee;
            
             return ContractHandler.SendRequestAsync(setFeeFunction);
        }

        public virtual Task<TransactionReceipt> SetFeeRequestAndWaitForReceiptAsync(BigInteger fee, CancellationTokenSource cancellationToken = null)
        {
            var setFeeFunction = new SetFeeFunction();
                setFeeFunction.Fee = fee;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFeeFunction, cancellationToken);
        }

        public virtual Task<string> SetMinMaxDurationRequestAsync(SetMinMaxDurationFunction setMinMaxDurationFunction)
        {
             return ContractHandler.SendRequestAsync(setMinMaxDurationFunction);
        }

        public virtual Task<TransactionReceipt> SetMinMaxDurationRequestAndWaitForReceiptAsync(SetMinMaxDurationFunction setMinMaxDurationFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setMinMaxDurationFunction, cancellationToken);
        }

        public virtual Task<string> SetMinMaxDurationRequestAsync(BigInteger minDuration, BigInteger maxDuration)
        {
            var setMinMaxDurationFunction = new SetMinMaxDurationFunction();
                setMinMaxDurationFunction.MinDuration = minDuration;
                setMinMaxDurationFunction.MaxDuration = maxDuration;
            
             return ContractHandler.SendRequestAsync(setMinMaxDurationFunction);
        }

        public virtual Task<TransactionReceipt> SetMinMaxDurationRequestAndWaitForReceiptAsync(BigInteger minDuration, BigInteger maxDuration, CancellationTokenSource cancellationToken = null)
        {
            var setMinMaxDurationFunction = new SetMinMaxDurationFunction();
                setMinMaxDurationFunction.MinDuration = minDuration;
                setMinMaxDurationFunction.MaxDuration = maxDuration;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setMinMaxDurationFunction, cancellationToken);
        }

        public virtual Task<string> SetMinMaxETHInvestRequestAsync(SetMinMaxETHInvestFunction setMinMaxETHInvestFunction)
        {
             return ContractHandler.SendRequestAsync(setMinMaxETHInvestFunction);
        }

        public virtual Task<TransactionReceipt> SetMinMaxETHInvestRequestAndWaitForReceiptAsync(SetMinMaxETHInvestFunction setMinMaxETHInvestFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setMinMaxETHInvestFunction, cancellationToken);
        }

        public virtual Task<string> SetMinMaxETHInvestRequestAsync(BigInteger minETHInvest, BigInteger maxETHInvest)
        {
            var setMinMaxETHInvestFunction = new SetMinMaxETHInvestFunction();
                setMinMaxETHInvestFunction.MinETHInvest = minETHInvest;
                setMinMaxETHInvestFunction.MaxETHInvest = maxETHInvest;
            
             return ContractHandler.SendRequestAsync(setMinMaxETHInvestFunction);
        }

        public virtual Task<TransactionReceipt> SetMinMaxETHInvestRequestAndWaitForReceiptAsync(BigInteger minETHInvest, BigInteger maxETHInvest, CancellationTokenSource cancellationToken = null)
        {
            var setMinMaxETHInvestFunction = new SetMinMaxETHInvestFunction();
                setMinMaxETHInvestFunction.MinETHInvest = minETHInvest;
                setMinMaxETHInvestFunction.MaxETHInvest = maxETHInvest;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setMinMaxETHInvestFunction, cancellationToken);
        }

        public virtual Task<string> SetPOZFeeRequestAsync(SetPOZFeeFunction setPOZFeeFunction)
        {
             return ContractHandler.SendRequestAsync(setPOZFeeFunction);
        }

        public virtual Task<TransactionReceipt> SetPOZFeeRequestAndWaitForReceiptAsync(SetPOZFeeFunction setPOZFeeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setPOZFeeFunction, cancellationToken);
        }

        public virtual Task<string> SetPOZFeeRequestAsync(BigInteger fee)
        {
            var setPOZFeeFunction = new SetPOZFeeFunction();
                setPOZFeeFunction.Fee = fee;
            
             return ContractHandler.SendRequestAsync(setPOZFeeFunction);
        }

        public virtual Task<TransactionReceipt> SetPOZFeeRequestAndWaitForReceiptAsync(BigInteger fee, CancellationTokenSource cancellationToken = null)
        {
            var setPOZFeeFunction = new SetPOZFeeFunction();
                setPOZFeeFunction.Fee = fee;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setPOZFeeFunction, cancellationToken);
        }

        public virtual Task<string> SetPoolPriceRequestAsync(SetPoolPriceFunction setPoolPriceFunction)
        {
             return ContractHandler.SendRequestAsync(setPoolPriceFunction);
        }

        public virtual Task<TransactionReceipt> SetPoolPriceRequestAndWaitForReceiptAsync(SetPoolPriceFunction setPoolPriceFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setPoolPriceFunction, cancellationToken);
        }

        public virtual Task<string> SetPoolPriceRequestAsync(BigInteger poolPrice)
        {
            var setPoolPriceFunction = new SetPoolPriceFunction();
                setPoolPriceFunction.PoolPrice = poolPrice;
            
             return ContractHandler.SendRequestAsync(setPoolPriceFunction);
        }

        public virtual Task<TransactionReceipt> SetPoolPriceRequestAndWaitForReceiptAsync(BigInteger poolPrice, CancellationTokenSource cancellationToken = null)
        {
            var setPoolPriceFunction = new SetPoolPriceFunction();
                setPoolPriceFunction.PoolPrice = poolPrice;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setPoolPriceFunction, cancellationToken);
        }

        public virtual Task<string> SetPozTimerRequestAsync(SetPozTimerFunction setPozTimerFunction)
        {
             return ContractHandler.SendRequestAsync(setPozTimerFunction);
        }

        public virtual Task<TransactionReceipt> SetPozTimerRequestAndWaitForReceiptAsync(SetPozTimerFunction setPozTimerFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setPozTimerFunction, cancellationToken);
        }

        public virtual Task<string> SetPozTimerRequestAsync(BigInteger pozTimer)
        {
            var setPozTimerFunction = new SetPozTimerFunction();
                setPozTimerFunction.PozTimer = pozTimer;
            
             return ContractHandler.SendRequestAsync(setPozTimerFunction);
        }

        public virtual Task<TransactionReceipt> SetPozTimerRequestAndWaitForReceiptAsync(BigInteger pozTimer, CancellationTokenSource cancellationToken = null)
        {
            var setPozTimerFunction = new SetPozTimerFunction();
                setPozTimerFunction.PozTimer = pozTimer;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setPozTimerFunction, cancellationToken);
        }

        public virtual Task<string> SetwhitelistAddressRequestAsync(SetwhitelistAddressFunction setwhitelistAddressFunction)
        {
             return ContractHandler.SendRequestAsync(setwhitelistAddressFunction);
        }

        public virtual Task<TransactionReceipt> SetwhitelistAddressRequestAndWaitForReceiptAsync(SetwhitelistAddressFunction setwhitelistAddressFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setwhitelistAddressFunction, cancellationToken);
        }

        public virtual Task<string> SetwhitelistAddressRequestAsync(string whitelistAddress)
        {
            var setwhitelistAddressFunction = new SetwhitelistAddressFunction();
                setwhitelistAddressFunction.WhitelistAddress = whitelistAddress;
            
             return ContractHandler.SendRequestAsync(setwhitelistAddressFunction);
        }

        public virtual Task<TransactionReceipt> SetwhitelistAddressRequestAndWaitForReceiptAsync(string whitelistAddress, CancellationTokenSource cancellationToken = null)
        {
            var setwhitelistAddressFunction = new SetwhitelistAddressFunction();
                setwhitelistAddressFunction.WhitelistAddress = whitelistAddress;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setwhitelistAddressFunction, cancellationToken);
        }

        public virtual Task<string> SwapTokenFilterRequestAsync(SwapTokenFilterFunction swapTokenFilterFunction)
        {
             return ContractHandler.SendRequestAsync(swapTokenFilterFunction);
        }

        public virtual Task<string> SwapTokenFilterRequestAsync()
        {
             return ContractHandler.SendRequestAsync<SwapTokenFilterFunction>();
        }

        public virtual Task<TransactionReceipt> SwapTokenFilterRequestAndWaitForReceiptAsync(SwapTokenFilterFunction swapTokenFilterFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(swapTokenFilterFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> SwapTokenFilterRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<SwapTokenFilterFunction>(null, cancellationToken);
        }

        public virtual Task<string> SwitchIsPaybleRequestAsync(SwitchIsPaybleFunction switchIsPaybleFunction)
        {
             return ContractHandler.SendRequestAsync(switchIsPaybleFunction);
        }

        public virtual Task<string> SwitchIsPaybleRequestAsync()
        {
             return ContractHandler.SendRequestAsync<SwitchIsPaybleFunction>();
        }

        public virtual Task<TransactionReceipt> SwitchIsPaybleRequestAndWaitForReceiptAsync(SwitchIsPaybleFunction switchIsPaybleFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(switchIsPaybleFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> SwitchIsPaybleRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<SwitchIsPaybleFunction>(null, cancellationToken);
        }

        public virtual Task<BigInteger> TokenWhitelistIdQueryAsync(TokenWhitelistIdFunction tokenWhitelistIdFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenWhitelistIdFunction, BigInteger>(tokenWhitelistIdFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> TokenWhitelistIdQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenWhitelistIdFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> WhitelistAddressQueryAsync(WhitelistAddressFunction whitelistAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<WhitelistAddressFunction, string>(whitelistAddressFunction, blockParameter);
        }

        
        public virtual Task<string> WhitelistAddressQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<WhitelistAddressFunction, string>(null, blockParameter);
        }

        public virtual Task<string> WithdrawInvestmentRequestAsync(WithdrawInvestmentFunction withdrawInvestmentFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawInvestmentFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawInvestmentRequestAndWaitForReceiptAsync(WithdrawInvestmentFunction withdrawInvestmentFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawInvestmentFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawInvestmentRequestAsync(BigInteger id)
        {
            var withdrawInvestmentFunction = new WithdrawInvestmentFunction();
                withdrawInvestmentFunction.Id = id;
            
             return ContractHandler.SendRequestAsync(withdrawInvestmentFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawInvestmentRequestAndWaitForReceiptAsync(BigInteger id, CancellationTokenSource cancellationToken = null)
        {
            var withdrawInvestmentFunction = new WithdrawInvestmentFunction();
                withdrawInvestmentFunction.Id = id;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawInvestmentFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawLeftOversRequestAsync(WithdrawLeftOversFunction withdrawLeftOversFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawLeftOversFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawLeftOversRequestAndWaitForReceiptAsync(WithdrawLeftOversFunction withdrawLeftOversFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawLeftOversFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawLeftOversRequestAsync(BigInteger poolId)
        {
            var withdrawLeftOversFunction = new WithdrawLeftOversFunction();
                withdrawLeftOversFunction.PoolId = poolId;
            
             return ContractHandler.SendRequestAsync(withdrawLeftOversFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawLeftOversRequestAndWaitForReceiptAsync(BigInteger poolId, CancellationTokenSource cancellationToken = null)
        {
            var withdrawLeftOversFunction = new WithdrawLeftOversFunction();
                withdrawLeftOversFunction.PoolId = poolId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawLeftOversFunction, cancellationToken);
        }

        public virtual Task<BigInteger> GetTotalInvestorQueryAsync(GetTotalInvestorFunction getTotalInvestorFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTotalInvestorFunction, BigInteger>(getTotalInvestorFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> GetTotalInvestorQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTotalInvestorFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<bool> IsPoolLockedQueryAsync(IsPoolLockedFunction isPoolLockedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsPoolLockedFunction, bool>(isPoolLockedFunction, blockParameter);
        }

        
        public virtual Task<bool> IsPoolLockedQueryAsync(BigInteger id, BlockParameter blockParameter = null)
        {
            var isPoolLockedFunction = new IsPoolLockedFunction();
                isPoolLockedFunction.Id = id;
            
            return ContractHandler.QueryAsync<IsPoolLockedFunction, bool>(isPoolLockedFunction, blockParameter);
        }

        public virtual Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        
        public virtual Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public virtual Task<bool> PausedQueryAsync(PausedFunction pausedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PausedFunction, bool>(pausedFunction, blockParameter);
        }

        
        public virtual Task<bool> PausedQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PausedFunction, bool>(null, blockParameter);
        }

        public virtual Task<BigInteger> PoolsCountQueryAsync(PoolsCountFunction poolsCountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolsCountFunction, BigInteger>(poolsCountFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> PoolsCountQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolsCountFunction, BigInteger>(null, blockParameter);
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

        public virtual Task<string> SetGovernerContractRequestAsync(SetGovernerContractFunction setGovernerContractFunction)
        {
             return ContractHandler.SendRequestAsync(setGovernerContractFunction);
        }

        public virtual Task<TransactionReceipt> SetGovernerContractRequestAndWaitForReceiptAsync(SetGovernerContractFunction setGovernerContractFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setGovernerContractFunction, cancellationToken);
        }

        public virtual Task<string> SetGovernerContractRequestAsync(string address)
        {
            var setGovernerContractFunction = new SetGovernerContractFunction();
                setGovernerContractFunction.Address = address;
            
             return ContractHandler.SendRequestAsync(setGovernerContractFunction);
        }

        public virtual Task<TransactionReceipt> SetGovernerContractRequestAndWaitForReceiptAsync(string address, CancellationTokenSource cancellationToken = null)
        {
            var setGovernerContractFunction = new SetGovernerContractFunction();
                setGovernerContractFunction.Address = address;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setGovernerContractFunction, cancellationToken);
        }

        public virtual Task<string> SetMCWhitelistIdRequestAsync(SetMCWhitelistIdFunction setMCWhitelistIdFunction)
        {
             return ContractHandler.SendRequestAsync(setMCWhitelistIdFunction);
        }

        public virtual Task<TransactionReceipt> SetMCWhitelistIdRequestAndWaitForReceiptAsync(SetMCWhitelistIdFunction setMCWhitelistIdFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setMCWhitelistIdFunction, cancellationToken);
        }

        public virtual Task<string> SetMCWhitelistIdRequestAsync(BigInteger whiteListId)
        {
            var setMCWhitelistIdFunction = new SetMCWhitelistIdFunction();
                setMCWhitelistIdFunction.WhiteListId = whiteListId;
            
             return ContractHandler.SendRequestAsync(setMCWhitelistIdFunction);
        }

        public virtual Task<TransactionReceipt> SetMCWhitelistIdRequestAndWaitForReceiptAsync(BigInteger whiteListId, CancellationTokenSource cancellationToken = null)
        {
            var setMCWhitelistIdFunction = new SetMCWhitelistIdFunction();
                setMCWhitelistIdFunction.WhiteListId = whiteListId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setMCWhitelistIdFunction, cancellationToken);
        }

        public virtual Task<string> SetTokenWhitelistIdRequestAsync(SetTokenWhitelistIdFunction setTokenWhitelistIdFunction)
        {
             return ContractHandler.SendRequestAsync(setTokenWhitelistIdFunction);
        }

        public virtual Task<TransactionReceipt> SetTokenWhitelistIdRequestAndWaitForReceiptAsync(SetTokenWhitelistIdFunction setTokenWhitelistIdFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTokenWhitelistIdFunction, cancellationToken);
        }

        public virtual Task<string> SetTokenWhitelistIdRequestAsync(BigInteger whiteListId)
        {
            var setTokenWhitelistIdFunction = new SetTokenWhitelistIdFunction();
                setTokenWhitelistIdFunction.WhiteListId = whiteListId;
            
             return ContractHandler.SendRequestAsync(setTokenWhitelistIdFunction);
        }

        public virtual Task<TransactionReceipt> SetTokenWhitelistIdRequestAndWaitForReceiptAsync(BigInteger whiteListId, CancellationTokenSource cancellationToken = null)
        {
            var setTokenWhitelistIdFunction = new SetTokenWhitelistIdFunction();
                setTokenWhitelistIdFunction.WhiteListId = whiteListId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTokenWhitelistIdFunction, cancellationToken);
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

        public virtual Task<string> WithdrawETHFeeRequestAsync(WithdrawETHFeeFunction withdrawETHFeeFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawETHFeeFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawETHFeeRequestAndWaitForReceiptAsync(WithdrawETHFeeFunction withdrawETHFeeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawETHFeeFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawETHFeeRequestAsync(string to)
        {
            var withdrawETHFeeFunction = new WithdrawETHFeeFunction();
                withdrawETHFeeFunction.To = to;
            
             return ContractHandler.SendRequestAsync(withdrawETHFeeFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawETHFeeRequestAndWaitForReceiptAsync(string to, CancellationTokenSource cancellationToken = null)
        {
            var withdrawETHFeeFunction = new WithdrawETHFeeFunction();
                withdrawETHFeeFunction.To = to;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawETHFeeFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawERC20FeeRequestAsync(WithdrawERC20FeeFunction withdrawERC20FeeFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawERC20FeeFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawERC20FeeRequestAndWaitForReceiptAsync(WithdrawERC20FeeFunction withdrawERC20FeeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawERC20FeeFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawERC20FeeRequestAsync(string token, string to)
        {
            var withdrawERC20FeeFunction = new WithdrawERC20FeeFunction();
                withdrawERC20FeeFunction.Token = token;
                withdrawERC20FeeFunction.To = to;
            
             return ContractHandler.SendRequestAsync(withdrawERC20FeeFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawERC20FeeRequestAndWaitForReceiptAsync(string token, string to, CancellationTokenSource cancellationToken = null)
        {
            var withdrawERC20FeeFunction = new WithdrawERC20FeeFunction();
                withdrawERC20FeeFunction.Token = token;
                withdrawERC20FeeFunction.To = to;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawERC20FeeFunction, cancellationToken);
        }
    }
}
