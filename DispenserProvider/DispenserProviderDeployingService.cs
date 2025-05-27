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
using poolz.finance.csharp.contracts.DispenserProvider.ContractDefinition;

namespace poolz.finance.csharp.contracts.DispenserProvider
{
    public partial class DispenserProviderDeployingService
    {
        public IChainProvider ChainProvider { get; }

        public DispenserProviderDeployingService(IChainProvider chainProvider)
        {
            ChainProvider = chainProvider;
        }

        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(long chainId, DispenserProviderDeployment dispenserProviderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var web3 = ChainProvider.Web3(chainId);
            return web3.Eth.GetContractDeploymentHandler<DispenserProviderDeployment>().SendRequestAndWaitForReceiptAsync(dispenserProviderDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(long chainId, DispenserProviderDeployment dispenserProviderDeployment)
        {
            var web3 = ChainProvider.Web3(chainId);
            return web3.Eth.GetContractDeploymentHandler<DispenserProviderDeployment>().SendRequestAsync(dispenserProviderDeployment);
        }
    }
}
