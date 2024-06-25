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
using poolz.finance.csharp.contracts.BeaconToken.ContractDefinition;

namespace poolz.finance.csharp.contracts.BeaconToken
{
    public partial class BeaconTokenService : IBeaconTokenService
    {
        protected virtual IWeb3 Web3 { get; private set; }

        public virtual ContractHandler ContractHandler { get; private set; }

        public BeaconTokenService() { }

        public BeaconTokenService(Web3 web3, string contractAddress)
        {
            Initialize(web3, contractAddress);
        }

        public BeaconTokenService(IWeb3 web3, string contractAddress)
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

        public virtual Task<BigInteger> AllowanceQueryAsync(AllowanceFunction allowanceFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<AllowanceFunction, BigInteger>(allowanceFunction, blockParameter);
        }

        public virtual Task<BigInteger> AllowanceQueryAsync(string owner, string spender, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var allowanceFunction = new AllowanceFunction();
                allowanceFunction.Owner = owner;
                allowanceFunction.Spender = spender;
            
            return ContractHandler.QueryAsync<AllowanceFunction, BigInteger>(allowanceFunction, blockParameter);
        }

        public virtual Task<string> ApproveRequestAsync(ApproveFunction approveFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(approveFunction);
        }

        public virtual Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public virtual Task<string> ApproveRequestAsync(string spender, BigInteger amount)
        {
            EnsureInitialized();
            var approveFunction = new ApproveFunction();
                approveFunction.Spender = spender;
                approveFunction.Amount = amount;
            
            return ContractHandler.SendRequestAsync(approveFunction);
        }

        public virtual Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(string spender, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var approveFunction = new ApproveFunction();
                approveFunction.Spender = spender;
                approveFunction.Amount = amount;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public virtual Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        public virtual Task<BigInteger> BalanceOfQueryAsync(string account, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            var balanceOfFunction = new BalanceOfFunction();
                balanceOfFunction.Account = account;
            
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        public virtual Task<string> BurnRequestAsync(BurnFunction burnFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(burnFunction);
        }

        public virtual Task<TransactionReceipt> BurnRequestAndWaitForReceiptAsync(BurnFunction burnFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(burnFunction, cancellationToken);
        }

        public virtual Task<string> BurnRequestAsync(BigInteger amount)
        {
            EnsureInitialized();
            var burnFunction = new BurnFunction();
                burnFunction.Amount = amount;
            
            return ContractHandler.SendRequestAsync(burnFunction);
        }

        public virtual Task<TransactionReceipt> BurnRequestAndWaitForReceiptAsync(BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var burnFunction = new BurnFunction();
                burnFunction.Amount = amount;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(burnFunction, cancellationToken);
        }

        public virtual Task<string> BurnFromRequestAsync(BurnFromFunction burnFromFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(burnFromFunction);
        }

        public virtual Task<TransactionReceipt> BurnFromRequestAndWaitForReceiptAsync(BurnFromFunction burnFromFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(burnFromFunction, cancellationToken);
        }

        public virtual Task<string> BurnFromRequestAsync(string account, BigInteger amount)
        {
            EnsureInitialized();
            var burnFromFunction = new BurnFromFunction();
                burnFromFunction.Account = account;
                burnFromFunction.Amount = amount;
            
            return ContractHandler.SendRequestAsync(burnFromFunction);
        }

        public virtual Task<TransactionReceipt> BurnFromRequestAndWaitForReceiptAsync(string account, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var burnFromFunction = new BurnFromFunction();
                burnFromFunction.Account = account;
                burnFromFunction.Amount = amount;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(burnFromFunction, cancellationToken);
        }

        public virtual Task<BigInteger> CapQueryAsync(CapFunction capFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<CapFunction, BigInteger>(capFunction, blockParameter);
        }

        public virtual Task<BigInteger> CapQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<CapFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> DecreaseAllowanceRequestAsync(DecreaseAllowanceFunction decreaseAllowanceFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(decreaseAllowanceFunction);
        }

        public virtual Task<TransactionReceipt> DecreaseAllowanceRequestAndWaitForReceiptAsync(DecreaseAllowanceFunction decreaseAllowanceFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(decreaseAllowanceFunction, cancellationToken);
        }

        public virtual Task<string> DecreaseAllowanceRequestAsync(string spender, BigInteger subtractedValue)
        {
            EnsureInitialized();
            var decreaseAllowanceFunction = new DecreaseAllowanceFunction();
                decreaseAllowanceFunction.Spender = spender;
                decreaseAllowanceFunction.SubtractedValue = subtractedValue;
            
            return ContractHandler.SendRequestAsync(decreaseAllowanceFunction);
        }

        public virtual Task<TransactionReceipt> DecreaseAllowanceRequestAndWaitForReceiptAsync(string spender, BigInteger subtractedValue, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var decreaseAllowanceFunction = new DecreaseAllowanceFunction();
                decreaseAllowanceFunction.Spender = spender;
                decreaseAllowanceFunction.SubtractedValue = subtractedValue;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(decreaseAllowanceFunction, cancellationToken);
        }

        public virtual Task<string> IncreaseAllowanceRequestAsync(IncreaseAllowanceFunction increaseAllowanceFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(increaseAllowanceFunction);
        }

        public virtual Task<TransactionReceipt> IncreaseAllowanceRequestAndWaitForReceiptAsync(IncreaseAllowanceFunction increaseAllowanceFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(increaseAllowanceFunction, cancellationToken);
        }

        public virtual Task<string> IncreaseAllowanceRequestAsync(string spender, BigInteger addedValue)
        {
            EnsureInitialized();
            var increaseAllowanceFunction = new IncreaseAllowanceFunction();
                increaseAllowanceFunction.Spender = spender;
                increaseAllowanceFunction.AddedValue = addedValue;
            
            return ContractHandler.SendRequestAsync(increaseAllowanceFunction);
        }

        public virtual Task<TransactionReceipt> IncreaseAllowanceRequestAndWaitForReceiptAsync(string spender, BigInteger addedValue, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var increaseAllowanceFunction = new IncreaseAllowanceFunction();
                increaseAllowanceFunction.Spender = spender;
                increaseAllowanceFunction.AddedValue = addedValue;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(increaseAllowanceFunction, cancellationToken);
        }

        public virtual Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
        }

        public virtual Task<string> NameQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
        }

