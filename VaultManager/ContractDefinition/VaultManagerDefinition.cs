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

namespace poolz.finance.csharp.VaultManager.ContractDefinition
{


    public partial class VaultManagerDeployment : VaultManagerDeploymentBase
    {
        public VaultManagerDeployment() : base(BYTECODE) { }
        public VaultManagerDeployment(string byteCode) : base(byteCode) { }
    }

    public class VaultManagerDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public VaultManagerDeploymentBase() : base(BYTECODE) { }
        public VaultManagerDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class CreateNewVault3Function : CreateNewVault3FunctionBase { }

    [Function("createNewVault", "uint256")]
    public class CreateNewVault3FunctionBase : FunctionMessage
    {
        [Parameter("address", "_tokenAddress", 1)]
        public virtual string TokenAddress { get; set; }
        [Parameter("uint256", "_tradeStartTime", 2)]
        public virtual BigInteger TradeStartTime { get; set; }
        [Parameter("address", "_royaltyReceiver", 3)]
        public virtual string RoyaltyReceiver { get; set; }
        [Parameter("uint96", "_feeNumerator", 4)]
        public virtual BigInteger FeeNumerator { get; set; }
    }

    public partial class CreateNewVault2Function : CreateNewVault2FunctionBase { }

    [Function("createNewVault", "uint256")]
    public class CreateNewVault2FunctionBase : FunctionMessage
    {
        [Parameter("address", "_tokenAddress", 1)]
        public virtual string TokenAddress { get; set; }
        [Parameter("address", "_royaltyReceiver", 2)]
        public virtual string RoyaltyReceiver { get; set; }
        [Parameter("uint96", "_feeNumerator", 3)]
        public virtual BigInteger FeeNumerator { get; set; }
    }

    public partial class CreateNewVault1Function : CreateNewVault1FunctionBase { }

    [Function("createNewVault", "uint256")]
    public class CreateNewVault1FunctionBase : FunctionMessage
    {
        [Parameter("address", "_tokenAddress", 1)]
        public virtual string TokenAddress { get; set; }
        [Parameter("uint256", "_tradeStartTime", 2)]
        public virtual BigInteger TradeStartTime { get; set; }
    }

    public partial class CreateNewVaultFunction : CreateNewVaultFunctionBase { }

    [Function("createNewVault", "uint256")]
    public class CreateNewVaultFunctionBase : FunctionMessage
    {
        [Parameter("address", "_tokenAddress", 1)]
        public virtual string TokenAddress { get; set; }
    }

    public partial class DepositByTokenFunction : DepositByTokenFunctionBase { }

