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
using poolz.finance.csharp.contracts.VaultManager.ContractDefinition;

namespace poolz.finance.csharp.contracts.VaultManager
{
    public partial class VaultManagerDeployingService
    {
        public IChainProvider ChainProvider { get; }

        public VaultManagerDeployingService(IChainProvider chainProvider)
        {
            ChainProvider = chainProvider;
        }

        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(long chainId, VaultManagerDeployment vaultManagerDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var web3 = ChainProvider.Web3(chainId);
            return web3.Eth.GetContractDeploymentHandler<VaultManagerDeployment>().SendRequestAndWaitForReceiptAsync(vaultManagerDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(long chainId, VaultManagerDeployment vaultManagerDeployment)
        {
            var web3 = ChainProvider.Web3(chainId);
            return web3.Eth.GetContractDeploymentHandler<VaultManagerDeployment>().SendRequestAsync(vaultManagerDeployment);
        }
    }
}
