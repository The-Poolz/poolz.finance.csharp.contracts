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
    public partial class SimpleBuilderDeployingService
    {
        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.IWeb3 web3, SimpleBuilderDeployment simpleBuilderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<SimpleBuilderDeployment>().SendRequestAndWaitForReceiptAsync(simpleBuilderDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(Nethereum.Web3.IWeb3 web3, SimpleBuilderDeployment simpleBuilderDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<SimpleBuilderDeployment>().SendRequestAsync(simpleBuilderDeployment);
        }

        public virtual async Task<SimpleBuilderService> DeployContractAndGetServiceAsync(Nethereum.Web3.IWeb3 web3, SimpleBuilderDeployment simpleBuilderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, simpleBuilderDeployment, cancellationTokenSource);
            return new SimpleBuilderService(web3, receipt.ContractAddress);
        }
    }
}
