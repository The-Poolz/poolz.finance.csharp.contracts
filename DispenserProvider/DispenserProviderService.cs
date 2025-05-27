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
using poolz.finance.csharp.contracts.DispenserProvider.ContractDefinition;

namespace poolz.finance.csharp.contracts.DispenserProvider
{
    public partial class DispenserProviderService<TContractType> : IDispenserProviderService<TContractType>
        where TContractType : Enum
    {
        public IChainProvider<TContractType> ChainProvider { get; }

        public DispenserProviderService(IChainProvider<TContractType> chainProvider)
        {
            ChainProvider = chainProvider;
        }

        private ContractHandler InitializeContractHandler(long chainId, TContractType contractType)
        {
            var contractAddress = ChainProvider.ContractAddress(chainId, contractType);
            var web3 = ChainProvider.Web3(chainId);
            var contractHandler = web3.Eth.GetContractHandler(contractAddress);
            return contractHandler;
        }

        public virtual Task<byte[]> BuilderTypehashQueryAsync(long chainId, TContractType contractType, BuilderTypehashFunction builderTypehashFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<BuilderTypehashFunction, byte[]>(builderTypehashFunction, blockParameter);
        }

        public virtual Task<byte[]> BuilderTypehashQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<BuilderTypehashFunction, byte[]>(null, blockParameter);
        }

        public virtual Task<byte[]> MessageTypehashQueryAsync(long chainId, TContractType contractType, MessageTypehashFunction messageTypehashFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<MessageTypehashFunction, byte[]>(messageTypehashFunction, blockParameter);
        }

