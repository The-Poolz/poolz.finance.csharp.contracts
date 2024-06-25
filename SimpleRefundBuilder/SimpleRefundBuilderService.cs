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
using poolz.finance.csharp.contracts.SimpleRefundBuilder.ContractDefinition;

namespace poolz.finance.csharp.contracts.SimpleRefundBuilder
{
    public partial class SimpleRefundBuilderService : ISimpleRefundBuilderService
    {
        protected virtual IWeb3 Web3 { get; private set; }

        public virtual ContractHandler ContractHandler { get; private set; }

        public SimpleRefundBuilderService() { }

        public SimpleRefundBuilderService(Web3 web3, string contractAddress)
        {
            Initialize(web3, contractAddress);
        }

        public SimpleRefundBuilderService(IWeb3 web3, string contractAddress)
        {
            Initialize(web3, contractAddress);
        }

        public void Initialize(IWeb3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        private void EnsureInitialized()
        {
            if (Web3 == null || ContractHandler == null)
            {
                throw new InvalidOperationException("The service has not been initialized. Please call the Initialize method with a valid IWeb3 instance and contract address.");
            }
        }

        public virtual Task<string> BuildMassPoolsRequestAsync(BuildMassPoolsFunction buildMassPoolsFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(buildMassPoolsFunction);
        }

        public virtual Task<TransactionReceipt> BuildMassPoolsRequestAndWaitForReceiptAsync(BuildMassPoolsFunction buildMassPoolsFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(buildMassPoolsFunction, cancellationToken);
        }

        public virtual Task<string> BuildMassPoolsRequestAsync(List<string> addressParams, Builder userData, List<List<BigInteger>> @params, byte[] tokenSignature, byte[] mainCoinSignature)
        {
            EnsureInitialized();
            var buildMassPoolsFunction = new BuildMassPoolsFunction();
                buildMassPoolsFunction.AddressParams = addressParams;
                buildMassPoolsFunction.UserData = userData;
                buildMassPoolsFunction.Params = @params;
                buildMassPoolsFunction.TokenSignature = tokenSignature;
                buildMassPoolsFunction.MainCoinSignature = mainCoinSignature;
            
            return ContractHandler.SendRequestAsync(buildMassPoolsFunction);
        }

        public virtual Task<TransactionReceipt> BuildMassPoolsRequestAndWaitForReceiptAsync(List<string> addressParams, Builder userData, List<List<BigInteger>> @params, byte[] tokenSignature, byte[] mainCoinSignature, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var buildMassPoolsFunction = new BuildMassPoolsFunction();
                buildMassPoolsFunction.AddressParams = addressParams;
                buildMassPoolsFunction.UserData = userData;
                buildMassPoolsFunction.Params = @params;
                buildMassPoolsFunction.TokenSignature = tokenSignature;
                buildMassPoolsFunction.MainCoinSignature = mainCoinSignature;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(buildMassPoolsFunction, cancellationToken);
        }

        public virtual Task<string> CollateralProviderQueryAsync(CollateralProviderFunction collateralProviderFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<CollateralProviderFunction, string>(collateralProviderFunction, blockParameter);
        }

        public virtual Task<string> CollateralProviderQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<CollateralProviderFunction, string>(null, blockParameter);
        }

        public virtual Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(firewallAdminFunction, blockParameter);
        }

        public virtual Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(null, blockParameter);
        }

        public virtual Task<string> LockDealNFTQueryAsync(LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<LockDealNFTFunction, string>(lockDealNFTFunction, blockParameter);
        }

        public virtual Task<string> LockDealNFTQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<LockDealNFTFunction, string>(null, blockParameter);
        }

        public virtual Task<string> OnERC721ReceivedRequestAsync(OnERC721ReceivedFunction onERC721ReceivedFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public virtual Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(OnERC721ReceivedFunction onERC721ReceivedFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }

        public virtual Task<string> OnERC721ReceivedRequestAsync(string returnValue1, string returnValue2, BigInteger returnValue3, byte[] returnValue4)
        {
            EnsureInitialized();
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.ReturnValue1 = returnValue1;
                onERC721ReceivedFunction.ReturnValue2 = returnValue2;
                onERC721ReceivedFunction.ReturnValue3 = returnValue3;
                onERC721ReceivedFunction.ReturnValue4 = returnValue4;
            
            return ContractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public virtual Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(string returnValue1, string returnValue2, BigInteger returnValue3, byte[] returnValue4, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.ReturnValue1 = returnValue1;
                onERC721ReceivedFunction.ReturnValue2 = returnValue2;
                onERC721ReceivedFunction.ReturnValue3 = returnValue3;
                onERC721ReceivedFunction.ReturnValue4 = returnValue4;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }

        public virtual Task<string> RefundProviderQueryAsync(RefundProviderFunction refundProviderFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<RefundProviderFunction, string>(refundProviderFunction, blockParameter);
        }

        public virtual Task<string> RefundProviderQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<RefundProviderFunction, string>(null, blockParameter);
        }

        public virtual Task<string> SetFirewallRequestAsync(SetFirewallFunction setFirewallFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(string firewall)
        {
            EnsureInitialized();
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(string firewall, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(SetFirewallAdminFunction setFirewallAdminFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(string firewallAdmin)
        {
            EnsureInitialized();
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(string firewallAdmin, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }
    }
}
