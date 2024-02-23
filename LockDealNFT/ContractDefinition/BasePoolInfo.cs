using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace poolz.finance.csharp.contracts.LockDealNFT.ContractDefinition
{
    public partial class BasePoolInfo : BasePoolInfoBase { }

    public class BasePoolInfoBase 
    {
        [Parameter("address", "provider", 1)]
        public virtual string Provider { get; set; }
        [Parameter("string", "name", 2)]
        public virtual string Name { get; set; }
        [Parameter("uint256", "poolId", 3)]
        public virtual BigInteger PoolId { get; set; }
        [Parameter("uint256", "vaultId", 4)]
        public virtual BigInteger VaultId { get; set; }
        [Parameter("address", "owner", 5)]
        public virtual string Owner { get; set; }
        [Parameter("address", "token", 6)]
        public virtual string Token { get; set; }
        [Parameter("uint256[]", "params", 7)]
        public virtual List<BigInteger> Params { get; set; }
    }
}
