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
using NethereumGenerators.Interfaces;
using poolz.finance.csharp.contracts.PoolzBack.ContractDefinition;

namespace poolz.finance.csharp.contracts.PoolzBack
{
    public partial class PoolzBackDeployingService
    {
        public IChainProvider ChainProvider { get; }

        public PoolzBackDeployingService(IChainProvider chainProvider)
        {
            ChainProvider = chainProvider;
        }

        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(long chainId, PoolzBackDeployment poolzBackDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var web3 = ChainProvider.Web3(chainId);
            return web3.Eth.GetContractDeploymentHandler<PoolzBackDeployment>().SendRequestAndWaitForReceiptAsync(poolzBackDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(long chainId, PoolzBackDeployment poolzBackDeployment)
        {
            var web3 = ChainProvider.Web3(chainId);
            return web3.Eth.GetContractDeploymentHandler<PoolzBackDeployment>().SendRequestAsync(poolzBackDeployment);
        }
    }
}
