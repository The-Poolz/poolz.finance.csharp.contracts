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
        Task<byte[]> BuilderTypehashQueryAsync(long chainId, Enum contractType, BuilderTypehashFunction builderTypehashFunction, BlockParameter blockParameter = null);

        Task<byte[]> BuilderTypehashQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<byte[]> MessageTypehashQueryAsync(long chainId, Enum contractType, MessageTypehashFunction messageTypehashFunction, BlockParameter blockParameter = null);

        Task<byte[]> MessageTypehashQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> AcceptFirewallAdminRequestAsync(long chainId, Enum contractType, AcceptFirewallAdminFunction acceptFirewallAdminFunction);

        Task<string> AcceptFirewallAdminRequestAsync(long chainId, Enum contractType);

        Task<TransactionReceipt> AcceptFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, AcceptFirewallAdminFunction acceptFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        Task<TransactionReceipt> AcceptFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewPoolRequestAsync(long chainId, Enum contractType, CreateNewPoolFunction createNewPoolFunction);

        Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CreateNewPoolFunction createNewPoolFunction, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewPoolRequestAsync(long chainId, Enum contractType, List<string> addresses, List<BigInteger> @params, byte[] signature);

        Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, List<string> addresses, List<BigInteger> @params, byte[] signature, CancellationTokenSource cancellationToken = null);

        Task<BigInteger> CurrentParamsTargetLengthQueryAsync(long chainId, Enum contractType, CurrentParamsTargetLengthFunction currentParamsTargetLengthFunction, BlockParameter blockParameter = null);

        Task<BigInteger> CurrentParamsTargetLengthQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> DispenseLockRequestAsync(long chainId, Enum contractType, DispenseLockFunction dispenseLockFunction);

        Task<TransactionReceipt> DispenseLockRequestAndWaitForReceiptAsync(long chainId, Enum contractType, DispenseLockFunction dispenseLockFunction, CancellationTokenSource cancellationToken = null);

        Task<string> DispenseLockRequestAsync(long chainId, Enum contractType, MessageStruct message, byte[] signature);

        Task<TransactionReceipt> DispenseLockRequestAndWaitForReceiptAsync(long chainId, Enum contractType, MessageStruct message, byte[] signature, CancellationTokenSource cancellationToken = null);

        Task<Eip712DomainOutputDTO> Eip712DomainQueryAsync(long chainId, Enum contractType, Eip712DomainFunction eip712DomainFunction, BlockParameter blockParameter = null);

        Task<Eip712DomainOutputDTO> Eip712DomainQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetParamsQueryAsync(long chainId, Enum contractType, GetParamsFunction getParamsFunction, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetParamsQueryAsync(long chainId, Enum contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(long chainId, Enum contractType, GetSubProvidersPoolIdsFunction getSubProvidersPoolIdsFunction, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(long chainId, Enum contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, Enum contractType, GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, Enum contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<bool> IsTakenQueryAsync(long chainId, Enum contractType, IsTakenFunction isTakenFunction, BlockParameter blockParameter = null);

        Task<bool> IsTakenQueryAsync(long chainId, Enum contractType, BigInteger returnValue1, string returnValue2, BlockParameter blockParameter = null);

        Task<string> LockDealNFTQueryAsync(long chainId, Enum contractType, LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null);

        Task<string> LockDealNFTQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> NameQueryAsync(long chainId, Enum contractType, NameFunction nameFunction, BlockParameter blockParameter = null);

        Task<string> NameQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<BigInteger> PoolIdToAmountQueryAsync(long chainId, Enum contractType, PoolIdToAmountFunction poolIdToAmountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> PoolIdToAmountQueryAsync(long chainId, Enum contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<string> RegisterPoolRequestAsync(long chainId, Enum contractType, RegisterPoolFunction registerPoolFunction);

        Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, RegisterPoolFunction registerPoolFunction, CancellationTokenSource cancellationToken = null);

        Task<string> RegisterPoolRequestAsync(long chainId, Enum contractType, BigInteger poolId, List<BigInteger> @params);

        Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger poolId, List<BigInteger> @params, CancellationTokenSource cancellationToken = null);

        Task<string> SafeFunctionCallRequestAsync(long chainId, Enum contractType, SafeFunctionCallFunction safeFunctionCallFunction);

        Task<TransactionReceipt> SafeFunctionCallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SafeFunctionCallFunction safeFunctionCallFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SafeFunctionCallRequestAsync(long chainId, Enum contractType, string vennPolicy, byte[] vennPolicyPayload, byte[] data);

        Task<TransactionReceipt> SafeFunctionCallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string vennPolicy, byte[] vennPolicyPayload, byte[] data, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovedVennPolicyRequestAsync(long chainId, Enum contractType, SetApprovedVennPolicyFunction setApprovedVennPolicyFunction);

        Task<TransactionReceipt> SetApprovedVennPolicyRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetApprovedVennPolicyFunction setApprovedVennPolicyFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovedVennPolicyRequestAsync(long chainId, Enum contractType, string vennPolicy, bool status);

        Task<TransactionReceipt> SetApprovedVennPolicyRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string vennPolicy, bool status, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovedVennPolicyFeeRequestAsync(long chainId, Enum contractType, SetApprovedVennPolicyFeeFunction setApprovedVennPolicyFeeFunction);

        Task<TransactionReceipt> SetApprovedVennPolicyFeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetApprovedVennPolicyFeeFunction setApprovedVennPolicyFeeFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovedVennPolicyFeeRequestAsync(long chainId, Enum contractType, BigInteger fee);

        Task<TransactionReceipt> SetApprovedVennPolicyFeeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger fee, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, string firewall);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewall, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, string firewallAdmin);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null);

        Task<string> SplitRequestAsync(long chainId, Enum contractType, SplitFunction splitFunction);

        Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SplitFunction splitFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SplitRequestAsync(long chainId, Enum contractType, BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio);

        Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio, CancellationTokenSource cancellationToken = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, Enum contractType, SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, Enum contractType, byte[] interfaceId, BlockParameter blockParameter = null);

        Task<string> WithdrawRequestAsync(long chainId, Enum contractType, WithdrawFunction withdrawFunction);

        Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, Enum contractType, WithdrawFunction withdrawFunction, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawRequestAsync(long chainId, Enum contractType, BigInteger poolId);

        Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger poolId, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawRequestAsync(long chainId, Enum contractType, Withdraw1Function withdraw1Function);

        Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, Enum contractType, Withdraw1Function withdraw1Function, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawRequestAsync(long chainId, Enum contractType, BigInteger poolId, BigInteger amount);

        Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger poolId, BigInteger amount, CancellationTokenSource cancellationToken = null);
    }
}