        public virtual Task<string> SymbolQueryAsync(SymbolFunction symbolFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<SymbolFunction, string>(symbolFunction, blockParameter);
        }

        public virtual Task<string> SymbolQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<SymbolFunction, string>(null, blockParameter);
        }

        public virtual Task<BigInteger> TotalSupplyQueryAsync(TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(totalSupplyFunction, blockParameter);
        }

        public virtual Task<BigInteger> TotalSupplyQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(null, blockParameter);
        }

        public virtual Task<string> TransferRequestAsync(TransferFunction transferFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(transferFunction);
        }

        public virtual Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(TransferFunction transferFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFunction, cancellationToken);
        }

        public virtual Task<string> TransferRequestAsync(string to, BigInteger amount)
        {
            EnsureInitialized();
            var transferFunction = new TransferFunction();
                transferFunction.To = to;
                transferFunction.Amount = amount;
            
            return ContractHandler.SendRequestAsync(transferFunction);
        }

        public virtual Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(string to, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var transferFunction = new TransferFunction();
                transferFunction.To = to;
                transferFunction.Amount = amount;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFunction, cancellationToken);
        }

        public virtual Task<string> TransferFromRequestAsync(TransferFromFunction transferFromFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public virtual Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(TransferFromFunction transferFromFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }

        public virtual Task<string> TransferFromRequestAsync(string from, string to, BigInteger amount)
        {
            EnsureInitialized();
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.Amount = amount;
            
            return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public virtual Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.Amount = amount;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }

        public virtual Task<byte> DecimalsQueryAsync(DecimalsFunction decimalsFunction, BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<DecimalsFunction, byte>(decimalsFunction, blockParameter);
        }

        public virtual Task<byte> DecimalsQueryAsync(BlockParameter blockParameter = null)
        {
            EnsureInitialized();
            return ContractHandler.QueryAsync<DecimalsFunction, byte>(null, blockParameter);
        }

        public virtual Task<string> ActivateBeaconRequestAsync(ActivateBeaconFunction activateBeaconFunction)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(activateBeaconFunction);
        }

        public virtual Task<TransactionReceipt> ActivateBeaconRequestAndWaitForReceiptAsync(ActivateBeaconFunction activateBeaconFunction, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(activateBeaconFunction, cancellationToken);
        }

        public virtual Task<string> ActivateBeaconRequestAsync(byte[] address)
        {
            EnsureInitialized();
            var activateBeaconFunction = new ActivateBeaconFunction();
                activateBeaconFunction.Address = address;
            
            return ContractHandler.SendRequestAsync(activateBeaconFunction);
        }

        public virtual Task<TransactionReceipt> ActivateBeaconRequestAndWaitForReceiptAsync(byte[] address, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var activateBeaconFunction = new ActivateBeaconFunction();
                activateBeaconFunction.Address = address;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(activateBeaconFunction, cancellationToken);
        }

        public virtual Task<string> ActivateBeaconRequestAsync(ActivateBeacon1Function activateBeacon1Function)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAsync(activateBeacon1Function);
        }

        public virtual Task<TransactionReceipt> ActivateBeaconRequestAndWaitForReceiptAsync(ActivateBeacon1Function activateBeacon1Function, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            return ContractHandler.SendRequestAndWaitForReceiptAsync(activateBeacon1Function, cancellationToken);
        }

        public virtual Task<string> ActivateBeaconRequestAsync(byte[] address, BigInteger amount)
        {
            EnsureInitialized();
            var activateBeacon1Function = new ActivateBeacon1Function();
                activateBeacon1Function.Address = address;
                activateBeacon1Function.Amount = amount;
            
            return ContractHandler.SendRequestAsync(activateBeacon1Function);
        }

        public virtual Task<TransactionReceipt> ActivateBeaconRequestAndWaitForReceiptAsync(byte[] address, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            EnsureInitialized();
            var activateBeacon1Function = new ActivateBeacon1Function();
                activateBeacon1Function.Address = address;
                activateBeacon1Function.Amount = amount;
            
            return ContractHandler.SendRequestAndWaitForReceiptAsync(activateBeacon1Function, cancellationToken);
        }
    }
}
