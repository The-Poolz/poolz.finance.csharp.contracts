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
using poolz.finance.csharp.contracts.DispenserProvider.ContractDefinition;

namespace poolz.finance.csharp.contracts.DispenserProvider
{
    public partial class DispenserProviderDeployingService
    {
        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.IWeb3 web3, DispenserProviderDeployment dispenserProviderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<DispenserProviderDeployment>().SendRequestAndWaitForReceiptAsync(dispenserProviderDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(Nethereum.Web3.IWeb3 web3, DispenserProviderDeployment dispenserProviderDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<DispenserProviderDeployment>().SendRequestAsync(dispenserProviderDeployment);
        }

        public virtual async Task<DispenserProviderService> DeployContractAndGetServiceAsync(Nethereum.Web3.IWeb3 web3, DispenserProviderDeployment dispenserProviderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, dispenserProviderDeployment, cancellationTokenSource);
            return new DispenserProviderService(web3, receipt.ContractAddress);
        }
    }
}
