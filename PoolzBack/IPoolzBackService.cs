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
    public interface IPoolzBackService
    {
        public Task<string> BenefitAddressQueryAsync(BenefitAddressFunction benefitAddressFunction, BlockParameter blockParameter = null);

        public Task<string> BenefitAddressQueryAsync(BlockParameter blockParameter = null);

        public Task<string> CreatePoolRequestAsync(CreatePoolFunction createPoolFunction);

        public Task<TransactionReceipt> CreatePoolRequestAndWaitForReceiptAsync(CreatePoolFunction createPoolFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> CreatePoolRequestAsync(string token, BigInteger finishTime, BigInteger rate, BigInteger pOZRate, BigInteger startAmount, ulong lockedUntil, string mainCoin, bool is21Decimal, BigInteger now, BigInteger whiteListId);

        public Task<TransactionReceipt> CreatePoolRequestAndWaitForReceiptAsync(string token, BigInteger finishTime, BigInteger rate, BigInteger pOZRate, BigInteger startAmount, ulong lockedUntil, string mainCoin, bool is21Decimal, BigInteger now, BigInteger whiteListId, CancellationTokenSource cancellationToken = null);

        public Task<BigInteger> FeeQueryAsync(FeeFunction feeFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> FeeQueryAsync(BlockParameter blockParameter = null);

        public Task<GetInvestmentDataOutputDTO> GetInvestmentDataQueryAsync(GetInvestmentDataFunction getInvestmentDataFunction, BlockParameter blockParameter = null);

        public Task<GetInvestmentDataOutputDTO> GetInvestmentDataQueryAsync(BigInteger id, BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetMyInvestmentIdsQueryAsync(GetMyInvestmentIdsFunction getMyInvestmentIdsFunction, BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetMyInvestmentIdsQueryAsync(BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetMyPoolsIdQueryAsync(GetMyPoolsIdFunction getMyPoolsIdFunction, BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetMyPoolsIdQueryAsync(BlockParameter blockParameter = null);

        public Task<GetPoolBaseDataOutputDTO> GetPoolBaseDataQueryAsync(GetPoolBaseDataFunction getPoolBaseDataFunction, BlockParameter blockParameter = null);

        public Task<GetPoolBaseDataOutputDTO> GetPoolBaseDataQueryAsync(BigInteger id, BlockParameter blockParameter = null);

        public Task<GetPoolExtraDataOutputDTO> GetPoolExtraDataQueryAsync(GetPoolExtraDataFunction getPoolExtraDataFunction, BlockParameter blockParameter = null);

        public Task<GetPoolExtraDataOutputDTO> GetPoolExtraDataQueryAsync(BigInteger id, BlockParameter blockParameter = null);

        public Task<GetPoolMoreDataOutputDTO> GetPoolMoreDataQueryAsync(GetPoolMoreDataFunction getPoolMoreDataFunction, BlockParameter blockParameter = null);

        public Task<GetPoolMoreDataOutputDTO> GetPoolMoreDataQueryAsync(BigInteger id, BlockParameter blockParameter = null);

        public Task<byte> GetPoolStatusQueryAsync(GetPoolStatusFunction getPoolStatusFunction, BlockParameter blockParameter = null);

        public Task<byte> GetPoolStatusQueryAsync(BigInteger id, BlockParameter blockParameter = null);

        public Task<string> GovernerContractQueryAsync(GovernerContractFunction governerContractFunction, BlockParameter blockParameter = null);

        public Task<string> GovernerContractQueryAsync(BlockParameter blockParameter = null);

        public Task<string> InvestERC20RequestAsync(InvestERC20Function investERC20Function);

        public Task<TransactionReceipt> InvestERC20RequestAndWaitForReceiptAsync(InvestERC20Function investERC20Function, CancellationTokenSource cancellationToken = null);

        public Task<string> InvestERC20RequestAsync(BigInteger poolId, BigInteger amount);

        public Task<TransactionReceipt> InvestERC20RequestAndWaitForReceiptAsync(BigInteger poolId, BigInteger amount, CancellationTokenSource cancellationToken = null);

        public Task<string> InvestETHRequestAsync(InvestETHFunction investETHFunction);

        public Task<TransactionReceipt> InvestETHRequestAndWaitForReceiptAsync(InvestETHFunction investETHFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> InvestETHRequestAsync(BigInteger poolId);

        public Task<TransactionReceipt> InvestETHRequestAndWaitForReceiptAsync(BigInteger poolId, CancellationTokenSource cancellationToken = null);

        public Task<bool> IsERC20MaincoinQueryAsync(IsERC20MaincoinFunction isERC20MaincoinFunction, BlockParameter blockParameter = null);

        public Task<bool> IsERC20MaincoinQueryAsync(string address, BlockParameter blockParameter = null);

        public Task<bool> IsPaybleQueryAsync(IsPaybleFunction isPaybleFunction, BlockParameter blockParameter = null);

        public Task<bool> IsPaybleQueryAsync(BlockParameter blockParameter = null);

        public Task<bool> IsReadyWithdrawInvestmentQueryAsync(IsReadyWithdrawInvestmentFunction isReadyWithdrawInvestmentFunction, BlockParameter blockParameter = null);

        public Task<bool> IsReadyWithdrawInvestmentQueryAsync(BigInteger id, BlockParameter blockParameter = null);

        public Task<bool> IsReadyWithdrawLeftOversQueryAsync(IsReadyWithdrawLeftOversFunction isReadyWithdrawLeftOversFunction, BlockParameter blockParameter = null);

        public Task<bool> IsReadyWithdrawLeftOversQueryAsync(BigInteger poolId, BlockParameter blockParameter = null);

        public Task<bool> IsTokenFilterOnQueryAsync(IsTokenFilterOnFunction isTokenFilterOnFunction, BlockParameter blockParameter = null);

        public Task<bool> IsTokenFilterOnQueryAsync(BlockParameter blockParameter = null);

        public Task<bool> IsValidTokenQueryAsync(IsValidTokenFunction isValidTokenFunction, BlockParameter blockParameter = null);

        public Task<bool> IsValidTokenQueryAsync(string address, BlockParameter blockParameter = null);

        public Task<BigInteger> MCWhitelistIdQueryAsync(MCWhitelistIdFunction mCWhitelistIdFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> MCWhitelistIdQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> MaxDurationQueryAsync(MaxDurationFunction maxDurationFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> MaxDurationQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> MaxETHInvestQueryAsync(MaxETHInvestFunction maxETHInvestFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> MaxETHInvestQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> MinDurationQueryAsync(MinDurationFunction minDurationFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> MinDurationQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> MinETHInvestQueryAsync(MinETHInvestFunction minETHInvestFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> MinETHInvestQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> PoolPriceQueryAsync(PoolPriceFunction poolPriceFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> PoolPriceQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> PozFeeQueryAsync(PozFeeFunction pozFeeFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> PozFeeQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> PozTimerQueryAsync(PozTimerFunction pozTimerFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> PozTimerQueryAsync(BlockParameter blockParameter = null);

        public Task<string> SetbenefitAddressRequestAsync(SetbenefitAddressFunction setbenefitAddressFunction);

        public Task<TransactionReceipt> SetbenefitAddressRequestAndWaitForReceiptAsync(SetbenefitAddressFunction setbenefitAddressFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetbenefitAddressRequestAsync(string benefitAddress);

        public Task<TransactionReceipt> SetbenefitAddressRequestAndWaitForReceiptAsync(string benefitAddress, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFeeRequestAsync(SetFeeFunction setFeeFunction);

        public Task<TransactionReceipt> SetFeeRequestAndWaitForReceiptAsync(SetFeeFunction setFeeFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFeeRequestAsync(BigInteger fee);

        public Task<TransactionReceipt> SetFeeRequestAndWaitForReceiptAsync(BigInteger fee, CancellationTokenSource cancellationToken = null);

        public Task<string> SetMinMaxDurationRequestAsync(SetMinMaxDurationFunction setMinMaxDurationFunction);

        public Task<TransactionReceipt> SetMinMaxDurationRequestAndWaitForReceiptAsync(SetMinMaxDurationFunction setMinMaxDurationFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetMinMaxDurationRequestAsync(BigInteger minDuration, BigInteger maxDuration);

        public Task<TransactionReceipt> SetMinMaxDurationRequestAndWaitForReceiptAsync(BigInteger minDuration, BigInteger maxDuration, CancellationTokenSource cancellationToken = null);

        public Task<string> SetMinMaxETHInvestRequestAsync(SetMinMaxETHInvestFunction setMinMaxETHInvestFunction);

        public Task<TransactionReceipt> SetMinMaxETHInvestRequestAndWaitForReceiptAsync(SetMinMaxETHInvestFunction setMinMaxETHInvestFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetMinMaxETHInvestRequestAsync(BigInteger minETHInvest, BigInteger maxETHInvest);

        public Task<TransactionReceipt> SetMinMaxETHInvestRequestAndWaitForReceiptAsync(BigInteger minETHInvest, BigInteger maxETHInvest, CancellationTokenSource cancellationToken = null);

        public Task<string> SetPOZFeeRequestAsync(SetPOZFeeFunction setPOZFeeFunction);

        public Task<TransactionReceipt> SetPOZFeeRequestAndWaitForReceiptAsync(SetPOZFeeFunction setPOZFeeFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetPOZFeeRequestAsync(BigInteger fee);

        public Task<TransactionReceipt> SetPOZFeeRequestAndWaitForReceiptAsync(BigInteger fee, CancellationTokenSource cancellationToken = null);

        public Task<string> SetPoolPriceRequestAsync(SetPoolPriceFunction setPoolPriceFunction);

        public Task<TransactionReceipt> SetPoolPriceRequestAndWaitForReceiptAsync(SetPoolPriceFunction setPoolPriceFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetPoolPriceRequestAsync(BigInteger poolPrice);

        public Task<TransactionReceipt> SetPoolPriceRequestAndWaitForReceiptAsync(BigInteger poolPrice, CancellationTokenSource cancellationToken = null);

        public Task<string> SetPozTimerRequestAsync(SetPozTimerFunction setPozTimerFunction);

        public Task<TransactionReceipt> SetPozTimerRequestAndWaitForReceiptAsync(SetPozTimerFunction setPozTimerFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetPozTimerRequestAsync(BigInteger pozTimer);

        public Task<TransactionReceipt> SetPozTimerRequestAndWaitForReceiptAsync(BigInteger pozTimer, CancellationTokenSource cancellationToken = null);

        public Task<string> SetwhitelistAddressRequestAsync(SetwhitelistAddressFunction setwhitelistAddressFunction);

        public Task<TransactionReceipt> SetwhitelistAddressRequestAndWaitForReceiptAsync(SetwhitelistAddressFunction setwhitelistAddressFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetwhitelistAddressRequestAsync(string whitelistAddress);

        public Task<TransactionReceipt> SetwhitelistAddressRequestAndWaitForReceiptAsync(string whitelistAddress, CancellationTokenSource cancellationToken = null);

        public Task<string> SwapTokenFilterRequestAsync(SwapTokenFilterFunction swapTokenFilterFunction);

        public Task<string> SwapTokenFilterRequestAsync();

        public Task<TransactionReceipt> SwapTokenFilterRequestAndWaitForReceiptAsync(SwapTokenFilterFunction swapTokenFilterFunction, CancellationTokenSource cancellationToken = null);

        public Task<TransactionReceipt> SwapTokenFilterRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null);

        public Task<string> SwitchIsPaybleRequestAsync(SwitchIsPaybleFunction switchIsPaybleFunction);

        public Task<string> SwitchIsPaybleRequestAsync();

        public Task<TransactionReceipt> SwitchIsPaybleRequestAndWaitForReceiptAsync(SwitchIsPaybleFunction switchIsPaybleFunction, CancellationTokenSource cancellationToken = null);

        public Task<TransactionReceipt> SwitchIsPaybleRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null);

        public Task<BigInteger> TokenWhitelistIdQueryAsync(TokenWhitelistIdFunction tokenWhitelistIdFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> TokenWhitelistIdQueryAsync(BlockParameter blockParameter = null);

        public Task<string> WhitelistAddressQueryAsync(WhitelistAddressFunction whitelistAddressFunction, BlockParameter blockParameter = null);

        public Task<string> WhitelistAddressQueryAsync(BlockParameter blockParameter = null);

        public Task<string> WithdrawInvestmentRequestAsync(WithdrawInvestmentFunction withdrawInvestmentFunction);

        public Task<TransactionReceipt> WithdrawInvestmentRequestAndWaitForReceiptAsync(WithdrawInvestmentFunction withdrawInvestmentFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> WithdrawInvestmentRequestAsync(BigInteger id);

        public Task<TransactionReceipt> WithdrawInvestmentRequestAndWaitForReceiptAsync(BigInteger id, CancellationTokenSource cancellationToken = null);

        public Task<string> WithdrawLeftOversRequestAsync(WithdrawLeftOversFunction withdrawLeftOversFunction);

        public Task<TransactionReceipt> WithdrawLeftOversRequestAndWaitForReceiptAsync(WithdrawLeftOversFunction withdrawLeftOversFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> WithdrawLeftOversRequestAsync(BigInteger poolId);

        public Task<TransactionReceipt> WithdrawLeftOversRequestAndWaitForReceiptAsync(BigInteger poolId, CancellationTokenSource cancellationToken = null);

        public Task<BigInteger> GetTotalInvestorQueryAsync(GetTotalInvestorFunction getTotalInvestorFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> GetTotalInvestorQueryAsync(BlockParameter blockParameter = null);

        public Task<bool> IsPoolLockedQueryAsync(IsPoolLockedFunction isPoolLockedFunction, BlockParameter blockParameter = null);

        public Task<bool> IsPoolLockedQueryAsync(BigInteger id, BlockParameter blockParameter = null);

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null);

        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null);

        public Task<bool> PausedQueryAsync(PausedFunction pausedFunction, BlockParameter blockParameter = null);

        public Task<bool> PausedQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> PoolsCountQueryAsync(PoolsCountFunction poolsCountFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> PoolsCountQueryAsync(BlockParameter blockParameter = null);

        public Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction);

        public Task<string> RenounceOwnershipRequestAsync();

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null);

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null);

        public Task<string> SetGovernerContractRequestAsync(SetGovernerContractFunction setGovernerContractFunction);

        public Task<TransactionReceipt> SetGovernerContractRequestAndWaitForReceiptAsync(SetGovernerContractFunction setGovernerContractFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetGovernerContractRequestAsync(string address);

        public Task<TransactionReceipt> SetGovernerContractRequestAndWaitForReceiptAsync(string address, CancellationTokenSource cancellationToken = null);

        public Task<string> SetMCWhitelistIdRequestAsync(SetMCWhitelistIdFunction setMCWhitelistIdFunction);

        public Task<TransactionReceipt> SetMCWhitelistIdRequestAndWaitForReceiptAsync(SetMCWhitelistIdFunction setMCWhitelistIdFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetMCWhitelistIdRequestAsync(BigInteger whiteListId);

        public Task<TransactionReceipt> SetMCWhitelistIdRequestAndWaitForReceiptAsync(BigInteger whiteListId, CancellationTokenSource cancellationToken = null);

        public Task<string> SetTokenWhitelistIdRequestAsync(SetTokenWhitelistIdFunction setTokenWhitelistIdFunction);

        public Task<TransactionReceipt> SetTokenWhitelistIdRequestAndWaitForReceiptAsync(SetTokenWhitelistIdFunction setTokenWhitelistIdFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetTokenWhitelistIdRequestAsync(BigInteger whiteListId);

        public Task<TransactionReceipt> SetTokenWhitelistIdRequestAndWaitForReceiptAsync(BigInteger whiteListId, CancellationTokenSource cancellationToken = null);

        public Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction);

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> TransferOwnershipRequestAsync(string newOwner);

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null);

        public Task<string> WithdrawETHFeeRequestAsync(WithdrawETHFeeFunction withdrawETHFeeFunction);

        public Task<TransactionReceipt> WithdrawETHFeeRequestAndWaitForReceiptAsync(WithdrawETHFeeFunction withdrawETHFeeFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> WithdrawETHFeeRequestAsync(string to);

        public Task<TransactionReceipt> WithdrawETHFeeRequestAndWaitForReceiptAsync(string to, CancellationTokenSource cancellationToken = null);

        public Task<string> WithdrawERC20FeeRequestAsync(WithdrawERC20FeeFunction withdrawERC20FeeFunction);

        public Task<TransactionReceipt> WithdrawERC20FeeRequestAndWaitForReceiptAsync(WithdrawERC20FeeFunction withdrawERC20FeeFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> WithdrawERC20FeeRequestAsync(string token, string to);

        public Task<TransactionReceipt> WithdrawERC20FeeRequestAndWaitForReceiptAsync(string token, string to, CancellationTokenSource cancellationToken = null);

        public void Initialize(IWeb3 web3, string contractAddress);
    }
}
