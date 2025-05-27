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
        Task<string> BenefitAddressQueryAsync(long chainId, Enum contractType, BenefitAddressFunction benefitAddressFunction, BlockParameter blockParameter = null);

        Task<string> BenefitAddressQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> CreatePoolRequestAsync(long chainId, Enum contractType, CreatePoolFunction createPoolFunction);

        Task<TransactionReceipt> CreatePoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CreatePoolFunction createPoolFunction, CancellationTokenSource cancellationToken = null);

        Task<string> CreatePoolRequestAsync(long chainId, Enum contractType, string token, BigInteger finishTime, BigInteger rate, BigInteger pOZRate, BigInteger startAmount, ulong lockedUntil, string mainCoin, bool is21Decimal, BigInteger now, BigInteger whiteListId);

        Task<TransactionReceipt> CreatePoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string token, BigInteger finishTime, BigInteger rate, BigInteger pOZRate, BigInteger startAmount, ulong lockedUntil, string mainCoin, bool is21Decimal, BigInteger now, BigInteger whiteListId, CancellationTokenSource cancellationToken = null);

        Task<BigInteger> FeeQueryAsync(long chainId, Enum contractType, FeeFunction feeFunction, BlockParameter blockParameter = null);

        Task<BigInteger> FeeQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<GetInvestmentDataOutputDTO> GetInvestmentDataQueryAsync(long chainId, Enum contractType, GetInvestmentDataFunction getInvestmentDataFunction, BlockParameter blockParameter = null);

        Task<GetInvestmentDataOutputDTO> GetInvestmentDataQueryAsync(long chainId, Enum contractType, BigInteger id, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetMyInvestmentIdsQueryAsync(long chainId, Enum contractType, GetMyInvestmentIdsFunction getMyInvestmentIdsFunction, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetMyInvestmentIdsQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetMyPoolsIdQueryAsync(long chainId, Enum contractType, GetMyPoolsIdFunction getMyPoolsIdFunction, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetMyPoolsIdQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<GetPoolBaseDataOutputDTO> GetPoolBaseDataQueryAsync(long chainId, Enum contractType, GetPoolBaseDataFunction getPoolBaseDataFunction, BlockParameter blockParameter = null);

        Task<GetPoolBaseDataOutputDTO> GetPoolBaseDataQueryAsync(long chainId, Enum contractType, BigInteger id, BlockParameter blockParameter = null);

        Task<GetPoolExtraDataOutputDTO> GetPoolExtraDataQueryAsync(long chainId, Enum contractType, GetPoolExtraDataFunction getPoolExtraDataFunction, BlockParameter blockParameter = null);

        Task<GetPoolExtraDataOutputDTO> GetPoolExtraDataQueryAsync(long chainId, Enum contractType, BigInteger id, BlockParameter blockParameter = null);

        Task<GetPoolMoreDataOutputDTO> GetPoolMoreDataQueryAsync(long chainId, Enum contractType, GetPoolMoreDataFunction getPoolMoreDataFunction, BlockParameter blockParameter = null);

        Task<GetPoolMoreDataOutputDTO> GetPoolMoreDataQueryAsync(long chainId, Enum contractType, BigInteger id, BlockParameter blockParameter = null);

        Task<byte> GetPoolStatusQueryAsync(long chainId, Enum contractType, GetPoolStatusFunction getPoolStatusFunction, BlockParameter blockParameter = null);

        Task<byte> GetPoolStatusQueryAsync(long chainId, Enum contractType, BigInteger id, BlockParameter blockParameter = null);

        Task<string> GovernerContractQueryAsync(long chainId, Enum contractType, GovernerContractFunction governerContractFunction, BlockParameter blockParameter = null);

        Task<string> GovernerContractQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> InvestERC20RequestAsync(long chainId, Enum contractType, InvestERC20Function investERC20Function);

        Task<TransactionReceipt> InvestERC20RequestAndWaitForReceiptAsync(long chainId, Enum contractType, InvestERC20Function investERC20Function, CancellationTokenSource cancellationToken = null);

        Task<string> InvestERC20RequestAsync(long chainId, Enum contractType, BigInteger poolId, BigInteger amount);

        Task<TransactionReceipt> InvestERC20RequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger poolId, BigInteger amount, CancellationTokenSource cancellationToken = null);

        Task<string> InvestETHRequestAsync(long chainId, Enum contractType, InvestETHFunction investETHFunction);

        Task<TransactionReceipt> InvestETHRequestAndWaitForReceiptAsync(long chainId, Enum contractType, InvestETHFunction investETHFunction, CancellationTokenSource cancellationToken = null);

        Task<string> InvestETHRequestAsync(long chainId, Enum contractType, BigInteger poolId);

        Task<TransactionReceipt> InvestETHRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger poolId, CancellationTokenSource cancellationToken = null);

        Task<bool> IsERC20MaincoinQueryAsync(long chainId, Enum contractType, IsERC20MaincoinFunction isERC20MaincoinFunction, BlockParameter blockParameter = null);

        Task<bool> IsERC20MaincoinQueryAsync(long chainId, Enum contractType, string address, BlockParameter blockParameter = null);

        Task<bool> IsPaybleQueryAsync(long chainId, Enum contractType, IsPaybleFunction isPaybleFunction, BlockParameter blockParameter = null);

        Task<bool> IsPaybleQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<bool> IsReadyWithdrawInvestmentQueryAsync(long chainId, Enum contractType, IsReadyWithdrawInvestmentFunction isReadyWithdrawInvestmentFunction, BlockParameter blockParameter = null);

        Task<bool> IsReadyWithdrawInvestmentQueryAsync(long chainId, Enum contractType, BigInteger id, BlockParameter blockParameter = null);

        Task<bool> IsReadyWithdrawLeftOversQueryAsync(long chainId, Enum contractType, IsReadyWithdrawLeftOversFunction isReadyWithdrawLeftOversFunction, BlockParameter blockParameter = null);

        Task<bool> IsReadyWithdrawLeftOversQueryAsync(long chainId, Enum contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<bool> IsTokenFilterOnQueryAsync(long chainId, Enum contractType, IsTokenFilterOnFunction isTokenFilterOnFunction, BlockParameter blockParameter = null);

        Task<bool> IsTokenFilterOnQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<bool> IsValidTokenQueryAsync(long chainId, Enum contractType, IsValidTokenFunction isValidTokenFunction, BlockParameter blockParameter = null);

        Task<bool> IsValidTokenQueryAsync(long chainId, Enum contractType, string address, BlockParameter blockParameter = null);

        Task<BigInteger> MCWhitelistIdQueryAsync(long chainId, Enum contractType, MCWhitelistIdFunction mCWhitelistIdFunction, BlockParameter blockParameter = null);

        Task<BigInteger> MCWhitelistIdQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<BigInteger> MaxDurationQueryAsync(long chainId, Enum contractType, MaxDurationFunction maxDurationFunction, BlockParameter blockParameter = null);

        Task<BigInteger> MaxDurationQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<BigInteger> MaxETHInvestQueryAsync(long chainId, Enum contractType, MaxETHInvestFunction maxETHInvestFunction, BlockParameter blockParameter = null);

        Task<BigInteger> MaxETHInvestQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<BigInteger> MinDurationQueryAsync(long chainId, Enum contractType, MinDurationFunction minDurationFunction, BlockParameter blockParameter = null);

        Task<BigInteger> MinDurationQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<BigInteger> MinETHInvestQueryAsync(long chainId, Enum contractType, MinETHInvestFunction minETHInvestFunction, BlockParameter blockParameter = null);

        Task<BigInteger> MinETHInvestQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<BigInteger> PoolPriceQueryAsync(long chainId, Enum contractType, PoolPriceFunction poolPriceFunction, BlockParameter blockParameter = null);

        Task<BigInteger> PoolPriceQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<BigInteger> PozFeeQueryAsync(long chainId, Enum contractType, PozFeeFunction pozFeeFunction, BlockParameter blockParameter = null);

        Task<BigInteger> PozFeeQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<BigInteger> PozTimerQueryAsync(long chainId, Enum contractType, PozTimerFunction pozTimerFunction, BlockParameter blockParameter = null);

        Task<BigInteger> PozTimerQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> SetbenefitAddressRequestAsync(long chainId, Enum contractType, SetbenefitAddressFunction setbenefitAddressFunction);

        Task<TransactionReceipt> SetbenefitAddressRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetbenefitAddressFunction setbenefitAddressFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetbenefitAddressRequestAsync(long chainId, Enum contractType, string benefitAddress);

        Task<TransactionReceipt> SetbenefitAddressRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string benefitAddress, CancellationTokenSource cancellationToken = null);

        Task<string> SetFeeRequestAsync(long chainId, Enum contractType, SetFeeFunction setFeeFunction);

        Task<TransactionReceipt> SetFeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFeeFunction setFeeFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFeeRequestAsync(long chainId, Enum contractType, BigInteger fee);

        Task<TransactionReceipt> SetFeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger fee, CancellationTokenSource cancellationToken = null);

        Task<string> SetMinMaxDurationRequestAsync(long chainId, Enum contractType, SetMinMaxDurationFunction setMinMaxDurationFunction);

        Task<TransactionReceipt> SetMinMaxDurationRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetMinMaxDurationFunction setMinMaxDurationFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetMinMaxDurationRequestAsync(long chainId, Enum contractType, BigInteger minDuration, BigInteger maxDuration);

        Task<TransactionReceipt> SetMinMaxDurationRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger minDuration, BigInteger maxDuration, CancellationTokenSource cancellationToken = null);

        Task<string> SetMinMaxETHInvestRequestAsync(long chainId, Enum contractType, SetMinMaxETHInvestFunction setMinMaxETHInvestFunction);

        Task<TransactionReceipt> SetMinMaxETHInvestRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetMinMaxETHInvestFunction setMinMaxETHInvestFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetMinMaxETHInvestRequestAsync(long chainId, Enum contractType, BigInteger minETHInvest, BigInteger maxETHInvest);

        Task<TransactionReceipt> SetMinMaxETHInvestRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger minETHInvest, BigInteger maxETHInvest, CancellationTokenSource cancellationToken = null);

        Task<string> SetPOZFeeRequestAsync(long chainId, Enum contractType, SetPOZFeeFunction setPOZFeeFunction);

        Task<TransactionReceipt> SetPOZFeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetPOZFeeFunction setPOZFeeFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetPOZFeeRequestAsync(long chainId, Enum contractType, BigInteger fee);

        Task<TransactionReceipt> SetPOZFeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger fee, CancellationTokenSource cancellationToken = null);

        Task<string> SetPoolPriceRequestAsync(long chainId, Enum contractType, SetPoolPriceFunction setPoolPriceFunction);

        Task<TransactionReceipt> SetPoolPriceRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetPoolPriceFunction setPoolPriceFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetPoolPriceRequestAsync(long chainId, Enum contractType, BigInteger poolPrice);

        Task<TransactionReceipt> SetPoolPriceRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger poolPrice, CancellationTokenSource cancellationToken = null);

        Task<string> SetPozTimerRequestAsync(long chainId, Enum contractType, SetPozTimerFunction setPozTimerFunction);

        Task<TransactionReceipt> SetPozTimerRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetPozTimerFunction setPozTimerFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetPozTimerRequestAsync(long chainId, Enum contractType, BigInteger pozTimer);

        Task<TransactionReceipt> SetPozTimerRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger pozTimer, CancellationTokenSource cancellationToken = null);

        Task<string> SetwhitelistAddressRequestAsync(long chainId, Enum contractType, SetwhitelistAddressFunction setwhitelistAddressFunction);

        Task<TransactionReceipt> SetwhitelistAddressRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetwhitelistAddressFunction setwhitelistAddressFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetwhitelistAddressRequestAsync(long chainId, Enum contractType, string whitelistAddress);

        Task<TransactionReceipt> SetwhitelistAddressRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string whitelistAddress, CancellationTokenSource cancellationToken = null);

        Task<string> SwapTokenFilterRequestAsync(long chainId, Enum contractType, SwapTokenFilterFunction swapTokenFilterFunction);

        Task<string> SwapTokenFilterRequestAsync(long chainId, Enum contractType);

        Task<TransactionReceipt> SwapTokenFilterRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SwapTokenFilterFunction swapTokenFilterFunction, CancellationTokenSource cancellationToken = null);

        Task<TransactionReceipt> SwapTokenFilterRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CancellationTokenSource cancellationToken = null);

        Task<string> SwitchIsPaybleRequestAsync(long chainId, Enum contractType, SwitchIsPaybleFunction switchIsPaybleFunction);

        Task<string> SwitchIsPaybleRequestAsync(long chainId, Enum contractType);

        Task<TransactionReceipt> SwitchIsPaybleRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SwitchIsPaybleFunction switchIsPaybleFunction, CancellationTokenSource cancellationToken = null);

        Task<TransactionReceipt> SwitchIsPaybleRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CancellationTokenSource cancellationToken = null);

        Task<BigInteger> TokenWhitelistIdQueryAsync(long chainId, Enum contractType, TokenWhitelistIdFunction tokenWhitelistIdFunction, BlockParameter blockParameter = null);

        Task<BigInteger> TokenWhitelistIdQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> WhitelistAddressQueryAsync(long chainId, Enum contractType, WhitelistAddressFunction whitelistAddressFunction, BlockParameter blockParameter = null);

        Task<string> WhitelistAddressQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> WithdrawInvestmentRequestAsync(long chainId, Enum contractType, WithdrawInvestmentFunction withdrawInvestmentFunction);

        Task<TransactionReceipt> WithdrawInvestmentRequestAndWaitForReceiptAsync(long chainId, Enum contractType, WithdrawInvestmentFunction withdrawInvestmentFunction, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawInvestmentRequestAsync(long chainId, Enum contractType, BigInteger id);

        Task<TransactionReceipt> WithdrawInvestmentRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger id, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawLeftOversRequestAsync(long chainId, Enum contractType, WithdrawLeftOversFunction withdrawLeftOversFunction);

        Task<TransactionReceipt> WithdrawLeftOversRequestAndWaitForReceiptAsync(long chainId, Enum contractType, WithdrawLeftOversFunction withdrawLeftOversFunction, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawLeftOversRequestAsync(long chainId, Enum contractType, BigInteger poolId);

        Task<TransactionReceipt> WithdrawLeftOversRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger poolId, CancellationTokenSource cancellationToken = null);

        Task<BigInteger> GetTotalInvestorQueryAsync(long chainId, Enum contractType, GetTotalInvestorFunction getTotalInvestorFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetTotalInvestorQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<bool> IsPoolLockedQueryAsync(long chainId, Enum contractType, IsPoolLockedFunction isPoolLockedFunction, BlockParameter blockParameter = null);

        Task<bool> IsPoolLockedQueryAsync(long chainId, Enum contractType, BigInteger id, BlockParameter blockParameter = null);

        Task<string> OwnerQueryAsync(long chainId, Enum contractType, OwnerFunction ownerFunction, BlockParameter blockParameter = null);

        Task<string> OwnerQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<bool> PausedQueryAsync(long chainId, Enum contractType, PausedFunction pausedFunction, BlockParameter blockParameter = null);

        Task<bool> PausedQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<BigInteger> PoolsCountQueryAsync(long chainId, Enum contractType, PoolsCountFunction poolsCountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> PoolsCountQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> RenounceOwnershipRequestAsync(long chainId, Enum contractType, RenounceOwnershipFunction renounceOwnershipFunction);

        Task<string> RenounceOwnershipRequestAsync(long chainId, Enum contractType);

        Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null);

        Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CancellationTokenSource cancellationToken = null);

        Task<string> SetGovernerContractRequestAsync(long chainId, Enum contractType, SetGovernerContractFunction setGovernerContractFunction);

        Task<TransactionReceipt> SetGovernerContractRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetGovernerContractFunction setGovernerContractFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetGovernerContractRequestAsync(long chainId, Enum contractType, string address);

        Task<TransactionReceipt> SetGovernerContractRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string address, CancellationTokenSource cancellationToken = null);

        Task<string> SetMCWhitelistIdRequestAsync(long chainId, Enum contractType, SetMCWhitelistIdFunction setMCWhitelistIdFunction);

        Task<TransactionReceipt> SetMCWhitelistIdRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetMCWhitelistIdFunction setMCWhitelistIdFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetMCWhitelistIdRequestAsync(long chainId, Enum contractType, BigInteger whiteListId);

        Task<TransactionReceipt> SetMCWhitelistIdRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger whiteListId, CancellationTokenSource cancellationToken = null);

        Task<string> SetTokenWhitelistIdRequestAsync(long chainId, Enum contractType, SetTokenWhitelistIdFunction setTokenWhitelistIdFunction);

        Task<TransactionReceipt> SetTokenWhitelistIdRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetTokenWhitelistIdFunction setTokenWhitelistIdFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetTokenWhitelistIdRequestAsync(long chainId, Enum contractType, BigInteger whiteListId);

        Task<TransactionReceipt> SetTokenWhitelistIdRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger whiteListId, CancellationTokenSource cancellationToken = null);

        Task<string> TransferOwnershipRequestAsync(long chainId, Enum contractType, TransferOwnershipFunction transferOwnershipFunction);

        Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null);

        Task<string> TransferOwnershipRequestAsync(long chainId, Enum contractType, string newOwner);

        Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string newOwner, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawETHFeeRequestAsync(long chainId, Enum contractType, WithdrawETHFeeFunction withdrawETHFeeFunction);

        Task<TransactionReceipt> WithdrawETHFeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, WithdrawETHFeeFunction withdrawETHFeeFunction, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawETHFeeRequestAsync(long chainId, Enum contractType, string to);

        Task<TransactionReceipt> WithdrawETHFeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string to, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawERC20FeeRequestAsync(long chainId, Enum contractType, WithdrawERC20FeeFunction withdrawERC20FeeFunction);

        Task<TransactionReceipt> WithdrawERC20FeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, WithdrawERC20FeeFunction withdrawERC20FeeFunction, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawERC20FeeRequestAsync(long chainId, Enum contractType, string token, string to);

        Task<TransactionReceipt> WithdrawERC20FeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string token, string to, CancellationTokenSource cancellationToken = null);
    }
}
