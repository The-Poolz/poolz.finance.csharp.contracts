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
using poolz.finance.csharp.Whitelist.ContractDefinition;

namespace poolz.finance.csharp.Whitelist
{
    public partial class WhitelistService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, WhitelistDeployment whitelistDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<WhitelistDeployment>().SendRequestAndWaitForReceiptAsync(whitelistDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, WhitelistDeployment whitelistDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<WhitelistDeployment>().SendRequestAsync(whitelistDeployment);
        }

        public static async Task<WhitelistService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, WhitelistDeployment whitelistDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, whitelistDeployment, cancellationTokenSource);
            return new WhitelistService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.IWeb3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public WhitelistService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public WhitelistService(Nethereum.Web3.IWeb3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<BigInteger> CheckQueryAsync(CheckFunction checkFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CheckFunction, BigInteger>(checkFunction, blockParameter);
        }

        
        public Task<BigInteger> CheckQueryAsync(string user, BigInteger id, BlockParameter blockParameter = null)
        {
            var checkFunction = new CheckFunction();
                checkFunction.User = user;
                checkFunction.Id = id;
            
            return ContractHandler.QueryAsync<CheckFunction, BigInteger>(checkFunction, blockParameter);
        }

        public Task<BigInteger> MaxUsersLimitQueryAsync(MaxUsersLimitFunction maxUsersLimitFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxUsersLimitFunction, BigInteger>(maxUsersLimitFunction, blockParameter);
        }

        
        public Task<BigInteger> MaxUsersLimitQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxUsersLimitFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> WhiteListCostQueryAsync(WhiteListCostFunction whiteListCostFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<WhiteListCostFunction, BigInteger>(whiteListCostFunction, blockParameter);
        }

        
        public Task<BigInteger> WhiteListCostQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<WhiteListCostFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> WhiteListCountQueryAsync(WhiteListCountFunction whiteListCountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<WhiteListCountFunction, BigInteger>(whiteListCountFunction, blockParameter);
        }

        
        public Task<BigInteger> WhiteListCountQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<WhiteListCountFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> WhitelistDBQueryAsync(WhitelistDBFunction whitelistDBFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<WhitelistDBFunction, BigInteger>(whitelistDBFunction, blockParameter);
        }

        
        public Task<BigInteger> WhitelistDBQueryAsync(BigInteger returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var whitelistDBFunction = new WhitelistDBFunction();
                whitelistDBFunction.ReturnValue1 = returnValue1;
                whitelistDBFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<WhitelistDBFunction, BigInteger>(whitelistDBFunction, blockParameter);
        }

        public Task<WhitelistSettingsOutputDTO> WhitelistSettingsQueryAsync(WhitelistSettingsFunction whitelistSettingsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<WhitelistSettingsFunction, WhitelistSettingsOutputDTO>(whitelistSettingsFunction, blockParameter);
        }

        public Task<WhitelistSettingsOutputDTO> WhitelistSettingsQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var whitelistSettingsFunction = new WhitelistSettingsFunction();
                whitelistSettingsFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryDeserializingToObjectAsync<WhitelistSettingsFunction, WhitelistSettingsOutputDTO>(whitelistSettingsFunction, blockParameter);
        }

        public Task<bool> IsWhiteListReadyQueryAsync(IsWhiteListReadyFunction isWhiteListReadyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsWhiteListReadyFunction, bool>(isWhiteListReadyFunction, blockParameter);
        }

        
        public Task<bool> IsWhiteListReadyQueryAsync(BigInteger id, BlockParameter blockParameter = null)
        {
            var isWhiteListReadyFunction = new IsWhiteListReadyFunction();
                isWhiteListReadyFunction.Id = id;
            
            return ContractHandler.QueryAsync<IsWhiteListReadyFunction, bool>(isWhiteListReadyFunction, blockParameter);
        }

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        
        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(renounceOwnershipFunction);
        }

        public Task<string> RenounceOwnershipRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RenounceOwnershipFunction>();
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceOwnershipFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RenounceOwnershipFunction>(null, cancellationToken);
        }

        public Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public Task<string> TransferOwnershipRequestAsync(string newOwner)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public Task<string> SetMaxUsersLimitRequestAsync(SetMaxUsersLimitFunction setMaxUsersLimitFunction)
        {
             return ContractHandler.SendRequestAsync(setMaxUsersLimitFunction);
        }

        public Task<TransactionReceipt> SetMaxUsersLimitRequestAndWaitForReceiptAsync(SetMaxUsersLimitFunction setMaxUsersLimitFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setMaxUsersLimitFunction, cancellationToken);
        }

        public Task<string> SetMaxUsersLimitRequestAsync(BigInteger limit)
        {
            var setMaxUsersLimitFunction = new SetMaxUsersLimitFunction();
                setMaxUsersLimitFunction.Limit = limit;
            
             return ContractHandler.SendRequestAsync(setMaxUsersLimitFunction);
        }

        public Task<TransactionReceipt> SetMaxUsersLimitRequestAndWaitForReceiptAsync(BigInteger limit, CancellationTokenSource cancellationToken = null)
        {
            var setMaxUsersLimitFunction = new SetMaxUsersLimitFunction();
                setMaxUsersLimitFunction.Limit = limit;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setMaxUsersLimitFunction, cancellationToken);
        }

        public Task<string> WithdrawETHFeeRequestAsync(WithdrawETHFeeFunction withdrawETHFeeFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawETHFeeFunction);
        }

        public Task<TransactionReceipt> WithdrawETHFeeRequestAndWaitForReceiptAsync(WithdrawETHFeeFunction withdrawETHFeeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawETHFeeFunction, cancellationToken);
        }

        public Task<string> WithdrawETHFeeRequestAsync(string to)
        {
            var withdrawETHFeeFunction = new WithdrawETHFeeFunction();
                withdrawETHFeeFunction.To = to;
            
             return ContractHandler.SendRequestAsync(withdrawETHFeeFunction);
        }

        public Task<TransactionReceipt> WithdrawETHFeeRequestAndWaitForReceiptAsync(string to, CancellationTokenSource cancellationToken = null)
        {
            var withdrawETHFeeFunction = new WithdrawETHFeeFunction();
                withdrawETHFeeFunction.To = to;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawETHFeeFunction, cancellationToken);
        }

        public Task<string> SetWhiteListCostRequestAsync(SetWhiteListCostFunction setWhiteListCostFunction)
        {
             return ContractHandler.SendRequestAsync(setWhiteListCostFunction);
        }

        public Task<TransactionReceipt> SetWhiteListCostRequestAndWaitForReceiptAsync(SetWhiteListCostFunction setWhiteListCostFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setWhiteListCostFunction, cancellationToken);
        }

        public Task<string> SetWhiteListCostRequestAsync(BigInteger newCost)
        {
            var setWhiteListCostFunction = new SetWhiteListCostFunction();
                setWhiteListCostFunction.NewCost = newCost;
            
             return ContractHandler.SendRequestAsync(setWhiteListCostFunction);
        }

        public Task<TransactionReceipt> SetWhiteListCostRequestAndWaitForReceiptAsync(BigInteger newCost, CancellationTokenSource cancellationToken = null)
        {
            var setWhiteListCostFunction = new SetWhiteListCostFunction();
                setWhiteListCostFunction.NewCost = newCost;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setWhiteListCostFunction, cancellationToken);
        }

        public Task<string> CreateManualWhiteListRequestAsync(CreateManualWhiteListFunction createManualWhiteListFunction)
        {
             return ContractHandler.SendRequestAsync(createManualWhiteListFunction);
        }

        public Task<TransactionReceipt> CreateManualWhiteListRequestAndWaitForReceiptAsync(CreateManualWhiteListFunction createManualWhiteListFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createManualWhiteListFunction, cancellationToken);
        }

        public Task<string> CreateManualWhiteListRequestAsync(BigInteger changeUntil, string contract)
        {
            var createManualWhiteListFunction = new CreateManualWhiteListFunction();
                createManualWhiteListFunction.ChangeUntil = changeUntil;
                createManualWhiteListFunction.Contract = contract;
            
             return ContractHandler.SendRequestAsync(createManualWhiteListFunction);
        }

        public Task<TransactionReceipt> CreateManualWhiteListRequestAndWaitForReceiptAsync(BigInteger changeUntil, string contract, CancellationTokenSource cancellationToken = null)
        {
            var createManualWhiteListFunction = new CreateManualWhiteListFunction();
                createManualWhiteListFunction.ChangeUntil = changeUntil;
                createManualWhiteListFunction.Contract = contract;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createManualWhiteListFunction, cancellationToken);
        }

        public Task<string> ChangeCreatorRequestAsync(ChangeCreatorFunction changeCreatorFunction)
        {
             return ContractHandler.SendRequestAsync(changeCreatorFunction);
        }

        public Task<TransactionReceipt> ChangeCreatorRequestAndWaitForReceiptAsync(ChangeCreatorFunction changeCreatorFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(changeCreatorFunction, cancellationToken);
        }

        public Task<string> ChangeCreatorRequestAsync(BigInteger id, string newCreator)
        {
            var changeCreatorFunction = new ChangeCreatorFunction();
                changeCreatorFunction.Id = id;
                changeCreatorFunction.NewCreator = newCreator;
            
             return ContractHandler.SendRequestAsync(changeCreatorFunction);
        }

        public Task<TransactionReceipt> ChangeCreatorRequestAndWaitForReceiptAsync(BigInteger id, string newCreator, CancellationTokenSource cancellationToken = null)
        {
            var changeCreatorFunction = new ChangeCreatorFunction();
                changeCreatorFunction.Id = id;
                changeCreatorFunction.NewCreator = newCreator;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(changeCreatorFunction, cancellationToken);
        }

        public Task<string> ChangeContractRequestAsync(ChangeContractFunction changeContractFunction)
        {
             return ContractHandler.SendRequestAsync(changeContractFunction);
        }

        public Task<TransactionReceipt> ChangeContractRequestAndWaitForReceiptAsync(ChangeContractFunction changeContractFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(changeContractFunction, cancellationToken);
        }

        public Task<string> ChangeContractRequestAsync(BigInteger id, string newContract)
        {
            var changeContractFunction = new ChangeContractFunction();
                changeContractFunction.Id = id;
                changeContractFunction.NewContract = newContract;
            
             return ContractHandler.SendRequestAsync(changeContractFunction);
        }

        public Task<TransactionReceipt> ChangeContractRequestAndWaitForReceiptAsync(BigInteger id, string newContract, CancellationTokenSource cancellationToken = null)
        {
            var changeContractFunction = new ChangeContractFunction();
                changeContractFunction.Id = id;
                changeContractFunction.NewContract = newContract;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(changeContractFunction, cancellationToken);
        }

        public Task<string> AddAddressRequestAsync(AddAddressFunction addAddressFunction)
        {
             return ContractHandler.SendRequestAsync(addAddressFunction);
        }

        public Task<TransactionReceipt> AddAddressRequestAndWaitForReceiptAsync(AddAddressFunction addAddressFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addAddressFunction, cancellationToken);
        }

        public Task<string> AddAddressRequestAsync(BigInteger id, List<string> users, List<BigInteger> amount)
        {
            var addAddressFunction = new AddAddressFunction();
                addAddressFunction.Id = id;
                addAddressFunction.Users = users;
                addAddressFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(addAddressFunction);
        }

        public Task<TransactionReceipt> AddAddressRequestAndWaitForReceiptAsync(BigInteger id, List<string> users, List<BigInteger> amount, CancellationTokenSource cancellationToken = null)
        {
            var addAddressFunction = new AddAddressFunction();
                addAddressFunction.Id = id;
                addAddressFunction.Users = users;
                addAddressFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addAddressFunction, cancellationToken);
        }

        public Task<string> RemoveAddressRequestAsync(RemoveAddressFunction removeAddressFunction)
        {
             return ContractHandler.SendRequestAsync(removeAddressFunction);
        }

        public Task<TransactionReceipt> RemoveAddressRequestAndWaitForReceiptAsync(RemoveAddressFunction removeAddressFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeAddressFunction, cancellationToken);
        }

        public Task<string> RemoveAddressRequestAsync(BigInteger id, List<string> users)
        {
            var removeAddressFunction = new RemoveAddressFunction();
                removeAddressFunction.Id = id;
                removeAddressFunction.Users = users;
            
             return ContractHandler.SendRequestAsync(removeAddressFunction);
        }

        public Task<TransactionReceipt> RemoveAddressRequestAndWaitForReceiptAsync(BigInteger id, List<string> users, CancellationTokenSource cancellationToken = null)
        {
            var removeAddressFunction = new RemoveAddressFunction();
                removeAddressFunction.Id = id;
                removeAddressFunction.Users = users;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeAddressFunction, cancellationToken);
        }

        public Task<string> RegisterRequestAsync(RegisterFunction registerFunction)
        {
             return ContractHandler.SendRequestAsync(registerFunction);
        }

        public Task<TransactionReceipt> RegisterRequestAndWaitForReceiptAsync(RegisterFunction registerFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerFunction, cancellationToken);
        }

        public Task<string> RegisterRequestAsync(string subject, BigInteger id, BigInteger amount)
        {
            var registerFunction = new RegisterFunction();
                registerFunction.Subject = subject;
                registerFunction.Id = id;
                registerFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(registerFunction);
        }

        public Task<TransactionReceipt> RegisterRequestAndWaitForReceiptAsync(string subject, BigInteger id, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var registerFunction = new RegisterFunction();
                registerFunction.Subject = subject;
                registerFunction.Id = id;
                registerFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerFunction, cancellationToken);
        }

        public Task<string> LastRoundRegisterRequestAsync(LastRoundRegisterFunction lastRoundRegisterFunction)
        {
             return ContractHandler.SendRequestAsync(lastRoundRegisterFunction);
        }

        public Task<TransactionReceipt> LastRoundRegisterRequestAndWaitForReceiptAsync(LastRoundRegisterFunction lastRoundRegisterFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(lastRoundRegisterFunction, cancellationToken);
        }

        public Task<string> LastRoundRegisterRequestAsync(string subject, BigInteger id)
        {
            var lastRoundRegisterFunction = new LastRoundRegisterFunction();
                lastRoundRegisterFunction.Subject = subject;
                lastRoundRegisterFunction.Id = id;
            
             return ContractHandler.SendRequestAsync(lastRoundRegisterFunction);
        }

        public Task<TransactionReceipt> LastRoundRegisterRequestAndWaitForReceiptAsync(string subject, BigInteger id, CancellationTokenSource cancellationToken = null)
        {
            var lastRoundRegisterFunction = new LastRoundRegisterFunction();
                lastRoundRegisterFunction.Subject = subject;
                lastRoundRegisterFunction.Id = id;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(lastRoundRegisterFunction, cancellationToken);
        }
    }
}