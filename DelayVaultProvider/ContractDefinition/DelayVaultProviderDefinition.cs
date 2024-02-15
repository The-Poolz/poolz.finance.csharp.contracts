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

namespace poolz.finance.csharp.DelayVaultProvider.ContractDefinition
{


    public partial class DelayVaultProviderDeployment : DelayVaultProviderDeploymentBase
    {
        public DelayVaultProviderDeployment() : base(BYTECODE) { }
        public DelayVaultProviderDeployment(string byteCode) : base(byteCode) { }
    }

    public class DelayVaultProviderDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public DelayVaultProviderDeploymentBase() : base(BYTECODE) { }
        public DelayVaultProviderDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_token", 1)]
        public virtual string Token { get; set; }
        [Parameter("address", "_migrator", 2)]
        public virtual string Migrator { get; set; }
        [Parameter("tuple[]", "_providersData", 3)]
        public virtual List<ProviderData> ProvidersData { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "user", 1)]
        public virtual string User { get; set; }
    }

    public partial class BeforeTransferFunction : BeforeTransferFunctionBase { }

    [Function("beforeTransfer")]
    public class BeforeTransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "poolId", 3)]
        public virtual BigInteger PoolId { get; set; }
    }

    public partial class CreateNewDelayVaultFunction : CreateNewDelayVaultFunctionBase { }

    [Function("createNewDelayVault", "uint256")]
    public class CreateNewDelayVaultFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("uint256[]", "params", 2)]
        public virtual List<BigInteger> Params { get; set; }
    }

    public partial class CreateNewDelayVaultWithSignatureFunction : CreateNewDelayVaultWithSignatureFunctionBase { }

    [Function("createNewDelayVaultWithSignature", "uint256")]
    public class CreateNewDelayVaultWithSignatureFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("uint256[]", "params", 2)]
        public virtual List<BigInteger> Params { get; set; }
        [Parameter("bytes", "signature", 3)]
        public virtual byte[] Signature { get; set; }
    }

    public partial class CurrentParamsTargetLengthFunction : CurrentParamsTargetLengthFunctionBase { }

    [Function("currentParamsTargetLength", "uint256")]
    public class CurrentParamsTargetLengthFunctionBase : FunctionMessage
    {

    }

    public partial class FirewallAdminFunction : FirewallAdminFunctionBase { }

    [Function("firewallAdmin", "address")]
    public class FirewallAdminFunctionBase : FunctionMessage
    {

    }

    public partial class GetParamsFunction : GetParamsFunctionBase { }

    [Function("getParams", "uint256[]")]
    public class GetParamsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "poolId", 1)]
        public virtual BigInteger PoolId { get; set; }
    }

    public partial class GetSubProvidersPoolIdsFunction : GetSubProvidersPoolIdsFunctionBase { }

    [Function("getSubProvidersPoolIds", "uint256[]")]
    public class GetSubProvidersPoolIdsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetTotalAmountFunction : GetTotalAmountFunctionBase { }

    [Function("getTotalAmount", "uint256")]
    public class GetTotalAmountFunctionBase : FunctionMessage
    {
        [Parameter("address", "user", 1)]
        public virtual string User { get; set; }
    }

    public partial class GetTypeToProviderDataFunction : GetTypeToProviderDataFunctionBase { }

    [Function("getTypeToProviderData", typeof(GetTypeToProviderDataOutputDTO))]
    public class GetTypeToProviderDataFunctionBase : FunctionMessage
    {
        [Parameter("uint8", "theType", 1)]
        public virtual byte TheType { get; set; }
    }

    public partial class GetWithdrawPoolParamsFunction : GetWithdrawPoolParamsFunctionBase { }

    [Function("getWithdrawPoolParams", "uint256[]")]
    public class GetWithdrawPoolParamsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "amount", 1)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("uint8", "theType", 2)]
        public virtual byte TheType { get; set; }
    }

    public partial class GetWithdrawableAmountFunction : GetWithdrawableAmountFunctionBase { }

    [Function("getWithdrawableAmount", "uint256")]
    public class GetWithdrawableAmountFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "poolId", 1)]
        public virtual BigInteger PoolId { get; set; }
    }

    public partial class LockDealNFTFunction : LockDealNFTFunctionBase { }

    [Function("lockDealNFT", "address")]
    public class LockDealNFTFunctionBase : FunctionMessage
    {

    }

    public partial class MigratorFunction : MigratorFunctionBase { }

    [Function("migrator", "address")]
    public class MigratorFunctionBase : FunctionMessage
    {

    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

    }

    public partial class PoolIdToAmountFunction : PoolIdToAmountFunctionBase { }

    [Function("poolIdToAmount", "uint256")]
    public class PoolIdToAmountFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class RegisterPoolFunction : RegisterPoolFunctionBase { }

    [Function("registerPool")]
    public class RegisterPoolFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "poolId", 1)]
        public virtual BigInteger PoolId { get; set; }
        [Parameter("uint256[]", "params", 2)]
        public virtual List<BigInteger> Params { get; set; }
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

    public partial class SplitFunction : SplitFunctionBase { }

    [Function("split")]
    public class SplitFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "oldPoolId", 1)]
        public virtual BigInteger OldPoolId { get; set; }
        [Parameter("uint256", "newPoolId", 2)]
        public virtual BigInteger NewPoolId { get; set; }
        [Parameter("uint256", "ratio", 3)]
        public virtual BigInteger Ratio { get; set; }
    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class TheTypeOfFunction : TheTypeOfFunctionBase { }

    [Function("theTypeOf", "uint8")]
    public class TheTypeOfFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class TokenFunction : TokenFunctionBase { }

    [Function("token", "address")]
    public class TokenFunctionBase : FunctionMessage
    {

    }

    public partial class TokenOfOwnerByIndexFunction : TokenOfOwnerByIndexFunctionBase { }

    [Function("tokenOfOwnerByIndex", "uint256")]
    public class TokenOfOwnerByIndexFunctionBase : FunctionMessage
    {
        [Parameter("address", "user", 1)]
        public virtual string User { get; set; }
        [Parameter("uint256", "index", 2)]
        public virtual BigInteger Index { get; set; }
    }

    public partial class TypeToProviderDataFunction : TypeToProviderDataFunctionBase { }

    [Function("typeToProviderData", typeof(TypeToProviderDataOutputDTO))]
    public class TypeToProviderDataFunctionBase : FunctionMessage
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
    }

    public partial class TypesCountFunction : TypesCountFunctionBase { }

    [Function("typesCount", "uint8")]
    public class TypesCountFunctionBase : FunctionMessage
    {

    }

    public partial class UpgradeTypeFunction : UpgradeTypeFunctionBase { }

    [Function("upgradeType")]
    public class UpgradeTypeFunctionBase : FunctionMessage
    {
        [Parameter("uint8", "newType", 1)]
        public virtual byte NewType { get; set; }
    }

    public partial class UserToAmountFunction : UserToAmountFunctionBase { }

    [Function("userToAmount", "uint256")]
    public class UserToAmountFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class UserToTypeFunction : UserToTypeFunctionBase { }

    [Function("userToType", "uint8")]
    public class UserToTypeFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class WithdrawFunction : WithdrawFunctionBase { }

    [Function("withdraw", typeof(WithdrawOutputDTO))]
    public class WithdrawFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class UpdateParamsEventDTO : UpdateParamsEventDTOBase { }

    [Event("UpdateParams")]
    public class UpdateParamsEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "poolId", 1, true )]
        public virtual BigInteger PoolId { get; set; }
        [Parameter("uint256[]", "params", 2, false )]
        public virtual List<BigInteger> Params { get; set; }
    }

    public partial class VaultValueChangedEventDTO : VaultValueChangedEventDTOBase { }

    [Event("VaultValueChanged")]
    public class VaultValueChangedEventDTOBase : IEventDTO
    {
        [Parameter("address", "token", 1, true )]
        public virtual string Token { get; set; }
        [Parameter("address", "owner", 2, true )]
        public virtual string Owner { get; set; }
        [Parameter("uint256", "amount", 3, false )]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "balance", 1)]
        public virtual BigInteger Balance { get; set; }
    }







    public partial class CurrentParamsTargetLengthOutputDTO : CurrentParamsTargetLengthOutputDTOBase { }

    [FunctionOutput]
    public class CurrentParamsTargetLengthOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class FirewallAdminOutputDTO : FirewallAdminOutputDTOBase { }

    [FunctionOutput]
    public class FirewallAdminOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetParamsOutputDTO : GetParamsOutputDTOBase { }

    [FunctionOutput]
    public class GetParamsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "params", 1)]
        public virtual List<BigInteger> Params { get; set; }
    }

    public partial class GetSubProvidersPoolIdsOutputDTO : GetSubProvidersPoolIdsOutputDTOBase { }

    [FunctionOutput]
    public class GetSubProvidersPoolIdsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "poolIds", 1)]
        public virtual List<BigInteger> PoolIds { get; set; }
    }

    public partial class GetTotalAmountOutputDTO : GetTotalAmountOutputDTOBase { }

    [FunctionOutput]
    public class GetTotalAmountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetTypeToProviderDataOutputDTO : GetTypeToProviderDataOutputDTOBase { }

    [FunctionOutput]
    public class GetTypeToProviderDataOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "providerData", 1)]
        public virtual ProviderData ProviderData { get; set; }
    }

    public partial class GetWithdrawPoolParamsOutputDTO : GetWithdrawPoolParamsOutputDTOBase { }

    [FunctionOutput]
    public class GetWithdrawPoolParamsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "params", 1)]
        public virtual List<BigInteger> Params { get; set; }
    }

    public partial class GetWithdrawableAmountOutputDTO : GetWithdrawableAmountOutputDTOBase { }

    [FunctionOutput]
    public class GetWithdrawableAmountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "withdrawalAmount", 1)]
        public virtual BigInteger WithdrawalAmount { get; set; }
    }

    public partial class LockDealNFTOutputDTO : LockDealNFTOutputDTOBase { }

    [FunctionOutput]
    public class LockDealNFTOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class MigratorOutputDTO : MigratorOutputDTOBase { }

    [FunctionOutput]
    public class MigratorOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PoolIdToAmountOutputDTO : PoolIdToAmountOutputDTOBase { }

    [FunctionOutput]
    public class PoolIdToAmountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }









    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class TheTypeOfOutputDTO : TheTypeOfOutputDTOBase { }

    [FunctionOutput]
    public class TheTypeOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "theType", 1)]
        public virtual byte TheType { get; set; }
    }

    public partial class TokenOutputDTO : TokenOutputDTOBase { }

    [FunctionOutput]
    public class TokenOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TokenOfOwnerByIndexOutputDTO : TokenOfOwnerByIndexOutputDTOBase { }

    [FunctionOutput]
    public class TokenOfOwnerByIndexOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "poolId", 1)]
        public virtual BigInteger PoolId { get; set; }
    }

    public partial class TypeToProviderDataOutputDTO : TypeToProviderDataOutputDTOBase { }

    [FunctionOutput]
    public class TypeToProviderDataOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "provider", 1)]
        public virtual string Provider { get; set; }
        [Parameter("uint256", "limit", 2)]
        public virtual BigInteger Limit { get; set; }
    }

    public partial class TypesCountOutputDTO : TypesCountOutputDTOBase { }

    [FunctionOutput]
    public class TypesCountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
    }



    public partial class UserToAmountOutputDTO : UserToAmountOutputDTOBase { }

    [FunctionOutput]
    public class UserToAmountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class UserToTypeOutputDTO : UserToTypeOutputDTOBase { }

    [FunctionOutput]
    public class UserToTypeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
    }

    public partial class WithdrawOutputDTO : WithdrawOutputDTOBase { }

    [FunctionOutput]
    public class WithdrawOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "withdrawnAmount", 1)]
        public virtual BigInteger WithdrawnAmount { get; set; }
        [Parameter("bool", "isFinal", 2)]
        public virtual bool IsFinal { get; set; }
    }
}
