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
        Task<string> BuildMassPoolsRequestAsync(long chainId, Enum contractType, BuildMassPoolsFunction buildMassPoolsFunction);

        Task<TransactionReceipt> BuildMassPoolsRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BuildMassPoolsFunction buildMassPoolsFunction, CancellationTokenSource cancellationToken = null);

        Task<string> BuildMassPoolsRequestAsync(long chainId, Enum contractType, List<string> addressParams, Builder userData, List<BigInteger> @params, byte[] signature);

        Task<TransactionReceipt> BuildMassPoolsRequestAndWaitForReceiptAsync(long chainId, Enum contractType, List<string> addressParams, Builder userData, List<BigInteger> @params, byte[] signature, CancellationTokenSource cancellationToken = null);

        Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> LockDealNFTQueryAsync(long chainId, Enum contractType, LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null);

        Task<string> LockDealNFTQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null);

        Task<string> OnERC721ReceivedRequestAsync(long chainId, Enum contractType, OnERC721ReceivedFunction onERC721ReceivedFunction);

        Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(long chainId, Enum contractType, OnERC721ReceivedFunction onERC721ReceivedFunction, CancellationTokenSource cancellationToken = null);

        Task<string> OnERC721ReceivedRequestAsync(long chainId, Enum contractType, string returnValue1, string returnValue2, BigInteger returnValue3, byte[] returnValue4);

        Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string returnValue1, string returnValue2, BigInteger returnValue3, byte[] returnValue4, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, string firewall);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewall, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, string firewallAdmin);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null);
    }
}
