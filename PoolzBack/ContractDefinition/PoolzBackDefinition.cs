using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace poolz.finance.csharp.PoolzBack.ContractDefinition
{


    public partial class PoolzBackDeployment : PoolzBackDeploymentBase
    {
        public PoolzBackDeployment() : base(BYTECODE) { }
        public PoolzBackDeployment(string byteCode) : base(byteCode) { }
    }

    public class PoolzBackDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public PoolzBackDeploymentBase() : base(BYTECODE) { }
        public PoolzBackDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class BenefitAddressFunction : BenefitAddressFunctionBase { }

    [Function("Benefit_Address", "address")]
    public class BenefitAddressFunctionBase : FunctionMessage
    {

    }

    public partial class CreatePoolFunction : CreatePoolFunctionBase { }

    [Function("CreatePool")]
    public class CreatePoolFunctionBase : FunctionMessage
    {
        [Parameter("address", "_Token", 1)]
        public virtual string Token { get; set; }
        [Parameter("uint256", "_FinishTime", 2)]
        public virtual BigInteger FinishTime { get; set; }
        [Parameter("uint256", "_Rate", 3)]
        public virtual BigInteger Rate { get; set; }
        [Parameter("uint256", "_POZRate", 4)]
        public virtual BigInteger POZRate { get; set; }
        [Parameter("uint256", "_StartAmount", 5)]
        public virtual BigInteger StartAmount { get; set; }
        [Parameter("uint64", "_LockedUntil", 6)]
        public virtual ulong LockedUntil { get; set; }
        [Parameter("address", "_MainCoin", 7)]
        public virtual string MainCoin { get; set; }
        [Parameter("bool", "_Is21Decimal", 8)]
        public virtual bool Is21Decimal { get; set; }
        [Parameter("uint256", "_Now", 9)]
        public virtual BigInteger Now { get; set; }
        [Parameter("uint256", "_WhiteListId", 10)]
        public virtual BigInteger WhiteListId { get; set; }
    }

    public partial class FeeFunction : FeeFunctionBase { }

    [Function("Fee", "uint256")]
    public class FeeFunctionBase : FunctionMessage
    {

    }

    public partial class GetInvestmentDataFunction : GetInvestmentDataFunctionBase { }

    [Function("GetInvestmentData", typeof(GetInvestmentDataOutputDTO))]
    public class GetInvestmentDataFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_id", 1)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class GetMyInvestmentIdsFunction : GetMyInvestmentIdsFunctionBase { }

    [Function("GetMyInvestmentIds", "uint256[]")]
    public class GetMyInvestmentIdsFunctionBase : FunctionMessage
    {

    }

    public partial class GetMyPoolsIdFunction : GetMyPoolsIdFunctionBase { }

    [Function("GetMyPoolsId", "uint256[]")]
    public class GetMyPoolsIdFunctionBase : FunctionMessage
    {

    }

    public partial class GetPoolBaseDataFunction : GetPoolBaseDataFunctionBase { }

    [Function("GetPoolBaseData", typeof(GetPoolBaseDataOutputDTO))]
    public class GetPoolBaseDataFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_Id", 1)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class GetPoolExtraDataFunction : GetPoolExtraDataFunctionBase { }

    [Function("GetPoolExtraData", typeof(GetPoolExtraDataOutputDTO))]
    public class GetPoolExtraDataFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_Id", 1)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class GetPoolMoreDataFunction : GetPoolMoreDataFunctionBase { }

    [Function("GetPoolMoreData", typeof(GetPoolMoreDataOutputDTO))]
    public class GetPoolMoreDataFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_Id", 1)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class GetPoolStatusFunction : GetPoolStatusFunctionBase { }

    [Function("GetPoolStatus", "uint8")]
    public class GetPoolStatusFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_id", 1)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class GovernerContractFunction : GovernerContractFunctionBase { }

    [Function("GovernerContract", "address")]
    public class GovernerContractFunctionBase : FunctionMessage
    {

    }

    public partial class InvestERC20Function : InvestERC20FunctionBase { }

    [Function("InvestERC20")]
    public class InvestERC20FunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_PoolId", 1)]
        public virtual BigInteger PoolId { get; set; }
        [Parameter("uint256", "_Amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class InvestETHFunction : InvestETHFunctionBase { }

    [Function("InvestETH")]
    public class InvestETHFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_PoolId", 1)]
        public virtual BigInteger PoolId { get; set; }
    }

    public partial class IsERC20MaincoinFunction : IsERC20MaincoinFunctionBase { }

    [Function("IsERC20Maincoin", "bool")]
    public class IsERC20MaincoinFunctionBase : FunctionMessage
    {
        [Parameter("address", "_address", 1)]
        public virtual string Address { get; set; }
    }

    public partial class IsPaybleFunction : IsPaybleFunctionBase { }

    [Function("IsPayble", "bool")]
    public class IsPaybleFunctionBase : FunctionMessage
    {

    }

    public partial class IsReadyWithdrawInvestmentFunction : IsReadyWithdrawInvestmentFunctionBase { }

    [Function("IsReadyWithdrawInvestment", "bool")]
    public class IsReadyWithdrawInvestmentFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_id", 1)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class IsReadyWithdrawLeftOversFunction : IsReadyWithdrawLeftOversFunctionBase { }

    [Function("IsReadyWithdrawLeftOvers", "bool")]
    public class IsReadyWithdrawLeftOversFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_PoolId", 1)]
        public virtual BigInteger PoolId { get; set; }
    }

    public partial class IsTokenFilterOnFunction : IsTokenFilterOnFunctionBase { }

    [Function("IsTokenFilterOn", "bool")]
    public class IsTokenFilterOnFunctionBase : FunctionMessage
    {

    }

    public partial class IsValidTokenFunction : IsValidTokenFunctionBase { }

    [Function("IsValidToken", "bool")]
    public class IsValidTokenFunctionBase : FunctionMessage
    {
        [Parameter("address", "_address", 1)]
        public virtual string Address { get; set; }
    }

    public partial class MCWhitelistIdFunction : MCWhitelistIdFunctionBase { }

    [Function("MCWhitelistId", "uint256")]
    public class MCWhitelistIdFunctionBase : FunctionMessage
    {

    }

    public partial class MaxDurationFunction : MaxDurationFunctionBase { }

    [Function("MaxDuration", "uint256")]
    public class MaxDurationFunctionBase : FunctionMessage
    {

    }

    public partial class MaxETHInvestFunction : MaxETHInvestFunctionBase { }

    [Function("MaxETHInvest", "uint256")]
    public class MaxETHInvestFunctionBase : FunctionMessage
    {

    }

    public partial class MinDurationFunction : MinDurationFunctionBase { }

    [Function("MinDuration", "uint256")]
    public class MinDurationFunctionBase : FunctionMessage
    {

    }

    public partial class MinETHInvestFunction : MinETHInvestFunctionBase { }

    [Function("MinETHInvest", "uint256")]
    public class MinETHInvestFunctionBase : FunctionMessage
    {

    }

    public partial class PoolPriceFunction : PoolPriceFunctionBase { }

    [Function("PoolPrice", "uint256")]
    public class PoolPriceFunctionBase : FunctionMessage
    {

    }

    public partial class PozFeeFunction : PozFeeFunctionBase { }

    [Function("PozFee", "uint256")]
    public class PozFeeFunctionBase : FunctionMessage
    {

    }

    public partial class PozTimerFunction : PozTimerFunctionBase { }

    [Function("PozTimer", "uint256")]
    public class PozTimerFunctionBase : FunctionMessage
    {

    }

    public partial class SetbenefitAddressFunction : SetbenefitAddressFunctionBase { }

    [Function("SetBenefit_Address")]
    public class SetbenefitAddressFunctionBase : FunctionMessage
    {
        [Parameter("address", "_benefitAddress", 1)]
        public virtual string BenefitAddress { get; set; }
    }

    public partial class SetFeeFunction : SetFeeFunctionBase { }

    [Function("SetFee")]
    public class SetFeeFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_fee", 1)]
        public virtual BigInteger Fee { get; set; }
    }

    public partial class SetMinMaxDurationFunction : SetMinMaxDurationFunctionBase { }

    [Function("SetMinMaxDuration")]
    public class SetMinMaxDurationFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_minDuration", 1)]
        public virtual BigInteger MinDuration { get; set; }
        [Parameter("uint256", "_maxDuration", 2)]
        public virtual BigInteger MaxDuration { get; set; }
    }

    public partial class SetMinMaxETHInvestFunction : SetMinMaxETHInvestFunctionBase { }

    [Function("SetMinMaxETHInvest")]
    public class SetMinMaxETHInvestFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_MinETHInvest", 1)]
        public virtual BigInteger MinETHInvest { get; set; }
        [Parameter("uint256", "_MaxETHInvest", 2)]
        public virtual BigInteger MaxETHInvest { get; set; }
    }

    public partial class SetPOZFeeFunction : SetPOZFeeFunctionBase { }

    [Function("SetPOZFee")]
    public class SetPOZFeeFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_fee", 1)]
        public virtual BigInteger Fee { get; set; }
    }

    public partial class SetPoolPriceFunction : SetPoolPriceFunctionBase { }

    [Function("SetPoolPrice")]
    public class SetPoolPriceFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_PoolPrice", 1)]
        public virtual BigInteger PoolPrice { get; set; }
    }

    public partial class SetPozTimerFunction : SetPozTimerFunctionBase { }

    [Function("SetPozTimer")]
    public class SetPozTimerFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_pozTimer", 1)]
        public virtual BigInteger PozTimer { get; set; }
    }

    public partial class SetwhitelistAddressFunction : SetwhitelistAddressFunctionBase { }

    [Function("SetWhiteList_Address")]
    public class SetwhitelistAddressFunctionBase : FunctionMessage
    {
        [Parameter("address", "_WhiteList_Address", 1)]
        public virtual string WhitelistAddress { get; set; }
    }

    public partial class SwapTokenFilterFunction : SwapTokenFilterFunctionBase { }

    [Function("SwapTokenFilter")]
    public class SwapTokenFilterFunctionBase : FunctionMessage
    {

    }

    public partial class SwitchIsPaybleFunction : SwitchIsPaybleFunctionBase { }

    [Function("SwitchIsPayble")]
    public class SwitchIsPaybleFunctionBase : FunctionMessage
    {

    }

    public partial class TokenWhitelistIdFunction : TokenWhitelistIdFunctionBase { }

    [Function("TokenWhitelistId", "uint256")]
    public class TokenWhitelistIdFunctionBase : FunctionMessage
    {

    }

    public partial class WhitelistAddressFunction : WhitelistAddressFunctionBase { }

    [Function("WhiteList_Address", "address")]
    public class WhitelistAddressFunctionBase : FunctionMessage
    {

    }

    public partial class WithdrawInvestmentFunction : WithdrawInvestmentFunctionBase { }

    [Function("WithdrawInvestment", "bool")]
    public class WithdrawInvestmentFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_id", 1)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class WithdrawLeftOversFunction : WithdrawLeftOversFunctionBase { }

    [Function("WithdrawLeftOvers", "bool")]
    public class WithdrawLeftOversFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_PoolId", 1)]
        public virtual BigInteger PoolId { get; set; }
    }

    public partial class GetTotalInvestorFunction : GetTotalInvestorFunctionBase { }

    [Function("getTotalInvestor", "uint256")]
    public class GetTotalInvestorFunctionBase : FunctionMessage
    {

    }

    public partial class IsPoolLockedFunction : IsPoolLockedFunctionBase { }

    [Function("isPoolLocked", "bool")]
    public class IsPoolLockedFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_id", 1)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class PausedFunction : PausedFunctionBase { }

    [Function("paused", "bool")]
    public class PausedFunctionBase : FunctionMessage
    {

    }

    public partial class PoolsCountFunction : PoolsCountFunctionBase { }

    [Function("poolsCount", "uint256")]
    public class PoolsCountFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class SetGovernerContractFunction : SetGovernerContractFunctionBase { }

    [Function("setGovernerContract")]
    public class SetGovernerContractFunctionBase : FunctionMessage
    {
        [Parameter("address", "_address", 1)]
        public virtual string Address { get; set; }
    }

    public partial class SetMCWhitelistIdFunction : SetMCWhitelistIdFunctionBase { }

    [Function("setMCWhitelistId")]
    public class SetMCWhitelistIdFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_whiteListId", 1)]
        public virtual BigInteger WhiteListId { get; set; }
    }

    public partial class SetTokenWhitelistIdFunction : SetTokenWhitelistIdFunctionBase { }

    [Function("setTokenWhitelistId")]
    public class SetTokenWhitelistIdFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_whiteListId", 1)]
        public virtual BigInteger WhiteListId { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class WithdrawETHFeeFunction : WithdrawETHFeeFunctionBase { }

    [Function("WithdrawETHFee")]
    public class WithdrawETHFeeFunctionBase : FunctionMessage
    {
        [Parameter("address", "_to", 1)]
        public virtual string To { get; set; }
    }

    public partial class WithdrawERC20FeeFunction : WithdrawERC20FeeFunctionBase { }

    [Function("WithdrawERC20Fee")]
    public class WithdrawERC20FeeFunctionBase : FunctionMessage
    {
        [Parameter("address", "_Token", 1)]
        public virtual string Token { get; set; }
        [Parameter("address", "_to", 2)]
        public virtual string To { get; set; }
    }

    public partial class FinishPoolEventDTO : FinishPoolEventDTOBase { }

    [Event("FinishPool")]
    public class FinishPoolEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "id", 1, false )]
        public virtual BigInteger Id { get; set; }
    }

    public partial class NewInvestorEventEventDTO : NewInvestorEventEventDTOBase { }

    [Event("NewInvestorEvent")]
    public class NewInvestorEventEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "Investor_ID", 1, false )]
        public virtual BigInteger InvestorId { get; set; }
        [Parameter("address", "Investor_Address", 2, false )]
        public virtual string InvestorAddress { get; set; }
    }

    public partial class NewPoolEventDTO : NewPoolEventDTOBase { }

    [Event("NewPool")]
    public class NewPoolEventDTOBase : IEventDTO
    {
        [Parameter("address", "token", 1, false )]
        public virtual string Token { get; set; }
        [Parameter("uint256", "id", 2, false )]
        public virtual BigInteger Id { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class PausedEventDTO : PausedEventDTOBase { }

    [Event("Paused")]
    public class PausedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, false )]
        public virtual string Account { get; set; }
    }

    public partial class PoolUpdateEventDTO : PoolUpdateEventDTOBase { }

    [Event("PoolUpdate")]
    public class PoolUpdateEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "id", 1, false )]
        public virtual BigInteger Id { get; set; }
    }

    public partial class TransferInEventDTO : TransferInEventDTOBase { }

    [Event("TransferIn")]
    public class TransferInEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "Amount", 1, false )]
        public virtual BigInteger Amount { get; set; }
        [Parameter("address", "From", 2, false )]
        public virtual string From { get; set; }
        [Parameter("address", "Token", 3, false )]
        public virtual string Token { get; set; }
    }

    public partial class TransferInETHEventDTO : TransferInETHEventDTOBase { }

    [Event("TransferInETH")]
    public class TransferInETHEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "Amount", 1, false )]
        public virtual BigInteger Amount { get; set; }
        [Parameter("address", "From", 2, false )]
        public virtual string From { get; set; }
    }

    public partial class TransferOutEventDTO : TransferOutEventDTOBase { }

    [Event("TransferOut")]
    public class TransferOutEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "Amount", 1, false )]
        public virtual BigInteger Amount { get; set; }
        [Parameter("address", "To", 2, false )]
        public virtual string To { get; set; }
        [Parameter("address", "Token", 3, false )]
        public virtual string Token { get; set; }
    }

    public partial class TransferOutETHEventDTO : TransferOutETHEventDTOBase { }

    [Event("TransferOutETH")]
    public class TransferOutETHEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "Amount", 1, false )]
        public virtual BigInteger Amount { get; set; }
        [Parameter("address", "To", 2, false )]
        public virtual string To { get; set; }
    }

    public partial class UnpausedEventDTO : UnpausedEventDTOBase { }

    [Event("Unpaused")]
    public class UnpausedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, false )]
        public virtual string Account { get; set; }
    }

    public partial class BenefitAddressOutputDTO : BenefitAddressOutputDTOBase { }

    [FunctionOutput]
    public class BenefitAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class FeeOutputDTO : FeeOutputDTOBase { }

    [FunctionOutput]
    public class FeeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetInvestmentDataOutputDTO : GetInvestmentDataOutputDTOBase { }

    [FunctionOutput]
    public class GetInvestmentDataOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
        [Parameter("uint256", "", 3)]
        public virtual BigInteger ReturnValue3 { get; set; }
        [Parameter("uint256", "", 4)]
        public virtual BigInteger ReturnValue4 { get; set; }
        [Parameter("uint256", "", 5)]
        public virtual BigInteger ReturnValue5 { get; set; }
    }

    public partial class GetMyInvestmentIdsOutputDTO : GetMyInvestmentIdsOutputDTOBase { }

    [FunctionOutput]
    public class GetMyInvestmentIdsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "", 1)]
        public virtual List<BigInteger> ReturnValue1 { get; set; }
    }

    public partial class GetMyPoolsIdOutputDTO : GetMyPoolsIdOutputDTOBase { }

    [FunctionOutput]
    public class GetMyPoolsIdOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "", 1)]
        public virtual List<BigInteger> ReturnValue1 { get; set; }
    }

    public partial class GetPoolBaseDataOutputDTO : GetPoolBaseDataOutputDTOBase { }

    [FunctionOutput]
    public class GetPoolBaseDataOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
        [Parameter("uint256", "", 3)]
        public virtual BigInteger ReturnValue3 { get; set; }
        [Parameter("uint256", "", 4)]
        public virtual BigInteger ReturnValue4 { get; set; }
        [Parameter("uint256", "", 5)]
        public virtual BigInteger ReturnValue5 { get; set; }
        [Parameter("uint256", "", 6)]
        public virtual BigInteger ReturnValue6 { get; set; }
    }

    public partial class GetPoolExtraDataOutputDTO : GetPoolExtraDataOutputDTOBase { }

    [FunctionOutput]
    public class GetPoolExtraDataOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
        [Parameter("address", "", 3)]
        public virtual string ReturnValue3 { get; set; }
    }

    public partial class GetPoolMoreDataOutputDTO : GetPoolMoreDataOutputDTOBase { }

    [FunctionOutput]
    public class GetPoolMoreDataOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint64", "", 1)]
        public virtual ulong ReturnValue1 { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
        [Parameter("uint256", "", 3)]
        public virtual BigInteger ReturnValue3 { get; set; }
        [Parameter("uint256", "", 4)]
        public virtual BigInteger ReturnValue4 { get; set; }
        [Parameter("uint256", "", 5)]
        public virtual BigInteger ReturnValue5 { get; set; }
        [Parameter("bool", "", 6)]
        public virtual bool ReturnValue6 { get; set; }
    }

    public partial class GetPoolStatusOutputDTO : GetPoolStatusOutputDTOBase { }

    [FunctionOutput]
    public class GetPoolStatusOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
    }

    public partial class GovernerContractOutputDTO : GovernerContractOutputDTOBase { }

    [FunctionOutput]
    public class GovernerContractOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }





    public partial class IsERC20MaincoinOutputDTO : IsERC20MaincoinOutputDTOBase { }

    [FunctionOutput]
    public class IsERC20MaincoinOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsPaybleOutputDTO : IsPaybleOutputDTOBase { }

    [FunctionOutput]
    public class IsPaybleOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsReadyWithdrawInvestmentOutputDTO : IsReadyWithdrawInvestmentOutputDTOBase { }

    [FunctionOutput]
    public class IsReadyWithdrawInvestmentOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsReadyWithdrawLeftOversOutputDTO : IsReadyWithdrawLeftOversOutputDTOBase { }

    [FunctionOutput]
    public class IsReadyWithdrawLeftOversOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsTokenFilterOnOutputDTO : IsTokenFilterOnOutputDTOBase { }

    [FunctionOutput]
    public class IsTokenFilterOnOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsValidTokenOutputDTO : IsValidTokenOutputDTOBase { }

    [FunctionOutput]
    public class IsValidTokenOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class MCWhitelistIdOutputDTO : MCWhitelistIdOutputDTOBase { }

    [FunctionOutput]
    public class MCWhitelistIdOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class MaxDurationOutputDTO : MaxDurationOutputDTOBase { }

    [FunctionOutput]
    public class MaxDurationOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class MaxETHInvestOutputDTO : MaxETHInvestOutputDTOBase { }

    [FunctionOutput]
    public class MaxETHInvestOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class MinDurationOutputDTO : MinDurationOutputDTOBase { }

    [FunctionOutput]
    public class MinDurationOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class MinETHInvestOutputDTO : MinETHInvestOutputDTOBase { }

    [FunctionOutput]
    public class MinETHInvestOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class PoolPriceOutputDTO : PoolPriceOutputDTOBase { }

    [FunctionOutput]
    public class PoolPriceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class PozFeeOutputDTO : PozFeeOutputDTOBase { }

    [FunctionOutput]
    public class PozFeeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class PozTimerOutputDTO : PozTimerOutputDTOBase { }

    [FunctionOutput]
    public class PozTimerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }





















    public partial class TokenWhitelistIdOutputDTO : TokenWhitelistIdOutputDTOBase { }

    [FunctionOutput]
    public class TokenWhitelistIdOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class WhitelistAddressOutputDTO : WhitelistAddressOutputDTOBase { }

    [FunctionOutput]
    public class WhitelistAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }





    public partial class GetTotalInvestorOutputDTO : GetTotalInvestorOutputDTOBase { }

    [FunctionOutput]
    public class GetTotalInvestorOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class IsPoolLockedOutputDTO : IsPoolLockedOutputDTOBase { }

    [FunctionOutput]
    public class IsPoolLockedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PausedOutputDTO : PausedOutputDTOBase { }

    [FunctionOutput]
    public class PausedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class PoolsCountOutputDTO : PoolsCountOutputDTOBase { }

    [FunctionOutput]
    public class PoolsCountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }














}
