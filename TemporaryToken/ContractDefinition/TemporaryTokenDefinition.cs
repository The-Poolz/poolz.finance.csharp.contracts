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

namespace poolz.finance.csharp.contracts.TemporaryToken.ContractDefinition
{


    public partial class TemporaryTokenDeployment : TemporaryTokenDeploymentBase
    {
        public TemporaryTokenDeployment() : base(BYTECODE) { }
        public TemporaryTokenDeployment(string byteCode) : base(byteCode) { }
    }

    public class TemporaryTokenDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x60c06040523480156200001157600080fd5b50604051620016653803806200166583398101604081905262000034916200052b565b6200004460ff8416600a6200070d565b62000050908562000722565b86866003620000608382620007e3565b5060046200006f8282620007e3565b50505060008111620000e2576040517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820152601560248201527f45524332304361707065643a206361702069732030000000000000000000000060448201526064015b60405180910390fd5b6080526200010b620000fc640100000000620001ea810204565b640100000000620001ee810204565b60068054600160a060020a0319169055601260ff841611156200018b576040517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820152601560248201527f446563696d616c73206d6f7265207468616e20313800000000000000000000006044820152606401620000d9565b60ff831660a081905260068054600160a060020a031916600160a060020a038416179055620001de908390620001c390600a6200070d565b620001cf908762000722565b64010000000062000240810204565b505050505050620008cb565b3390565b60058054600160a060020a03838116600160a060020a0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b62000253640100000000620002f6810204565b8162000267640100000000620002fc810204565b620002739190620008b5565b1115620002dd576040517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820152601960248201527f45524332304361707065643a20636170206578636565646564000000000000006044820152606401620000d9565b620002f2828264010000000062000302810204565b5050565b60805190565b60025490565b600160a060020a03821662000374576040517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f2061646472657373006044820152606401620000d9565b6200038b600083836401000000006200042b810204565b80600260008282546200039f9190620008b5565b9091555050600160a060020a03821660009081526020819052604081208054839290620003ce908490620008b5565b9091555050604051818152600160a060020a038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a3620002f2600083836401000000006200042b810204565b505050565b7f4e487b7100000000000000000000000000000000000000000000000000000000600052604160045260246000fd5b600082601f8301126200047157600080fd5b81516001604060020a03808211156200048e576200048e62000430565b604051601f8301601f19908116603f01168101908282118183101715620004b957620004b962000430565b81604052838152602092508683858801011115620004d657600080fd5b600091505b83821015620004fa5785820183015181830184015290820190620004db565b600093810190920192909252949350505050565b8051600160a060020a03811681146200052657600080fd5b919050565b60008060008060008060c087890312156200054557600080fd5b86516001604060020a03808211156200055d57600080fd5b6200056b8a838b016200045f565b975060208901519150808211156200058257600080fd5b506200059189828a016200045f565b95505060408701519350606087015160ff81168114620005b057600080fd5b9250620005c0608088016200050e565b9150620005d060a088016200050e565b90509295509295509295565b7f4e487b7100000000000000000000000000000000000000000000000000000000600052601160045260246000fd5b600181815b808511156200064e578160001904821115620006305762000630620005dc565b808516156200063e57918102915b6002909404939080029062000610565b509250929050565b600082620006675750600162000707565b81620006765750600062000707565b81600181146200068f57600281146200069a57620006bb565b600191505062000707565b60ff841115620006ae57620006ae620005dc565b8360020a91505062000707565b5060208310610133831016604e8410600b8410161715620006e0575081810a62000707565b620006ec83836200060b565b8060001904821115620007035762000703620005dc565b0290505b92915050565b60006200071b838362000656565b9392505050565b8082028115828204841417620007075762000707620005dc565b6002810460018216806200075157607f821691505b6020821081036200078b577f4e487b7100000000000000000000000000000000000000000000000000000000600052602260045260246000fd5b50919050565b601f8211156200042b576000818152602081206020601f86010481016020861015620007ba5750805b6020601f860104820191505b81811015620007db57828155600101620007c6565b505050505050565b81516001604060020a03811115620007ff57620007ff62000430565b62000817816200081084546200073c565b8462000791565b602080601f831160018114620008535760008415620008365750858301515b60028086026008870290910a6000190419821617865550620007db565b600085815260208120601f198616915b82811015620008845788860151825594840194600190910190840162000863565b5085821015620008a557878501516008601f88160260020a60001904191681555b5050505050600202600101905550565b80820180821115620007075762000707620005dc565b60805160a051610d74620008f160003960006101ba015260006101e60152610d746000f3fe608060405234801561001057600080fd5b5060043610610133576000357c010000000000000000000000000000000000000000000000000000000090048063715018a6116100bf57806395d89b411161008e57806395d89b4114610292578063a457c2d71461029a578063a9059cbb146102ad578063dd62ed3e146102c0578063f2fde38b146102d357600080fd5b8063715018a6146102465780637a14583a1461024e57806383197ef0146102795780638da5cb5b1461028157600080fd5b806323b872dd1161010657806323b872dd146101a0578063313ce567146101b3578063355274ea146101e4578063395093511461020a57806370a082311461021d57600080fd5b806306c498221461013857806306fdde031461014d578063095ea7b31461016b57806318160ddd1461018e575b600080fd5b61014b610146366004610b71565b6102e6565b005b610155610390565b6040516101629190610b93565b60405180910390f35b61017e610179366004610be1565b610422565b6040519015158152602001610162565b6002545b604051908152602001610162565b61017e6101ae366004610c0b565b61043c565b60405160ff7f0000000000000000000000000000000000000000000000000000000000000000168152602001610162565b7f0000000000000000000000000000000000000000000000000000000000000000610192565b61017e610218366004610be1565b610460565b61019261022b366004610b71565b600160a060020a031660009081526020819052604090205490565b61014b610482565b60065461026190600160a060020a031681565b604051600160a060020a039091168152602001610162565b61014b610496565b600554600160a060020a0316610261565b6101556104db565b61017e6102a8366004610be1565b6104ea565b61017e6102bb366004610be1565b610580565b6101926102ce366004610c47565b61058e565b61014b6102e1366004610b71565b6105b9565b600554600160a060020a03163314806103095750600654600160a060020a031633145b6103315760405160e560020a62461bcd02815260040161032890610c7a565b60405180910390fd5b60068054600160a060020a0383811673ffffffffffffffffffffffffffffffffffffffff19831681179093556040519116919082907f5af6a85e864342d4f108c43dd574d98480c91f1de0ac2a9f66d826dee49bd9bb90600090a35050565b60606003805461039f90610cb1565b80601f01602080910402602001604051908101604052809291908181526020018280546103cb90610cb1565b80156104185780601f106103ed57610100808354040283529160200191610418565b820191906000526020600020905b8154815290600101906020018083116103fb57829003601f168201915b5050505050905090565b60003361043081858561064c565b60019150505b92915050565b60003361044a8582856107aa565b610455858585610827565b506001949350505050565b600033610430818585610473838361058e565b61047d9190610d04565b61064c565b61048a610879565b61049460006108d6565b565b600554600160a060020a03163314806104b95750600654600160a060020a031633145b6104d85760405160e560020a62461bcd02815260040161032890610c7a565b33ff5b60606004805461039f90610cb1565b600033816104f8828661058e565b9050838110156105735760405160e560020a62461bcd02815260206004820152602560248201527f45524332303a2064656372656173656420616c6c6f77616e63652062656c6f7760448201527f207a65726f0000000000000000000000000000000000000000000000000000006064820152608401610328565b610455828686840361064c565b600033610430818585610827565b600160a060020a03918216600090815260016020908152604080832093909416825291909152205490565b6105c1610879565b600160a060020a0381166106405760405160e560020a62461bcd02815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201527f64647265737300000000000000000000000000000000000000000000000000006064820152608401610328565b610649816108d6565b50565b600160a060020a0383166106ca5760405160e560020a62461bcd028152602060048201526024808201527f45524332303a20617070726f76652066726f6d20746865207a65726f2061646460448201527f72657373000000000000000000000000000000000000000000000000000000006064820152608401610328565b600160a060020a0382166107495760405160e560020a62461bcd02815260206004820152602260248201527f45524332303a20617070726f766520746f20746865207a65726f20616464726560448201527f73730000000000000000000000000000000000000000000000000000000000006064820152608401610328565b600160a060020a0383811660008181526001602090815260408083209487168084529482529182902085905590518481527f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925910160405180910390a3505050565b60006107b6848461058e565b9050600019811461082157818110156108145760405160e560020a62461bcd02815260206004820152601d60248201527f45524332303a20696e73756666696369656e7420616c6c6f77616e63650000006044820152606401610328565b610821848484840361064c565b50505050565b600554600160a060020a031633148061084a5750600654600160a060020a031633145b6108695760405160e560020a62461bcd02815260040161032890610c7a565b610874838383610935565b505050565b600554600160a060020a031633146104945760405160e560020a62461bcd02815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610328565b60058054600160a060020a0383811673ffffffffffffffffffffffffffffffffffffffff19831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b600160a060020a0383166109b45760405160e560020a62461bcd02815260206004820152602560248201527f45524332303a207472616e736665722066726f6d20746865207a65726f20616460448201527f64726573730000000000000000000000000000000000000000000000000000006064820152608401610328565b600160a060020a038216610a335760405160e560020a62461bcd02815260206004820152602360248201527f45524332303a207472616e7366657220746f20746865207a65726f206164647260448201527f65737300000000000000000000000000000000000000000000000000000000006064820152608401610328565b600160a060020a03831660009081526020819052604090205481811015610ac55760405160e560020a62461bcd02815260206004820152602660248201527f45524332303a207472616e7366657220616d6f756e742065786365656473206260448201527f616c616e636500000000000000000000000000000000000000000000000000006064820152608401610328565b600160a060020a03808516600090815260208190526040808220858503905591851681529081208054849290610afc908490610d04565b9250508190555082600160a060020a031684600160a060020a03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef84604051610b4891815260200190565b60405180910390a3610821565b8035600160a060020a0381168114610b6c57600080fd5b919050565b600060208284031215610b8357600080fd5b610b8c82610b55565b9392505050565b600060208083528351808285015260005b81811015610bc057858101830151858201604001528201610ba4565b506000604082860101526040601f19601f8301168501019250505092915050565b60008060408385031215610bf457600080fd5b610bfd83610b55565b946020939093013593505050565b600080600060608486031215610c2057600080fd5b610c2984610b55565b9250610c3760208501610b55565b9150604084013590509250925092565b60008060408385031215610c5a57600080fd5b610c6383610b55565b9150610c7160208401610b55565b90509250929050565b60208082526013908201527f417574686f72697a6174696f6e204572726f7200000000000000000000000000604082015260600190565b600281046001821680610cc557607f821691505b602082108103610cfe577f4e487b7100000000000000000000000000000000000000000000000000000000600052602260045260246000fd5b50919050565b80820180821115610436577f4e487b7100000000000000000000000000000000000000000000000000000000600052601160045260246000fdfea26469706673582212204cb06f454671be043ff1f0e4c6cd9c32f6279bf2074ed109c37a0e6f6d5db72c64736f6c63430008130033";
        public TemporaryTokenDeploymentBase() : base(BYTECODE) { }
        public TemporaryTokenDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("string", "_name", 1)]
        public string Name { get; set; }
        [Parameter("string", "_symbol", 2)]
        public string Symbol { get; set; }
        [Parameter("uint256", "_cap", 3)]
        public BigInteger Cap { get; set; }
        [Parameter("uint8", "_decimals", 4)]
        public byte Decimals { get; set; }
        [Parameter("address", "_owner", 5)]
        public string Owner { get; set; }
        [Parameter("address", "_poolzBack", 6)]
        public string PoolzBack { get; set; }
    }

    public partial class GovernorContractFunction : GovernorContractFunctionBase { }

    [Function("GovernorContract", "address")]
    public class GovernorContractFunctionBase : FunctionMessage
    {

    }

    public partial class AllowanceFunction : AllowanceFunctionBase { }

    [Function("allowance", "uint256")]
    public class AllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public string Owner { get; set; }
        [Parameter("address", "spender", 2)]
        public string Spender { get; set; }
    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve", "bool")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public string Spender { get; set; }
        [Parameter("uint256", "amount", 2)]
        public BigInteger Amount { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public string Account { get; set; }
    }

    public partial class CapFunction : CapFunctionBase { }

    [Function("cap", "uint256")]
    public class CapFunctionBase : FunctionMessage
    {

    }

    public partial class DecreaseAllowanceFunction : DecreaseAllowanceFunctionBase { }

    [Function("decreaseAllowance", "bool")]
    public class DecreaseAllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public string Spender { get; set; }
        [Parameter("uint256", "subtractedValue", 2)]
        public BigInteger SubtractedValue { get; set; }
    }

    public partial class IncreaseAllowanceFunction : IncreaseAllowanceFunctionBase { }

    [Function("increaseAllowance", "bool")]
    public class IncreaseAllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public string Spender { get; set; }
        [Parameter("uint256", "addedValue", 2)]
        public BigInteger AddedValue { get; set; }
    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

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

    public partial class SetGovernorContractFunction : SetGovernorContractFunctionBase { }

    [Function("setGovernorContract")]
    public class SetGovernorContractFunctionBase : FunctionMessage
    {
        [Parameter("address", "_address", 1)]
        public string Address { get; set; }
    }

    public partial class SymbolFunction : SymbolFunctionBase { }

    [Function("symbol", "string")]
    public class SymbolFunctionBase : FunctionMessage
    {

    }

    public partial class TotalSupplyFunction : TotalSupplyFunctionBase { }

    [Function("totalSupply", "uint256")]
    public class TotalSupplyFunctionBase : FunctionMessage
    {

    }

    public partial class TransferFunction : TransferFunctionBase { }

    [Function("transfer", "bool")]
    public class TransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public string To { get; set; }
        [Parameter("uint256", "amount", 2)]
        public BigInteger Amount { get; set; }
    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom", "bool")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public string From { get; set; }
        [Parameter("address", "to", 2)]
        public string To { get; set; }
        [Parameter("uint256", "amount", 3)]
        public BigInteger Amount { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public string NewOwner { get; set; }
    }

    public partial class DestroyFunction : DestroyFunctionBase { }

    [Function("destroy")]
    public class DestroyFunctionBase : FunctionMessage
    {

    }

    public partial class DecimalsFunction : DecimalsFunctionBase { }

    [Function("decimals", "uint8")]
    public class DecimalsFunctionBase : FunctionMessage
    {

    }

    public partial class ApprovalEventDTO : ApprovalEventDTOBase { }

    [Event("Approval")]
    public class ApprovalEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public string Owner { get; set; }
        [Parameter("address", "spender", 2, true )]
        public string Spender { get; set; }
        [Parameter("uint256", "value", 3, false )]
        public BigInteger Value { get; set; }
    }

    public partial class GovernorUpdatedEventDTO : GovernorUpdatedEventDTOBase { }

    [Event("GovernorUpdated")]
    public class GovernorUpdatedEventDTOBase : IEventDTO
    {
        [Parameter("address", "oldGovernor", 1, true )]
        public string OldGovernor { get; set; }
        [Parameter("address", "newGovernor", 2, true )]
        public string NewGovernor { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public string NewOwner { get; set; }
    }

    public partial class TransferEventDTO : TransferEventDTOBase { }

    [Event("Transfer")]
    public class TransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true )]
        public string From { get; set; }
        [Parameter("address", "to", 2, true )]
        public string To { get; set; }
        [Parameter("uint256", "value", 3, false )]
        public BigInteger Value { get; set; }
    }

    public partial class GovernorContractOutputDTO : GovernorContractOutputDTOBase { }

    [FunctionOutput]
    public class GovernorContractOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public string ReturnValue1 { get; set; }
    }

    public partial class AllowanceOutputDTO : AllowanceOutputDTOBase { }

    [FunctionOutput]
    public class AllowanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public BigInteger ReturnValue1 { get; set; }
    }



    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public BigInteger ReturnValue1 { get; set; }
    }

    public partial class CapOutputDTO : CapOutputDTOBase { }

    [FunctionOutput]
    public class CapOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public BigInteger ReturnValue1 { get; set; }
    }





    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public string ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public string ReturnValue1 { get; set; }
    }





    public partial class SymbolOutputDTO : SymbolOutputDTOBase { }

    [FunctionOutput]
    public class SymbolOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public string ReturnValue1 { get; set; }
    }

    public partial class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase { }

    [FunctionOutput]
    public class TotalSupplyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public BigInteger ReturnValue1 { get; set; }
    }









    public partial class DecimalsOutputDTO : DecimalsOutputDTOBase { }

    [FunctionOutput]
    public class DecimalsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "", 1)]
        public byte ReturnValue1 { get; set; }
    }
}
