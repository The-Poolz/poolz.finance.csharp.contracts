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
using poolz.finance.csharp.contracts.DelayVaultProvider.ContractDefinition;

namespace poolz.finance.csharp.contracts.DelayVaultProvider
{
    public partial class DelayVaultProviderDeployingService
    {
        public IChainProvider ChainProvider { get; }

        public DelayVaultProviderDeployingService(IChainProvider chainProvider)
        {
            ChainProvider = chainProvider;
        }

        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(long chainId, DelayVaultProviderDeployment delayVaultProviderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var web3 = ChainProvider.Web3(chainId);
            return web3.Eth.GetContractDeploymentHandler<DelayVaultProviderDeployment>().SendRequestAndWaitForReceiptAsync(delayVaultProviderDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(long chainId, DelayVaultProviderDeployment delayVaultProviderDeployment)
        {
            var web3 = ChainProvider.Web3(chainId);
            return web3.Eth.GetContractDeploymentHandler<DelayVaultProviderDeployment>().SendRequestAsync(delayVaultProviderDeployment);
        }
    }
}
