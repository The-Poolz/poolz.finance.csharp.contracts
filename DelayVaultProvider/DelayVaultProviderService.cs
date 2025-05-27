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
using poolz.finance.csharp.contracts.DelayVaultProvider.ContractDefinition;

namespace poolz.finance.csharp.contracts.DelayVaultProvider
{
    public partial class DelayVaultProviderService : IDelayVaultProviderService
    {
        public IChainProvider ChainProvider { get; }

        public DelayVaultProviderService(IChainProvider chainProvider)
        {
            ChainProvider = chainProvider;
        }

        private ContractHandler InitializeContractHandler(long chainId, Enum contractType)
        {
            var contractAddress = ChainProvider.ContractAddress(chainId, contractType);
            var web3 = ChainProvider.Web3(chainId);
            var contractHandler = web3.Eth.GetContractHandler(contractAddress);
            return contractHandler;
        }

        public virtual Task<BigInteger> BalanceOfQueryAsync(long chainId, Enum contractType, BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        public virtual Task<BigInteger> BalanceOfQueryAsync(long chainId, Enum contractType, string user, BlockParameter blockParameter = null)
        {
            var balanceOfFunction = new BalanceOfFunction();
                balanceOfFunction.User = user;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        public virtual Task<string> BeforeTransferRequestAsync(long chainId, Enum contractType, BeforeTransferFunction beforeTransferFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(beforeTransferFunction);
        }

        public virtual Task<TransactionReceipt> BeforeTransferRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BeforeTransferFunction beforeTransferFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(beforeTransferFunction, cancellationToken);
        }

        public virtual Task<string> BeforeTransferRequestAsync(long chainId, Enum contractType, string from, string to, BigInteger poolId)
        {
            var beforeTransferFunction = new BeforeTransferFunction();
                beforeTransferFunction.From = from;
                beforeTransferFunction.To = to;
                beforeTransferFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(beforeTransferFunction);
        }

        public virtual Task<TransactionReceipt> BeforeTransferRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string from, string to, BigInteger poolId, CancellationTokenSource cancellationToken = null)
        {
            var beforeTransferFunction = new BeforeTransferFunction();
                beforeTransferFunction.From = from;
                beforeTransferFunction.To = to;
                beforeTransferFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(beforeTransferFunction, cancellationToken);
        }

        public virtual Task<string> CreateNewDelayVaultRequestAsync(long chainId, Enum contractType, CreateNewDelayVaultFunction createNewDelayVaultFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewDelayVaultFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewDelayVaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CreateNewDelayVaultFunction createNewDelayVaultFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewDelayVaultFunction, cancellationToken);
        }

