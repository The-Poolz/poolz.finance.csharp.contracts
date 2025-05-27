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
using poolz.finance.csharp.contracts.BeaconToken.ContractDefinition;

namespace poolz.finance.csharp.contracts.BeaconToken
{
    public partial class BeaconTokenDeployingService
    {
        public IChainProvider ChainProvider { get; }

        public BeaconTokenDeployingService(IChainProvider chainProvider)
        {
            ChainProvider = chainProvider;
        }

        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(long chainId, BeaconTokenDeployment beaconTokenDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var web3 = ChainProvider.Web3(chainId);
            return web3.Eth.GetContractDeploymentHandler<BeaconTokenDeployment>().SendRequestAndWaitForReceiptAsync(beaconTokenDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(long chainId, BeaconTokenDeployment beaconTokenDeployment)
        {
            var web3 = ChainProvider.Web3(chainId);
            return web3.Eth.GetContractDeploymentHandler<BeaconTokenDeployment>().SendRequestAsync(beaconTokenDeployment);
        }
    }
}
