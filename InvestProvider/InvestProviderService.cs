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
using poolz.finance.csharp.contracts.InvestProvider.ContractDefinition;

namespace poolz.finance.csharp.contracts.InvestProvider
{
    public partial class InvestProviderService<TContractType> : IInvestProviderService<TContractType>
        where TContractType : Enum
    {
        public IChainProvider<TContractType> ChainProvider { get; }

        public InvestProviderService(IChainProvider<TContractType> chainProvider)
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

        public virtual Task<byte[]> InvestTypehashQueryAsync(long chainId, TContractType contractType, InvestTypehashFunction investTypehashFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<InvestTypehashFunction, byte[]>(investTypehashFunction, blockParameter);
        }

        public virtual Task<byte[]> InvestTypehashQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<InvestTypehashFunction, byte[]>(null, blockParameter);
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

        public virtual Task<string> CreateNewPoolRequestAsync(long chainId, TContractType contractType, BigInteger poolAmount, BigInteger sourcePoolId)
        {
            var createNewPoolFunction = new CreateNewPoolFunction();
                createNewPoolFunction.PoolAmount = poolAmount;
                createNewPoolFunction.SourcePoolId = sourcePoolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewPoolFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger poolAmount, BigInteger sourcePoolId, CancellationTokenSource cancellationToken = null)
        {
            var createNewPoolFunction = new CreateNewPoolFunction();
                createNewPoolFunction.PoolAmount = poolAmount;
                createNewPoolFunction.SourcePoolId = sourcePoolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewPoolFunction, cancellationToken);
        }

