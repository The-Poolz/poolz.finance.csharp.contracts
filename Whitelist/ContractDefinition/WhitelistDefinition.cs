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

namespace poolz.finance.csharp.Whitelist.ContractDefinition
{


    public partial class WhitelistDeployment : WhitelistDeploymentBase
    {
        public WhitelistDeployment() : base(BYTECODE) { }
        public WhitelistDeployment(string byteCode) : base(byteCode) { }
    }

    public class WhitelistDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public WhitelistDeploymentBase() : base(BYTECODE) { }
        public WhitelistDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class CheckFunction : CheckFunctionBase { }

    [Function("Check", "uint256")]
    public class CheckFunctionBase : FunctionMessage
    {
        [Parameter("address", "_user", 1)]
        public virtual string User { get; set; }
        [Parameter("uint256", "_id", 2)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class MaxUsersLimitFunction : MaxUsersLimitFunctionBase { }

    [Function("MaxUsersLimit", "uint256")]
    public class MaxUsersLimitFunctionBase : FunctionMessage
    {

    }

    public partial class WhiteListCostFunction : WhiteListCostFunctionBase { }

    [Function("WhiteListCost", "uint256")]
    public class WhiteListCostFunctionBase : FunctionMessage
    {

    }

    public partial class WhiteListCountFunction : WhiteListCountFunctionBase { }

    [Function("WhiteListCount", "uint256")]
    public class WhiteListCountFunctionBase : FunctionMessage
    {

    }

    public partial class WhitelistDBFunction : WhitelistDBFunctionBase { }

    [Function("WhitelistDB", "uint256")]
    public class WhitelistDBFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
    }

    public partial class WhitelistSettingsFunction : WhitelistSettingsFunctionBase { }

    [Function("WhitelistSettings", typeof(WhitelistSettingsOutputDTO))]
    public class WhitelistSettingsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class IsWhiteListReadyFunction : IsWhiteListReadyFunctionBase { }

    [Function("isWhiteListReady", "bool")]
    public class IsWhiteListReadyFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_Id", 1)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class SetMaxUsersLimitFunction : SetMaxUsersLimitFunctionBase { }

    [Function("setMaxUsersLimit")]
    public class SetMaxUsersLimitFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_limit", 1)]
        public virtual BigInteger Limit { get; set; }
    }

    public partial class WithdrawETHFeeFunction : WithdrawETHFeeFunctionBase { }

    [Function("WithdrawETHFee")]
    public class WithdrawETHFeeFunctionBase : FunctionMessage
    {
        [Parameter("address", "_to", 1)]
        public virtual string To { get; set; }
    }

    public partial class SetWhiteListCostFunction : SetWhiteListCostFunctionBase { }

    [Function("setWhiteListCost")]
    public class SetWhiteListCostFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_newCost", 1)]
        public virtual BigInteger NewCost { get; set; }
    }

    public partial class CreateManualWhiteListFunction : CreateManualWhiteListFunctionBase { }

    [Function("CreateManualWhiteList", "uint256")]
    public class CreateManualWhiteListFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_ChangeUntil", 1)]
        public virtual BigInteger ChangeUntil { get; set; }
        [Parameter("address", "_Contract", 2)]
        public virtual string Contract { get; set; }
    }

    public partial class ChangeCreatorFunction : ChangeCreatorFunctionBase { }

    [Function("ChangeCreator")]
    public class ChangeCreatorFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_Id", 1)]
        public virtual BigInteger Id { get; set; }
        [Parameter("address", "_NewCreator", 2)]
        public virtual string NewCreator { get; set; }
    }

    public partial class ChangeContractFunction : ChangeContractFunctionBase { }

    [Function("ChangeContract")]
    public class ChangeContractFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_Id", 1)]
        public virtual BigInteger Id { get; set; }
        [Parameter("address", "_NewContract", 2)]
        public virtual string NewContract { get; set; }
    }

    public partial class AddAddressFunction : AddAddressFunctionBase { }

    [Function("AddAddress")]
    public class AddAddressFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_Id", 1)]
        public virtual BigInteger Id { get; set; }
        [Parameter("address[]", "_Users", 2)]
        public virtual List<string> Users { get; set; }
        [Parameter("uint256[]", "_Amount", 3)]
        public virtual List<BigInteger> Amount { get; set; }
    }

    public partial class RemoveAddressFunction : RemoveAddressFunctionBase { }

    [Function("RemoveAddress")]
    public class RemoveAddressFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_Id", 1)]
        public virtual BigInteger Id { get; set; }
        [Parameter("address[]", "_Users", 2)]
        public virtual List<string> Users { get; set; }
    }

    public partial class RegisterFunction : RegisterFunctionBase { }

    [Function("Register")]
    public class RegisterFunctionBase : FunctionMessage
    {
        [Parameter("address", "_Subject", 1)]
        public virtual string Subject { get; set; }
        [Parameter("uint256", "_Id", 2)]
        public virtual BigInteger Id { get; set; }
        [Parameter("uint256", "_Amount", 3)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class LastRoundRegisterFunction : LastRoundRegisterFunctionBase { }

    [Function("LastRoundRegister")]
    public class LastRoundRegisterFunctionBase : FunctionMessage
    {
        [Parameter("address", "_Subject", 1)]
        public virtual string Subject { get; set; }
        [Parameter("uint256", "_Id", 2)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class NewWhiteListEventDTO : NewWhiteListEventDTOBase { }

    [Event("NewWhiteList")]
    public class NewWhiteListEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "_WhiteListCount", 1, false )]
        public virtual BigInteger WhiteListCount { get; set; }
        [Parameter("address", "_creator", 2, false )]
        public virtual string Creator { get; set; }
        [Parameter("address", "_contract", 3, false )]
        public virtual string Contract { get; set; }
        [Parameter("uint256", "_changeUntil", 4, false )]
        public virtual BigInteger ChangeUntil { get; set; }
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

    public partial class CheckOutputDTO : CheckOutputDTOBase { }

    [FunctionOutput]
    public class CheckOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class MaxUsersLimitOutputDTO : MaxUsersLimitOutputDTOBase { }

    [FunctionOutput]
    public class MaxUsersLimitOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class WhiteListCostOutputDTO : WhiteListCostOutputDTOBase { }

    [FunctionOutput]
    public class WhiteListCostOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class WhiteListCountOutputDTO : WhiteListCountOutputDTOBase { }

    [FunctionOutput]
    public class WhiteListCountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class WhitelistDBOutputDTO : WhitelistDBOutputDTOBase { }

    [FunctionOutput]
    public class WhitelistDBOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class WhitelistSettingsOutputDTO : WhitelistSettingsOutputDTOBase { }

    [FunctionOutput]
    public class WhitelistSettingsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "Creator", 1)]
        public virtual string Creator { get; set; }
        [Parameter("uint256", "ChangeUntil", 2)]
        public virtual BigInteger ChangeUntil { get; set; }
        [Parameter("address", "Contract", 3)]
        public virtual string Contract { get; set; }
        [Parameter("bool", "isReady", 4)]
        public virtual bool IsReady { get; set; }
    }

    public partial class IsWhiteListReadyOutputDTO : IsWhiteListReadyOutputDTOBase { }

    [FunctionOutput]
    public class IsWhiteListReadyOutputDTOBase : IFunctionOutputDTO 
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
























}
