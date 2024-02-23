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
using poolz.finance.csharp.SimpleBuilder.ContractDefinition;

namespace poolz.finance.csharp.SimpleBuilder
{
    public partial class SimpleBuilderService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, SimpleBuilderDeployment simpleBuilderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<SimpleBuilderDeployment>().SendRequestAndWaitForReceiptAsync(simpleBuilderDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, SimpleBuilderDeployment simpleBuilderDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<SimpleBuilderDeployment>().SendRequestAsync(simpleBuilderDeployment);
        }

        public static async Task<SimpleBuilderService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, SimpleBuilderDeployment simpleBuilderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, simpleBuilderDeployment, cancellationTokenSource);
            return new SimpleBuilderService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.IWeb3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public SimpleBuilderService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public SimpleBuilderService(Nethereum.Web3.IWeb3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> BuildMassPoolsRequestAsync(BuildMassPoolsFunction buildMassPoolsFunction)
        {
             return ContractHandler.SendRequestAsync(buildMassPoolsFunction);
        }

        public Task<TransactionReceipt> BuildMassPoolsRequestAndWaitForReceiptAsync(BuildMassPoolsFunction buildMassPoolsFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(buildMassPoolsFunction, cancellationToken);
        }

        public Task<string> BuildMassPoolsRequestAsync(List<string> addressParams, Builder userData, List<BigInteger> @params, byte[] signature)
        {
            var buildMassPoolsFunction = new BuildMassPoolsFunction();
                buildMassPoolsFunction.AddressParams = addressParams;
                buildMassPoolsFunction.UserData = userData;
                buildMassPoolsFunction.Params = @params;
                buildMassPoolsFunction.Signature = signature;
            
             return ContractHandler.SendRequestAsync(buildMassPoolsFunction);
        }

        public Task<TransactionReceipt> BuildMassPoolsRequestAndWaitForReceiptAsync(List<string> addressParams, Builder userData, List<BigInteger> @params, byte[] signature, CancellationTokenSource cancellationToken = null)
        {
            var buildMassPoolsFunction = new BuildMassPoolsFunction();
                buildMassPoolsFunction.AddressParams = addressParams;
                buildMassPoolsFunction.UserData = userData;
                buildMassPoolsFunction.Params = @params;
                buildMassPoolsFunction.Signature = signature;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(buildMassPoolsFunction, cancellationToken);
        }

        public Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(firewallAdminFunction, blockParameter);
        }

        
        public Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(null, blockParameter);
        }

        public Task<string> LockDealNFTQueryAsync(LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<LockDealNFTFunction, string>(lockDealNFTFunction, blockParameter);
        }

        
        public Task<string> LockDealNFTQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<LockDealNFTFunction, string>(null, blockParameter);
        }

        public Task<string> OnERC721ReceivedRequestAsync(OnERC721ReceivedFunction onERC721ReceivedFunction)
        {
             return ContractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(OnERC721ReceivedFunction onERC721ReceivedFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }

        public Task<string> OnERC721ReceivedRequestAsync(string returnValue1, string returnValue2, BigInteger returnValue3, byte[] returnValue4)
        {
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.ReturnValue1 = returnValue1;
                onERC721ReceivedFunction.ReturnValue2 = returnValue2;
                onERC721ReceivedFunction.ReturnValue3 = returnValue3;
                onERC721ReceivedFunction.ReturnValue4 = returnValue4;
            
             return ContractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(string returnValue1, string returnValue2, BigInteger returnValue3, byte[] returnValue4, CancellationTokenSource cancellationToken = null)
        {
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.ReturnValue1 = returnValue1;
                onERC721ReceivedFunction.ReturnValue2 = returnValue2;
                onERC721ReceivedFunction.ReturnValue3 = returnValue3;
                onERC721ReceivedFunction.ReturnValue4 = returnValue4;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }

        public Task<string> SetFirewallRequestAsync(SetFirewallFunction setFirewallFunction)
        {
             return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public Task<string> SetFirewallRequestAsync(string firewall)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
             return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(string firewall, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public Task<string> SetFirewallAdminRequestAsync(SetFirewallAdminFunction setFirewallAdminFunction)
        {
             return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public Task<string> SetFirewallAdminRequestAsync(string firewallAdmin)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
             return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(string firewallAdmin, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }
    }
}
