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
using poolz.finance.csharp.contracts.DelayVaultMigrator.ContractDefinition;

namespace poolz.finance.csharp.contracts.DelayVaultMigrator
{
    public partial class DelayVaultMigratorDeployingService
    {
        public IChainProvider ChainProvider { get; }

        public DelayVaultMigratorDeployingService(IChainProvider chainProvider)
        {
            ChainProvider = chainProvider;
        }

        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(long chainId, DelayVaultMigratorDeployment delayVaultMigratorDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var web3 = ChainProvider.Web3(chainId);
            return web3.Eth.GetContractDeploymentHandler<DelayVaultMigratorDeployment>().SendRequestAndWaitForReceiptAsync(delayVaultMigratorDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(long chainId, DelayVaultMigratorDeployment delayVaultMigratorDeployment)
        {
            var web3 = ChainProvider.Web3(chainId);
            return web3.Eth.GetContractDeploymentHandler<DelayVaultMigratorDeployment>().SendRequestAsync(delayVaultMigratorDeployment);
        }
    }
}
