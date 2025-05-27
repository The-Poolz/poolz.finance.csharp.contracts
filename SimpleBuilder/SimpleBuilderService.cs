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
using poolz.finance.csharp.contracts.SimpleBuilder.ContractDefinition;

namespace poolz.finance.csharp.contracts.SimpleBuilder
{
    public partial class SimpleBuilderService<TContractType> : ISimpleBuilderService<TContractType>
        where TContractType : Enum
    {
        public IChainProvider<TContractType> ChainProvider { get; }

        public SimpleBuilderService(IChainProvider<TContractType> chainProvider)
        {
            ChainProvider = chainProvider;
        }

        private ContractHandler InitializeContractHandler(long chainId, TContractType contractType)
        {
            var contractAddress = ChainProvider.ContractAddress(chainId, contractType);
            var web3 = ChainProvider.Web3(chainId);
            var contractHandler = web3.Eth.GetContractHandler(contractAddress);
            return contractHandler;
        }

        public virtual Task<string> BuildMassPoolsRequestAsync(long chainId, TContractType contractType, BuildMassPoolsFunction buildMassPoolsFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(buildMassPoolsFunction);
        }

        public virtual Task<TransactionReceipt> BuildMassPoolsRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BuildMassPoolsFunction buildMassPoolsFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(buildMassPoolsFunction, cancellationToken);
        }

        public virtual Task<string> BuildMassPoolsRequestAsync(long chainId, TContractType contractType, List<string> addressParams, Builder userData, List<BigInteger> @params, byte[] signature)
        {
            var buildMassPoolsFunction = new BuildMassPoolsFunction();
                buildMassPoolsFunction.AddressParams = addressParams;
                buildMassPoolsFunction.UserData = userData;
                buildMassPoolsFunction.Params = @params;
                buildMassPoolsFunction.Signature = signature;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(buildMassPoolsFunction);
        }

        public virtual Task<TransactionReceipt> BuildMassPoolsRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, List<string> addressParams, Builder userData, List<BigInteger> @params, byte[] signature, CancellationTokenSource cancellationToken = null)
        {
            var buildMassPoolsFunction = new BuildMassPoolsFunction();
                buildMassPoolsFunction.AddressParams = addressParams;
                buildMassPoolsFunction.UserData = userData;
                buildMassPoolsFunction.Params = @params;
                buildMassPoolsFunction.Signature = signature;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(buildMassPoolsFunction, cancellationToken);
        }

        public virtual Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<FirewallAdminFunction, string>(firewallAdminFunction, blockParameter);
        }

        public virtual Task<string> FirewallAdminQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<FirewallAdminFunction, string>(null, blockParameter);
        }

        public virtual Task<string> LockDealNFTQueryAsync(long chainId, TContractType contractType, LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<LockDealNFTFunction, string>(lockDealNFTFunction, blockParameter);
        }

        public virtual Task<string> LockDealNFTQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<LockDealNFTFunction, string>(null, blockParameter);
        }

        public virtual Task<string> OnERC721ReceivedRequestAsync(long chainId, TContractType contractType, OnERC721ReceivedFunction onERC721ReceivedFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public virtual Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, OnERC721ReceivedFunction onERC721ReceivedFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }

        public virtual Task<string> OnERC721ReceivedRequestAsync(long chainId, TContractType contractType, string returnValue1, string returnValue2, BigInteger returnValue3, byte[] returnValue4)
        {
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.ReturnValue1 = returnValue1;
                onERC721ReceivedFunction.ReturnValue2 = returnValue2;
                onERC721ReceivedFunction.ReturnValue3 = returnValue3;
                onERC721ReceivedFunction.ReturnValue4 = returnValue4;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public virtual Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string returnValue1, string returnValue2, BigInteger returnValue3, byte[] returnValue4, CancellationTokenSource cancellationToken = null)
        {
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.ReturnValue1 = returnValue1;
                onERC721ReceivedFunction.ReturnValue2 = returnValue2;
                onERC721ReceivedFunction.ReturnValue3 = returnValue3;
                onERC721ReceivedFunction.ReturnValue4 = returnValue4;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(long chainId, TContractType contractType, string firewall)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewall, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(long chainId, TContractType contractType, string firewallAdmin)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }
    }
}
