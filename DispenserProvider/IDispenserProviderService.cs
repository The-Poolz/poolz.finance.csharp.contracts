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
    public interface IDispenserProviderService<in TContractType>
        where TContractType : Enum
    {
        Task<byte[]> BuilderTypehashQueryAsync(long chainId, TContractType contractType, BuilderTypehashFunction builderTypehashFunction, BlockParameter blockParameter = null);

        Task<byte[]> BuilderTypehashQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<byte[]> MessageTypehashQueryAsync(long chainId, TContractType contractType, MessageTypehashFunction messageTypehashFunction, BlockParameter blockParameter = null);

        Task<byte[]> MessageTypehashQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> AcceptFirewallAdminRequestAsync(long chainId, TContractType contractType, AcceptFirewallAdminFunction acceptFirewallAdminFunction);

        Task<string> AcceptFirewallAdminRequestAsync(long chainId, TContractType contractType);

        Task<TransactionReceipt> AcceptFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, AcceptFirewallAdminFunction acceptFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        Task<TransactionReceipt> AcceptFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewPoolRequestAsync(long chainId, TContractType contractType, CreateNewPoolFunction createNewPoolFunction);

        Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CreateNewPoolFunction createNewPoolFunction, CancellationTokenSource cancellationToken = null);

        Task<string> CreateNewPoolRequestAsync(long chainId, TContractType contractType, List<string> addresses, List<BigInteger> @params, byte[] signature);

        Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, List<string> addresses, List<BigInteger> @params, byte[] signature, CancellationTokenSource cancellationToken = null);

        Task<BigInteger> CurrentParamsTargetLengthQueryAsync(long chainId, TContractType contractType, CurrentParamsTargetLengthFunction currentParamsTargetLengthFunction, BlockParameter blockParameter = null);

        Task<BigInteger> CurrentParamsTargetLengthQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> DispenseLockRequestAsync(long chainId, TContractType contractType, DispenseLockFunction dispenseLockFunction);

        Task<TransactionReceipt> DispenseLockRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, DispenseLockFunction dispenseLockFunction, CancellationTokenSource cancellationToken = null);

        Task<string> DispenseLockRequestAsync(long chainId, TContractType contractType, MessageStruct message, byte[] signature);

        Task<TransactionReceipt> DispenseLockRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, MessageStruct message, byte[] signature, CancellationTokenSource cancellationToken = null);

        Task<Eip712DomainOutputDTO> Eip712DomainQueryAsync(long chainId, TContractType contractType, Eip712DomainFunction eip712DomainFunction, BlockParameter blockParameter = null);

        Task<Eip712DomainOutputDTO> Eip712DomainQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetParamsQueryAsync(long chainId, TContractType contractType, GetParamsFunction getParamsFunction, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetParamsQueryAsync(long chainId, TContractType contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(long chainId, TContractType contractType, GetSubProvidersPoolIdsFunction getSubProvidersPoolIdsFunction, BlockParameter blockParameter = null);

        Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, TContractType contractType, GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, TContractType contractType, BigInteger poolId, BlockParameter blockParameter = null);

        Task<bool> IsTakenQueryAsync(long chainId, TContractType contractType, IsTakenFunction isTakenFunction, BlockParameter blockParameter = null);

        Task<bool> IsTakenQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, string returnValue2, BlockParameter blockParameter = null);

        Task<string> LockDealNFTQueryAsync(long chainId, TContractType contractType, LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null);

        Task<string> LockDealNFTQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> NameQueryAsync(long chainId, TContractType contractType, NameFunction nameFunction, BlockParameter blockParameter = null);

        Task<string> NameQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<BigInteger> PoolIdToAmountQueryAsync(long chainId, TContractType contractType, PoolIdToAmountFunction poolIdToAmountFunction, BlockParameter blockParameter = null);

        Task<BigInteger> PoolIdToAmountQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null);

        Task<string> RegisterPoolRequestAsync(long chainId, TContractType contractType, RegisterPoolFunction registerPoolFunction);

        Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, RegisterPoolFunction registerPoolFunction, CancellationTokenSource cancellationToken = null);

        Task<string> RegisterPoolRequestAsync(long chainId, TContractType contractType, BigInteger poolId, List<BigInteger> @params);

        Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger poolId, List<BigInteger> @params, CancellationTokenSource cancellationToken = null);

        Task<string> SafeFunctionCallRequestAsync(long chainId, TContractType contractType, SafeFunctionCallFunction safeFunctionCallFunction);

        Task<TransactionReceipt> SafeFunctionCallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SafeFunctionCallFunction safeFunctionCallFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SafeFunctionCallRequestAsync(long chainId, TContractType contractType, string vennPolicy, byte[] vennPolicyPayload, byte[] data);

        Task<TransactionReceipt> SafeFunctionCallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string vennPolicy, byte[] vennPolicyPayload, byte[] data, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovedVennPolicyRequestAsync(long chainId, TContractType contractType, SetApprovedVennPolicyFunction setApprovedVennPolicyFunction);

        Task<TransactionReceipt> SetApprovedVennPolicyRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetApprovedVennPolicyFunction setApprovedVennPolicyFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovedVennPolicyRequestAsync(long chainId, TContractType contractType, string vennPolicy, bool status);

        Task<TransactionReceipt> SetApprovedVennPolicyRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string vennPolicy, bool status, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovedVennPolicyFeeRequestAsync(long chainId, TContractType contractType, SetApprovedVennPolicyFeeFunction setApprovedVennPolicyFeeFunction);

        Task<TransactionReceipt> SetApprovedVennPolicyFeeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetApprovedVennPolicyFeeFunction setApprovedVennPolicyFeeFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetApprovedVennPolicyFeeRequestAsync(long chainId, TContractType contractType, BigInteger fee);

        Task<TransactionReceipt> SetApprovedVennPolicyFeeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger fee, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, string firewall);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewall, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, string firewallAdmin);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null);

        Task<string> SplitRequestAsync(long chainId, TContractType contractType, SplitFunction splitFunction);

        Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SplitFunction splitFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SplitRequestAsync(long chainId, TContractType contractType, BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio);

        Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio, CancellationTokenSource cancellationToken = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, TContractType contractType, SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null);

        Task<bool> SupportsInterfaceQueryAsync(long chainId, TContractType contractType, byte[] interfaceId, BlockParameter blockParameter = null);

        Task<string> WithdrawRequestAsync(long chainId, TContractType contractType, WithdrawFunction withdrawFunction);

        Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, WithdrawFunction withdrawFunction, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawRequestAsync(long chainId, TContractType contractType, BigInteger poolId);

        Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger poolId, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawRequestAsync(long chainId, TContractType contractType, Withdraw1Function withdraw1Function);

        Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, Withdraw1Function withdraw1Function, CancellationTokenSource cancellationToken = null);

        Task<string> WithdrawRequestAsync(long chainId, TContractType contractType, BigInteger poolId, BigInteger amount);

        Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger poolId, BigInteger amount, CancellationTokenSource cancellationToken = null);
    }
}
