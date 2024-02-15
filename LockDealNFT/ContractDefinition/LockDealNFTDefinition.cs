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

namespace poolz.finance.csharp.LockDealNFT.ContractDefinition
{


    public partial class LockDealNFTDeployment : LockDealNFTDeploymentBase
    {
        public LockDealNFTDeployment() : base(BYTECODE) { }
        public LockDealNFTDeployment(string byteCode) : base(byteCode) { }
    }

    public class LockDealNFTDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public LockDealNFTDeploymentBase() : base(BYTECODE) { }
        public LockDealNFTDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_vaultManager", 1)]
        public virtual string VaultManager { get; set; }
        [Parameter("string", "_baseURI", 2)]
        public virtual string BaseURI { get; set; }
    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class ApprovePoolTransfersFunction : ApprovePoolTransfersFunctionBase { }

    [Function("approvePoolTransfers")]
    public class ApprovePoolTransfersFunctionBase : FunctionMessage
    {
        [Parameter("bool", "status", 1)]
        public virtual bool Status { get; set; }
    }

    public partial class ApprovedContractsFunction : ApprovedContractsFunctionBase { }

    [Function("approvedContracts", "bool")]
    public class ApprovedContractsFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class ApprovedPoolUserTransfersFunction : ApprovedPoolUserTransfersFunctionBase { }

    [Function("approvedPoolUserTransfers", "bool")]
    public class ApprovedPoolUserTransfersFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class BalanceOf1Function : BalanceOf1FunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOf1FunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address[]", "tokens", 2)]
        public virtual List<string> Tokens { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
    }

    public partial class BaseURIFunction : BaseURIFunctionBase { }

    [Function("baseURI", "string")]
    public class BaseURIFunctionBase : FunctionMessage
    {

    }

    public partial class CloneVaultIdFunction : CloneVaultIdFunctionBase { }

