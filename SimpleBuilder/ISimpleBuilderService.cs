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
    public interface ISimpleBuilderService<in TContractType>
        where TContractType : Enum
    {
        Task<string> BuildMassPoolsRequestAsync(long chainId, TContractType contractType, BuildMassPoolsFunction buildMassPoolsFunction);

        Task<TransactionReceipt> BuildMassPoolsRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BuildMassPoolsFunction buildMassPoolsFunction, CancellationTokenSource cancellationToken = null);

        Task<string> BuildMassPoolsRequestAsync(long chainId, TContractType contractType, List<string> addressParams, Builder userData, List<BigInteger> @params, byte[] signature);

        Task<TransactionReceipt> BuildMassPoolsRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, List<string> addressParams, Builder userData, List<BigInteger> @params, byte[] signature, CancellationTokenSource cancellationToken = null);

        Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null);

        Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> LockDealNFTQueryAsync(long chainId, TContractType contractType, LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null);

        Task<string> LockDealNFTQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null);

        Task<string> OnERC721ReceivedRequestAsync(long chainId, TContractType contractType, OnERC721ReceivedFunction onERC721ReceivedFunction);

        Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, OnERC721ReceivedFunction onERC721ReceivedFunction, CancellationTokenSource cancellationToken = null);

        Task<string> OnERC721ReceivedRequestAsync(long chainId, TContractType contractType, string returnValue1, string returnValue2, BigInteger returnValue3, byte[] returnValue4);

        Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string returnValue1, string returnValue2, BigInteger returnValue3, byte[] returnValue4, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, string firewall);

        Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewall, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null);

        Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, string firewallAdmin);

        Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null);
    }
}
