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
using poolz.finance.csharp.contracts.SimpleBuilder.ContractDefinition;

namespace poolz.finance.csharp.contracts.SimpleBuilder
{
    public interface ISimpleBuilderService
    {
        public Task<string> BuildMassPoolsRequestAsync(BuildMassPoolsFunction buildMassPoolsFunction);

        public Task<TransactionReceipt> BuildMassPoolsRequestAndWaitForReceiptAsync(BuildMassPoolsFunction buildMassPoolsFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> BuildMassPoolsRequestAsync(List<string> addressParams, Builder userData, List<BigInteger> @params, byte[] signature);

        public Task<TransactionReceipt> BuildMassPoolsRequestAndWaitForReceiptAsync(List<string> addressParams, Builder userData, List<BigInteger> @params, byte[] signature, CancellationTokenSource cancellationToken = null);

        public Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        public Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null);

        public Task<string> LockDealNFTQueryAsync(LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null);

        public Task<string> LockDealNFTQueryAsync(BlockParameter blockParameter = null);

        public Task<string> OnERC721ReceivedRequestAsync(OnERC721ReceivedFunction onERC721ReceivedFunction);

        public Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(OnERC721ReceivedFunction onERC721ReceivedFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> OnERC721ReceivedRequestAsync(string returnValue1, string returnValue2, BigInteger returnValue3, byte[] returnValue4);

        public Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(string returnValue1, string returnValue2, BigInteger returnValue3, byte[] returnValue4, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallRequestAsync(SetFirewallFunction setFirewallFunction);

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallRequestAsync(string firewall);

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(string firewall, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallAdminRequestAsync(SetFirewallAdminFunction setFirewallAdminFunction);

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        public Task<string> SetFirewallAdminRequestAsync(string firewallAdmin);

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(string firewallAdmin, CancellationTokenSource cancellationToken = null);

        public void Initialize(IWeb3 web3, string contractAddress);
    }
}