        public virtual Task<string> CreateNewDelayVaultRequestAsync(long chainId, Enum contractType, string owner, List<BigInteger> @params)
        {
            var createNewDelayVaultFunction = new CreateNewDelayVaultFunction();
                createNewDelayVaultFunction.Owner = owner;
                createNewDelayVaultFunction.Params = @params;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewDelayVaultFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewDelayVaultRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string owner, List<BigInteger> @params, CancellationTokenSource cancellationToken = null)
        {
            var createNewDelayVaultFunction = new CreateNewDelayVaultFunction();
                createNewDelayVaultFunction.Owner = owner;
                createNewDelayVaultFunction.Params = @params;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewDelayVaultFunction, cancellationToken);
        }

        public virtual Task<string> CreateNewDelayVaultWithSignatureRequestAsync(long chainId, Enum contractType, CreateNewDelayVaultWithSignatureFunction createNewDelayVaultWithSignatureFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewDelayVaultWithSignatureFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewDelayVaultWithSignatureRequestAndWaitForReceiptAsync(long chainId, Enum contractType, CreateNewDelayVaultWithSignatureFunction createNewDelayVaultWithSignatureFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewDelayVaultWithSignatureFunction, cancellationToken);
        }

        public virtual Task<string> CreateNewDelayVaultWithSignatureRequestAsync(long chainId, Enum contractType, string owner, List<BigInteger> @params, byte[] signature)
        {
            var createNewDelayVaultWithSignatureFunction = new CreateNewDelayVaultWithSignatureFunction();
                createNewDelayVaultWithSignatureFunction.Owner = owner;
                createNewDelayVaultWithSignatureFunction.Params = @params;
                createNewDelayVaultWithSignatureFunction.Signature = signature;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewDelayVaultWithSignatureFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewDelayVaultWithSignatureRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string owner, List<BigInteger> @params, byte[] signature, CancellationTokenSource cancellationToken = null)
        {
            var createNewDelayVaultWithSignatureFunction = new CreateNewDelayVaultWithSignatureFunction();
                createNewDelayVaultWithSignatureFunction.Owner = owner;
                createNewDelayVaultWithSignatureFunction.Params = @params;
                createNewDelayVaultWithSignatureFunction.Signature = signature;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewDelayVaultWithSignatureFunction, cancellationToken);
        }

        public virtual Task<BigInteger> CurrentParamsTargetLengthQueryAsync(long chainId, Enum contractType, CurrentParamsTargetLengthFunction currentParamsTargetLengthFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<CurrentParamsTargetLengthFunction, BigInteger>(currentParamsTargetLengthFunction, blockParameter);
        }

        public virtual Task<BigInteger> CurrentParamsTargetLengthQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<CurrentParamsTargetLengthFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<FirewallAdminFunction, string>(firewallAdminFunction, blockParameter);
        }

        public virtual Task<string> FirewallAdminQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<FirewallAdminFunction, string>(null, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetParamsQueryAsync(long chainId, Enum contractType, GetParamsFunction getParamsFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetParamsFunction, List<BigInteger>>(getParamsFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetParamsQueryAsync(long chainId, Enum contractType, BigInteger poolId, BlockParameter blockParameter = null)
        {
            var getParamsFunction = new GetParamsFunction();
                getParamsFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetParamsFunction, List<BigInteger>>(getParamsFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(long chainId, Enum contractType, GetSubProvidersPoolIdsFunction getSubProvidersPoolIdsFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetSubProvidersPoolIdsFunction, List<BigInteger>>(getSubProvidersPoolIdsFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(long chainId, Enum contractType, BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var getSubProvidersPoolIdsFunction = new GetSubProvidersPoolIdsFunction();
                getSubProvidersPoolIdsFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetSubProvidersPoolIdsFunction, List<BigInteger>>(getSubProvidersPoolIdsFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetTotalAmountQueryAsync(long chainId, Enum contractType, GetTotalAmountFunction getTotalAmountFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetTotalAmountFunction, BigInteger>(getTotalAmountFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetTotalAmountQueryAsync(long chainId, Enum contractType, string user, BlockParameter blockParameter = null)
        {
            var getTotalAmountFunction = new GetTotalAmountFunction();
                getTotalAmountFunction.User = user;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetTotalAmountFunction, BigInteger>(getTotalAmountFunction, blockParameter);
        }

        public virtual Task<GetTypeToProviderDataOutputDTO> GetTypeToProviderDataQueryAsync(long chainId, Enum contractType, GetTypeToProviderDataFunction getTypeToProviderDataFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetTypeToProviderDataFunction, GetTypeToProviderDataOutputDTO>(getTypeToProviderDataFunction, blockParameter);
        }

        public virtual Task<GetTypeToProviderDataOutputDTO> GetTypeToProviderDataQueryAsync(long chainId, Enum contractType, byte theType, BlockParameter blockParameter = null)
        {
            var getTypeToProviderDataFunction = new GetTypeToProviderDataFunction();
                getTypeToProviderDataFunction.TheType = theType;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<GetTypeToProviderDataFunction, GetTypeToProviderDataOutputDTO>(getTypeToProviderDataFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetWithdrawPoolParamsQueryAsync(long chainId, Enum contractType, GetWithdrawPoolParamsFunction getWithdrawPoolParamsFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetWithdrawPoolParamsFunction, List<BigInteger>>(getWithdrawPoolParamsFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetWithdrawPoolParamsQueryAsync(long chainId, Enum contractType, BigInteger amount, byte theType, BlockParameter blockParameter = null)
        {
            var getWithdrawPoolParamsFunction = new GetWithdrawPoolParamsFunction();
                getWithdrawPoolParamsFunction.Amount = amount;
                getWithdrawPoolParamsFunction.TheType = theType;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetWithdrawPoolParamsFunction, List<BigInteger>>(getWithdrawPoolParamsFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, Enum contractType, GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(long chainId, Enum contractType, BigInteger poolId, BlockParameter blockParameter = null)
        {
            var getWithdrawableAmountFunction = new GetWithdrawableAmountFunction();
                getWithdrawableAmountFunction.PoolId = poolId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        public virtual Task<string> LockDealNFTQueryAsync(long chainId, Enum contractType, LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<LockDealNFTFunction, string>(lockDealNFTFunction, blockParameter);
        }

        public virtual Task<string> LockDealNFTQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<LockDealNFTFunction, string>(null, blockParameter);
        }

        public virtual Task<string> MigratorQueryAsync(long chainId, Enum contractType, MigratorFunction migratorFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<MigratorFunction, string>(migratorFunction, blockParameter);
        }

        public virtual Task<string> MigratorQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<MigratorFunction, string>(null, blockParameter);
        }

        public virtual Task<string> NameQueryAsync(long chainId, Enum contractType, NameFunction nameFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
        }

        public virtual Task<string> NameQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
        }

        public virtual Task<BigInteger> PoolIdToAmountQueryAsync(long chainId, Enum contractType, PoolIdToAmountFunction poolIdToAmountFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PoolIdToAmountFunction, BigInteger>(poolIdToAmountFunction, blockParameter);
        }

        public virtual Task<BigInteger> PoolIdToAmountQueryAsync(long chainId, Enum contractType, BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var poolIdToAmountFunction = new PoolIdToAmountFunction();
                poolIdToAmountFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<PoolIdToAmountFunction, BigInteger>(poolIdToAmountFunction, blockParameter);
        }

        public virtual Task<string> RegisterPoolRequestAsync(long chainId, Enum contractType, RegisterPoolFunction registerPoolFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(registerPoolFunction);
        }

        public virtual Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, RegisterPoolFunction registerPoolFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(registerPoolFunction, cancellationToken);
        }

        public virtual Task<string> RegisterPoolRequestAsync(long chainId, Enum contractType, BigInteger poolId, List<BigInteger> @params)
        {
            var registerPoolFunction = new RegisterPoolFunction();
                registerPoolFunction.PoolId = poolId;
                registerPoolFunction.Params = @params;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(registerPoolFunction);
        }

        public virtual Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger poolId, List<BigInteger> @params, CancellationTokenSource cancellationToken = null)
        {
            var registerPoolFunction = new RegisterPoolFunction();
                registerPoolFunction.PoolId = poolId;
                registerPoolFunction.Params = @params;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(registerPoolFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(long chainId, Enum contractType, string firewall)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewall, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(long chainId, Enum contractType, string firewallAdmin)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(long chainId, Enum contractType, string firewallAdmin, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> SplitRequestAsync(long chainId, Enum contractType, SplitFunction splitFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(splitFunction);
        }

        public virtual Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(long chainId, Enum contractType, SplitFunction splitFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(splitFunction, cancellationToken);
        }

        public virtual Task<string> SplitRequestAsync(long chainId, Enum contractType, BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio)
        {
            var splitFunction = new SplitFunction();
                splitFunction.OldPoolId = oldPoolId;
                splitFunction.NewPoolId = newPoolId;
                splitFunction.Ratio = ratio;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(splitFunction);
        }

        public virtual Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio, CancellationTokenSource cancellationToken = null)
        {
            var splitFunction = new SplitFunction();
                splitFunction.OldPoolId = oldPoolId;
                splitFunction.NewPoolId = newPoolId;
                splitFunction.Ratio = ratio;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(splitFunction, cancellationToken);
        }

        public virtual Task<bool> SupportsInterfaceQueryAsync(long chainId, Enum contractType, SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public virtual Task<bool> SupportsInterfaceQueryAsync(long chainId, Enum contractType, byte[] interfaceId, BlockParameter blockParameter = null)
        {
            var supportsInterfaceFunction = new SupportsInterfaceFunction();
                supportsInterfaceFunction.InterfaceId = interfaceId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public virtual Task<byte> TheTypeOfQueryAsync(long chainId, Enum contractType, TheTypeOfFunction theTypeOfFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TheTypeOfFunction, byte>(theTypeOfFunction, blockParameter);
        }

        public virtual Task<byte> TheTypeOfQueryAsync(long chainId, Enum contractType, BigInteger amount, BlockParameter blockParameter = null)
        {
            var theTypeOfFunction = new TheTypeOfFunction();
                theTypeOfFunction.Amount = amount;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TheTypeOfFunction, byte>(theTypeOfFunction, blockParameter);
        }

        public virtual Task<string> TokenQueryAsync(long chainId, Enum contractType, TokenFunction tokenFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenFunction, string>(tokenFunction, blockParameter);
        }

        public virtual Task<string> TokenQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenFunction, string>(null, blockParameter);
        }

        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, Enum contractType, TokenOfOwnerByIndexFunction tokenOfOwnerByIndexFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
        }

        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(long chainId, Enum contractType, string user, BigInteger index, BlockParameter blockParameter = null)
        {
            var tokenOfOwnerByIndexFunction = new TokenOfOwnerByIndexFunction();
                tokenOfOwnerByIndexFunction.User = user;
                tokenOfOwnerByIndexFunction.Index = index;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
        }

        public virtual Task<TypeToProviderDataOutputDTO> TypeToProviderDataQueryAsync(long chainId, Enum contractType, TypeToProviderDataFunction typeToProviderDataFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<TypeToProviderDataFunction, TypeToProviderDataOutputDTO>(typeToProviderDataFunction, blockParameter);
        }

        public virtual Task<TypeToProviderDataOutputDTO> TypeToProviderDataQueryAsync(long chainId, Enum contractType, byte returnValue1, BlockParameter blockParameter = null)
        {
            var typeToProviderDataFunction = new TypeToProviderDataFunction();
                typeToProviderDataFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<TypeToProviderDataFunction, TypeToProviderDataOutputDTO>(typeToProviderDataFunction, blockParameter);
        }

        public virtual Task<byte> TypesCountQueryAsync(long chainId, Enum contractType, TypesCountFunction typesCountFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TypesCountFunction, byte>(typesCountFunction, blockParameter);
        }

        public virtual Task<byte> TypesCountQueryAsync(long chainId, Enum contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TypesCountFunction, byte>(null, blockParameter);
        }

        public virtual Task<string> UpgradeTypeRequestAsync(long chainId, Enum contractType, UpgradeTypeFunction upgradeTypeFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(upgradeTypeFunction);
        }

        public virtual Task<TransactionReceipt> UpgradeTypeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, UpgradeTypeFunction upgradeTypeFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(upgradeTypeFunction, cancellationToken);
        }

        public virtual Task<string> UpgradeTypeRequestAsync(long chainId, Enum contractType, byte newType)
        {
            var upgradeTypeFunction = new UpgradeTypeFunction();
                upgradeTypeFunction.NewType = newType;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(upgradeTypeFunction);
        }

        public virtual Task<TransactionReceipt> UpgradeTypeRequestAndWaitForReceiptAsync(long chainId, Enum contractType, byte newType, CancellationTokenSource cancellationToken = null)
        {
            var upgradeTypeFunction = new UpgradeTypeFunction();
                upgradeTypeFunction.NewType = newType;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(upgradeTypeFunction, cancellationToken);
        }

        public virtual Task<BigInteger> UserToAmountQueryAsync(long chainId, Enum contractType, UserToAmountFunction userToAmountFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<UserToAmountFunction, BigInteger>(userToAmountFunction, blockParameter);
        }

        public virtual Task<BigInteger> UserToAmountQueryAsync(long chainId, Enum contractType, string returnValue1, BlockParameter blockParameter = null)
        {
            var userToAmountFunction = new UserToAmountFunction();
                userToAmountFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<UserToAmountFunction, BigInteger>(userToAmountFunction, blockParameter);
        }

        public virtual Task<byte> UserToTypeQueryAsync(long chainId, Enum contractType, UserToTypeFunction userToTypeFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<UserToTypeFunction, byte>(userToTypeFunction, blockParameter);
        }

        public virtual Task<byte> UserToTypeQueryAsync(long chainId, Enum contractType, string returnValue1, BlockParameter blockParameter = null)
        {
            var userToTypeFunction = new UserToTypeFunction();
                userToTypeFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<UserToTypeFunction, byte>(userToTypeFunction, blockParameter);
        }

        public virtual Task<string> WithdrawRequestAsync(long chainId, Enum contractType, WithdrawFunction withdrawFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, Enum contractType, WithdrawFunction withdrawFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawRequestAsync(long chainId, Enum contractType, BigInteger tokenId)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.TokenId = tokenId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(long chainId, Enum contractType, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.TokenId = tokenId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }
    }
}
