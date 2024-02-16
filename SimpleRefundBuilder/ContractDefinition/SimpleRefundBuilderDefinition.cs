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

namespace poolz.finance.csharp.SimpleRefundBuilder.ContractDefinition
{


    public partial class SimpleRefundBuilderDeployment : SimpleRefundBuilderDeploymentBase
    {
        public SimpleRefundBuilderDeployment() : base(BYTECODE) { }
        public SimpleRefundBuilderDeployment(string byteCode) : base(byteCode) { }
    }

    public class SimpleRefundBuilderDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public SimpleRefundBuilderDeploymentBase() : base(BYTECODE) { }
        public SimpleRefundBuilderDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_nft", 1)]
        public virtual string Nft { get; set; }
        [Parameter("address", "_refund", 2)]
        public virtual string Refund { get; set; }
        [Parameter("address", "_collateral", 3)]
        public virtual string Collateral { get; set; }
    }

    public partial class BuildMassPoolsFunction : BuildMassPoolsFunctionBase { }

    [Function("buildMassPools")]
    public class BuildMassPoolsFunctionBase : FunctionMessage
    {
        [Parameter("address[]", "addressParams", 1)]
        public virtual List<string> AddressParams { get; set; }
        [Parameter("tuple", "userData", 2)]
        public virtual Builder UserData { get; set; }
        [Parameter("uint256[][]", "params", 3)]
        public virtual List<List<BigInteger>> Params { get; set; }
        [Parameter("bytes", "tokenSignature", 4)]
        public virtual byte[] TokenSignature { get; set; }
        [Parameter("bytes", "mainCoinSignature", 5)]
        public virtual byte[] MainCoinSignature { get; set; }
    }

    public partial class CollateralProviderFunction : CollateralProviderFunctionBase { }

    [Function("collateralProvider", "address")]
    public class CollateralProviderFunctionBase : FunctionMessage
    {

    }

    public partial class FirewallAdminFunction : FirewallAdminFunctionBase { }

    [Function("firewallAdmin", "address")]
    public class FirewallAdminFunctionBase : FunctionMessage
    {

    }

    public partial class LockDealNFTFunction : LockDealNFTFunctionBase { }

    [Function("lockDealNFT", "address")]
    public class LockDealNFTFunctionBase : FunctionMessage
    {

    }

    public partial class OnERC721ReceivedFunction : OnERC721ReceivedFunctionBase { }

    [Function("onERC721Received", "bytes4")]
    public class OnERC721ReceivedFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
        [Parameter("uint256", "", 3)]
        public virtual BigInteger ReturnValue3 { get; set; }
        [Parameter("bytes", "", 4)]
        public virtual byte[] ReturnValue4 { get; set; }
    }

    public partial class RefundProviderFunction : RefundProviderFunctionBase { }

    [Function("refundProvider", "address")]
    public class RefundProviderFunctionBase : FunctionMessage
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



    public partial class CollateralProviderOutputDTO : CollateralProviderOutputDTOBase { }

    [FunctionOutput]
    public class CollateralProviderOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class FirewallAdminOutputDTO : FirewallAdminOutputDTOBase { }

    [FunctionOutput]
    public class FirewallAdminOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class LockDealNFTOutputDTO : LockDealNFTOutputDTOBase { }

    [FunctionOutput]
    public class LockDealNFTOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class RefundProviderOutputDTO : RefundProviderOutputDTOBase { }

    [FunctionOutput]
    public class RefundProviderOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }




}