    [Function("cloneVaultId")]
    public class CloneVaultIdFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "destinationPoolId", 1)]
        public virtual BigInteger DestinationPoolId { get; set; }
        [Parameter("uint256", "sourcePoolId", 2)]
        public virtual BigInteger SourcePoolId { get; set; }
    }

    public partial class FirewallAdminFunction : FirewallAdminFunctionBase { }

    [Function("firewallAdmin", "address")]
    public class FirewallAdminFunctionBase : FunctionMessage
    {

    }

    public partial class GetApprovedFunction : GetApprovedFunctionBase { }

    [Function("getApproved", "address")]
    public class GetApprovedFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class GetDataFunction : GetDataFunctionBase { }

    [Function("getData", typeof(GetDataOutputDTO))]
    public class GetDataFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "poolId", 1)]
        public virtual BigInteger PoolId { get; set; }
    }

    public partial class GetFullDataFunction : GetFullDataFunctionBase { }

    [Function("getFullData", typeof(GetFullDataOutputDTO))]
    public class GetFullDataFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "poolId", 1)]
        public virtual BigInteger PoolId { get; set; }
    }

    public partial class GetUserDataByTokensFunction : GetUserDataByTokensFunctionBase { }

    [Function("getUserDataByTokens", typeof(GetUserDataByTokensOutputDTO))]
    public class GetUserDataByTokensFunctionBase : FunctionMessage
    {
        [Parameter("address", "user", 1)]
        public virtual string User { get; set; }
        [Parameter("address[]", "tokens", 2)]
        public virtual List<string> Tokens { get; set; }
        [Parameter("uint256", "from", 3)]
        public virtual BigInteger From { get; set; }
        [Parameter("uint256", "to", 4)]
        public virtual BigInteger To { get; set; }
    }

    public partial class GetWithdrawableAmountFunction : GetWithdrawableAmountFunctionBase { }

    [Function("getWithdrawableAmount", "uint256")]
    public class GetWithdrawableAmountFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "poolId", 1)]
        public virtual BigInteger PoolId { get; set; }
    }

    public partial class IsApprovedForAllFunction : IsApprovedForAllFunctionBase { }

    [Function("isApprovedForAll", "bool")]
    public class IsApprovedForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "operator", 2)]
        public virtual string Operator { get; set; }
    }

    public partial class MintAndTransferFunction : MintAndTransferFunctionBase { }

    [Function("mintAndTransfer", "uint256")]
    public class MintAndTransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "token", 2)]
        public virtual string Token { get; set; }
        [Parameter("uint256", "amount", 3)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("address", "provider", 4)]
        public virtual string Provider { get; set; }
    }

    public partial class MintForProviderFunction : MintForProviderFunctionBase { }

    [Function("mintForProvider", "uint256")]
    public class MintForProviderFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "provider", 2)]
        public virtual string Provider { get; set; }
    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

    }

    public partial class OnERC721ReceivedFunction : OnERC721ReceivedFunctionBase { }

    [Function("onERC721Received", "bytes4")]
    public class OnERC721ReceivedFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "from", 2)]
        public virtual string From { get; set; }
        [Parameter("uint256", "poolId", 3)]
        public virtual BigInteger PoolId { get; set; }
        [Parameter("bytes", "data", 4)]
        public virtual byte[] Data { get; set; }
    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerOfFunction : OwnerOfFunctionBase { }

    [Function("ownerOf", "address")]
    public class OwnerOfFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class PoolIdToProviderFunction : PoolIdToProviderFunctionBase { }

    [Function("poolIdToProvider", "address")]
    public class PoolIdToProviderFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class PoolIdToVaultIdFunction : PoolIdToVaultIdFunctionBase { }

    [Function("poolIdToVaultId", "uint256")]
    public class PoolIdToVaultIdFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
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

    public partial class SafeMintAndTransferFunction : SafeMintAndTransferFunctionBase { }

    [Function("safeMintAndTransfer", "uint256")]
    public class SafeMintAndTransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "token", 2)]
        public virtual string Token { get; set; }
        [Parameter("address", "from", 3)]
        public virtual string From { get; set; }
        [Parameter("uint256", "amount", 4)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("address", "provider", 5)]
        public virtual string Provider { get; set; }
        [Parameter("bytes", "data", 6)]
        public virtual byte[] Data { get; set; }
    }

    public partial class SafeTransferFromFunction : SafeTransferFromFunctionBase { }

    [Function("safeTransferFrom")]
    public class SafeTransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class SafeTransferFrom1Function : SafeTransferFrom1FunctionBase { }

    [Function("safeTransferFrom")]
    public class SafeTransferFrom1FunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("bytes", "data", 4)]
        public virtual byte[] Data { get; set; }
    }

    public partial class SetApprovalForAllFunction : SetApprovalForAllFunctionBase { }

    [Function("setApprovalForAll")]
    public class SetApprovalForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "operator", 1)]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 2)]
        public virtual bool Approved { get; set; }
    }

    public partial class SetApprovedContractFunction : SetApprovedContractFunctionBase { }

    [Function("setApprovedContract")]
    public class SetApprovedContractFunctionBase : FunctionMessage
    {
        [Parameter("address", "contractAddress", 1)]
        public virtual string ContractAddress { get; set; }
        [Parameter("bool", "status", 2)]
        public virtual bool Status { get; set; }
    }

    public partial class SetBaseURIFunction : SetBaseURIFunctionBase { }

    [Function("setBaseURI")]
    public class SetBaseURIFunctionBase : FunctionMessage
    {
        [Parameter("string", "newBaseURI", 1)]
        public virtual string NewBaseURI { get; set; }
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

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class SymbolFunction : SymbolFunctionBase { }

    [Function("symbol", "string")]
    public class SymbolFunctionBase : FunctionMessage
    {

    }

    public partial class TokenByIndexFunction : TokenByIndexFunctionBase { }

    [Function("tokenByIndex", "uint256")]
    public class TokenByIndexFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "index", 1)]
        public virtual BigInteger Index { get; set; }
    }

    public partial class TokenOfFunction : TokenOfFunctionBase { }

    [Function("tokenOf", "address")]
    public class TokenOfFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "poolId", 1)]
        public virtual BigInteger PoolId { get; set; }
    }

    public partial class TokenOfOwnerByIndexFunction : TokenOfOwnerByIndexFunctionBase { }

    [Function("tokenOfOwnerByIndex", "uint256")]
    public class TokenOfOwnerByIndexFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("uint256", "index", 2)]
        public virtual BigInteger Index { get; set; }
    }

    public partial class TokenOfOwnerByIndex1Function : TokenOfOwnerByIndex1FunctionBase { }

    [Function("tokenOfOwnerByIndex", "uint256")]
    public class TokenOfOwnerByIndex1FunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address[]", "tokens", 2)]
        public virtual List<string> Tokens { get; set; }
        [Parameter("uint256", "index", 3)]
        public virtual BigInteger Index { get; set; }
    }

    public partial class TokenURIFunction : TokenURIFunctionBase { }

    [Function("tokenURI", "string")]
    public class TokenURIFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TotalSupplyFunction : TotalSupplyFunctionBase { }

    [Function("totalSupply", "uint256")]
    public class TotalSupplyFunctionBase : FunctionMessage
    {

    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class UpdateAllMetadataFunction : UpdateAllMetadataFunctionBase { }

    [Function("updateAllMetadata")]
    public class UpdateAllMetadataFunctionBase : FunctionMessage
    {

    }

    public partial class VaultManagerFunction : VaultManagerFunctionBase { }

    [Function("vaultManager", "address")]
    public class VaultManagerFunctionBase : FunctionMessage
    {

    }

    public partial class ApprovalEventDTO : ApprovalEventDTOBase { }

    [Event("Approval")]
    public class ApprovalEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "approved", 2, true )]
        public virtual string Approved { get; set; }
        [Parameter("uint256", "tokenId", 3, true )]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class ApprovalForAllEventDTO : ApprovalForAllEventDTOBase { }

    [Event("ApprovalForAll")]
    public class ApprovalForAllEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "operator", 2, true )]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 3, false )]
        public virtual bool Approved { get; set; }
    }

    public partial class BaseURIChangedEventDTO : BaseURIChangedEventDTOBase { }

    [Event("BaseURIChanged")]
    public class BaseURIChangedEventDTOBase : IEventDTO
    {
        [Parameter("string", "oldBaseURI", 1, false )]
        public virtual string OldBaseURI { get; set; }
        [Parameter("string", "newBaseURI", 2, false )]
        public virtual string NewBaseURI { get; set; }
    }

    public partial class BatchMetadataUpdateEventDTO : BatchMetadataUpdateEventDTOBase { }

    [Event("BatchMetadataUpdate")]
    public class BatchMetadataUpdateEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "_fromTokenId", 1, false )]
        public virtual BigInteger FromTokenId { get; set; }
        [Parameter("uint256", "_toTokenId", 2, false )]
        public virtual BigInteger ToTokenId { get; set; }
    }

    public partial class ContractApprovedEventDTO : ContractApprovedEventDTOBase { }

    [Event("ContractApproved")]
    public class ContractApprovedEventDTOBase : IEventDTO
    {
        [Parameter("address", "contractAddress", 1, true )]
        public virtual string ContractAddress { get; set; }
        [Parameter("bool", "status", 2, false )]
        public virtual bool Status { get; set; }
    }

    public partial class MetadataUpdateEventDTO : MetadataUpdateEventDTOBase { }

    [Event("MetadataUpdate")]
    public class MetadataUpdateEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "_tokenId", 1, false )]
        public virtual BigInteger TokenId { get; set; }
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

    public partial class PoolSplitEventDTO : PoolSplitEventDTOBase { }

    [Event("PoolSplit")]
    public class PoolSplitEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "poolId", 1, false )]
        public virtual BigInteger PoolId { get; set; }
        [Parameter("address", "owner", 2, true )]
        public virtual string Owner { get; set; }
        [Parameter("uint256", "newPoolId", 3, false )]
        public virtual BigInteger NewPoolId { get; set; }
        [Parameter("address", "newOwner", 4, true )]
        public virtual string NewOwner { get; set; }
        [Parameter("uint256", "splitLeftAmount", 5, false )]
        public virtual BigInteger SplitLeftAmount { get; set; }
        [Parameter("uint256", "newSplitLeftAmount", 6, false )]
        public virtual BigInteger NewSplitLeftAmount { get; set; }
    }

    public partial class TokenWithdrawnEventDTO : TokenWithdrawnEventDTOBase { }

    [Event("TokenWithdrawn")]
    public class TokenWithdrawnEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "poolId", 1, false )]
        public virtual BigInteger PoolId { get; set; }
        [Parameter("address", "owner", 2, true )]
        public virtual string Owner { get; set; }
        [Parameter("uint256", "withdrawnAmount", 3, false )]
        public virtual BigInteger WithdrawnAmount { get; set; }
        [Parameter("uint256", "leftAmount", 4, false )]
        public virtual BigInteger LeftAmount { get; set; }
    }

    public partial class TransferEventDTO : TransferEventDTOBase { }

    [Event("Transfer")]
    public class TransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3, true )]
        public virtual BigInteger TokenId { get; set; }
    }





    public partial class ApprovedContractsOutputDTO : ApprovedContractsOutputDTOBase { }

    [FunctionOutput]
    public class ApprovedContractsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class ApprovedPoolUserTransfersOutputDTO : ApprovedPoolUserTransfersOutputDTOBase { }

    [FunctionOutput]
    public class ApprovedPoolUserTransfersOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class BalanceOf1OutputDTO : BalanceOf1OutputDTOBase { }

    [FunctionOutput]
    public class BalanceOf1OutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "balance", 1)]
        public virtual BigInteger Balance { get; set; }
    }

    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class BaseURIOutputDTO : BaseURIOutputDTOBase { }

    [FunctionOutput]
    public class BaseURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class FirewallAdminOutputDTO : FirewallAdminOutputDTOBase { }

    [FunctionOutput]
    public class FirewallAdminOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetApprovedOutputDTO : GetApprovedOutputDTOBase { }

    [FunctionOutput]
    public class GetApprovedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetDataOutputDTO : GetDataOutputDTOBase { }

    [FunctionOutput]
    public class GetDataOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "poolInfo", 1)]
        public virtual BasePoolInfo PoolInfo { get; set; }
    }

    public partial class GetFullDataOutputDTO : GetFullDataOutputDTOBase { }

    [FunctionOutput]
    public class GetFullDataOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple[]", "poolInfo", 1)]
        public virtual List<BasePoolInfo> PoolInfo { get; set; }
    }

    public partial class GetUserDataByTokensOutputDTO : GetUserDataByTokensOutputDTOBase { }

    [FunctionOutput]
    public class GetUserDataByTokensOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple[]", "userPoolInfo", 1)]
        public virtual List<BasePoolInfo> UserPoolInfo { get; set; }
    }

    public partial class GetWithdrawableAmountOutputDTO : GetWithdrawableAmountOutputDTOBase { }

    [FunctionOutput]
    public class GetWithdrawableAmountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "withdrawalAmount", 1)]
        public virtual BigInteger WithdrawalAmount { get; set; }
    }

    public partial class IsApprovedForAllOutputDTO : IsApprovedForAllOutputDTOBase { }

    [FunctionOutput]
    public class IsApprovedForAllOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }





    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnerOfOutputDTO : OwnerOfOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PoolIdToProviderOutputDTO : PoolIdToProviderOutputDTOBase { }

    [FunctionOutput]
    public class PoolIdToProviderOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PoolIdToVaultIdOutputDTO : PoolIdToVaultIdOutputDTOBase { }

    [FunctionOutput]
    public class PoolIdToVaultIdOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class RoyaltyInfoOutputDTO : RoyaltyInfoOutputDTOBase { }

    [FunctionOutput]
    public class RoyaltyInfoOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "receiver", 1)]
        public virtual string Receiver { get; set; }
        [Parameter("uint256", "royaltyAmount", 2)]
        public virtual BigInteger RoyaltyAmount { get; set; }
    }

















    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class SymbolOutputDTO : SymbolOutputDTOBase { }

    [FunctionOutput]
    public class SymbolOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TokenByIndexOutputDTO : TokenByIndexOutputDTOBase { }

    [FunctionOutput]
    public class TokenByIndexOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class TokenOfOutputDTO : TokenOfOutputDTOBase { }

    [FunctionOutput]
    public class TokenOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "token", 1)]
        public virtual string Token { get; set; }
    }

    public partial class TokenOfOwnerByIndexOutputDTO : TokenOfOwnerByIndexOutputDTOBase { }

    [FunctionOutput]
    public class TokenOfOwnerByIndexOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class TokenOfOwnerByIndex1OutputDTO : TokenOfOwnerByIndex1OutputDTOBase { }

    [FunctionOutput]
    public class TokenOfOwnerByIndex1OutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "poolId", 1)]
        public virtual BigInteger PoolId { get; set; }
    }

    public partial class TokenURIOutputDTO : TokenURIOutputDTOBase { }

    [FunctionOutput]
    public class TokenURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase { }

    [FunctionOutput]
    public class TotalSupplyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }







    public partial class VaultManagerOutputDTO : VaultManagerOutputDTOBase { }

    [FunctionOutput]
    public class VaultManagerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }
}
