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
    public partial class DelayVaultProviderService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, DelayVaultProviderDeployment delayVaultProviderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<DelayVaultProviderDeployment>().SendRequestAndWaitForReceiptAsync(delayVaultProviderDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, DelayVaultProviderDeployment delayVaultProviderDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<DelayVaultProviderDeployment>().SendRequestAsync(delayVaultProviderDeployment);
        }

        public static async Task<DelayVaultProviderService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, DelayVaultProviderDeployment delayVaultProviderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, delayVaultProviderDeployment, cancellationTokenSource);
            return new DelayVaultProviderService(web3, receipt.ContractAddress);
        }

        protected virtual Nethereum.Web3.IWeb3 Web3 { get; }

        public virtual ContractHandler ContractHandler { get; }

        public DelayVaultProviderService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public DelayVaultProviderService(Nethereum.Web3.IWeb3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public virtual Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> BalanceOfQueryAsync(string user, BlockParameter blockParameter = null)
        {
            var balanceOfFunction = new BalanceOfFunction();
                balanceOfFunction.User = user;
            
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        public virtual Task<string> BeforeTransferRequestAsync(BeforeTransferFunction beforeTransferFunction)
        {
             return ContractHandler.SendRequestAsync(beforeTransferFunction);
        }

        public virtual Task<TransactionReceipt> BeforeTransferRequestAndWaitForReceiptAsync(BeforeTransferFunction beforeTransferFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(beforeTransferFunction, cancellationToken);
        }

        public virtual Task<string> BeforeTransferRequestAsync(string from, string to, BigInteger poolId)
        {
            var beforeTransferFunction = new BeforeTransferFunction();
                beforeTransferFunction.From = from;
                beforeTransferFunction.To = to;
                beforeTransferFunction.PoolId = poolId;
            
             return ContractHandler.SendRequestAsync(beforeTransferFunction);
        }

        public virtual Task<TransactionReceipt> BeforeTransferRequestAndWaitForReceiptAsync(string from, string to, BigInteger poolId, CancellationTokenSource cancellationToken = null)
        {
            var beforeTransferFunction = new BeforeTransferFunction();
                beforeTransferFunction.From = from;
                beforeTransferFunction.To = to;
                beforeTransferFunction.PoolId = poolId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(beforeTransferFunction, cancellationToken);
        }

        public virtual Task<string> CreateNewDelayVaultRequestAsync(CreateNewDelayVaultFunction createNewDelayVaultFunction)
        {
             return ContractHandler.SendRequestAsync(createNewDelayVaultFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewDelayVaultRequestAndWaitForReceiptAsync(CreateNewDelayVaultFunction createNewDelayVaultFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewDelayVaultFunction, cancellationToken);
        }

        public virtual Task<string> CreateNewDelayVaultRequestAsync(string owner, List<BigInteger> @params)
        {
            var createNewDelayVaultFunction = new CreateNewDelayVaultFunction();
                createNewDelayVaultFunction.Owner = owner;
                createNewDelayVaultFunction.Params = @params;
            
             return ContractHandler.SendRequestAsync(createNewDelayVaultFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewDelayVaultRequestAndWaitForReceiptAsync(string owner, List<BigInteger> @params, CancellationTokenSource cancellationToken = null)
        {
            var createNewDelayVaultFunction = new CreateNewDelayVaultFunction();
                createNewDelayVaultFunction.Owner = owner;
                createNewDelayVaultFunction.Params = @params;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewDelayVaultFunction, cancellationToken);
        }

        public virtual Task<string> CreateNewDelayVaultWithSignatureRequestAsync(CreateNewDelayVaultWithSignatureFunction createNewDelayVaultWithSignatureFunction)
        {
             return ContractHandler.SendRequestAsync(createNewDelayVaultWithSignatureFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewDelayVaultWithSignatureRequestAndWaitForReceiptAsync(CreateNewDelayVaultWithSignatureFunction createNewDelayVaultWithSignatureFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewDelayVaultWithSignatureFunction, cancellationToken);
        }

        public virtual Task<string> CreateNewDelayVaultWithSignatureRequestAsync(string owner, List<BigInteger> @params, byte[] signature)
        {
            var createNewDelayVaultWithSignatureFunction = new CreateNewDelayVaultWithSignatureFunction();
                createNewDelayVaultWithSignatureFunction.Owner = owner;
                createNewDelayVaultWithSignatureFunction.Params = @params;
                createNewDelayVaultWithSignatureFunction.Signature = signature;
            
             return ContractHandler.SendRequestAsync(createNewDelayVaultWithSignatureFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewDelayVaultWithSignatureRequestAndWaitForReceiptAsync(string owner, List<BigInteger> @params, byte[] signature, CancellationTokenSource cancellationToken = null)
        {
            var createNewDelayVaultWithSignatureFunction = new CreateNewDelayVaultWithSignatureFunction();
                createNewDelayVaultWithSignatureFunction.Owner = owner;
                createNewDelayVaultWithSignatureFunction.Params = @params;
                createNewDelayVaultWithSignatureFunction.Signature = signature;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewDelayVaultWithSignatureFunction, cancellationToken);
        }

        public virtual Task<BigInteger> CurrentParamsTargetLengthQueryAsync(CurrentParamsTargetLengthFunction currentParamsTargetLengthFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CurrentParamsTargetLengthFunction, BigInteger>(currentParamsTargetLengthFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> CurrentParamsTargetLengthQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CurrentParamsTargetLengthFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(firewallAdminFunction, blockParameter);
        }

        
        public virtual Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(null, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetParamsQueryAsync(GetParamsFunction getParamsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetParamsFunction, List<BigInteger>>(getParamsFunction, blockParameter);
        }

        
        public virtual Task<List<BigInteger>> GetParamsQueryAsync(BigInteger poolId, BlockParameter blockParameter = null)
        {
            var getParamsFunction = new GetParamsFunction();
                getParamsFunction.PoolId = poolId;
            
            return ContractHandler.QueryAsync<GetParamsFunction, List<BigInteger>>(getParamsFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(GetSubProvidersPoolIdsFunction getSubProvidersPoolIdsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetSubProvidersPoolIdsFunction, List<BigInteger>>(getSubProvidersPoolIdsFunction, blockParameter);
        }

        
        public virtual Task<List<BigInteger>> GetSubProvidersPoolIdsQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var getSubProvidersPoolIdsFunction = new GetSubProvidersPoolIdsFunction();
                getSubProvidersPoolIdsFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<GetSubProvidersPoolIdsFunction, List<BigInteger>>(getSubProvidersPoolIdsFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetTotalAmountQueryAsync(GetTotalAmountFunction getTotalAmountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTotalAmountFunction, BigInteger>(getTotalAmountFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> GetTotalAmountQueryAsync(string user, BlockParameter blockParameter = null)
        {
            var getTotalAmountFunction = new GetTotalAmountFunction();
                getTotalAmountFunction.User = user;
            
            return ContractHandler.QueryAsync<GetTotalAmountFunction, BigInteger>(getTotalAmountFunction, blockParameter);
        }

        public virtual Task<GetTypeToProviderDataOutputDTO> GetTypeToProviderDataQueryAsync(GetTypeToProviderDataFunction getTypeToProviderDataFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetTypeToProviderDataFunction, GetTypeToProviderDataOutputDTO>(getTypeToProviderDataFunction, blockParameter);
        }

        public virtual Task<GetTypeToProviderDataOutputDTO> GetTypeToProviderDataQueryAsync(byte theType, BlockParameter blockParameter = null)
        {
            var getTypeToProviderDataFunction = new GetTypeToProviderDataFunction();
                getTypeToProviderDataFunction.TheType = theType;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetTypeToProviderDataFunction, GetTypeToProviderDataOutputDTO>(getTypeToProviderDataFunction, blockParameter);
        }

        public virtual Task<List<BigInteger>> GetWithdrawPoolParamsQueryAsync(GetWithdrawPoolParamsFunction getWithdrawPoolParamsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetWithdrawPoolParamsFunction, List<BigInteger>>(getWithdrawPoolParamsFunction, blockParameter);
        }

        
        public virtual Task<List<BigInteger>> GetWithdrawPoolParamsQueryAsync(BigInteger amount, byte theType, BlockParameter blockParameter = null)
        {
            var getWithdrawPoolParamsFunction = new GetWithdrawPoolParamsFunction();
                getWithdrawPoolParamsFunction.Amount = amount;
                getWithdrawPoolParamsFunction.TheType = theType;
            
            return ContractHandler.QueryAsync<GetWithdrawPoolParamsFunction, List<BigInteger>>(getWithdrawPoolParamsFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(GetWithdrawableAmountFunction getWithdrawableAmountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> GetWithdrawableAmountQueryAsync(BigInteger poolId, BlockParameter blockParameter = null)
        {
            var getWithdrawableAmountFunction = new GetWithdrawableAmountFunction();
                getWithdrawableAmountFunction.PoolId = poolId;
            
            return ContractHandler.QueryAsync<GetWithdrawableAmountFunction, BigInteger>(getWithdrawableAmountFunction, blockParameter);
        }

        public virtual Task<string> LockDealNFTQueryAsync(LockDealNFTFunction lockDealNFTFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<LockDealNFTFunction, string>(lockDealNFTFunction, blockParameter);
        }

        
        public virtual Task<string> LockDealNFTQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<LockDealNFTFunction, string>(null, blockParameter);
        }

        public virtual Task<string> MigratorQueryAsync(MigratorFunction migratorFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MigratorFunction, string>(migratorFunction, blockParameter);
        }

        
        public virtual Task<string> MigratorQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MigratorFunction, string>(null, blockParameter);
        }

        public virtual Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
        }

        
        public virtual Task<string> NameQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
        }

        public virtual Task<BigInteger> PoolIdToAmountQueryAsync(PoolIdToAmountFunction poolIdToAmountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PoolIdToAmountFunction, BigInteger>(poolIdToAmountFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> PoolIdToAmountQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var poolIdToAmountFunction = new PoolIdToAmountFunction();
                poolIdToAmountFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PoolIdToAmountFunction, BigInteger>(poolIdToAmountFunction, blockParameter);
        }

        public virtual Task<string> RegisterPoolRequestAsync(RegisterPoolFunction registerPoolFunction)
        {
             return ContractHandler.SendRequestAsync(registerPoolFunction);
        }

        public virtual Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(RegisterPoolFunction registerPoolFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerPoolFunction, cancellationToken);
        }

        public virtual Task<string> RegisterPoolRequestAsync(BigInteger poolId, List<BigInteger> @params)
        {
            var registerPoolFunction = new RegisterPoolFunction();
                registerPoolFunction.PoolId = poolId;
                registerPoolFunction.Params = @params;
            
             return ContractHandler.SendRequestAsync(registerPoolFunction);
        }

        public virtual Task<TransactionReceipt> RegisterPoolRequestAndWaitForReceiptAsync(BigInteger poolId, List<BigInteger> @params, CancellationTokenSource cancellationToken = null)
        {
            var registerPoolFunction = new RegisterPoolFunction();
                registerPoolFunction.PoolId = poolId;
                registerPoolFunction.Params = @params;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerPoolFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(SetFirewallFunction setFirewallFunction)
        {
             return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(SetFirewallFunction setFirewallFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallRequestAsync(string firewall)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
             return ContractHandler.SendRequestAsync(setFirewallFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallRequestAndWaitForReceiptAsync(string firewall, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallFunction = new SetFirewallFunction();
                setFirewallFunction.Firewall = firewall;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(SetFirewallAdminFunction setFirewallAdminFunction)
        {
             return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(SetFirewallAdminFunction setFirewallAdminFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> SetFirewallAdminRequestAsync(string firewallAdmin)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
             return ContractHandler.SendRequestAsync(setFirewallAdminFunction);
        }

        public virtual Task<TransactionReceipt> SetFirewallAdminRequestAndWaitForReceiptAsync(string firewallAdmin, CancellationTokenSource cancellationToken = null)
        {
            var setFirewallAdminFunction = new SetFirewallAdminFunction();
                setFirewallAdminFunction.FirewallAdmin = firewallAdmin;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFirewallAdminFunction, cancellationToken);
        }

        public virtual Task<string> SplitRequestAsync(SplitFunction splitFunction)
        {
             return ContractHandler.SendRequestAsync(splitFunction);
        }

        public virtual Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(SplitFunction splitFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(splitFunction, cancellationToken);
        }

        public virtual Task<string> SplitRequestAsync(BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio)
        {
            var splitFunction = new SplitFunction();
                splitFunction.OldPoolId = oldPoolId;
                splitFunction.NewPoolId = newPoolId;
                splitFunction.Ratio = ratio;
            
             return ContractHandler.SendRequestAsync(splitFunction);
        }

        public virtual Task<TransactionReceipt> SplitRequestAndWaitForReceiptAsync(BigInteger oldPoolId, BigInteger newPoolId, BigInteger ratio, CancellationTokenSource cancellationToken = null)
        {
            var splitFunction = new SplitFunction();
                splitFunction.OldPoolId = oldPoolId;
                splitFunction.NewPoolId = newPoolId;
                splitFunction.Ratio = ratio;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(splitFunction, cancellationToken);
        }

        public virtual Task<bool> SupportsInterfaceQueryAsync(SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        
        public virtual Task<bool> SupportsInterfaceQueryAsync(byte[] interfaceId, BlockParameter blockParameter = null)
        {
            var supportsInterfaceFunction = new SupportsInterfaceFunction();
                supportsInterfaceFunction.InterfaceId = interfaceId;
            
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public virtual Task<byte> TheTypeOfQueryAsync(TheTypeOfFunction theTypeOfFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TheTypeOfFunction, byte>(theTypeOfFunction, blockParameter);
        }

        
        public virtual Task<byte> TheTypeOfQueryAsync(BigInteger amount, BlockParameter blockParameter = null)
        {
            var theTypeOfFunction = new TheTypeOfFunction();
                theTypeOfFunction.Amount = amount;
            
            return ContractHandler.QueryAsync<TheTypeOfFunction, byte>(theTypeOfFunction, blockParameter);
        }

        public virtual Task<string> TokenQueryAsync(TokenFunction tokenFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenFunction, string>(tokenFunction, blockParameter);
        }

        
        public virtual Task<string> TokenQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenFunction, string>(null, blockParameter);
        }

        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(TokenOfOwnerByIndexFunction tokenOfOwnerByIndexFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> TokenOfOwnerByIndexQueryAsync(string user, BigInteger index, BlockParameter blockParameter = null)
        {
            var tokenOfOwnerByIndexFunction = new TokenOfOwnerByIndexFunction();
                tokenOfOwnerByIndexFunction.User = user;
                tokenOfOwnerByIndexFunction.Index = index;
            
            return ContractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
        }

        public virtual Task<TypeToProviderDataOutputDTO> TypeToProviderDataQueryAsync(TypeToProviderDataFunction typeToProviderDataFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<TypeToProviderDataFunction, TypeToProviderDataOutputDTO>(typeToProviderDataFunction, blockParameter);
        }

        public virtual Task<TypeToProviderDataOutputDTO> TypeToProviderDataQueryAsync(byte returnValue1, BlockParameter blockParameter = null)
        {
            var typeToProviderDataFunction = new TypeToProviderDataFunction();
                typeToProviderDataFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryDeserializingToObjectAsync<TypeToProviderDataFunction, TypeToProviderDataOutputDTO>(typeToProviderDataFunction, blockParameter);
        }

        public virtual Task<byte> TypesCountQueryAsync(TypesCountFunction typesCountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TypesCountFunction, byte>(typesCountFunction, blockParameter);
        }

        
        public virtual Task<byte> TypesCountQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TypesCountFunction, byte>(null, blockParameter);
        }

        public virtual Task<string> UpgradeTypeRequestAsync(UpgradeTypeFunction upgradeTypeFunction)
        {
             return ContractHandler.SendRequestAsync(upgradeTypeFunction);
        }

        public virtual Task<TransactionReceipt> UpgradeTypeRequestAndWaitForReceiptAsync(UpgradeTypeFunction upgradeTypeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradeTypeFunction, cancellationToken);
        }

        public virtual Task<string> UpgradeTypeRequestAsync(byte newType)
        {
            var upgradeTypeFunction = new UpgradeTypeFunction();
                upgradeTypeFunction.NewType = newType;
            
             return ContractHandler.SendRequestAsync(upgradeTypeFunction);
        }

        public virtual Task<TransactionReceipt> UpgradeTypeRequestAndWaitForReceiptAsync(byte newType, CancellationTokenSource cancellationToken = null)
        {
            var upgradeTypeFunction = new UpgradeTypeFunction();
                upgradeTypeFunction.NewType = newType;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradeTypeFunction, cancellationToken);
        }

        public virtual Task<BigInteger> UserToAmountQueryAsync(UserToAmountFunction userToAmountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<UserToAmountFunction, BigInteger>(userToAmountFunction, blockParameter);
        }

        
        public virtual Task<BigInteger> UserToAmountQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var userToAmountFunction = new UserToAmountFunction();
                userToAmountFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<UserToAmountFunction, BigInteger>(userToAmountFunction, blockParameter);
        }

        public virtual Task<byte> UserToTypeQueryAsync(UserToTypeFunction userToTypeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<UserToTypeFunction, byte>(userToTypeFunction, blockParameter);
        }

        
        public virtual Task<byte> UserToTypeQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var userToTypeFunction = new UserToTypeFunction();
                userToTypeFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<UserToTypeFunction, byte>(userToTypeFunction, blockParameter);
        }

        public virtual Task<string> WithdrawRequestAsync(WithdrawFunction withdrawFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(WithdrawFunction withdrawFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawRequestAsync(BigInteger tokenId)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(withdrawFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }
    }
}
