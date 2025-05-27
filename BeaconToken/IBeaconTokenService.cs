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
using poolz.finance.csharp.contracts.BeaconToken.ContractDefinition;

namespace poolz.finance.csharp.contracts.BeaconToken
{
    public interface IBeaconTokenService
    {
        Task<BigInteger> AllowanceQueryAsync(long chainId, Enum contractType, AllowanceFunction allowanceFunction, BlockParameter blockParameter = null);

        Task<BigInteger> AllowanceQueryAsync(long chainId, Enum contractType, string owner, string spender, BlockParameter blockParameter = null);

        Task<string> ApproveRequestAsync(long chainId, Enum contractType, ApproveFunction approveFunction);

        Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(long chainId, Enum contractType, ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null);

        Task<string> ApproveRequestAsync(long chainId, Enum contractType, string spender, BigInteger amount);

        Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string spender, BigInteger amount, CancellationTokenSource cancellationToken = null);

        Task<BigInteger> BalanceOfQueryAsync(long chainId, Enum contractType, BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null);

        Task<BigInteger> BalanceOfQueryAsync(long chainId, Enum contractType, string account, BlockParameter blockParameter = null);

        Task<string> BurnRequestAsync(long chainId, Enum contractType, BurnFunction burnFunction);

        Task<TransactionReceipt> BurnRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BurnFunction burnFunction, CancellationTokenSource cancellationToken = null);

        Task<string> BurnRequestAsync(long chainId, Enum contractType, BigInteger amount);

        Task<TransactionReceipt> BurnRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger amount, CancellationTokenSource cancellationToken = null);

        Task<string> BurnFromRequestAsync(long chainId, Enum contractType, BurnFromFunction burnFromFunction);

        Task<TransactionReceipt> BurnFromRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BurnFromFunction burnFromFunction, CancellationTokenSource cancellationToken = null);

        Task<string> BurnFromRequestAsync(long chainId, Enum contractType, string account, BigInteger amount);

        Task<TransactionReceipt> BurnFromRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string account, BigInteger amount, CancellationTokenSource cancellationToken = null);

        Task<BigInteger> CapQueryAsync(long chainId, Enum contractType, CapFunction capFunction, BlockParameter blockParameter = null);

        Task<BigInteger> CapQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> DecreaseAllowanceRequestAsync(long chainId, Enum contractType, DecreaseAllowanceFunction decreaseAllowanceFunction);

        Task<TransactionReceipt> DecreaseAllowanceRequestAndWaitForReceiptAsync(long chainId, Enum contractType, DecreaseAllowanceFunction decreaseAllowanceFunction, CancellationTokenSource cancellationToken = null);

        Task<string> DecreaseAllowanceRequestAsync(long chainId, Enum contractType, string spender, BigInteger subtractedValue);

        Task<TransactionReceipt> DecreaseAllowanceRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string spender, BigInteger subtractedValue, CancellationTokenSource cancellationToken = null);

        Task<string> IncreaseAllowanceRequestAsync(long chainId, Enum contractType, IncreaseAllowanceFunction increaseAllowanceFunction);

        Task<TransactionReceipt> IncreaseAllowanceRequestAndWaitForReceiptAsync(long chainId, Enum contractType, IncreaseAllowanceFunction increaseAllowanceFunction, CancellationTokenSource cancellationToken = null);

        Task<string> IncreaseAllowanceRequestAsync(long chainId, Enum contractType, string spender, BigInteger addedValue);

        Task<TransactionReceipt> IncreaseAllowanceRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string spender, BigInteger addedValue, CancellationTokenSource cancellationToken = null);

        Task<string> NameQueryAsync(long chainId, Enum contractType, NameFunction nameFunction, BlockParameter blockParameter = null);

        Task<string> NameQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> SymbolQueryAsync(long chainId, Enum contractType, SymbolFunction symbolFunction, BlockParameter blockParameter = null);

        Task<string> SymbolQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<BigInteger> TotalSupplyQueryAsync(long chainId, Enum contractType, TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null);

        Task<BigInteger> TotalSupplyQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> TransferRequestAsync(long chainId, Enum contractType, TransferFunction transferFunction);

        Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(long chainId, Enum contractType, TransferFunction transferFunction, CancellationTokenSource cancellationToken = null);

        Task<string> TransferRequestAsync(long chainId, Enum contractType, string to, BigInteger amount);

        Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string to, BigInteger amount, CancellationTokenSource cancellationToken = null);

        Task<string> TransferFromRequestAsync(long chainId, Enum contractType, TransferFromFunction transferFromFunction);

        Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(long chainId, Enum contractType, TransferFromFunction transferFromFunction, CancellationTokenSource cancellationToken = null);

        Task<string> TransferFromRequestAsync(long chainId, Enum contractType, string from, string to, BigInteger amount);

        Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string from, string to, BigInteger amount, CancellationTokenSource cancellationToken = null);

        Task<byte> DecimalsQueryAsync(long chainId, Enum contractType, DecimalsFunction decimalsFunction, BlockParameter blockParameter = null);

        Task<byte> DecimalsQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> ActivateBeaconRequestAsync(long chainId, Enum contractType, ActivateBeaconFunction activateBeaconFunction);

        Task<TransactionReceipt> ActivateBeaconRequestAndWaitForReceiptAsync(long chainId, Enum contractType, ActivateBeaconFunction activateBeaconFunction, CancellationTokenSource cancellationToken = null);

        Task<string> ActivateBeaconRequestAsync(long chainId, Enum contractType, byte[] address);

        Task<TransactionReceipt> ActivateBeaconRequestAndWaitForReceiptAsync(long chainId, Enum contractType, byte[] address, CancellationTokenSource cancellationToken = null);

        Task<string> ActivateBeaconRequestAsync(long chainId, Enum contractType, ActivateBeacon1Function activateBeacon1Function);

        Task<TransactionReceipt> ActivateBeaconRequestAndWaitForReceiptAsync(long chainId, Enum contractType, ActivateBeacon1Function activateBeacon1Function, CancellationTokenSource cancellationToken = null);

        Task<string> ActivateBeaconRequestAsync(long chainId, Enum contractType, byte[] address, BigInteger amount);

        Task<TransactionReceipt> ActivateBeaconRequestAndWaitForReceiptAsync(long chainId, Enum contractType, byte[] address, BigInteger amount, CancellationTokenSource cancellationToken = null);
    }
}