    [Function("depositByToken", "uint256")]
    public class DepositByTokenFunctionBase : FunctionMessage
    {
        [Parameter("address", "_tokenAddress", 1)]
        public virtual string TokenAddress { get; set; }
        [Parameter("uint256", "_amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class FirewallAdminFunction : FirewallAdminFunctionBase { }

    [Function("firewallAdmin", "address")]
    public class FirewallAdminFunctionBase : FunctionMessage
    {

    }

    public partial class GetAllVaultBalanceByTokenFunction : GetAllVaultBalanceByTokenFunctionBase { }

    [Function("getAllVaultBalanceByToken", "uint256")]
    public class GetAllVaultBalanceByTokenFunctionBase : FunctionMessage
    {
        [Parameter("address", "_tokenAddress", 1)]
        public virtual string TokenAddress { get; set; }
        [Parameter("uint256", "from", 2)]
        public virtual BigInteger From { get; set; }
        [Parameter("uint256", "count", 3)]
        public virtual BigInteger Count { get; set; }
    }

    public partial class GetCurrentVaultBalanceByTokenFunction : GetCurrentVaultBalanceByTokenFunctionBase { }

    [Function("getCurrentVaultBalanceByToken", "uint256")]
    public class GetCurrentVaultBalanceByTokenFunctionBase : FunctionMessage
    {
        [Parameter("address", "_tokenAddress", 1)]
        public virtual string TokenAddress { get; set; }
    }

    public partial class GetCurrentVaultIdByTokenFunction : GetCurrentVaultIdByTokenFunctionBase { }

    [Function("getCurrentVaultIdByToken", "uint256")]
    public class GetCurrentVaultIdByTokenFunctionBase : FunctionMessage
    {
        [Parameter("address", "_tokenAddress", 1)]
        public virtual string TokenAddress { get; set; }
    }

    public partial class GetTotalVaultsByTokenFunction : GetTotalVaultsByTokenFunctionBase { }

    [Function("getTotalVaultsByToken", "uint256")]
    public class GetTotalVaultsByTokenFunctionBase : FunctionMessage
    {
        [Parameter("address", "_tokenAddress", 1)]
        public virtual string TokenAddress { get; set; }
    }

    public partial class GetVaultBalanceByVaultIdFunction : GetVaultBalanceByVaultIdFunctionBase { }

    [Function("getVaultBalanceByVaultId", "uint256")]
    public class GetVaultBalanceByVaultIdFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_vaultId", 1)]
        public virtual BigInteger VaultId { get; set; }
    }

    public partial class IsDepositActiveForVaultIdFunction : IsDepositActiveForVaultIdFunctionBase { }

    [Function("isDepositActiveForVaultId", "bool")]
    public class IsDepositActiveForVaultIdFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class IsWithdrawalActiveForVaultIdFunction : IsWithdrawalActiveForVaultIdFunctionBase { }

    [Function("isWithdrawalActiveForVaultId", "bool")]
    public class IsWithdrawalActiveForVaultIdFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class NoncesFunction : NoncesFunctionBase { }

    [Function("nonces", "uint256")]
    public class NoncesFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
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

    public partial class RoyaltyInfoFunction : RoyaltyInfoFunctionBase { }

    [Function("royaltyInfo", typeof(RoyaltyInfoOutputDTO))]
    public class RoyaltyInfoFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "salePrice", 2)]
        public virtual BigInteger SalePrice { get; set; }
    }

    public partial class SafeDepositFunction : SafeDepositFunctionBase { }

    [Function("safeDeposit", "uint256")]
    public class SafeDepositFunctionBase : FunctionMessage
    {
        [Parameter("address", "_tokenAddress", 1)]
        public virtual string TokenAddress { get; set; }
        [Parameter("uint256", "_amount", 2)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("address", "_from", 3)]
        public virtual string From { get; set; }
        [Parameter("bytes", "_signature", 4)]
        public virtual byte[] Signature { get; set; }
    }

    public partial class SetActiveStatusForVaultIdFunction : SetActiveStatusForVaultIdFunctionBase { }

    [Function("setActiveStatusForVaultId")]
    public class SetActiveStatusForVaultIdFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_vaultId", 1)]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("bool", "_depositStatus", 2)]
        public virtual bool DepositStatus { get; set; }
        [Parameter("bool", "_withdrawStatus", 3)]
        public virtual bool WithdrawStatus { get; set; }
    }

    public partial class SetFirewallFunction : SetFirewallFunctionBase { }

    [Function("setFirewall")]
    public class SetFirewallFunctionBase : FunctionMessage
    {
        [Parameter("address", "_firewall", 1)]
        public virtual string Firewall { get; set; }
    }

    public partial class SetFirewallAdminFunction : SetFirewallAdminFunctionBase { }

    [Function("setFirewallAdmin")]
    public class SetFirewallAdminFunctionBase : FunctionMessage
    {
        [Parameter("address", "_firewallAdmin", 1)]
        public virtual string FirewallAdmin { get; set; }
    }

    public partial class SetTradeStartTimeFunction : SetTradeStartTimeFunctionBase { }

    [Function("setTradeStartTime")]
    public class SetTradeStartTimeFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_vaultId", 1)]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("uint256", "_tradeStartTime", 2)]
        public virtual BigInteger TradeStartTime { get; set; }
    }

    public partial class SetTrusteeFunction : SetTrusteeFunctionBase { }

    [Function("setTrustee")]
    public class SetTrusteeFunctionBase : FunctionMessage
    {
        [Parameter("address", "_address", 1)]
        public virtual string Address { get; set; }
    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class TokenToVaultIdsFunction : TokenToVaultIdsFunctionBase { }

    [Function("tokenToVaultIds", "uint256")]
    public class TokenToVaultIdsFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
    }

    public partial class TotalVaultsFunction : TotalVaultsFunctionBase { }

    [Function("totalVaults", "uint256")]
    public class TotalVaultsFunctionBase : FunctionMessage
    {

    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class TrusteeFunction : TrusteeFunctionBase { }

    [Function("trustee", "address")]
    public class TrusteeFunctionBase : FunctionMessage
    {

    }

    public partial class UpdateTrusteeFunction : UpdateTrusteeFunctionBase { }

    [Function("updateTrustee")]
    public class UpdateTrusteeFunctionBase : FunctionMessage
    {
        [Parameter("address", "_address", 1)]
        public virtual string Address { get; set; }
    }

    public partial class VaultIdToTokenAddressFunction : VaultIdToTokenAddressFunctionBase { }

    [Function("vaultIdToTokenAddress", "address")]
    public class VaultIdToTokenAddressFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_vaultId", 1)]
        public virtual BigInteger VaultId { get; set; }
    }

    public partial class VaultIdToTradeStartTimeFunction : VaultIdToTradeStartTimeFunctionBase { }

    [Function("vaultIdToTradeStartTime", "uint256")]
    public class VaultIdToTradeStartTimeFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class VaultIdToVaultFunction : VaultIdToVaultFunctionBase { }

    [Function("vaultIdToVault", "address")]
    public class VaultIdToVaultFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class WithdrawByVaultIdFunction : WithdrawByVaultIdFunctionBase { }

    [Function("withdrawByVaultId")]
    public class WithdrawByVaultIdFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_vaultId", 1)]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("address", "_to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_amount", 3)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class DepositedEventDTO : DepositedEventDTOBase { }

    [Event("Deposited")]
    public class DepositedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "vaultId", 1, true )]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("address", "tokenAddress", 2, true )]
        public virtual string TokenAddress { get; set; }
        [Parameter("uint256", "amount", 3, false )]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class NewVaultCreatedEventDTO : NewVaultCreatedEventDTOBase { }

    [Event("NewVaultCreated")]
    public class NewVaultCreatedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "vaultId", 1, true )]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("address", "tokenAddress", 2, true )]
        public virtual string TokenAddress { get; set; }
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

    public partial class VaultDeletedEventDTO : VaultDeletedEventDTOBase { }

    [Event("VaultDeleted")]
    public class VaultDeletedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "vaultId", 1, true )]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("address", "tokenAddress", 2, true )]
        public virtual string TokenAddress { get; set; }
    }

    public partial class VaultRoyaltySetEventDTO : VaultRoyaltySetEventDTOBase { }

    [Event("VaultRoyaltySet")]
    public class VaultRoyaltySetEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "vaultId", 1, false )]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("address", "tokenAddress", 2, true )]
        public virtual string TokenAddress { get; set; }
        [Parameter("address", "receiver", 3, true )]
        public virtual string Receiver { get; set; }
        [Parameter("uint96", "feeNumerator", 4, true )]
        public virtual BigInteger FeeNumerator { get; set; }
    }

    public partial class VaultStatusUpdateEventDTO : VaultStatusUpdateEventDTOBase { }

    [Event("VaultStatusUpdate")]
    public class VaultStatusUpdateEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "vaultId", 1, true )]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("bool", "depositStatus", 2, true )]
        public virtual bool DepositStatus { get; set; }
        [Parameter("bool", "withdrawStatus", 3, true )]
        public virtual bool WithdrawStatus { get; set; }
    }

    public partial class WithdrawnEventDTO : WithdrawnEventDTOBase { }

    [Event("Withdrawn")]
    public class WithdrawnEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "vaultId", 1, true )]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("address", "tokenAddress", 2, true )]
        public virtual string TokenAddress { get; set; }
        [Parameter("address", "to", 3, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "amount", 4, false )]
        public virtual BigInteger Amount { get; set; }
    }











    public partial class FirewallAdminOutputDTO : FirewallAdminOutputDTOBase { }

    [FunctionOutput]
    public class FirewallAdminOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetAllVaultBalanceByTokenOutputDTO : GetAllVaultBalanceByTokenOutputDTOBase { }

    [FunctionOutput]
    public class GetAllVaultBalanceByTokenOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "balance", 1)]
        public virtual BigInteger Balance { get; set; }
    }

    public partial class GetCurrentVaultBalanceByTokenOutputDTO : GetCurrentVaultBalanceByTokenOutputDTOBase { }

    [FunctionOutput]
    public class GetCurrentVaultBalanceByTokenOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetCurrentVaultIdByTokenOutputDTO : GetCurrentVaultIdByTokenOutputDTOBase { }

    [FunctionOutput]
    public class GetCurrentVaultIdByTokenOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "vaultId", 1)]
        public virtual BigInteger VaultId { get; set; }
    }

    public partial class GetTotalVaultsByTokenOutputDTO : GetTotalVaultsByTokenOutputDTOBase { }

    [FunctionOutput]
    public class GetTotalVaultsByTokenOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "_totalVaults", 1)]
        public virtual BigInteger TotalVaults { get; set; }
    }

    public partial class GetVaultBalanceByVaultIdOutputDTO : GetVaultBalanceByVaultIdOutputDTOBase { }

    [FunctionOutput]
    public class GetVaultBalanceByVaultIdOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class IsDepositActiveForVaultIdOutputDTO : IsDepositActiveForVaultIdOutputDTOBase { }

    [FunctionOutput]
    public class IsDepositActiveForVaultIdOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsWithdrawalActiveForVaultIdOutputDTO : IsWithdrawalActiveForVaultIdOutputDTOBase { }

    [FunctionOutput]
    public class IsWithdrawalActiveForVaultIdOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class NoncesOutputDTO : NoncesOutputDTOBase { }

    [FunctionOutput]
    public class NoncesOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class RoyaltyInfoOutputDTO : RoyaltyInfoOutputDTOBase { }

    [FunctionOutput]
    public class RoyaltyInfoOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
    }













    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class TokenToVaultIdsOutputDTO : TokenToVaultIdsOutputDTOBase { }

    [FunctionOutput]
    public class TokenToVaultIdsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class TotalVaultsOutputDTO : TotalVaultsOutputDTOBase { }

    [FunctionOutput]
    public class TotalVaultsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class TrusteeOutputDTO : TrusteeOutputDTOBase { }

    [FunctionOutput]
    public class TrusteeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class VaultIdToTokenAddressOutputDTO : VaultIdToTokenAddressOutputDTOBase { }

    [FunctionOutput]
    public class VaultIdToTokenAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "token", 1)]
        public virtual string Token { get; set; }
    }

    public partial class VaultIdToTradeStartTimeOutputDTO : VaultIdToTradeStartTimeOutputDTOBase { }

    [FunctionOutput]
    public class VaultIdToTradeStartTimeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class VaultIdToVaultOutputDTO : VaultIdToVaultOutputDTOBase { }

    [FunctionOutput]
    public class VaultIdToVaultOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }


}