        public virtual Task<byte[]> MessageTypehashQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<MessageTypehashFunction, byte[]>(null, blockParameter);
        }

        public virtual Task<string> AcceptFirewallAdminRequestAsync(long chainId, TContractType contractType, AcceptFirewallAdminFunction acceptFirewallAdminFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(acceptFirewallAdminFunction);
        }

        public virtual Task<string> AcceptFirewallAdminRequestAsync(long chainId, TContractType contractType)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync<AcceptFirewallAdminFunction>();
        }

        public virtual Task<TransactionReceipt> AcceptFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, AcceptFirewallAdminFunction acceptFirewallAdminFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(acceptFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> AcceptFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync<AcceptFirewallAdminFunction>(null, cancellationToken);
        }

        public virtual Task<string> CreateNewPoolRequestAsync(long chainId, TContractType contractType, CreateNewPoolFunction createNewPoolFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewPoolFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CreateNewPoolFunction createNewPoolFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewPoolFunction, cancellationToken);
        }

        public virtual Task<string> CreateNewPoolRequestAsync(long chainId, TContractType contractType, List<string> addresses, List<BigInteger> @params, byte[] signature)
        {
            var createNewPoolFunction = new CreateNewPoolFunction();
                createNewPoolFunction.Addresses = addresses;
                createNewPoolFunction.Params = @params;
                createNewPoolFunction.Signature = signature;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewPoolFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, List<string> addresses, List<BigInteger> @params, byte[] signature, CancellationTokenSource cancellationToken = null)
        {
            var createNewPoolFunction = new CreateNewPoolFunction();
                createNewPoolFunction.Addresses = addresses;
                createNewPoolFunction.Params = @params;
                createNewPoolFunction.Signature = signature;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewPoolFunction, cancellationToken);
        }

        public virtual Task<BigInteger> CurrentParamsTargetLengthQueryAsync(long chainId, TContractType contractType, CurrentParamsTargetLengthFunction currentParamsTargetLengthFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<CurrentParamsTargetLengthFunction, BigInteger>(currentParamsTargetLengthFunction, blockParameter);
        }

        public virtual Task<BigInteger> CurrentParamsTargetLengthQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<CurrentParamsTargetLengthFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> DispenseLockRequestAsync(long chainId, TContractType contractType, DispenseLockFunction dispenseLockFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(dispenseLockFunction);
        }

        public virtual Task<TransactionReceipt> DispenseLockRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, DispenseLockFunction dispenseLockFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(dispenseLockFunction, cancellationToken);
        }

        public virtual Task<string> DispenseLockRequestAsync(long chainId, TContractType contractType, MessageStruct message, byte[] signature)
        {
            var dispenseLockFunction = new DispenseLockFunction();
                dispenseLockFunction.Message = message;
                dispenseLockFunction.Signature = signature;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(dispenseLockFunction);
        }

        public virtual Task<TransactionReceipt> DispenseLockRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, MessageStruct message, byte[] signature, CancellationTokenSource cancellationToken = null)
        {
            var dispenseLockFunction = new DispenseLockFunction();
                dispenseLockFunction.Message = message;
                dispenseLockFunction.Signature = signature;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(dispenseLockFunction, cancellationToken);
        }

        public virtual Task<Eip712DomainOutputDTO> Eip712DomainQueryAsync(long chainId, TContractType contractType, Eip712DomainFunction eip712DomainFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<Eip712DomainFunction, Eip712DomainOutputDTO>(eip712DomainFunction, blockParameter);
        }

        public virtual Task<Eip712DomainOutputDTO> Eip712DomainQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<Eip712DomainFunction, Eip712DomainOutputDTO>(null, blockParameter);
        }

        public virtual Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<FirewallAdminFunction, string>(firewallAdminFunction, blockParameter);
        }

        public virtual Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<FirewallAdminFunction, string>(null, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetParamsQueryAsync(long chainId, TContractType contractType, GetParamsFunction getParamsFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetParamsFunction, List<BigInteger>>(getParamsFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetParamsQueryAsync(long chainId, TContractType contractType, BigInteger poolId, BlockParameter blockParameter = null)
        {
            var getParamsFunction = new GetParamsFunction();
                getParamsFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetParamsFunction, List<BigInteger>>(getParamsFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(long chainId, TContractType contractType, GetSubProvidersPoolIdsFunction getSubProvidersPoolIdsFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetSubProvidersPoolIdsFunction, List<BigInteger>>(getSubProvidersPoolIdsFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var getSubProvidersPoolIdsFunction = new GetSubProvidersPoolIdsFunction();
                getSubProvidersPoolIdsFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetSubProvidersPoolIdsFunction, List<BigInteger>>(getSubProvidersPoolIdsFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, TContractType contractType, GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, TContractType contractType, BigInteger poolId, BlockParameter blockParameter = null)
        {
            var getWithdrawableAmountFunction = new GetWithdrawableAmountFunction();
                getWithdrawableAmountFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        public virtual Task<bool> IsTakenQueryAsync(long chainId, TContractType contractType, IsTakenFunction isTakenFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsTakenFunction, bool>(isTakenFunction, blockParameter);
        }

        public virtual Task<bool> IsTakenQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, string returnValue2, BlockParameter blockParameter = null)
        {
            var isTakenFunction = new IsTakenFunction();
                isTakenFunction.ReturnValue1 = returnValue1;
                isTakenFunction.ReturnValue2 = returnValue2;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsTakenFunction, bool>(isTakenFunction, blockParameter);
        }

        public virtual Task<string> LockDealNFTQueryAsync(long chainId, TContractType contractType, LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<LockDealNFTFunction, string>(lockDealNFTFunction, blockParameter);
        }

        public virtual Task<string> LockDealNFTQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<LockDealNFTFunction, string>(null, blockParameter);
        }

        public virtual Task<string> NameQueryAsync(long chainId, TContractType contractType, NameFunction nameFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
        }

        public virtual Task<string> NameQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
        }

        public virtual Task<BigInteger> PoolIdToAmountQueryAsync(long chainId, TContractType contractType, PoolIdToAmountFunction poolIdToAmountFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PoolIdToAmountFunction, BigInteger>(poolIdToAmountFunction, blockParameter);
        }

        public virtual Task<BigInteger> PoolIdToAmountQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var poolIdToAmountFunction = new PoolIdToAmountFunction();
                poolIdToAmountFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PoolIdToAmountFunction, BigInteger>(poolIdToAmountFunction, blockParameter);
        }

        public virtual Task<string> RegisterPoolRequestAsync(long chainId, TContractType contractType, RegisterPoolFunction registerPoolFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(registerPoolFunction);
        }

        public virtual Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, RegisterPoolFunction registerPoolFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(registerPoolFunction, cancellationToken);
        }

        public virtual Task<string> RegisterPoolRequestAsync(long chainId, TContractType contractType, BigInteger poolId, List<BigInteger> @params)
        {
            var registerPoolFunction = new RegisterPoolFunction();
                registerPoolFunction.PoolId = poolId;
                registerPoolFunction.Params = @params;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(registerPoolFunction);
        }

        public virtual Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger poolId, List<BigInteger> @params, CancellationTokenSource cancellationToken = null)
        {
            var registerPoolFunction = new RegisterPoolFunction();
                registerPoolFunction.PoolId = poolId;
                registerPoolFunction.Params = @params;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(registerPoolFunction, cancellationToken);
        }

        public virtual Task<string> SafeFunctionCallRequestAsync(long chainId, TContractType contractType, SafeFunctionCallFunction safeFunctionCallFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(safeFunctionCallFunction);
        }

        public virtual Task<TransactionReceipt> SafeFunctionCallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SafeFunctionCallFunction safeFunctionCallFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(safeFunctionCallFunction, cancellationToken);
        }

        public virtual Task<string> SafeFunctionCallRequestAsync(long chainId, TContractType contractType, string vennPolicy, byte[] vennPolicyPayload, byte[] data)
        {
            var safeFunctionCallFunction = new SafeFunctionCallFunction();
                safeFunctionCallFunction.VennPolicy = vennPolicy;
                safeFunctionCallFunction.VennPolicyPayload = vennPolicyPayload;
                safeFunctionCallFunction.Data = data;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(safeFunctionCallFunction);
        }

        public virtual Task<TransactionReceipt> SafeFunctionCallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string vennPolicy, byte[] vennPolicyPayload, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            var safeFunctionCallFunction = new SafeFunctionCallFunction();
                safeFunctionCallFunction.VennPolicy = vennPolicy;
                safeFunctionCallFunction.VennPolicyPayload = vennPolicyPayload;
                safeFunctionCallFunction.Data = data;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(safeFunctionCallFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovedVennPolicyRequestAsync(long chainId, TContractType contractType, SetApprovedVennPolicyFunction setApprovedVennPolicyFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setApprovedVennPolicyFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovedVennPolicyRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetApprovedVennPolicyFunction setApprovedVennPolicyFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setApprovedVennPolicyFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovedVennPolicyRequestAsync(long chainId, TContractType contractType, string vennPolicy, bool status)
        {
            var setApprovedVennPolicyFunction = new SetApprovedVennPolicyFunction();
                setApprovedVennPolicyFunction.VennPolicy = vennPolicy;
                setApprovedVennPolicyFunction.Status = status;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setApprovedVennPolicyFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovedVennPolicyRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string vennPolicy, bool status, CancellationTokenSource cancellationToken = null)
        {
            var setApprovedVennPolicyFunction = new SetApprovedVennPolicyFunction();
                setApprovedVennPolicyFunction.VennPolicy = vennPolicy;
                setApprovedVennPolicyFunction.Status = status;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setApprovedVennPolicyFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovedVennPolicyFeeRequestAsync(long chainId, TContractType contractType, SetApprovedVennPolicyFeeFunction setApprovedVennPolicyFeeFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setApprovedVennPolicyFeeFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovedVennPolicyFeeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetApprovedVennPolicyFeeFunction setApprovedVennPolicyFeeFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setApprovedVennPolicyFeeFunction, cancellationToken);
        }

        public virtual Task<string> SetApprovedVennPolicyFeeRequestAsync(long chainId, TContractType contractType, BigInteger fee)
        {
            var setApprovedVennPolicyFeeFunction = new SetApprovedVennPolicyFeeFunction();
                setApprovedVennPolicyFeeFunction.Fee = fee;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setApprovedVennPolicyFeeFunction);
        }

        public virtual Task<TransactionReceipt> SetApprovedVennPolicyFeeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger fee, CancellationTokenSource cancellationToken = null)
        {
            var setApprovedVennPolicyFeeFunction = new SetApprovedVennPolicyFeeFunction();
                setApprovedVennPolicyFeeFunction.Fee = fee;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setApprovedVennPolicyFeeFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, string firewall)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewall, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, string firewallAdmin)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> SplitRequestAsync(long chainId, TContractType contractType, SplitFunction splitFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(splitFunction);
        }

        public virtual Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SplitFunction splitFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(splitFunction, cancellationToken);
        }

        public virtual Task<string> SplitRequestAsync(long chainId, TContractType contractType, BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio)
        {
            var splitFunction = new SplitFunction();
                splitFunction.OldPoolId = oldPoolId;
                splitFunction.NewPoolId = newPoolId;
                splitFunction.Ratio = ratio;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(splitFunction);
        }

        public virtual Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio, CancellationTokenSource cancellationToken = null)
        {
            var splitFunction = new SplitFunction();
                splitFunction.OldPoolId = oldPoolId;
                splitFunction.NewPoolId = newPoolId;
                splitFunction.Ratio = ratio;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(splitFunction, cancellationToken);
        }

        public virtual Task<bool> SupportsInterfaceQueryAsync(long chainId, TContractType contractType, SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public virtual Task<bool> SupportsInterfaceQueryAsync(long chainId, TContractType contractType, byte[] interfaceId, BlockParameter blockParameter = null)
        {
            var supportsInterfaceFunction = new SupportsInterfaceFunction();
                supportsInterfaceFunction.InterfaceId = interfaceId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public virtual Task<string> WithdrawRequestAsync(long chainId, TContractType contractType, WithdrawFunction withdrawFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, WithdrawFunction withdrawFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawRequestAsync(long chainId, TContractType contractType, BigInteger poolId)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger poolId, CancellationTokenSource cancellationToken = null)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawRequestAsync(long chainId, TContractType contractType, Withdraw1Function withdraw1Function)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdraw1Function);
        }

        public virtual Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, Withdraw1Function withdraw1Function, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdraw1Function, cancellationToken);
        }

        public virtual Task<string> WithdrawRequestAsync(long chainId, TContractType contractType, BigInteger poolId, BigInteger amount)
        {
            var withdraw1Function = new Withdraw1Function();
                withdraw1Function.PoolId = poolId;
                withdraw1Function.Amount = amount;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdraw1Function);
        }

        public virtual Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger poolId, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var withdraw1Function = new Withdraw1Function();
                withdraw1Function.PoolId = poolId;
                withdraw1Function.Amount = amount;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdraw1Function, cancellationToken);
        }
    }
}
