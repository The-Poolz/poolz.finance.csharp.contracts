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
using poolz.finance.csharp.contracts.LockDealNFT.ContractDefinition;

namespace poolz.finance.csharp.contracts.LockDealNFT
{
    public partial class LockDealNFTDeployingService
    {
        public virtual Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.IWeb3 web3, LockDealNFTDeployment lockDealNFTDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<LockDealNFTDeployment>().SendRequestAndWaitForReceiptAsync(lockDealNFTDeployment, cancellationTokenSource);
        }

        public virtual Task<string> DeployContractAsync(Nethereum.Web3.IWeb3 web3, LockDealNFTDeployment lockDealNFTDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<LockDealNFTDeployment>().SendRequestAsync(lockDealNFTDeployment);
        }

        public virtual async Task<LockDealNFTService> DeployContractAndGetServiceAsync(Nethereum.Web3.IWeb3 web3, LockDealNFTDeployment lockDealNFTDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, lockDealNFTDeployment, cancellationTokenSource);
            return new LockDealNFTService(web3, receipt.ContractAddress);
        }
    }
}
