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
using poolz.finance.csharp.contracts.VaultManager.ContractDefinition;

namespace poolz.finance.csharp.contracts.VaultManager
{
    public partial class VaultManagerDeployingService
    {
        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.IWeb3 web3, VaultManagerDeployment vaultManagerDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<VaultManagerDeployment>().SendRequestAndWaitForReceiptAsync(vaultManagerDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(Nethereum.Web3.IWeb3 web3, VaultManagerDeployment vaultManagerDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<VaultManagerDeployment>().SendRequestAsync(vaultManagerDeployment);
        }

        public virtual async Task<VaultManagerService> DeployContractAndGetServiceAsync(Nethereum.Web3.IWeb3 web3, VaultManagerDeployment vaultManagerDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, vaultManagerDeployment, cancellationTokenSource);
            return new VaultManagerService(web3, receipt.ContractAddress);
        }
    }
}
