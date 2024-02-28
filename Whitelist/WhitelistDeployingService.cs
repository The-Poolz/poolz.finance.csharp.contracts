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
using poolz.finance.csharp.contracts.Whitelist.ContractDefinition;

namespace poolz.finance.csharp.contracts.Whitelist
{
    public partial class WhitelistDeployingService
    {
        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.IWeb3 web3, WhitelistDeployment whitelistDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<WhitelistDeployment>().SendRequestAndWaitForReceiptAsync(whitelistDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(Nethereum.Web3.IWeb3 web3, WhitelistDeployment whitelistDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<WhitelistDeployment>().SendRequestAsync(whitelistDeployment);
        }

        public virtual async Task<WhitelistService> DeployContractAndGetServiceAsync(Nethereum.Web3.IWeb3 web3, WhitelistDeployment whitelistDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, whitelistDeployment, cancellationTokenSource);
            return new WhitelistService(web3, receipt.ContractAddress);
        }
    }
}
