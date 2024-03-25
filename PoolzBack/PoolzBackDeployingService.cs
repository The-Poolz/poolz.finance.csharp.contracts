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
using poolz.finance.csharp.contracts.PoolzBack.ContractDefinition;

namespace poolz.finance.csharp.contracts.PoolzBack
{
    public partial class PoolzBackDeployingService
    {
        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.IWeb3 web3, PoolzBackDeployment poolzBackDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<PoolzBackDeployment>().SendRequestAndWaitForReceiptAsync(poolzBackDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(Nethereum.Web3.IWeb3 web3, PoolzBackDeployment poolzBackDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<PoolzBackDeployment>().SendRequestAsync(poolzBackDeployment);
        }

        public virtual async Task<PoolzBackService> DeployContractAndGetServiceAsync(Nethereum.Web3.IWeb3 web3, PoolzBackDeployment poolzBackDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, poolzBackDeployment, cancellationTokenSource);
            return new PoolzBackService(web3, receipt.ContractAddress);
        }
    }
}
