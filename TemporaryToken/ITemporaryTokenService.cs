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
using poolz.finance.csharp.contracts.TemporaryToken.ContractDefinition;

namespace poolz.finance.csharp.contracts.TemporaryToken
{
    public interface ITemporaryTokenService
    {
        public Task<string> GovernorContractQueryAsync(GovernorContractFunction governorContractFunction, BlockParameter blockParameter = null);

        public Task<string> GovernorContractQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> AllowanceQueryAsync(AllowanceFunction allowanceFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> AllowanceQueryAsync(string owner, string spender, BlockParameter blockParameter = null);

        public Task<string> ApproveRequestAsync(ApproveFunction approveFunction);

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> ApproveRequestAsync(string spender, BigInteger amount);

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(string spender, BigInteger amount, CancellationTokenSource cancellationToken = null);

        public Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> BalanceOfQueryAsync(string account, BlockParameter blockParameter = null);

        public Task<BigInteger> CapQueryAsync(CapFunction capFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> CapQueryAsync(BlockParameter blockParameter = null);

        public Task<string> DecreaseAllowanceRequestAsync(DecreaseAllowanceFunction decreaseAllowanceFunction);

        public Task<TransactionReceipt> DecreaseAllowanceRequestAndWaitForReceiptAsync(DecreaseAllowanceFunction decreaseAllowanceFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> DecreaseAllowanceRequestAsync(string spender, BigInteger subtractedValue);

        public Task<TransactionReceipt> DecreaseAllowanceRequestAndWaitForReceiptAsync(string spender, BigInteger subtractedValue, CancellationTokenSource cancellationToken = null);

        public Task<string> IncreaseAllowanceRequestAsync(IncreaseAllowanceFunction increaseAllowanceFunction);

        public Task<TransactionReceipt> IncreaseAllowanceRequestAndWaitForReceiptAsync(IncreaseAllowanceFunction increaseAllowanceFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> IncreaseAllowanceRequestAsync(string spender, BigInteger addedValue);

        public Task<TransactionReceipt> IncreaseAllowanceRequestAndWaitForReceiptAsync(string spender, BigInteger addedValue, CancellationTokenSource cancellationToken = null);

        public Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null);

        public Task<string> NameQueryAsync(BlockParameter blockParameter = null);

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null);

        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null);

        public Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction);

        public Task<string> RenounceOwnershipRequestAsync();

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null);

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null);

        public Task<string> SetGovernorContractRequestAsync(SetGovernorContractFunction setGovernorContractFunction);

        public Task<TransactionReceipt> SetGovernorContractRequestAndWaitForReceiptAsync(SetGovernorContractFunction setGovernorContractFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetGovernorContractRequestAsync(string address);

        public Task<TransactionReceipt> SetGovernorContractRequestAndWaitForReceiptAsync(string address, CancellationTokenSource cancellationToken = null);

        public Task<string> SymbolQueryAsync(SymbolFunction symbolFunction, BlockParameter blockParameter = null);

        public Task<string> SymbolQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> TotalSupplyQueryAsync(TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> TotalSupplyQueryAsync(BlockParameter blockParameter = null);

        public Task<string> TransferRequestAsync(TransferFunction transferFunction);

        public Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(TransferFunction transferFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> TransferRequestAsync(string to, BigInteger amount);

        public Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(string to, BigInteger amount, CancellationTokenSource cancellationToken = null);

        public Task<string> TransferFromRequestAsync(TransferFromFunction transferFromFunction);

        public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(TransferFromFunction transferFromFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> TransferFromRequestAsync(string from, string to, BigInteger amount);

        public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger amount, CancellationTokenSource cancellationToken = null);

        public Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction);

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> TransferOwnershipRequestAsync(string newOwner);

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null);

        public Task<string> DestroyRequestAsync(DestroyFunction destroyFunction);

        public Task<string> DestroyRequestAsync();

        public Task<TransactionReceipt> DestroyRequestAndWaitForReceiptAsync(DestroyFunction destroyFunction, CancellationTokenSource cancellationToken = null);

        public Task<TransactionReceipt> DestroyRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null);

        public Task<byte> DecimalsQueryAsync(DecimalsFunction decimalsFunction, BlockParameter blockParameter = null);

        public Task<byte> DecimalsQueryAsync(BlockParameter blockParameter = null);

        public void Initialize(IWeb3 web3, string contractAddress);
    }
}
