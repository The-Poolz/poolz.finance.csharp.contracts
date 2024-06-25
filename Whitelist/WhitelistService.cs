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
    public partial class WhitelistService : IWhitelistService
    {
        protected virtual IWeb3 Web3 { get; private set; }

        public virtual ContractHandler ContractHandler { get; private set; }

        public WhitelistService() { }

        public WhitelistService(Web3 web3, string contractAddress)
        {
            Initialize(web3, contractAddress);
        }

        public WhitelistService(IWeb3 web3, string contractAddress)
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

        public virtual Task<BigInteger> CheckQueryAsync(CheckFunction checkFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<CheckFunction, BigInteger>(checkFunction, blockParameter);
        }

        public virtual Task<BigInteger> CheckQueryAsync(string user, BigInteger id, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var checkFunction = new CheckFunction();
                checkFunction.User = user;
                checkFunction.Id = id;
            
            return ContractHandler.QueryAsync<CheckFunction, BigInteger>(checkFunction, blockParameter);
        }

        public virtual Task<BigInteger> MaxUsersLimitQueryAsync(MaxUsersLimitFunction maxUsersLimitFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<MaxUsersLimitFunction, BigInteger>(maxUsersLimitFunction, blockParameter);
        }

        public virtual Task<BigInteger> MaxUsersLimitQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<MaxUsersLimitFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> WhiteListCostQueryAsync(WhiteListCostFunction whiteListCostFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<WhiteListCostFunction, BigInteger>(whiteListCostFunction, blockParameter);
        }

        public virtual Task<BigInteger> WhiteListCostQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<WhiteListCostFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> WhiteListCountQueryAsync(WhiteListCountFunction whiteListCountFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<WhiteListCountFunction, BigInteger>(whiteListCountFunction, blockParameter);
        }

        public virtual Task<BigInteger> WhiteListCountQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<WhiteListCountFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<BigInteger> WhitelistDBQueryAsync(WhitelistDBFunction whitelistDBFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<WhitelistDBFunction, BigInteger>(whitelistDBFunction, blockParameter);
        }

        public virtual Task<BigInteger> WhitelistDBQueryAsync(BigInteger returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var whitelistDBFunction = new WhitelistDBFunction();
                whitelistDBFunction.ReturnValue1 = returnValue1;
                whitelistDBFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<WhitelistDBFunction, BigInteger>(whitelistDBFunction, blockParameter);
        }

        public virtual Task<WhitelistSettingsOutputDTO> WhitelistSettingsQueryAsync(WhitelistSettingsFunction whitelistSettingsFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryDeserializingToObjectAsync<WhitelistSettingsFunction, WhitelistSettingsOutputDTO>(whitelistSettingsFunction, blockParameter);
        }

        public virtual Task<WhitelistSettingsOutputDTO> WhitelistSettingsQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var whitelistSettingsFunction = new WhitelistSettingsFunction();
                whitelistSettingsFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryDeserializingToObjectAsync<WhitelistSettingsFunction, WhitelistSettingsOutputDTO>(whitelistSettingsFunction, blockParameter);
        }

        public virtual Task<bool> IsWhiteListReadyQueryAsync(IsWhiteListReadyFunction isWhiteListReadyFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<IsWhiteListReadyFunction, bool>(isWhiteListReadyFunction, blockParameter);
        }

        public virtual Task<bool> IsWhiteListReadyQueryAsync(BigInteger id, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var isWhiteListReadyFunction = new IsWhiteListReadyFunction();
                isWhiteListReadyFunction.Id = id;
            
            return ContractHandler.QueryAsync<IsWhiteListReadyFunction, bool>(isWhiteListReadyFunction, blockParameter);
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

        public virtual Task<string> SetMaxUsersLimitRequestAsync(SetMaxUsersLimitFunction setMaxUsersLimitFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setMaxUsersLimitFunction);
        }

        public virtual Task<TransactionReceipt> SetMaxUsersLimitRequestAndWaitForReceiptAsync(SetMaxUsersLimitFunction setMaxUsersLimitFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setMaxUsersLimitFunction, cancellationToken);
        }

        public virtual Task<string> SetMaxUsersLimitRequestAsync(BigInteger limit)
        {
            EnsureInitialized();
            var setMaxUsersLimitFunction = new SetMaxUsersLimitFunction();
                setMaxUsersLimitFunction.Limit = limit;
            
            return ContractHandler.SendRequestAsync(setMaxUsersLimitFunction);
        }

        public virtual Task<TransactionReceipt> SetMaxUsersLimitRequestAndWaitForReceiptAsync(BigInteger limit, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setMaxUsersLimitFunction = new SetMaxUsersLimitFunction();
                setMaxUsersLimitFunction.Limit = limit;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setMaxUsersLimitFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawETHFeeRequestAsync(WithdrawETHFeeFunction withdrawETHFeeFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(withdrawETHFeeFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawETHFeeRequestAndWaitForReceiptAsync(WithdrawETHFeeFunction withdrawETHFeeFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawETHFeeFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawETHFeeRequestAsync(string to)
        {
            EnsureInitialized();
            var withdrawETHFeeFunction = new WithdrawETHFeeFunction();
                withdrawETHFeeFunction.To = to;
            
            return ContractHandler.SendRequestAsync(withdrawETHFeeFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawETHFeeRequestAndWaitForReceiptAsync(string to, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var withdrawETHFeeFunction = new WithdrawETHFeeFunction();
                withdrawETHFeeFunction.To = to;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawETHFeeFunction, cancellationToken);
        }

        public virtual Task<string> SetWhiteListCostRequestAsync(SetWhiteListCostFunction setWhiteListCostFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setWhiteListCostFunction);
        }

        public virtual Task<TransactionReceipt> SetWhiteListCostRequestAndWaitForReceiptAsync(SetWhiteListCostFunction setWhiteListCostFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setWhiteListCostFunction, cancellationToken);
        }

        public virtual Task<string> SetWhiteListCostRequestAsync(BigInteger newCost)
        {
            EnsureInitialized();
            var setWhiteListCostFunction = new SetWhiteListCostFunction();
                setWhiteListCostFunction.NewCost = newCost;
            
            return ContractHandler.SendRequestAsync(setWhiteListCostFunction);
        }

        public virtual Task<TransactionReceipt> SetWhiteListCostRequestAndWaitForReceiptAsync(BigInteger newCost, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setWhiteListCostFunction = new SetWhiteListCostFunction();
                setWhiteListCostFunction.NewCost = newCost;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setWhiteListCostFunction, cancellationToken);
        }

        public virtual Task<string> CreateManualWhiteListRequestAsync(CreateManualWhiteListFunction createManualWhiteListFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(createManualWhiteListFunction);
        }

        public virtual Task<TransactionReceipt> CreateManualWhiteListRequestAndWaitForReceiptAsync(CreateManualWhiteListFunction createManualWhiteListFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(createManualWhiteListFunction, cancellationToken);
        }

        public virtual Task<string> CreateManualWhiteListRequestAsync(BigInteger changeUntil, string contract)
        {
            EnsureInitialized();
            var createManualWhiteListFunction = new CreateManualWhiteListFunction();
                createManualWhiteListFunction.ChangeUntil = changeUntil;
                createManualWhiteListFunction.Contract = contract;
            
            return ContractHandler.SendRequestAsync(createManualWhiteListFunction);
        }

        public virtual Task<TransactionReceipt> CreateManualWhiteListRequestAndWaitForReceiptAsync(BigInteger changeUntil, string contract, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var createManualWhiteListFunction = new CreateManualWhiteListFunction();
                createManualWhiteListFunction.ChangeUntil = changeUntil;
                createManualWhiteListFunction.Contract = contract;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(createManualWhiteListFunction, cancellationToken);
        }

        public virtual Task<string> ChangeCreatorRequestAsync(ChangeCreatorFunction changeCreatorFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(changeCreatorFunction);
        }

        public virtual Task<TransactionReceipt> ChangeCreatorRequestAndWaitForReceiptAsync(ChangeCreatorFunction changeCreatorFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(changeCreatorFunction, cancellationToken);
        }

        public virtual Task<string> ChangeCreatorRequestAsync(BigInteger id, string newCreator)
        {
            EnsureInitialized();
            var changeCreatorFunction = new ChangeCreatorFunction();
                changeCreatorFunction.Id = id;
                changeCreatorFunction.NewCreator = newCreator;
            
            return ContractHandler.SendRequestAsync(changeCreatorFunction);
        }

        public virtual Task<TransactionReceipt> ChangeCreatorRequestAndWaitForReceiptAsync(BigInteger id, string newCreator, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var changeCreatorFunction = new ChangeCreatorFunction();
                changeCreatorFunction.Id = id;
                changeCreatorFunction.NewCreator = newCreator;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(changeCreatorFunction, cancellationToken);
        }

        public virtual Task<string> ChangeContractRequestAsync(ChangeContractFunction changeContractFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(changeContractFunction);
        }

        public virtual Task<TransactionReceipt> ChangeContractRequestAndWaitForReceiptAsync(ChangeContractFunction changeContractFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(changeContractFunction, cancellationToken);
        }

        public virtual Task<string> ChangeContractRequestAsync(BigInteger id, string newContract)
        {
            EnsureInitialized();
            var changeContractFunction = new ChangeContractFunction();
                changeContractFunction.Id = id;
                changeContractFunction.NewContract = newContract;
            
            return ContractHandler.SendRequestAsync(changeContractFunction);
        }

        public virtual Task<TransactionReceipt> ChangeContractRequestAndWaitForReceiptAsync(BigInteger id, string newContract, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var changeContractFunction = new ChangeContractFunction();
                changeContractFunction.Id = id;
                changeContractFunction.NewContract = newContract;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(changeContractFunction, cancellationToken);
        }

        public virtual Task<string> AddAddressRequestAsync(AddAddressFunction addAddressFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(addAddressFunction);
        }

        public virtual Task<TransactionReceipt> AddAddressRequestAndWaitForReceiptAsync(AddAddressFunction addAddressFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(addAddressFunction, cancellationToken);
        }

        public virtual Task<string> AddAddressRequestAsync(BigInteger id, List<string> users, List<BigInteger> amount)
        {
            EnsureInitialized();
            var addAddressFunction = new AddAddressFunction();
                addAddressFunction.Id = id;
                addAddressFunction.Users = users;
                addAddressFunction.Amount = amount;
            
            return ContractHandler.SendRequestAsync(addAddressFunction);
        }

        public virtual Task<TransactionReceipt> AddAddressRequestAndWaitForReceiptAsync(BigInteger id, List<string> users, List<BigInteger> amount, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var addAddressFunction = new AddAddressFunction();
                addAddressFunction.Id = id;
                addAddressFunction.Users = users;
                addAddressFunction.Amount = amount;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(addAddressFunction, cancellationToken);
        }

        public virtual Task<string> RemoveAddressRequestAsync(RemoveAddressFunction removeAddressFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(removeAddressFunction);
        }

        public virtual Task<TransactionReceipt> RemoveAddressRequestAndWaitForReceiptAsync(RemoveAddressFunction removeAddressFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(removeAddressFunction, cancellationToken);
        }

        public virtual Task<string> RemoveAddressRequestAsync(BigInteger id, List<string> users)
        {
            EnsureInitialized();
            var removeAddressFunction = new RemoveAddressFunction();
                removeAddressFunction.Id = id;
                removeAddressFunction.Users = users;
            
            return ContractHandler.SendRequestAsync(removeAddressFunction);
        }

        public virtual Task<TransactionReceipt> RemoveAddressRequestAndWaitForReceiptAsync(BigInteger id, List<string> users, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var removeAddressFunction = new RemoveAddressFunction();
                removeAddressFunction.Id = id;
                removeAddressFunction.Users = users;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(removeAddressFunction, cancellationToken);
        }

        public virtual Task<string> RegisterRequestAsync(RegisterFunction registerFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(registerFunction);
        }

        public virtual Task<TransactionReceipt> RegisterRequestAndWaitForReceiptAsync(RegisterFunction registerFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(registerFunction, cancellationToken);
        }

        public virtual Task<string> RegisterRequestAsync(string subject, BigInteger id, BigInteger amount)
        {
            EnsureInitialized();
            var registerFunction = new RegisterFunction();
                registerFunction.Subject = subject;
                registerFunction.Id = id;
                registerFunction.Amount = amount;
            
            return ContractHandler.SendRequestAsync(registerFunction);
        }

        public virtual Task<TransactionReceipt> RegisterRequestAndWaitForReceiptAsync(string subject, BigInteger id, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var registerFunction = new RegisterFunction();
                registerFunction.Subject = subject;
                registerFunction.Id = id;
                registerFunction.Amount = amount;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(registerFunction, cancellationToken);
        }

        public virtual Task<string> LastRoundRegisterRequestAsync(LastRoundRegisterFunction lastRoundRegisterFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(lastRoundRegisterFunction);
        }

        public virtual Task<TransactionReceipt> LastRoundRegisterRequestAndWaitForReceiptAsync(LastRoundRegisterFunction lastRoundRegisterFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(lastRoundRegisterFunction, cancellationToken);
        }

        public virtual Task<string> LastRoundRegisterRequestAsync(string subject, BigInteger id)
        {
            EnsureInitialized();
            var lastRoundRegisterFunction = new LastRoundRegisterFunction();
                lastRoundRegisterFunction.Subject = subject;
                lastRoundRegisterFunction.Id = id;
            
            return ContractHandler.SendRequestAsync(lastRoundRegisterFunction);
        }

        public virtual Task<TransactionReceipt> LastRoundRegisterRequestAndWaitForReceiptAsync(string subject, BigInteger id, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var lastRoundRegisterFunction = new LastRoundRegisterFunction();
                lastRoundRegisterFunction.Subject = subject;
                lastRoundRegisterFunction.Id = id;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(lastRoundRegisterFunction, cancellationToken);
        }
    }
}
