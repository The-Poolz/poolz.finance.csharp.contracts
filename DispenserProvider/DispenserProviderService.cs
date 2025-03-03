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
using poolz.finance.csharp.contracts.DispenserProvider.ContractDefinition;

namespace poolz.finance.csharp.contracts.DispenserProvider
{
    public partial class DispenserProviderService : IDispenserProviderService
    {
        protected virtual IWeb3 Web3 { get; private set; }

        public virtual ContractHandler ContractHandler { get; private set; }

        public DispenserProviderService() { }

        public DispenserProviderService(Web3 web3, string contractAddress)
        {
            Initialize(web3, contractAddress);
        }

        public DispenserProviderService(IWeb3 web3, string contractAddress)
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

        public virtual Task<byte[]> BuilderTypehashQueryAsync(BuilderTypehashFunction builderTypehashFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<BuilderTypehashFunction, byte[]>(builderTypehashFunction, blockParameter);
        }

        public virtual Task<byte[]> BuilderTypehashQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<BuilderTypehashFunction, byte[]>(null, blockParameter);
        }

        public virtual Task<byte[]> MessageTypehashQueryAsync(MessageTypehashFunction messageTypehashFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<MessageTypehashFunction, byte[]>(messageTypehashFunction, blockParameter);
        }

        public virtual Task<byte[]> MessageTypehashQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<MessageTypehashFunction, byte[]>(null, blockParameter);
        }

        public virtual Task<string> AcceptFirewallAdminRequestAsync(AcceptFirewallAdminFunction acceptFirewallAdminFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(acceptFirewallAdminFunction);
        }

        public virtual Task<string> AcceptFirewallAdminRequestAsync()
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync<AcceptFirewallAdminFunction>();
        }

        public virtual Task<TransactionReceipt> AcceptFirewallAdminRequestAndWaitForReceiptAsync(AcceptFirewallAdminFunction acceptFirewallAdminFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(acceptFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> AcceptFirewallAdminRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync<AcceptFirewallAdminFunction>(null, cancellationToken);
        }

        public virtual Task<string> CreateNewPoolRequestAsync(CreateNewPoolFunction createNewPoolFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(createNewPoolFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(CreateNewPoolFunction createNewPoolFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewPoolFunction, cancellationToken);
        }

        public virtual Task<string> CreateNewPoolRequestAsync(List<string> addresses, List<BigInteger> @params, byte[] signature)
        {
            EnsureInitialized();
            var createNewPoolFunction = new CreateNewPoolFunction();
                createNewPoolFunction.Addresses = addresses;
                createNewPoolFunction.Params = @params;
                createNewPoolFunction.Signature = signature;
            
            return ContractHandler.SendRequestAsync(createNewPoolFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(List<string> addresses, List<BigInteger> @params, byte[] signature, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var createNewPoolFunction = new CreateNewPoolFunction();
                createNewPoolFunction.Addresses = addresses;
                createNewPoolFunction.Params = @params;
                createNewPoolFunction.Signature = signature;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewPoolFunction, cancellationToken);
        }

        public virtual Task<BigInteger> CurrentParamsTargetLengthQueryAsync(CurrentParamsTargetLengthFunction currentParamsTargetLengthFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<CurrentParamsTargetLengthFunction, BigInteger>(currentParamsTargetLengthFunction, blockParameter);
        }

        public virtual Task<BigInteger> CurrentParamsTargetLengthQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<CurrentParamsTargetLengthFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> DispenseLockRequestAsync(DispenseLockFunction dispenseLockFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(dispenseLockFunction);
        }

        public virtual Task<TransactionReceipt> DispenseLockRequestAndWaitForReceiptAsync(DispenseLockFunction dispenseLockFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(dispenseLockFunction, cancellationToken);
        }

        public virtual Task<string> DispenseLockRequestAsync(MessageStruct message, byte[] signature)
        {
            EnsureInitialized();
            var dispenseLockFunction = new DispenseLockFunction();
                dispenseLockFunction.Message = message;
                dispenseLockFunction.Signature = signature;
            
            return ContractHandler.SendRequestAsync(dispenseLockFunction);
        }

        public virtual Task<TransactionReceipt> DispenseLockRequestAndWaitForReceiptAsync(MessageStruct message, byte[] signature, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var dispenseLockFunction = new DispenseLockFunction();
                dispenseLockFunction.Message = message;
                dispenseLockFunction.Signature = signature;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(dispenseLockFunction, cancellationToken);
        }

        public virtual Task<Eip712DomainOutputDTO> Eip712DomainQueryAsync(Eip712DomainFunction eip712DomainFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryDeserializingToObjectAsync<Eip712DomainFunction, Eip712DomainOutputDTO>(eip712DomainFunction, blockParameter);
        }

        public virtual Task<Eip712DomainOutputDTO> Eip712DomainQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryDeserializingToObjectAsync<Eip712DomainFunction, Eip712DomainOutputDTO>(null, blockParameter);
        }

        public virtual Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(firewallAdminFunction, blockParameter);
        }

        public virtual Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(null, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetParamsQueryAsync(GetParamsFunction getParamsFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<GetParamsFunction, List<BigInteger>>(getParamsFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetParamsQueryAsync(BigInteger poolId, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var getParamsFunction = new GetParamsFunction();
                getParamsFunction.PoolId = poolId;
            
            return ContractHandler.QueryAsync<GetParamsFunction, List<BigInteger>>(getParamsFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(GetSubProvidersPoolIdsFunction getSubProvidersPoolIdsFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<GetSubProvidersPoolIdsFunction, List<BigInteger>>(getSubProvidersPoolIdsFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var getSubProvidersPoolIdsFunction = new GetSubProvidersPoolIdsFunction();
                getSubProvidersPoolIdsFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<GetSubProvidersPoolIdsFunction, List<BigInteger>>(getSubProvidersPoolIdsFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(BigInteger poolId, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var getWithdrawableAmountFunction = new GetWithdrawableAmountFunction();
                getWithdrawableAmountFunction.PoolId = poolId;
            
            return ContractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        public virtual Task<bool> IsTakenQueryAsync(IsTakenFunction isTakenFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<IsTakenFunction, bool>(isTakenFunction, blockParameter);
        }

        public virtual Task<bool> IsTakenQueryAsync(BigInteger returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var isTakenFunction = new IsTakenFunction();
                isTakenFunction.ReturnValue1 = returnValue1;
                isTakenFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<IsTakenFunction, bool>(isTakenFunction, blockParameter);
        }

        public virtual Task<string> LockDealNFTQueryAsync(LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<LockDealNFTFunction, string>(lockDealNFTFunction, blockParameter);
        }

        public virtual Task<string> LockDealNFTQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<LockDealNFTFunction, string>(null, blockParameter);
        }

        public virtual Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
        }

        public virtual Task<string> NameQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
        }

        public virtual Task<BigInteger> PoolIdToAmountQueryAsync(PoolIdToAmountFunction poolIdToAmountFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<PoolIdToAmountFunction, BigInteger>(poolIdToAmountFunction, blockParameter);
        }

        public virtual Task<BigInteger> PoolIdToAmountQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var poolIdToAmountFunction = new PoolIdToAmountFunction();
                poolIdToAmountFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PoolIdToAmountFunction, BigInteger>(poolIdToAmountFunction, blockParameter);
        }

        public virtual Task<string> RegisterPoolRequestAsync(RegisterPoolFunction registerPoolFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(registerPoolFunction);
        }

        public virtual Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(RegisterPoolFunction registerPoolFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(registerPoolFunction, cancellationToken);
        }

        public virtual Task<string> RegisterPoolRequestAsync(BigInteger poolId, List<BigInteger> @params)
        {
            EnsureInitialized();
            var registerPoolFunction = new RegisterPoolFunction();
                registerPoolFunction.PoolId = poolId;
                registerPoolFunction.Params = @params;
            
            return ContractHandler.SendRequestAsync(registerPoolFunction);
        }

        public virtual Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(BigInteger poolId, List<BigInteger> @params, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var registerPoolFunction = new RegisterPoolFunction();
                registerPoolFunction.PoolId = poolId;
                registerPoolFunction.Params = @params;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(registerPoolFunction, cancellationToken);
        }

        public virtual Task<string> SafeFunctionCallRequestAsync(SafeFunctionCallFunction safeFunctionCallFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(safeFunctionCallFunction);
        }

        public virtual Task<TransactionReceipt> SafeFunctionCallRequestAndWaitForReceiptAsync(SafeFunctionCallFunction safeFunctionCallFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(safeFunctionCallFunction, cancellationToken);
        }

        public virtual Task<string> SafeFunctionCallRequestAsync(string vennPolicy, byte[] vennPolicyPayload, byte[] data)
        {
            EnsureInitialized();
            var safeFunctionCallFunction = new SafeFunctionCallFunction();
                safeFunctionCallFunction.VennPolicy = vennPolicy;
                safeFunctionCallFunction.VennPolicyPayload = vennPolicyPayload;
                safeFunctionCallFunction.Data = data;
            
            return ContractHandler.SendRequestAsync(safeFunctionCallFunction);
        }

        public virtual Task<TransactionReceipt> SafeFunctionCallRequestAndWaitForReceiptAsync(string vennPolicy, byte[] vennPolicyPayload, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var safeFunctionCallFunction = new SafeFunctionCallFunction();
                safeFunctionCallFunction.VennPolicy = vennPolicy;
                safeFunctionCallFunction.VennPolicyPayload = vennPolicyPayload;
                safeFunctionCallFunction.Data = data;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(safeFunctionCallFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovedVennPolicyRequestAsync(SetApprovedVennPolicyFunction setApprovedVennPolicyFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setApprovedVennPolicyFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovedVennPolicyRequestAndWaitForReceiptAsync(SetApprovedVennPolicyFunction setApprovedVennPolicyFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovedVennPolicyFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovedVennPolicyRequestAsync(string vennPolicy, bool status)
        {
            EnsureInitialized();
            var setApprovedVennPolicyFunction = new SetApprovedVennPolicyFunction();
                setApprovedVennPolicyFunction.VennPolicy = vennPolicy;
                setApprovedVennPolicyFunction.Status = status;
            
            return ContractHandler.SendRequestAsync(setApprovedVennPolicyFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovedVennPolicyRequestAndWaitForReceiptAsync(string vennPolicy, bool status, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setApprovedVennPolicyFunction = new SetApprovedVennPolicyFunction();
                setApprovedVennPolicyFunction.VennPolicy = vennPolicy;
                setApprovedVennPolicyFunction.Status = status;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovedVennPolicyFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovedVennPolicyFeeRequestAsync(SetApprovedVennPolicyFeeFunction setApprovedVennPolicyFeeFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setApprovedVennPolicyFeeFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovedVennPolicyFeeRequestAndWaitForReceiptAsync(SetApprovedVennPolicyFeeFunction setApprovedVennPolicyFeeFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovedVennPolicyFeeFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovedVennPolicyFeeRequestAsync(BigInteger fee)
        {
            EnsureInitialized();
            var setApprovedVennPolicyFeeFunction = new SetApprovedVennPolicyFeeFunction();
                setApprovedVennPolicyFeeFunction.Fee = fee;
            
            return ContractHandler.SendRequestAsync(setApprovedVennPolicyFeeFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovedVennPolicyFeeRequestAndWaitForReceiptAsync(BigInteger fee, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setApprovedVennPolicyFeeFunction = new SetApprovedVennPolicyFeeFunction();
                setApprovedVennPolicyFeeFunction.Fee = fee;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovedVennPolicyFeeFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(SetFirewallFunction setFirewallFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(string firewall)
        {
            EnsureInitialized();
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(string firewall, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(SetFirewallAdminFunction setFirewallAdminFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(string firewallAdmin)
        {
            EnsureInitialized();
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(string firewallAdmin, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> SplitRequestAsync(SplitFunction splitFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(splitFunction);
        }

        public virtual Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(SplitFunction splitFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(splitFunction, cancellationToken);
        }

        public virtual Task<string> SplitRequestAsync(BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio)
        {
            EnsureInitialized();
            var splitFunction = new SplitFunction();
                splitFunction.OldPoolId = oldPoolId;
                splitFunction.NewPoolId = newPoolId;
                splitFunction.Ratio = ratio;
            
            return ContractHandler.SendRequestAsync(splitFunction);
        }

        public virtual Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var splitFunction = new SplitFunction();
                splitFunction.OldPoolId = oldPoolId;
                splitFunction.NewPoolId = newPoolId;
                splitFunction.Ratio = ratio;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(splitFunction, cancellationToken);
        }

        public virtual Task<bool> SupportsInterfaceQueryAsync(SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public virtual Task<bool> SupportsInterfaceQueryAsync(byte[] interfaceId, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var supportsInterfaceFunction = new SupportsInterfaceFunction();
                supportsInterfaceFunction.InterfaceId = interfaceId;
            
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public virtual Task<string> WithdrawRequestAsync(WithdrawFunction withdrawFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(withdrawFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(WithdrawFunction withdrawFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawRequestAsync(BigInteger poolId)
        {
            EnsureInitialized();
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.PoolId = poolId;
            
            return ContractHandler.SendRequestAsync(withdrawFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(BigInteger poolId, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.PoolId = poolId;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawRequestAsync(Withdraw1Function withdraw1Function)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(withdraw1Function);
        }

        public virtual Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(Withdraw1Function withdraw1Function, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(withdraw1Function, cancellationToken);
        }

        public virtual Task<string> WithdrawRequestAsync(BigInteger poolId, BigInteger amount)
        {
            EnsureInitialized();
            var withdraw1Function = new Withdraw1Function();
                withdraw1Function.PoolId = poolId;
                withdraw1Function.Amount = amount;
            
            return ContractHandler.SendRequestAsync(withdraw1Function);
        }

        public virtual Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(BigInteger poolId, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var withdraw1Function = new Withdraw1Function();
                withdraw1Function.PoolId = poolId;
                withdraw1Function.Amount = amount;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(withdraw1Function, cancellationToken);
        }
    }
}
