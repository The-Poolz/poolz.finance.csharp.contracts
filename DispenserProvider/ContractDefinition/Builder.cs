using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace poolz.finance.csharp.contracts.DispenserProvider.ContractDefinition
{
    public partial class Builder : BuilderBase { }

    public class BuilderBase 
    {
        [Parameter("address", "simpleProvider", 1)]
        public string SimpleProvider { get; set; }
        [Parameter("uint256[]", "params", 2)]
        public List<BigInteger> Params { get; set; }
    }
}
