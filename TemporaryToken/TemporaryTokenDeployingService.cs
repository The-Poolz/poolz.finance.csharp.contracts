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
using poolz.finance.csharp.contracts.TemporaryToken.ContractDefinition;

namespace poolz.finance.csharp.contracts.TemporaryToken
{
    public partial class TemporaryTokenDeployingService
    {
        public IChainProvider ChainProvider { get; }

        public TemporaryTokenDeployingService(IChainProvider chainProvider)
        {
            ChainProvider = chainProvider;
        }

        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(long chainId, TemporaryTokenDeployment temporaryTokenDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var web3 = ChainProvider.Web3(chainId);
            return web3.Eth.GetContractDeploymentHandler<TemporaryTokenDeployment>().SendRequestAndWaitForReceiptAsync(temporaryTokenDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(long chainId, TemporaryTokenDeployment temporaryTokenDeployment)
        {
            var web3 = ChainProvider.Web3(chainId);
            return web3.Eth.GetContractDeploymentHandler<TemporaryTokenDeployment>().SendRequestAsync(temporaryTokenDeployment);
        }
    }
}
