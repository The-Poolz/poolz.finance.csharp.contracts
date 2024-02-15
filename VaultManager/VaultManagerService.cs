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
using poolz.finance.csharp.VaultManager.ContractDefinition;

namespace poolz.finance.csharp.VaultManager
{
    public partial class VaultManagerService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, VaultManagerDeployment vaultManagerDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<VaultManagerDeployment>().SendRequestAndWaitForReceiptAsync(vaultManagerDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, VaultManagerDeployment vaultManagerDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<VaultManagerDeployment>().SendRequestAsync(vaultManagerDeployment);
        }

        public static async Task<VaultManagerService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, VaultManagerDeployment vaultManagerDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, vaultManagerDeployment, cancellationTokenSource);
            return new VaultManagerService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.IWeb3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public VaultManagerService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public VaultManagerService(Nethereum.Web3.IWeb3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> CreateNewVaultRequestAsync(CreateNewVault3Function createNewVault3Function)
        {
             return ContractHandler.SendRequestAsync(createNewVault3Function);
        }

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(CreateNewVault3Function createNewVault3Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewVault3Function, cancellationToken);
        }

        public Task<string> CreateNewVaultRequestAsync(string tokenAddress, BigInteger tradeStartTime, string royaltyReceiver, BigInteger feeNumerator)
        {
            var createNewVault3Function = new CreateNewVault3Function();
                createNewVault3Function.TokenAddress = tokenAddress;
                createNewVault3Function.TradeStartTime = tradeStartTime;
                createNewVault3Function.RoyaltyReceiver = royaltyReceiver;
                createNewVault3Function.FeeNumerator = feeNumerator;
            
             return ContractHandler.SendRequestAsync(createNewVault3Function);
        }

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(string tokenAddress, BigInteger tradeStartTime, string royaltyReceiver, BigInteger feeNumerator, CancellationTokenSource cancellationToken = null)
        {
            var createNewVault3Function = new CreateNewVault3Function();
                createNewVault3Function.TokenAddress = tokenAddress;
                createNewVault3Function.TradeStartTime = tradeStartTime;
                createNewVault3Function.RoyaltyReceiver = royaltyReceiver;
                createNewVault3Function.FeeNumerator = feeNumerator;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewVault3Function, cancellationToken);
        }

        public Task<string> CreateNewVaultRequestAsync(CreateNewVault2Function createNewVault2Function)
        {
             return ContractHandler.SendRequestAsync(createNewVault2Function);
        }

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(CreateNewVault2Function createNewVault2Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewVault2Function, cancellationToken);
        }

        public Task<string> CreateNewVaultRequestAsync(string tokenAddress, string royaltyReceiver, BigInteger feeNumerator)
        {
            var createNewVault2Function = new CreateNewVault2Function();
                createNewVault2Function.TokenAddress = tokenAddress;
                createNewVault2Function.RoyaltyReceiver = royaltyReceiver;
                createNewVault2Function.FeeNumerator = feeNumerator;
            
             return ContractHandler.SendRequestAsync(createNewVault2Function);
        }

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(string tokenAddress, string royaltyReceiver, BigInteger feeNumerator, CancellationTokenSource cancellationToken = null)
        {
            var createNewVault2Function = new CreateNewVault2Function();
                createNewVault2Function.TokenAddress = tokenAddress;
                createNewVault2Function.RoyaltyReceiver = royaltyReceiver;
                createNewVault2Function.FeeNumerator = feeNumerator;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewVault2Function, cancellationToken);
        }

        public Task<string> CreateNewVaultRequestAsync(CreateNewVault1Function createNewVault1Function)
        {
             return ContractHandler.SendRequestAsync(createNewVault1Function);
        }

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(CreateNewVault1Function createNewVault1Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewVault1Function, cancellationToken);
        }

        public Task<string> CreateNewVaultRequestAsync(string tokenAddress, BigInteger tradeStartTime)
        {
            var createNewVault1Function = new CreateNewVault1Function();
                createNewVault1Function.TokenAddress = tokenAddress;
                createNewVault1Function.TradeStartTime = tradeStartTime;
            
             return ContractHandler.SendRequestAsync(createNewVault1Function);
        }

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(string tokenAddress, BigInteger tradeStartTime, CancellationTokenSource cancellationToken = null)
        {
            var createNewVault1Function = new CreateNewVault1Function();
                createNewVault1Function.TokenAddress = tokenAddress;
                createNewVault1Function.TradeStartTime = tradeStartTime;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewVault1Function, cancellationToken);
        }

        public Task<string> CreateNewVaultRequestAsync(CreateNewVaultFunction createNewVaultFunction)
        {
             return ContractHandler.SendRequestAsync(createNewVaultFunction);
        }

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(CreateNewVaultFunction createNewVaultFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewVaultFunction, cancellationToken);
        }

        public Task<string> CreateNewVaultRequestAsync(string tokenAddress)
        {
            var createNewVaultFunction = new CreateNewVaultFunction();
                createNewVaultFunction.TokenAddress = tokenAddress;
            
             return ContractHandler.SendRequestAsync(createNewVaultFunction);
        }

        public Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(string tokenAddress, CancellationTokenSource cancellationToken = null)
        {
            var createNewVaultFunction = new CreateNewVaultFunction();
                createNewVaultFunction.TokenAddress = tokenAddress;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createNewVaultFunction, cancellationToken);
        }

        public Task<string> DepositByTokenRequestAsync(DepositByTokenFunction depositByTokenFunction)
        {
             return ContractHandler.SendRequestAsync(depositByTokenFunction);
        }

        public Task<TransactionReceipt> DepositByTokenRequestAndWaitForReceiptAsync(DepositByTokenFunction depositByTokenFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositByTokenFunction, cancellationToken);
        }

        public Task<string> DepositByTokenRequestAsync(string tokenAddress, BigInteger amount)
        {
            var depositByTokenFunction = new DepositByTokenFunction();
                depositByTokenFunction.TokenAddress = tokenAddress;
                depositByTokenFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(depositByTokenFunction);
        }

        public Task<TransactionReceipt> DepositByTokenRequestAndWaitForReceiptAsync(string tokenAddress, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var depositByTokenFunction = new DepositByTokenFunction();
                depositByTokenFunction.TokenAddress = tokenAddress;
                depositByTokenFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositByTokenFunction, cancellationToken);
        }

        public Task<string> FirewallAdminQueryAsync(FirewallAdminFunction firewallAdminFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(firewallAdminFunction, blockParameter);
        }

        
        public Task<string> FirewallAdminQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<FirewallAdminFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> GetAllVaultBalanceByTokenQueryAsync(GetAllVaultBalanceByTokenFunction getAllVaultBalanceByTokenFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetAllVaultBalanceByTokenFunction, BigInteger>(getAllVaultBalanceByTokenFunction, blockParameter);
        }

        
        public Task<BigInteger> GetAllVaultBalanceByTokenQueryAsync(string tokenAddress, BigInteger from, BigInteger count, BlockParameter blockParameter = null)
        {
            var getAllVaultBalanceByTokenFunction = new GetAllVaultBalanceByTokenFunction();
                getAllVaultBalanceByTokenFunction.TokenAddress = tokenAddress;
                getAllVaultBalanceByTokenFunction.From = from;
                getAllVaultBalanceByTokenFunction.Count = count;
            
            return ContractHandler.QueryAsync<GetAllVaultBalanceByTokenFunction, BigInteger>(getAllVaultBalanceByTokenFunction, blockParameter);
        }

        public Task<BigInteger> GetCurrentVaultBalanceByTokenQueryAsync(GetCurrentVaultBalanceByTokenFunction getCurrentVaultBalanceByTokenFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetCurrentVaultBalanceByTokenFunction, BigInteger>(getCurrentVaultBalanceByTokenFunction, blockParameter);
        }

        
        public Task<BigInteger> GetCurrentVaultBalanceByTokenQueryAsync(string tokenAddress, BlockParameter blockParameter = null)
        {
            var getCurrentVaultBalanceByTokenFunction = new GetCurrentVaultBalanceByTokenFunction();
                getCurrentVaultBalanceByTokenFunction.TokenAddress = tokenAddress;
            
            return ContractHandler.QueryAsync<GetCurrentVaultBalanceByTokenFunction, BigInteger>(getCurrentVaultBalanceByTokenFunction, blockParameter);
        }

        public Task<BigInteger> GetCurrentVaultIdByTokenQueryAsync(GetCurrentVaultIdByTokenFunction getCurrentVaultIdByTokenFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetCurrentVaultIdByTokenFunction, BigInteger>(getCurrentVaultIdByTokenFunction, blockParameter);
        }

        
        public Task<BigInteger> GetCurrentVaultIdByTokenQueryAsync(string tokenAddress, BlockParameter blockParameter = null)
        {
            var getCurrentVaultIdByTokenFunction = new GetCurrentVaultIdByTokenFunction();
                getCurrentVaultIdByTokenFunction.TokenAddress = tokenAddress;
            
            return ContractHandler.QueryAsync<GetCurrentVaultIdByTokenFunction, BigInteger>(getCurrentVaultIdByTokenFunction, blockParameter);
        }

        public Task<BigInteger> GetTotalVaultsByTokenQueryAsync(GetTotalVaultsByTokenFunction getTotalVaultsByTokenFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTotalVaultsByTokenFunction, BigInteger>(getTotalVaultsByTokenFunction, blockParameter);
        }

        
        public Task<BigInteger> GetTotalVaultsByTokenQueryAsync(string tokenAddress, BlockParameter blockParameter = null)
        {
            var getTotalVaultsByTokenFunction = new GetTotalVaultsByTokenFunction();
                getTotalVaultsByTokenFunction.TokenAddress = tokenAddress;
            
            return ContractHandler.QueryAsync<GetTotalVaultsByTokenFunction, BigInteger>(getTotalVaultsByTokenFunction, blockParameter);
        }

        public Task<BigInteger> GetVaultBalanceByVaultIdQueryAsync(GetVaultBalanceByVaultIdFunction getVaultBalanceByVaultIdFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetVaultBalanceByVaultIdFunction, BigInteger>(getVaultBalanceByVaultIdFunction, blockParameter);
        }

        
        public Task<BigInteger> GetVaultBalanceByVaultIdQueryAsync(BigInteger vaultId, BlockParameter blockParameter = null)
        {
            var getVaultBalanceByVaultIdFunction = new GetVaultBalanceByVaultIdFunction();
                getVaultBalanceByVaultIdFunction.VaultId = vaultId;
            
            return ContractHandler.QueryAsync<GetVaultBalanceByVaultIdFunction, BigInteger>(getVaultBalanceByVaultIdFunction, blockParameter);
        }

        public Task<bool> IsDepositActiveForVaultIdQueryAsync(IsDepositActiveForVaultIdFunction isDepositActiveForVaultIdFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsDepositActiveForVaultIdFunction, bool>(isDepositActiveForVaultIdFunction, blockParameter);
        }

        
        public Task<bool> IsDepositActiveForVaultIdQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var isDepositActiveForVaultIdFunction = new IsDepositActiveForVaultIdFunction();
                isDepositActiveForVaultIdFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<IsDepositActiveForVaultIdFunction, bool>(isDepositActiveForVaultIdFunction, blockParameter);
        }

        public Task<bool> IsWithdrawalActiveForVaultIdQueryAsync(IsWithdrawalActiveForVaultIdFunction isWithdrawalActiveForVaultIdFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsWithdrawalActiveForVaultIdFunction, bool>(isWithdrawalActiveForVaultIdFunction, blockParameter);
        }

        
        public Task<bool> IsWithdrawalActiveForVaultIdQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var isWithdrawalActiveForVaultIdFunction = new IsWithdrawalActiveForVaultIdFunction();
                isWithdrawalActiveForVaultIdFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<IsWithdrawalActiveForVaultIdFunction, bool>(isWithdrawalActiveForVaultIdFunction, blockParameter);
        }

        public Task<BigInteger> NoncesQueryAsync(NoncesFunction noncesFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NoncesFunction, BigInteger>(noncesFunction, blockParameter);
        }

        
        public Task<BigInteger> NoncesQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var noncesFunction = new NoncesFunction();
                noncesFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<NoncesFunction, BigInteger>(noncesFunction, blockParameter);
        }

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        
        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(renounceOwnershipFunction);
        }

        public Task<string> RenounceOwnershipRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RenounceOwnershipFunction>();
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceOwnershipFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RenounceOwnershipFunction>(null, cancellationToken);
        }

        public Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(RoyaltyInfoFunction royaltyInfoFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<RoyaltyInfoFunction, RoyaltyInfoOutputDTO>(royaltyInfoFunction, blockParameter);
        }

        public Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(BigInteger tokenId, BigInteger salePrice, BlockParameter blockParameter = null)
        {
            var royaltyInfoFunction = new RoyaltyInfoFunction();
                royaltyInfoFunction.TokenId = tokenId;
                royaltyInfoFunction.SalePrice = salePrice;
            
            return ContractHandler.QueryDeserializingToObjectAsync<RoyaltyInfoFunction, RoyaltyInfoOutputDTO>(royaltyInfoFunction, blockParameter);
        }

        public Task<string> SafeDepositRequestAsync(SafeDepositFunction safeDepositFunction)
        {
             return ContractHandler.SendRequestAsync(safeDepositFunction);
        }

        public Task<TransactionReceipt> SafeDepositRequestAndWaitForReceiptAsync(SafeDepositFunction safeDepositFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeDepositFunction, cancellationToken);
        }

        public Task<string> SafeDepositRequestAsync(string tokenAddress, BigInteger amount, string from, byte[] signature)
        {
            var safeDepositFunction = new SafeDepositFunction();
                safeDepositFunction.TokenAddress = tokenAddress;
                safeDepositFunction.Amount = amount;
                safeDepositFunction.From = from;
                safeDepositFunction.Signature = signature;
            
             return ContractHandler.SendRequestAsync(safeDepositFunction);
        }

        public Task<TransactionReceipt> SafeDepositRequestAndWaitForReceiptAsync(string tokenAddress, BigInteger amount, string from, byte[] signature, CancellationTokenSource cancellationToken = null)
        {
            var safeDepositFunction = new SafeDepositFunction();
                safeDepositFunction.TokenAddress = tokenAddress;
                safeDepositFunction.Amount = amount;
                safeDepositFunction.From = from;
                safeDepositFunction.Signature = signature;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeDepositFunction, cancellationToken);
        }

        public Task<string> SetActiveStatusForVaultIdRequestAsync(SetActiveStatusForVaultIdFunction setActiveStatusForVaultIdFunction)
        {
             return ContractHandler.SendRequestAsync(setActiveStatusForVaultIdFunction);
        }

        public Task<TransactionReceipt> SetActiveStatusForVaultIdRequestAndWaitForReceiptAsync(SetActiveStatusForVaultIdFunction setActiveStatusForVaultIdFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setActiveStatusForVaultIdFunction, cancellationToken);
        }

        public Task<string> SetActiveStatusForVaultIdRequestAsync(BigInteger vaultId, bool depositStatus, bool withdrawStatus)
        {
            var setActiveStatusForVaultIdFunction = new SetActiveStatusForVaultIdFunction();
                setActiveStatusForVaultIdFunction.VaultId = vaultId;
                setActiveStatusForVaultIdFunction.DepositStatus = depositStatus;
                setActiveStatusForVaultIdFunction.WithdrawStatus = withdrawStatus;
            
             return ContractHandler.SendRequestAsync(setActiveStatusForVaultIdFunction);
        }

        public Task<TransactionReceipt> SetActiveStatusForVaultIdRequestAndWaitForReceiptAsync(BigInteger vaultId, bool depositStatus, bool withdrawStatus, CancellationTokenSource cancellationToken = null)
        {
            var setActiveStatusForVaultIdFunction = new SetActiveStatusForVaultIdFunction();
                setActiveStatusForVaultIdFunction.VaultId = vaultId;
                setActiveStatusForVaultIdFunction.DepositStatus = depositStatus;
                setActiveStatusForVaultIdFunction.WithdrawStatus = withdrawStatus;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setActiveStatusForVaultIdFunction, cancellationToken);
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

        public Task<string> SetTradeStartTimeRequestAsync(SetTradeStartTimeFunction setTradeStartTimeFunction)
        {
             return ContractHandler.SendRequestAsync(setTradeStartTimeFunction);
        }

        public Task<TransactionReceipt> SetTradeStartTimeRequestAndWaitForReceiptAsync(SetTradeStartTimeFunction setTradeStartTimeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTradeStartTimeFunction, cancellationToken);
        }

        public Task<string> SetTradeStartTimeRequestAsync(BigInteger vaultId, BigInteger tradeStartTime)
        {
            var setTradeStartTimeFunction = new SetTradeStartTimeFunction();
                setTradeStartTimeFunction.VaultId = vaultId;
                setTradeStartTimeFunction.TradeStartTime = tradeStartTime;
            
             return ContractHandler.SendRequestAsync(setTradeStartTimeFunction);
        }

        public Task<TransactionReceipt> SetTradeStartTimeRequestAndWaitForReceiptAsync(BigInteger vaultId, BigInteger tradeStartTime, CancellationTokenSource cancellationToken = null)
        {
            var setTradeStartTimeFunction = new SetTradeStartTimeFunction();
                setTradeStartTimeFunction.VaultId = vaultId;
                setTradeStartTimeFunction.TradeStartTime = tradeStartTime;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTradeStartTimeFunction, cancellationToken);
        }

        public Task<string> SetTrusteeRequestAsync(SetTrusteeFunction setTrusteeFunction)
        {
             return ContractHandler.SendRequestAsync(setTrusteeFunction);
        }

        public Task<TransactionReceipt> SetTrusteeRequestAndWaitForReceiptAsync(SetTrusteeFunction setTrusteeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTrusteeFunction, cancellationToken);
        }

        public Task<string> SetTrusteeRequestAsync(string address)
        {
            var setTrusteeFunction = new SetTrusteeFunction();
                setTrusteeFunction.Address = address;
            
             return ContractHandler.SendRequestAsync(setTrusteeFunction);
        }

        public Task<TransactionReceipt> SetTrusteeRequestAndWaitForReceiptAsync(string address, CancellationTokenSource cancellationToken = null)
        {
            var setTrusteeFunction = new SetTrusteeFunction();
                setTrusteeFunction.Address = address;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTrusteeFunction, cancellationToken);
        }

        public Task<bool> SupportsInterfaceQueryAsync(SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        
        public Task<bool> SupportsInterfaceQueryAsync(byte[] interfaceId, BlockParameter blockParameter = null)
        {
            var supportsInterfaceFunction = new SupportsInterfaceFunction();
                supportsInterfaceFunction.InterfaceId = interfaceId;
            
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public Task<BigInteger> TokenToVaultIdsQueryAsync(TokenToVaultIdsFunction tokenToVaultIdsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenToVaultIdsFunction, BigInteger>(tokenToVaultIdsFunction, blockParameter);
        }

        
        public Task<BigInteger> TokenToVaultIdsQueryAsync(string returnValue1, BigInteger returnValue2, BlockParameter blockParameter = null)
        {
            var tokenToVaultIdsFunction = new TokenToVaultIdsFunction();
                tokenToVaultIdsFunction.ReturnValue1 = returnValue1;
                tokenToVaultIdsFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<TokenToVaultIdsFunction, BigInteger>(tokenToVaultIdsFunction, blockParameter);
        }

        public Task<BigInteger> TotalVaultsQueryAsync(TotalVaultsFunction totalVaultsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TotalVaultsFunction, BigInteger>(totalVaultsFunction, blockParameter);
        }

        
        public Task<BigInteger> TotalVaultsQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TotalVaultsFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public Task<string> TransferOwnershipRequestAsync(string newOwner)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public Task<string> TrusteeQueryAsync(TrusteeFunction trusteeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TrusteeFunction, string>(trusteeFunction, blockParameter);
        }

        
        public Task<string> TrusteeQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TrusteeFunction, string>(null, blockParameter);
        }

        public Task<string> UpdateTrusteeRequestAsync(UpdateTrusteeFunction updateTrusteeFunction)
        {
             return ContractHandler.SendRequestAsync(updateTrusteeFunction);
        }

        public Task<TransactionReceipt> UpdateTrusteeRequestAndWaitForReceiptAsync(UpdateTrusteeFunction updateTrusteeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(updateTrusteeFunction, cancellationToken);
        }

        public Task<string> UpdateTrusteeRequestAsync(string address)
        {
            var updateTrusteeFunction = new UpdateTrusteeFunction();
                updateTrusteeFunction.Address = address;
            
             return ContractHandler.SendRequestAsync(updateTrusteeFunction);
        }

        public Task<TransactionReceipt> UpdateTrusteeRequestAndWaitForReceiptAsync(string address, CancellationTokenSource cancellationToken = null)
        {
            var updateTrusteeFunction = new UpdateTrusteeFunction();
                updateTrusteeFunction.Address = address;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(updateTrusteeFunction, cancellationToken);
        }

        public Task<string> VaultIdToTokenAddressQueryAsync(VaultIdToTokenAddressFunction vaultIdToTokenAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<VaultIdToTokenAddressFunction, string>(vaultIdToTokenAddressFunction, blockParameter);
        }

        
        public Task<string> VaultIdToTokenAddressQueryAsync(BigInteger vaultId, BlockParameter blockParameter = null)
        {
            var vaultIdToTokenAddressFunction = new VaultIdToTokenAddressFunction();
                vaultIdToTokenAddressFunction.VaultId = vaultId;
            
            return ContractHandler.QueryAsync<VaultIdToTokenAddressFunction, string>(vaultIdToTokenAddressFunction, blockParameter);
        }

        public Task<BigInteger> VaultIdToTradeStartTimeQueryAsync(VaultIdToTradeStartTimeFunction vaultIdToTradeStartTimeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<VaultIdToTradeStartTimeFunction, BigInteger>(vaultIdToTradeStartTimeFunction, blockParameter);
        }

        
        public Task<BigInteger> VaultIdToTradeStartTimeQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var vaultIdToTradeStartTimeFunction = new VaultIdToTradeStartTimeFunction();
                vaultIdToTradeStartTimeFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<VaultIdToTradeStartTimeFunction, BigInteger>(vaultIdToTradeStartTimeFunction, blockParameter);
        }

        public Task<string> VaultIdToVaultQueryAsync(VaultIdToVaultFunction vaultIdToVaultFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<VaultIdToVaultFunction, string>(vaultIdToVaultFunction, blockParameter);
        }

        
        public Task<string> VaultIdToVaultQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var vaultIdToVaultFunction = new VaultIdToVaultFunction();
                vaultIdToVaultFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<VaultIdToVaultFunction, string>(vaultIdToVaultFunction, blockParameter);
        }

        public Task<string> WithdrawByVaultIdRequestAsync(WithdrawByVaultIdFunction withdrawByVaultIdFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawByVaultIdFunction);
        }

        public Task<TransactionReceipt> WithdrawByVaultIdRequestAndWaitForReceiptAsync(WithdrawByVaultIdFunction withdrawByVaultIdFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawByVaultIdFunction, cancellationToken);
        }

        public Task<string> WithdrawByVaultIdRequestAsync(BigInteger vaultId, string to, BigInteger amount)
        {
            var withdrawByVaultIdFunction = new WithdrawByVaultIdFunction();
                withdrawByVaultIdFunction.VaultId = vaultId;
                withdrawByVaultIdFunction.To = to;
                withdrawByVaultIdFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(withdrawByVaultIdFunction);
        }

        public Task<TransactionReceipt> WithdrawByVaultIdRequestAndWaitForReceiptAsync(BigInteger vaultId, string to, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var withdrawByVaultIdFunction = new WithdrawByVaultIdFunction();
                withdrawByVaultIdFunction.VaultId = vaultId;
                withdrawByVaultIdFunction.To = to;
                withdrawByVaultIdFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawByVaultIdFunction, cancellationToken);
        }
    }
}
