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
using poolz.finance.csharp.contracts.SimpleRefundBuilder.ContractDefinition;

namespace poolz.finance.csharp.contracts.SimpleRefundBuilder
{
    public partial class SimpleRefundBuilderDeployingService
    {
        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.IWeb3 web3, SimpleRefundBuilderDeployment simpleRefundBuilderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<SimpleRefundBuilderDeployment>().SendRequestAndWaitForReceiptAsync(simpleRefundBuilderDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(Nethereum.Web3.IWeb3 web3, SimpleRefundBuilderDeployment simpleRefundBuilderDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<SimpleRefundBuilderDeployment>().SendRequestAsync(simpleRefundBuilderDeployment);
        }

        public virtual async Task<SimpleRefundBuilderService> DeployContractAndGetServiceAsync(Nethereum.Web3.IWeb3 web3, SimpleRefundBuilderDeployment simpleRefundBuilderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, simpleRefundBuilderDeployment, cancellationTokenSource);
            return new SimpleRefundBuilderService(web3, receipt.ContractAddress);
        }
    }
}
