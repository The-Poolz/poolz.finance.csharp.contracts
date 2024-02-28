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
using poolz.finance.csharp.contracts.DelayVaultProvider.ContractDefinition;

namespace poolz.finance.csharp.contracts.DelayVaultProvider
{
    public partial class DelayVaultProviderDeployingService
    {
        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.IWeb3 web3, DelayVaultProviderDeployment delayVaultProviderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<DelayVaultProviderDeployment>().SendRequestAndWaitForReceiptAsync(delayVaultProviderDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(Nethereum.Web3.IWeb3 web3, DelayVaultProviderDeployment delayVaultProviderDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<DelayVaultProviderDeployment>().SendRequestAsync(delayVaultProviderDeployment);
        }

        public virtual async Task<DelayVaultProviderService> DeployContractAndGetServiceAsync(Nethereum.Web3.IWeb3 web3, DelayVaultProviderDeployment delayVaultProviderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, delayVaultProviderDeployment, cancellationTokenSource);
            return new DelayVaultProviderService(web3, receipt.ContractAddress);
        }
    }
}
