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
using poolz.finance.csharp.contracts.DelayVaultMigrator.ContractDefinition;

namespace poolz.finance.csharp.contracts.DelayVaultMigrator
{
    public partial class DelayVaultMigratorDeployingService
    {
        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.IWeb3 web3, DelayVaultMigratorDeployment delayVaultMigratorDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<DelayVaultMigratorDeployment>().SendRequestAndWaitForReceiptAsync(delayVaultMigratorDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(Nethereum.Web3.IWeb3 web3, DelayVaultMigratorDeployment delayVaultMigratorDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<DelayVaultMigratorDeployment>().SendRequestAsync(delayVaultMigratorDeployment);
        }

        public virtual async Task<DelayVaultMigratorService> DeployContractAndGetServiceAsync(Nethereum.Web3.IWeb3 web3, DelayVaultMigratorDeployment delayVaultMigratorDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, delayVaultMigratorDeployment, cancellationTokenSource);
            return new DelayVaultMigratorService(web3, receipt.ContractAddress);
        }
    }
}