        public virtual Task<string> CreateNewPoolRequestAsync(long chainId, TContractType contractType, CreateNewPool1Function createNewPool1Function)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewPool1Function);
        }

        public virtual Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CreateNewPool1Function createNewPool1Function, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewPool1Function, cancellationToken);
        }

        public virtual Task<string> CreateNewPoolRequestAsync(long chainId, TContractType contractType, BigInteger poolAmount, string investSigner, string dispenserSigner, BigInteger sourcePoolId)
        {
            var createNewPool1Function = new CreateNewPool1Function();
                createNewPool1Function.PoolAmount = poolAmount;
                createNewPool1Function.InvestSigner = investSigner;
                createNewPool1Function.DispenserSigner = dispenserSigner;
                createNewPool1Function.SourcePoolId = sourcePoolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewPool1Function);
        }

        public virtual Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger poolAmount, string investSigner, string dispenserSigner, BigInteger sourcePoolId, CancellationTokenSource cancellationToken = null)
        {
            var createNewPool1Function = new CreateNewPool1Function();
                createNewPool1Function.PoolAmount = poolAmount;
                createNewPool1Function.InvestSigner = investSigner;
                createNewPool1Function.DispenserSigner = dispenserSigner;
                createNewPool1Function.SourcePoolId = sourcePoolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewPool1Function, cancellationToken);
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

        public virtual Task<string> DispenserProviderQueryAsync(long chainId, TContractType contractType, DispenserProviderFunction dispenserProviderFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<DispenserProviderFunction, string>(dispenserProviderFunction, blockParameter);
        }

        public virtual Task<string> DispenserProviderQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<DispenserProviderFunction, string>(null, blockParameter);
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

        public virtual Task<BigInteger> GetNonceQueryAsync(long chainId, TContractType contractType, GetNonceFunction getNonceFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetNonceFunction, BigInteger>(getNonceFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetNonceQueryAsync(long chainId, TContractType contractType, BigInteger poolId, string user, BlockParameter blockParameter = null)
        {
            var getNonceFunction = new GetNonceFunction();
                getNonceFunction.PoolId = poolId;
                getNonceFunction.User = user;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetNonceFunction, BigInteger>(getNonceFunction, blockParameter);
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

        public virtual Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(long chainId, TContractType contractType, BigInteger poolId, BlockParameter blockParameter = null)
        {
            var getSubProvidersPoolIdsFunction = new GetSubProvidersPoolIdsFunction();
                getSubProvidersPoolIdsFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetSubProvidersPoolIdsFunction, List<BigInteger>>(getSubProvidersPoolIdsFunction, blockParameter);
        }

        public virtual Task<GetUserInvestsOutputDTO> GetUserInvestsQueryAsync(long chainId, TContractType contractType, GetUserInvestsFunction getUserInvestsFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetUserInvestsFunction, GetUserInvestsOutputDTO>(getUserInvestsFunction, blockParameter);
        }

        public virtual Task<GetUserInvestsOutputDTO> GetUserInvestsQueryAsync(long chainId, TContractType contractType, BigInteger poolId, string user, BlockParameter blockParameter = null)
        {
            var getUserInvestsFunction = new GetUserInvestsFunction();
                getUserInvestsFunction.PoolId = poolId;
                getUserInvestsFunction.User = user;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetUserInvestsFunction, GetUserInvestsOutputDTO>(getUserInvestsFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, TContractType contractType, GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var getWithdrawableAmountFunction = new GetWithdrawableAmountFunction();
                getWithdrawableAmountFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        public virtual Task<string> InvestRequestAsync(long chainId, TContractType contractType, InvestFunction investFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(investFunction);
        }

        public virtual Task<TransactionReceipt> InvestRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, InvestFunction investFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(investFunction, cancellationToken);
        }

        public virtual Task<string> InvestRequestAsync(long chainId, TContractType contractType, BigInteger poolId, BigInteger amount, BigInteger validUntil, byte[] signature)
        {
            var investFunction = new InvestFunction();
                investFunction.PoolId = poolId;
                investFunction.Amount = amount;
                investFunction.ValidUntil = validUntil;
                investFunction.Signature = signature;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(investFunction);
        }

        public virtual Task<TransactionReceipt> InvestRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger poolId, BigInteger amount, BigInteger validUntil, byte[] signature, CancellationTokenSource cancellationToken = null)
        {
            var investFunction = new InvestFunction();
                investFunction.PoolId = poolId;
                investFunction.Amount = amount;
                investFunction.ValidUntil = validUntil;
                investFunction.Signature = signature;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(investFunction, cancellationToken);
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

        public virtual Task<PoolIdToInvestsOutputDTO> PoolIdToInvestsQueryAsync(long chainId, TContractType contractType, PoolIdToInvestsFunction poolIdToInvestsFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<PoolIdToInvestsFunction, PoolIdToInvestsOutputDTO>(poolIdToInvestsFunction, blockParameter);
        }

        public virtual Task<PoolIdToInvestsOutputDTO> PoolIdToInvestsQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, string returnValue2, BigInteger returnValue3, BlockParameter blockParameter = null)
        {
            var poolIdToInvestsFunction = new PoolIdToInvestsFunction();
                poolIdToInvestsFunction.ReturnValue1 = returnValue1;
                poolIdToInvestsFunction.ReturnValue2 = returnValue2;
                poolIdToInvestsFunction.ReturnValue3 = returnValue3;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<PoolIdToInvestsFunction, PoolIdToInvestsOutputDTO>(poolIdToInvestsFunction, blockParameter);
        }

        public virtual Task<PoolIdToPoolOutputDTO> PoolIdToPoolQueryAsync(long chainId, TContractType contractType, PoolIdToPoolFunction poolIdToPoolFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<PoolIdToPoolFunction, PoolIdToPoolOutputDTO>(poolIdToPoolFunction, blockParameter);
        }

        public virtual Task<PoolIdToPoolOutputDTO> PoolIdToPoolQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var poolIdToPoolFunction = new PoolIdToPoolFunction();
                poolIdToPoolFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<PoolIdToPoolFunction, PoolIdToPoolOutputDTO>(poolIdToPoolFunction, blockParameter);
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

        public virtual Task<string> WithdrawRequestAsync(long chainId, TContractType contractType, BigInteger returnValue1)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }
    }
}
