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
using poolz.finance.csharp.contracts.TemporaryToken.ContractDefinition;

namespace poolz.finance.csharp.contracts.TemporaryToken
{
    public partial class TemporaryTokenDeployingService
    {
        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.IWeb3 web3, TemporaryTokenDeployment temporaryTokenDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<TemporaryTokenDeployment>().SendRequestAndWaitForReceiptAsync(temporaryTokenDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(Nethereum.Web3.IWeb3 web3, TemporaryTokenDeployment temporaryTokenDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<TemporaryTokenDeployment>().SendRequestAsync(temporaryTokenDeployment);
        }

        public virtual async Task<TemporaryTokenService> DeployContractAndGetServiceAsync(Nethereum.Web3.IWeb3 web3, TemporaryTokenDeployment temporaryTokenDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, temporaryTokenDeployment, cancellationTokenSource);
            return new TemporaryTokenService(web3, receipt.ContractAddress);
        }
    }
}
