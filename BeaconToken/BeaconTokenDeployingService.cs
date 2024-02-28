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
using poolz.finance.csharp.contracts.BeaconToken.ContractDefinition;

namespace poolz.finance.csharp.contracts.BeaconToken
{
    public partial class BeaconTokenDeployingService
    {
        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.IWeb3 web3, BeaconTokenDeployment beaconTokenDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<BeaconTokenDeployment>().SendRequestAndWaitForReceiptAsync(beaconTokenDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(Nethereum.Web3.IWeb3 web3, BeaconTokenDeployment beaconTokenDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<BeaconTokenDeployment>().SendRequestAsync(beaconTokenDeployment);
        }

        public virtual async Task<BeaconTokenService> DeployContractAndGetServiceAsync(Nethereum.Web3.IWeb3 web3, BeaconTokenDeployment beaconTokenDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, beaconTokenDeployment, cancellationTokenSource);
            return new BeaconTokenService(web3, receipt.ContractAddress);
        }
    }
}
