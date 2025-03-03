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
    public interface IDispenserProviderService
    {
        public Task<byte[]> BuilderTypehashQueryAsync(BuilderTypehashFunction builderTypehashFunction, BlockParameter blockParameter = null);

        public Task<byte[]> BuilderTypehashQueryAsync(BlockParameter blockParameter = null);

        public Task<byte[]> MessageTypehashQueryAsync(MessageTypehashFunction messageTypehashFunction, BlockParameter blockParameter = null);

        public Task<byte[]> MessageTypehashQueryAsync(BlockParameter blockParameter = null);

        public Task<string> AcceptFirewallAdminRequestAsync(AcceptFirewallAdminFunction acceptFirewallAdminFunction);

        public Task<string> AcceptFirewallAdminRequestAsync();

        public Task<TransactionReceipt> AcceptFirewallAdminRequestAndWaitForReceiptAsync(AcceptFirewallAdminFunction acceptFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        public Task<TransactionReceipt> AcceptFirewallAdminRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewPoolRequestAsync(CreateNewPoolFunction createNewPoolFunction);

        public Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(CreateNewPoolFunction createNewPoolFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewPoolRequestAsync(List<string> addresses, List<BigInteger> @params, byte[] signature);

        public Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(List<string> addresses, List<BigInteger> @params, byte[] signature, CancellationTokenSource cancellationToken = null);

        public Task<BigInteger> CurrentParamsTargetLengthQueryAsync(CurrentParamsTargetLengthFunction currentParamsTargetLengthFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> CurrentParamsTargetLengthQueryAsync(BlockParameter blockParameter = null);

        public Task<string> DispenseLockRequestAsync(DispenseLockFunction dispenseLockFunction);

        public Task<TransactionReceipt> DispenseLockRequestAndWaitForReceiptAsync(DispenseLockFunction dispenseLockFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> DispenseLockRequestAsync(MessageStruct message, byte[] signature);

        public Task<TransactionReceipt> DispenseLockRequestAndWaitForReceiptAsync(MessageStruct message, byte[] signature, CancellationTokenSource cancellationToken = null);

        public Task<Eip712DomainOutputDTO> Eip712DomainQueryAsync(Eip712DomainFunction eip712DomainFunction, BlockParameter blockParameter = null);

        public Task<Eip712DomainOutputDTO> Eip712DomainQueryAsync(BlockParameter blockParameter = null);

        public Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        public Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetParamsQueryAsync(GetParamsFunction getParamsFunction, BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetParamsQueryAsync(BigInteger poolId, BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(GetSubProvidersPoolIdsFunction getSubProvidersPoolIdsFunction, BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null);

        public Task<BigInteger> GetWithdrawableAmountQueryAsync(GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> GetWithdrawableAmountQueryAsync(BigInteger poolId, BlockParameter blockParameter = null);

        public Task<bool> IsTakenQueryAsync(IsTakenFunction isTakenFunction, BlockParameter blockParameter = null);

        public Task<bool> IsTakenQueryAsync(BigInteger returnValue1, string returnValue2, BlockParameter blockParameter = null);

        public Task<string> LockDealNFTQueryAsync(LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null);

        public Task<string> LockDealNFTQueryAsync(BlockParameter blockParameter = null);

        public Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null);

        public Task<string> NameQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> PoolIdToAmountQueryAsync(PoolIdToAmountFunction poolIdToAmountFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> PoolIdToAmountQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null);

        public Task<string> RegisterPoolRequestAsync(RegisterPoolFunction registerPoolFunction);

        public Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(RegisterPoolFunction registerPoolFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> RegisterPoolRequestAsync(BigInteger poolId, List<BigInteger> @params);

        public Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(BigInteger poolId, List<BigInteger> @params, CancellationTokenSource cancellationToken = null);

        public Task<string> SafeFunctionCallRequestAsync(SafeFunctionCallFunction safeFunctionCallFunction);

        public Task<TransactionReceipt> SafeFunctionCallRequestAndWaitForReceiptAsync(SafeFunctionCallFunction safeFunctionCallFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SafeFunctionCallRequestAsync(string vennPolicy, byte[] vennPolicyPayload, byte[] data);

        public Task<TransactionReceipt> SafeFunctionCallRequestAndWaitForReceiptAsync(string vennPolicy, byte[] vennPolicyPayload, byte[] data, CancellationTokenSource cancellationToken = null);

        public Task<string> SetApprovedVennPolicyRequestAsync(SetApprovedVennPolicyFunction setApprovedVennPolicyFunction);

        public Task<TransactionReceipt> SetApprovedVennPolicyRequestAndWaitForReceiptAsync(SetApprovedVennPolicyFunction setApprovedVennPolicyFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetApprovedVennPolicyRequestAsync(string vennPolicy, bool status);

        public Task<TransactionReceipt> SetApprovedVennPolicyRequestAndWaitForReceiptAsync(string vennPolicy, bool status, CancellationTokenSource cancellationToken = null);

        public Task<string> SetApprovedVennPolicyFeeRequestAsync(SetApprovedVennPolicyFeeFunction setApprovedVennPolicyFeeFunction);

        public Task<TransactionReceipt> SetApprovedVennPolicyFeeRequestAndWaitForReceiptAsync(SetApprovedVennPolicyFeeFunction setApprovedVennPolicyFeeFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetApprovedVennPolicyFeeRequestAsync(BigInteger fee);

        public Task<TransactionReceipt> SetApprovedVennPolicyFeeRequestAndWaitForReceiptAsync(BigInteger fee, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallRequestAsync(SetFirewallFunction setFirewallFunction);

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallRequestAsync(string firewall);

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(string firewall, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallAdminRequestAsync(SetFirewallAdminFunction setFirewallAdminFunction);

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallAdminRequestAsync(string firewallAdmin);

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(string firewallAdmin, CancellationTokenSource cancellationToken = null);

        public Task<string> SplitRequestAsync(SplitFunction splitFunction);

        public Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(SplitFunction splitFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SplitRequestAsync(BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio);

        public Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio, CancellationTokenSource cancellationToken = null);

        public Task<bool> SupportsInterfaceQueryAsync(SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null);

        public Task<bool> SupportsInterfaceQueryAsync(byte[] interfaceId, BlockParameter blockParameter = null);

        public Task<string> WithdrawRequestAsync(WithdrawFunction withdrawFunction);

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(WithdrawFunction withdrawFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> WithdrawRequestAsync(BigInteger poolId);

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(BigInteger poolId, CancellationTokenSource cancellationToken = null);

        public Task<string> WithdrawRequestAsync(Withdraw1Function withdraw1Function);

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(Withdraw1Function withdraw1Function, CancellationTokenSource cancellationToken = null);

        public Task<string> WithdrawRequestAsync(BigInteger poolId, BigInteger amount);

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(BigInteger poolId, BigInteger amount, CancellationTokenSource cancellationToken = null);

        public void Initialize(IWeb3 web3, string contractAddress);
    }
}
