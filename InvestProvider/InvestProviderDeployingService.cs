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
    public partial class InvestProviderDeployingService
    {
        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.IWeb3 web3, InvestProviderDeployment investProviderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<InvestProviderDeployment>().SendRequestAndWaitForReceiptAsync(investProviderDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(Nethereum.Web3.IWeb3 web3, InvestProviderDeployment investProviderDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<InvestProviderDeployment>().SendRequestAsync(investProviderDeployment);
        }

        public virtual async Task<InvestProviderService> DeployContractAndGetServiceAsync(Nethereum.Web3.IWeb3 web3, InvestProviderDeployment investProviderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, investProviderDeployment, cancellationTokenSource);
            return new InvestProviderService(web3, receipt.ContractAddress);
        }
    }
}
