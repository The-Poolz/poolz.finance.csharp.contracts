using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace poolz.finance.csharp.contracts.SimpleBuilder.ContractDefinition
{
    public partial class Builder : BuilderBase { }

    public class BuilderBase 
    {
        [Parameter("tuple[]", "userPools", 1)]
        public List<UserPool> UserPools { get; set; }
        [Parameter("uint256", "totalAmount", 2)]
        public BigInteger TotalAmount { get; set; }
    }
}
