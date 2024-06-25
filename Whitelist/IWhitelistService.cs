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
using poolz.finance.csharp.contracts.Whitelist.ContractDefinition;

namespace poolz.finance.csharp.contracts.Whitelist
{
    public interface IWhitelistService
    {
        public Task<BigInteger> CheckQueryAsync(CheckFunction checkFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> CheckQueryAsync(string user, BigInteger id, BlockParameter blockParameter = null);

        public Task<BigInteger> MaxUsersLimitQueryAsync(MaxUsersLimitFunction maxUsersLimitFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> MaxUsersLimitQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> WhiteListCostQueryAsync(WhiteListCostFunction whiteListCostFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> WhiteListCostQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> WhiteListCountQueryAsync(WhiteListCountFunction whiteListCountFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> WhiteListCountQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> WhitelistDBQueryAsync(WhitelistDBFunction whitelistDBFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> WhitelistDBQueryAsync(BigInteger returnValue1, string returnValue2, BlockParameter blockParameter = null);

        public Task<WhitelistSettingsOutputDTO> WhitelistSettingsQueryAsync(WhitelistSettingsFunction whitelistSettingsFunction, BlockParameter blockParameter = null);

        public Task<WhitelistSettingsOutputDTO> WhitelistSettingsQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null);

        public Task<bool> IsWhiteListReadyQueryAsync(IsWhiteListReadyFunction isWhiteListReadyFunction, BlockParameter blockParameter = null);

        public Task<bool> IsWhiteListReadyQueryAsync(BigInteger id, BlockParameter blockParameter = null);

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null);

        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null);

        public Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction);

        public Task<string> RenounceOwnershipRequestAsync();

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null);

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null);

        public Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction);

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> TransferOwnershipRequestAsync(string newOwner);

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null);

        public Task<string> SetMaxUsersLimitRequestAsync(SetMaxUsersLimitFunction setMaxUsersLimitFunction);

        public Task<TransactionReceipt> SetMaxUsersLimitRequestAndWaitForReceiptAsync(SetMaxUsersLimitFunction setMaxUsersLimitFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetMaxUsersLimitRequestAsync(BigInteger limit);

        public Task<TransactionReceipt> SetMaxUsersLimitRequestAndWaitForReceiptAsync(BigInteger limit, CancellationTokenSource cancellationToken = null);

        public Task<string> WithdrawETHFeeRequestAsync(WithdrawETHFeeFunction withdrawETHFeeFunction);

        public Task<TransactionReceipt> WithdrawETHFeeRequestAndWaitForReceiptAsync(WithdrawETHFeeFunction withdrawETHFeeFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> WithdrawETHFeeRequestAsync(string to);

        public Task<TransactionReceipt> WithdrawETHFeeRequestAndWaitForReceiptAsync(string to, CancellationTokenSource cancellationToken = null);

        public Task<string> SetWhiteListCostRequestAsync(SetWhiteListCostFunction setWhiteListCostFunction);

        public Task<TransactionReceipt> SetWhiteListCostRequestAndWaitForReceiptAsync(SetWhiteListCostFunction setWhiteListCostFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetWhiteListCostRequestAsync(BigInteger newCost);

        public Task<TransactionReceipt> SetWhiteListCostRequestAndWaitForReceiptAsync(BigInteger newCost, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateManualWhiteListRequestAsync(CreateManualWhiteListFunction createManualWhiteListFunction);

        public Task<TransactionReceipt> CreateManualWhiteListRequestAndWaitForReceiptAsync(CreateManualWhiteListFunction createManualWhiteListFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateManualWhiteListRequestAsync(BigInteger changeUntil, string contract);

        public Task<TransactionReceipt> CreateManualWhiteListRequestAndWaitForReceiptAsync(BigInteger changeUntil, string contract, CancellationTokenSource cancellationToken = null);

        public Task<string> ChangeCreatorRequestAsync(ChangeCreatorFunction changeCreatorFunction);

        public Task<TransactionReceipt> ChangeCreatorRequestAndWaitForReceiptAsync(ChangeCreatorFunction changeCreatorFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> ChangeCreatorRequestAsync(BigInteger id, string newCreator);

        public Task<TransactionReceipt> ChangeCreatorRequestAndWaitForReceiptAsync(BigInteger id, string newCreator, CancellationTokenSource cancellationToken = null);

        public Task<string> ChangeContractRequestAsync(ChangeContractFunction changeContractFunction);

        public Task<TransactionReceipt> ChangeContractRequestAndWaitForReceiptAsync(ChangeContractFunction changeContractFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> ChangeContractRequestAsync(BigInteger id, string newContract);

        public Task<TransactionReceipt> ChangeContractRequestAndWaitForReceiptAsync(BigInteger id, string newContract, CancellationTokenSource cancellationToken = null);

        public Task<string> AddAddressRequestAsync(AddAddressFunction addAddressFunction);

        public Task<TransactionReceipt> AddAddressRequestAndWaitForReceiptAsync(AddAddressFunction addAddressFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> AddAddressRequestAsync(BigInteger id, List<string> users, List<BigInteger> amount);

        public Task<TransactionReceipt> AddAddressRequestAndWaitForReceiptAsync(BigInteger id, List<string> users, List<BigInteger> amount, CancellationTokenSource cancellationToken = null);

        public Task<string> RemoveAddressRequestAsync(RemoveAddressFunction removeAddressFunction);

        public Task<TransactionReceipt> RemoveAddressRequestAndWaitForReceiptAsync(RemoveAddressFunction removeAddressFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> RemoveAddressRequestAsync(BigInteger id, List<string> users);

        public Task<TransactionReceipt> RemoveAddressRequestAndWaitForReceiptAsync(BigInteger id, List<string> users, CancellationTokenSource cancellationToken = null);

        public Task<string> RegisterRequestAsync(RegisterFunction registerFunction);

        public Task<TransactionReceipt> RegisterRequestAndWaitForReceiptAsync(RegisterFunction registerFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> RegisterRequestAsync(string subject, BigInteger id, BigInteger amount);

        public Task<TransactionReceipt> RegisterRequestAndWaitForReceiptAsync(string subject, BigInteger id, BigInteger amount, CancellationTokenSource cancellationToken = null);

        public Task<string> LastRoundRegisterRequestAsync(LastRoundRegisterFunction lastRoundRegisterFunction);

        public Task<TransactionReceipt> LastRoundRegisterRequestAndWaitForReceiptAsync(LastRoundRegisterFunction lastRoundRegisterFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> LastRoundRegisterRequestAsync(string subject, BigInteger id);

        public Task<TransactionReceipt> LastRoundRegisterRequestAndWaitForReceiptAsync(string subject, BigInteger id, CancellationTokenSource cancellationToken = null);

        public void Initialize(IWeb3 web3, string contractAddress);
    }
}
