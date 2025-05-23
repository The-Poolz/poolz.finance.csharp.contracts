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
using poolz.finance.csharp.contracts.InvestProvider.ContractDefinition;

namespace poolz.finance.csharp.contracts.InvestProvider
{
    public interface IInvestProviderService
    {
        public Task<byte[]> InvestTypehashQueryAsync(InvestTypehashFunction investTypehashFunction, BlockParameter blockParameter = null);

        public Task<byte[]> InvestTypehashQueryAsync(BlockParameter blockParameter = null);

        public Task<string> AcceptFirewallAdminRequestAsync(AcceptFirewallAdminFunction acceptFirewallAdminFunction);

        public Task<string> AcceptFirewallAdminRequestAsync();

        public Task<TransactionReceipt> AcceptFirewallAdminRequestAndWaitForReceiptAsync(AcceptFirewallAdminFunction acceptFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        public Task<TransactionReceipt> AcceptFirewallAdminRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewPoolRequestAsync(CreateNewPoolFunction createNewPoolFunction);

        public Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(CreateNewPoolFunction createNewPoolFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewPoolRequestAsync(BigInteger poolAmount, BigInteger sourcePoolId);

        public Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(BigInteger poolAmount, BigInteger sourcePoolId, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewPoolRequestAsync(CreateNewPool1Function createNewPool1Function);

        public Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(CreateNewPool1Function createNewPool1Function, CancellationTokenSource cancellationToken = null);

        public Task<string> CreateNewPoolRequestAsync(BigInteger poolAmount, string investSigner, string dispenserSigner, BigInteger sourcePoolId);

        public Task<TransactionReceipt> CreateNewPoolRequestAndWaitForReceiptAsync(BigInteger poolAmount, string investSigner, string dispenserSigner, BigInteger sourcePoolId, CancellationTokenSource cancellationToken = null);

        public Task<BigInteger> CurrentParamsTargetLengthQueryAsync(CurrentParamsTargetLengthFunction currentParamsTargetLengthFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> CurrentParamsTargetLengthQueryAsync(BlockParameter blockParameter = null);

        public Task<string> DispenserProviderQueryAsync(DispenserProviderFunction dispenserProviderFunction, BlockParameter blockParameter = null);

        public Task<string> DispenserProviderQueryAsync(BlockParameter blockParameter = null);

        public Task<Eip712DomainOutputDTO> Eip712DomainQueryAsync(Eip712DomainFunction eip712DomainFunction, BlockParameter blockParameter = null);

        public Task<Eip712DomainOutputDTO> Eip712DomainQueryAsync(BlockParameter blockParameter = null);

        public Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        public Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null);

        public Task<BigInteger> GetNonceQueryAsync(GetNonceFunction getNonceFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> GetNonceQueryAsync(BigInteger poolId, string user, BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetParamsQueryAsync(GetParamsFunction getParamsFunction, BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetParamsQueryAsync(BigInteger poolId, BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(GetSubProvidersPoolIdsFunction getSubProvidersPoolIdsFunction, BlockParameter blockParameter = null);

        public Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(BigInteger poolId, BlockParameter blockParameter = null);

        public Task<GetUserInvestsOutputDTO> GetUserInvestsQueryAsync(GetUserInvestsFunction getUserInvestsFunction, BlockParameter blockParameter = null);

        public Task<GetUserInvestsOutputDTO> GetUserInvestsQueryAsync(BigInteger poolId, string user, BlockParameter blockParameter = null);

        public Task<BigInteger> GetWithdrawableAmountQueryAsync(GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null);

        public Task<BigInteger> GetWithdrawableAmountQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null);

        public Task<string> InvestRequestAsync(InvestFunction investFunction);

        public Task<TransactionReceipt> InvestRequestAndWaitForReceiptAsync(InvestFunction investFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> InvestRequestAsync(BigInteger poolId, BigInteger amount, BigInteger validUntil, byte[] signature);

        public Task<TransactionReceipt> InvestRequestAndWaitForReceiptAsync(BigInteger poolId, BigInteger amount, BigInteger validUntil, byte[] signature, CancellationTokenSource cancellationToken = null);

        public Task<string> LockDealNFTQueryAsync(LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null);

        public Task<string> LockDealNFTQueryAsync(BlockParameter blockParameter = null);

        public Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null);

        public Task<string> NameQueryAsync(BlockParameter blockParameter = null);

        public Task<PoolIdToInvestsOutputDTO> PoolIdToInvestsQueryAsync(PoolIdToInvestsFunction poolIdToInvestsFunction, BlockParameter blockParameter = null);

        public Task<PoolIdToInvestsOutputDTO> PoolIdToInvestsQueryAsync(BigInteger returnValue1, string returnValue2, BigInteger returnValue3, BlockParameter blockParameter = null);

        public Task<PoolIdToPoolOutputDTO> PoolIdToPoolQueryAsync(PoolIdToPoolFunction poolIdToPoolFunction, BlockParameter blockParameter = null);

        public Task<PoolIdToPoolOutputDTO> PoolIdToPoolQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null);

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

        public Task<string> WithdrawRequestAsync(BigInteger returnValue1);

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(BigInteger returnValue1, CancellationTokenSource cancellationToken = null);

        public void Initialize(IWeb3 web3, string contractAddress);
    }
}
