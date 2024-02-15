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

namespace poolz.finance.csharp.DelayVaultMigrator.ContractDefinition
{


    public partial class DelayVaultMigratorDeployment : DelayVaultMigratorDeploymentBase
    {
        public DelayVaultMigratorDeployment() : base(BYTECODE) { }
        public DelayVaultMigratorDeployment(string byteCode) : base(byteCode) { }
    }

    public class DelayVaultMigratorDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public DelayVaultMigratorDeploymentBase() : base(BYTECODE) { }
        public DelayVaultMigratorDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_nft", 1)]
        public virtual string Nft { get; set; }
        [Parameter("address", "_oldVault", 2)]
        public virtual string OldVault { get; set; }
    }

    public partial class CreateNewPoolFunction : CreateNewPoolFunctionBase { }

    [Function("CreateNewPool")]
    public class CreateNewPoolFunctionBase : FunctionMessage
    {
        [Parameter("address", "_Token", 1)]
        public virtual string Token { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
        [Parameter("uint256", "", 3)]
        public virtual BigInteger ReturnValue3 { get; set; }
        [Parameter("uint256", "", 4)]
        public virtual BigInteger ReturnValue4 { get; set; }
        [Parameter("uint256", "_StartAmount", 5)]
        public virtual BigInteger StartAmount { get; set; }
        [Parameter("address", "_Owner", 6)]
        public virtual string Owner { get; set; }
    }

    public partial class FinalizeFunction : FinalizeFunctionBase { }

    [Function("finalize")]
    public class FinalizeFunctionBase : FunctionMessage
    {
        [Parameter("address", "_newVault", 1)]
        public virtual string NewVault { get; set; }
    }

    public partial class FirewallAdminFunction : FirewallAdminFunctionBase { }

    [Function("firewallAdmin", "address")]
    public class FirewallAdminFunctionBase : FunctionMessage
    {

    }

    public partial class FullMigrateFunction : FullMigrateFunctionBase { }

    [Function("fullMigrate")]
    public class FullMigrateFunctionBase : FunctionMessage
    {

    }

    public partial class GetUserV1AmountFunction : GetUserV1AmountFunctionBase { }

    [Function("getUserV1Amount", "uint256")]
    public class GetUserV1AmountFunctionBase : FunctionMessage
    {
        [Parameter("address", "user", 1)]
        public virtual string User { get; set; }
    }

    public partial class LockDealNFTFunction : LockDealNFTFunctionBase { }

    [Function("lockDealNFT", "address")]
    public class LockDealNFTFunctionBase : FunctionMessage
    {

    }

    public partial class NewVaultFunction : NewVaultFunctionBase { }

    [Function("newVault", "address")]
    public class NewVaultFunctionBase : FunctionMessage
    {

    }

    public partial class OldVaultFunction : OldVaultFunctionBase { }

    [Function("oldVault", "address")]
    public class OldVaultFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

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

    public partial class TokenFunction : TokenFunctionBase { }

    [Function("token", "address")]
    public class TokenFunctionBase : FunctionMessage
    {

    }

    public partial class WithdrawTokensFromV1VaultFunction : WithdrawTokensFromV1VaultFunctionBase { }

    [Function("withdrawTokensFromV1Vault")]
    public class WithdrawTokensFromV1VaultFunctionBase : FunctionMessage
    {

    }





    public partial class FirewallAdminOutputDTO : FirewallAdminOutputDTOBase { }

    [FunctionOutput]
    public class FirewallAdminOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class GetUserV1AmountOutputDTO : GetUserV1AmountOutputDTOBase { }

    [FunctionOutput]
    public class GetUserV1AmountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class LockDealNFTOutputDTO : LockDealNFTOutputDTOBase { }

    [FunctionOutput]
    public class LockDealNFTOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class NewVaultOutputDTO : NewVaultOutputDTOBase { }

    [FunctionOutput]
    public class NewVaultOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OldVaultOutputDTO : OldVaultOutputDTOBase { }

    [FunctionOutput]
    public class OldVaultOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }





    public partial class TokenOutputDTO : TokenOutputDTOBase { }

    [FunctionOutput]
    public class TokenOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }


}
