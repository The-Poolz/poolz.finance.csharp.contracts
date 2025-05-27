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
using poolz.finance.csharp.contracts.VaultManager.ContractDefinition;

namespace poolz.finance.csharp.contracts.VaultManager
{
    public partial class VaultManagerService<TContractType> : IVaultManagerService<TContractType>
        where TContractType : Enum
    {
        public IChainProvider<TContractType> ChainProvider { get; }

        public VaultManagerService(IChainProvider<TContractType> chainProvider)
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

        public virtual Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, CreateNewVault3Function createNewVault3Function)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewVault3Function);
        }

        public virtual Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CreateNewVault3Function createNewVault3Function, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewVault3Function, cancellationToken);
        }

        public virtual Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger tradeStartTime, string royaltyReceiver, BigInteger feeNumerator)
        {
            var createNewVault3Function = new CreateNewVault3Function();
                createNewVault3Function.TokenAddress = tokenAddress;
                createNewVault3Function.TradeStartTime = tradeStartTime;
                createNewVault3Function.RoyaltyReceiver = royaltyReceiver;
                createNewVault3Function.FeeNumerator = feeNumerator;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewVault3Function);
        }

        public virtual Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger tradeStartTime, string royaltyReceiver, BigInteger feeNumerator, CancellationTokenSource cancellationToken = null)
        {
            var createNewVault3Function = new CreateNewVault3Function();
                createNewVault3Function.TokenAddress = tokenAddress;
                createNewVault3Function.TradeStartTime = tradeStartTime;
                createNewVault3Function.RoyaltyReceiver = royaltyReceiver;
                createNewVault3Function.FeeNumerator = feeNumerator;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewVault3Function, cancellationToken);
        }

        public virtual Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, CreateNewVault2Function createNewVault2Function)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewVault2Function);
        }

        public virtual Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CreateNewVault2Function createNewVault2Function, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewVault2Function, cancellationToken);
        }

        public virtual Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, string tokenAddress, string royaltyReceiver, BigInteger feeNumerator)
        {
            var createNewVault2Function = new CreateNewVault2Function();
                createNewVault2Function.TokenAddress = tokenAddress;
                createNewVault2Function.RoyaltyReceiver = royaltyReceiver;
                createNewVault2Function.FeeNumerator = feeNumerator;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewVault2Function);
        }

        public virtual Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string tokenAddress, string royaltyReceiver, BigInteger feeNumerator, CancellationTokenSource cancellationToken = null)
        {
            var createNewVault2Function = new CreateNewVault2Function();
                createNewVault2Function.TokenAddress = tokenAddress;
                createNewVault2Function.RoyaltyReceiver = royaltyReceiver;
                createNewVault2Function.FeeNumerator = feeNumerator;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewVault2Function, cancellationToken);
        }

        public virtual Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, CreateNewVault1Function createNewVault1Function)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewVault1Function);
        }

        public virtual Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CreateNewVault1Function createNewVault1Function, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewVault1Function, cancellationToken);
        }

        public virtual Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger tradeStartTime)
        {
            var createNewVault1Function = new CreateNewVault1Function();
                createNewVault1Function.TokenAddress = tokenAddress;
                createNewVault1Function.TradeStartTime = tradeStartTime;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewVault1Function);
        }

        public virtual Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger tradeStartTime, CancellationTokenSource cancellationToken = null)
        {
            var createNewVault1Function = new CreateNewVault1Function();
                createNewVault1Function.TokenAddress = tokenAddress;
                createNewVault1Function.TradeStartTime = tradeStartTime;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewVault1Function, cancellationToken);
        }

        public virtual Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, CreateNewVaultFunction createNewVaultFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewVaultFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CreateNewVaultFunction createNewVaultFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewVaultFunction, cancellationToken);
        }

        public virtual Task<string> CreateNewVaultRequestAsync(long chainId, TContractType contractType, string tokenAddress)
        {
            var createNewVaultFunction = new CreateNewVaultFunction();
                createNewVaultFunction.TokenAddress = tokenAddress;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(createNewVaultFunction);
        }

        public virtual Task<TransactionReceipt> CreateNewVaultRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string tokenAddress, CancellationTokenSource cancellationToken = null)
        {
            var createNewVaultFunction = new CreateNewVaultFunction();
                createNewVaultFunction.TokenAddress = tokenAddress;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(createNewVaultFunction, cancellationToken);
        }

        public virtual Task<string> DepositByTokenRequestAsync(long chainId, TContractType contractType, DepositByTokenFunction depositByTokenFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(depositByTokenFunction);
        }

        public virtual Task<TransactionReceipt> DepositByTokenRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, DepositByTokenFunction depositByTokenFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(depositByTokenFunction, cancellationToken);
        }

        public virtual Task<string> DepositByTokenRequestAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger amount)
        {
            var depositByTokenFunction = new DepositByTokenFunction();
                depositByTokenFunction.TokenAddress = tokenAddress;
                depositByTokenFunction.Amount = amount;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(depositByTokenFunction);
        }

        public virtual Task<TransactionReceipt> DepositByTokenRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var depositByTokenFunction = new DepositByTokenFunction();
                depositByTokenFunction.TokenAddress = tokenAddress;
                depositByTokenFunction.Amount = amount;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(depositByTokenFunction, cancellationToken);
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

        public virtual Task<BigInteger> GetAllVaultBalanceByTokenQueryAsync(long chainId, TContractType contractType, GetAllVaultBalanceByTokenFunction getAllVaultBalanceByTokenFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetAllVaultBalanceByTokenFunction, BigInteger>(getAllVaultBalanceByTokenFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetAllVaultBalanceByTokenQueryAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger from, BigInteger count, BlockParameter blockParameter = null)
        {
            var getAllVaultBalanceByTokenFunction = new GetAllVaultBalanceByTokenFunction();
                getAllVaultBalanceByTokenFunction.TokenAddress = tokenAddress;
                getAllVaultBalanceByTokenFunction.From = from;
                getAllVaultBalanceByTokenFunction.Count = count;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetAllVaultBalanceByTokenFunction, BigInteger>(getAllVaultBalanceByTokenFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetCurrentVaultBalanceByTokenQueryAsync(long chainId, TContractType contractType, GetCurrentVaultBalanceByTokenFunction getCurrentVaultBalanceByTokenFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetCurrentVaultBalanceByTokenFunction, BigInteger>(getCurrentVaultBalanceByTokenFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetCurrentVaultBalanceByTokenQueryAsync(long chainId, TContractType contractType, string tokenAddress, BlockParameter blockParameter = null)
        {
            var getCurrentVaultBalanceByTokenFunction = new GetCurrentVaultBalanceByTokenFunction();
                getCurrentVaultBalanceByTokenFunction.TokenAddress = tokenAddress;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetCurrentVaultBalanceByTokenFunction, BigInteger>(getCurrentVaultBalanceByTokenFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetCurrentVaultIdByTokenQueryAsync(long chainId, TContractType contractType, GetCurrentVaultIdByTokenFunction getCurrentVaultIdByTokenFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetCurrentVaultIdByTokenFunction, BigInteger>(getCurrentVaultIdByTokenFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetCurrentVaultIdByTokenQueryAsync(long chainId, TContractType contractType, string tokenAddress, BlockParameter blockParameter = null)
        {
            var getCurrentVaultIdByTokenFunction = new GetCurrentVaultIdByTokenFunction();
                getCurrentVaultIdByTokenFunction.TokenAddress = tokenAddress;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetCurrentVaultIdByTokenFunction, BigInteger>(getCurrentVaultIdByTokenFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetTotalVaultsByTokenQueryAsync(long chainId, TContractType contractType, GetTotalVaultsByTokenFunction getTotalVaultsByTokenFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetTotalVaultsByTokenFunction, BigInteger>(getTotalVaultsByTokenFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetTotalVaultsByTokenQueryAsync(long chainId, TContractType contractType, string tokenAddress, BlockParameter blockParameter = null)
        {
            var getTotalVaultsByTokenFunction = new GetTotalVaultsByTokenFunction();
                getTotalVaultsByTokenFunction.TokenAddress = tokenAddress;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetTotalVaultsByTokenFunction, BigInteger>(getTotalVaultsByTokenFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetVaultBalanceByVaultIdQueryAsync(long chainId, TContractType contractType, GetVaultBalanceByVaultIdFunction getVaultBalanceByVaultIdFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetVaultBalanceByVaultIdFunction, BigInteger>(getVaultBalanceByVaultIdFunction, blockParameter);
        }

        public virtual Task<BigInteger> GetVaultBalanceByVaultIdQueryAsync(long chainId, TContractType contractType, BigInteger vaultId, BlockParameter blockParameter = null)
        {
            var getVaultBalanceByVaultIdFunction = new GetVaultBalanceByVaultIdFunction();
                getVaultBalanceByVaultIdFunction.VaultId = vaultId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<GetVaultBalanceByVaultIdFunction, BigInteger>(getVaultBalanceByVaultIdFunction, blockParameter);
        }

        public virtual Task<bool> IsDepositActiveForVaultIdQueryAsync(long chainId, TContractType contractType, IsDepositActiveForVaultIdFunction isDepositActiveForVaultIdFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsDepositActiveForVaultIdFunction, bool>(isDepositActiveForVaultIdFunction, blockParameter);
        }

        public virtual Task<bool> IsDepositActiveForVaultIdQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var isDepositActiveForVaultIdFunction = new IsDepositActiveForVaultIdFunction();
                isDepositActiveForVaultIdFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsDepositActiveForVaultIdFunction, bool>(isDepositActiveForVaultIdFunction, blockParameter);
        }

        public virtual Task<bool> IsWithdrawalActiveForVaultIdQueryAsync(long chainId, TContractType contractType, IsWithdrawalActiveForVaultIdFunction isWithdrawalActiveForVaultIdFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsWithdrawalActiveForVaultIdFunction, bool>(isWithdrawalActiveForVaultIdFunction, blockParameter);
        }

        public virtual Task<bool> IsWithdrawalActiveForVaultIdQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var isWithdrawalActiveForVaultIdFunction = new IsWithdrawalActiveForVaultIdFunction();
                isWithdrawalActiveForVaultIdFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<IsWithdrawalActiveForVaultIdFunction, bool>(isWithdrawalActiveForVaultIdFunction, blockParameter);
        }

        public virtual Task<BigInteger> NoncesQueryAsync(long chainId, TContractType contractType, NoncesFunction noncesFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<NoncesFunction, BigInteger>(noncesFunction, blockParameter);
        }

        public virtual Task<BigInteger> NoncesQueryAsync(long chainId, TContractType contractType, string returnValue1, BlockParameter blockParameter = null)
        {
            var noncesFunction = new NoncesFunction();
                noncesFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<NoncesFunction, BigInteger>(noncesFunction, blockParameter);
        }

        public virtual Task<string> OwnerQueryAsync(long chainId, TContractType contractType, OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        public virtual Task<string> OwnerQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public virtual Task<string> RenounceOwnershipRequestAsync(long chainId, TContractType contractType, RenounceOwnershipFunction renounceOwnershipFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(renounceOwnershipFunction);
        }

        public virtual Task<string> RenounceOwnershipRequestAsync(long chainId, TContractType contractType)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync<RenounceOwnershipFunction>();
        }

        public virtual Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(renounceOwnershipFunction, cancellationToken);
        }

        public virtual Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync<RenounceOwnershipFunction>(null, cancellationToken);
        }

        public virtual Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(long chainId, TContractType contractType, RoyaltyInfoFunction royaltyInfoFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<RoyaltyInfoFunction, RoyaltyInfoOutputDTO>(royaltyInfoFunction, blockParameter);
        }

        public virtual Task<RoyaltyInfoOutputDTO> RoyaltyInfoQueryAsync(long chainId, TContractType contractType, BigInteger tokenId, BigInteger salePrice, BlockParameter blockParameter = null)
        {
            var royaltyInfoFunction = new RoyaltyInfoFunction();
                royaltyInfoFunction.TokenId = tokenId;
                royaltyInfoFunction.SalePrice = salePrice;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryDeserializingToObjectAsync<RoyaltyInfoFunction, RoyaltyInfoOutputDTO>(royaltyInfoFunction, blockParameter);
        }

        public virtual Task<string> SafeDepositRequestAsync(long chainId, TContractType contractType, SafeDepositFunction safeDepositFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(safeDepositFunction);
        }

        public virtual Task<TransactionReceipt> SafeDepositRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SafeDepositFunction safeDepositFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(safeDepositFunction, cancellationToken);
        }

        public virtual Task<string> SafeDepositRequestAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger amount, string from, byte[] signature)
        {
            var safeDepositFunction = new SafeDepositFunction();
                safeDepositFunction.TokenAddress = tokenAddress;
                safeDepositFunction.Amount = amount;
                safeDepositFunction.From = from;
                safeDepositFunction.Signature = signature;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(safeDepositFunction);
        }

        public virtual Task<TransactionReceipt> SafeDepositRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string tokenAddress, BigInteger amount, string from, byte[] signature, CancellationTokenSource cancellationToken = null)
        {
            var safeDepositFunction = new SafeDepositFunction();
                safeDepositFunction.TokenAddress = tokenAddress;
                safeDepositFunction.Amount = amount;
                safeDepositFunction.From = from;
                safeDepositFunction.Signature = signature;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(safeDepositFunction, cancellationToken);
        }

        public virtual Task<string> SetActiveStatusForVaultIdRequestAsync(long chainId, TContractType contractType, SetActiveStatusForVaultIdFunction setActiveStatusForVaultIdFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setActiveStatusForVaultIdFunction);
        }

        public virtual Task<TransactionReceipt> SetActiveStatusForVaultIdRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetActiveStatusForVaultIdFunction setActiveStatusForVaultIdFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setActiveStatusForVaultIdFunction, cancellationToken);
        }

        public virtual Task<string> SetActiveStatusForVaultIdRequestAsync(long chainId, TContractType contractType, BigInteger vaultId, bool depositStatus, bool withdrawStatus)
        {
            var setActiveStatusForVaultIdFunction = new SetActiveStatusForVaultIdFunction();
                setActiveStatusForVaultIdFunction.VaultId = vaultId;
                setActiveStatusForVaultIdFunction.DepositStatus = depositStatus;
                setActiveStatusForVaultIdFunction.WithdrawStatus = withdrawStatus;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setActiveStatusForVaultIdFunction);
        }

        public virtual Task<TransactionReceipt> SetActiveStatusForVaultIdRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger vaultId, bool depositStatus, bool withdrawStatus, CancellationTokenSource cancellationToken = null)
        {
            var setActiveStatusForVaultIdFunction = new SetActiveStatusForVaultIdFunction();
                setActiveStatusForVaultIdFunction.VaultId = vaultId;
                setActiveStatusForVaultIdFunction.DepositStatus = depositStatus;
                setActiveStatusForVaultIdFunction.WithdrawStatus = withdrawStatus;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setActiveStatusForVaultIdFunction, cancellationToken);
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

        public virtual Task<string> SetTradeStartTimeRequestAsync(long chainId, TContractType contractType, SetTradeStartTimeFunction setTradeStartTimeFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setTradeStartTimeFunction);
        }

        public virtual Task<TransactionReceipt> SetTradeStartTimeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetTradeStartTimeFunction setTradeStartTimeFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setTradeStartTimeFunction, cancellationToken);
        }

        public virtual Task<string> SetTradeStartTimeRequestAsync(long chainId, TContractType contractType, BigInteger vaultId, BigInteger tradeStartTime)
        {
            var setTradeStartTimeFunction = new SetTradeStartTimeFunction();
                setTradeStartTimeFunction.VaultId = vaultId;
                setTradeStartTimeFunction.TradeStartTime = tradeStartTime;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setTradeStartTimeFunction);
        }

        public virtual Task<TransactionReceipt> SetTradeStartTimeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger vaultId, BigInteger tradeStartTime, CancellationTokenSource cancellationToken = null)
        {
            var setTradeStartTimeFunction = new SetTradeStartTimeFunction();
                setTradeStartTimeFunction.VaultId = vaultId;
                setTradeStartTimeFunction.TradeStartTime = tradeStartTime;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setTradeStartTimeFunction, cancellationToken);
        }

        public virtual Task<string> SetTrusteeRequestAsync(long chainId, TContractType contractType, SetTrusteeFunction setTrusteeFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setTrusteeFunction);
        }

        public virtual Task<TransactionReceipt> SetTrusteeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, SetTrusteeFunction setTrusteeFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setTrusteeFunction, cancellationToken);
        }

        public virtual Task<string> SetTrusteeRequestAsync(long chainId, TContractType contractType, string address)
        {
            var setTrusteeFunction = new SetTrusteeFunction();
                setTrusteeFunction.Address = address;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(setTrusteeFunction);
        }

        public virtual Task<TransactionReceipt> SetTrusteeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string address, CancellationTokenSource cancellationToken = null)
        {
            var setTrusteeFunction = new SetTrusteeFunction();
                setTrusteeFunction.Address = address;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(setTrusteeFunction, cancellationToken);
        }

        public virtual Task<bool> SupportsInterfaceQueryAsync(long chainId, TContractType contractType, SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public virtual Task<bool> SupportsInterfaceQueryAsync(long chainId, TContractType contractType, byte[] interfaceId, BlockParameter blockParameter = null)
        {
            var supportsInterfaceFunction = new SupportsInterfaceFunction();
                supportsInterfaceFunction.InterfaceId = interfaceId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public virtual Task<BigInteger> TokenToVaultIdsQueryAsync(long chainId, TContractType contractType, TokenToVaultIdsFunction tokenToVaultIdsFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenToVaultIdsFunction, BigInteger>(tokenToVaultIdsFunction, blockParameter);
        }

        public virtual Task<BigInteger> TokenToVaultIdsQueryAsync(long chainId, TContractType contractType, string returnValue1, BigInteger returnValue2, BlockParameter blockParameter = null)
        {
            var tokenToVaultIdsFunction = new TokenToVaultIdsFunction();
                tokenToVaultIdsFunction.ReturnValue1 = returnValue1;
                tokenToVaultIdsFunction.ReturnValue2 = returnValue2;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TokenToVaultIdsFunction, BigInteger>(tokenToVaultIdsFunction, blockParameter);
        }

        public virtual Task<BigInteger> TotalVaultsQueryAsync(long chainId, TContractType contractType, TotalVaultsFunction totalVaultsFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TotalVaultsFunction, BigInteger>(totalVaultsFunction, blockParameter);
        }

        public virtual Task<BigInteger> TotalVaultsQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TotalVaultsFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> TransferOwnershipRequestAsync(long chainId, TContractType contractType, TransferOwnershipFunction transferOwnershipFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public virtual Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public virtual Task<string> TransferOwnershipRequestAsync(long chainId, TContractType contractType, string newOwner)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public virtual Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string newOwner, CancellationTokenSource cancellationToken = null)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public virtual Task<string> TrusteeQueryAsync(long chainId, TContractType contractType, TrusteeFunction trusteeFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TrusteeFunction, string>(trusteeFunction, blockParameter);
        }

        public virtual Task<string> TrusteeQueryAsync(long chainId, TContractType contractType, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<TrusteeFunction, string>(null, blockParameter);
        }

        public virtual Task<string> UpdateTrusteeRequestAsync(long chainId, TContractType contractType, UpdateTrusteeFunction updateTrusteeFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(updateTrusteeFunction);
        }

        public virtual Task<TransactionReceipt> UpdateTrusteeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, UpdateTrusteeFunction updateTrusteeFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(updateTrusteeFunction, cancellationToken);
        }

        public virtual Task<string> UpdateTrusteeRequestAsync(long chainId, TContractType contractType, string address)
        {
            var updateTrusteeFunction = new UpdateTrusteeFunction();
                updateTrusteeFunction.Address = address;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(updateTrusteeFunction);
        }

        public virtual Task<TransactionReceipt> UpdateTrusteeRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, string address, CancellationTokenSource cancellationToken = null)
        {
            var updateTrusteeFunction = new UpdateTrusteeFunction();
                updateTrusteeFunction.Address = address;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(updateTrusteeFunction, cancellationToken);
        }

        public virtual Task<string> VaultIdToTokenAddressQueryAsync(long chainId, TContractType contractType, VaultIdToTokenAddressFunction vaultIdToTokenAddressFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<VaultIdToTokenAddressFunction, string>(vaultIdToTokenAddressFunction, blockParameter);
        }

        public virtual Task<string> VaultIdToTokenAddressQueryAsync(long chainId, TContractType contractType, BigInteger vaultId, BlockParameter blockParameter = null)
        {
            var vaultIdToTokenAddressFunction = new VaultIdToTokenAddressFunction();
                vaultIdToTokenAddressFunction.VaultId = vaultId;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<VaultIdToTokenAddressFunction, string>(vaultIdToTokenAddressFunction, blockParameter);
        }

        public virtual Task<BigInteger> VaultIdToTradeStartTimeQueryAsync(long chainId, TContractType contractType, VaultIdToTradeStartTimeFunction vaultIdToTradeStartTimeFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<VaultIdToTradeStartTimeFunction, BigInteger>(vaultIdToTradeStartTimeFunction, blockParameter);
        }

        public virtual Task<BigInteger> VaultIdToTradeStartTimeQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var vaultIdToTradeStartTimeFunction = new VaultIdToTradeStartTimeFunction();
                vaultIdToTradeStartTimeFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<VaultIdToTradeStartTimeFunction, BigInteger>(vaultIdToTradeStartTimeFunction, blockParameter);
        }

        public virtual Task<string> VaultIdToVaultQueryAsync(long chainId, TContractType contractType, VaultIdToVaultFunction vaultIdToVaultFunction, BlockParameter blockParameter = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<VaultIdToVaultFunction, string>(vaultIdToVaultFunction, blockParameter);
        }

        public virtual Task<string> VaultIdToVaultQueryAsync(long chainId, TContractType contractType, BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var vaultIdToVaultFunction = new VaultIdToVaultFunction();
                vaultIdToVaultFunction.ReturnValue1 = returnValue1;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.QueryAsync<VaultIdToVaultFunction, string>(vaultIdToVaultFunction, blockParameter);
        }

        public virtual Task<string> WithdrawByVaultIdRequestAsync(long chainId, TContractType contractType, WithdrawByVaultIdFunction withdrawByVaultIdFunction)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawByVaultIdFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawByVaultIdRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, WithdrawByVaultIdFunction withdrawByVaultIdFunction, CancellationTokenSource cancellationToken = null)
        {
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawByVaultIdFunction, cancellationToken);
        }

        public virtual Task<string> WithdrawByVaultIdRequestAsync(long chainId, TContractType contractType, BigInteger vaultId, string to, BigInteger amount)
        {
            var withdrawByVaultIdFunction = new WithdrawByVaultIdFunction();
                withdrawByVaultIdFunction.VaultId = vaultId;
                withdrawByVaultIdFunction.To = to;
                withdrawByVaultIdFunction.Amount = amount;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAsync(withdrawByVaultIdFunction);
        }

        public virtual Task<TransactionReceipt> WithdrawByVaultIdRequestAndWaitForReceiptAsync(long chainId, TContractType contractType, BigInteger vaultId, string to, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var withdrawByVaultIdFunction = new WithdrawByVaultIdFunction();
                withdrawByVaultIdFunction.VaultId = vaultId;
                withdrawByVaultIdFunction.To = to;
                withdrawByVaultIdFunction.Amount = amount;
            
            var contractHandler = InitializeContractHandler(chainId, contractType);
            return contractHandler.SendRequestAndWaitForReceiptAsync(withdrawByVaultIdFunction, cancellationToken);
        }
    }
}
