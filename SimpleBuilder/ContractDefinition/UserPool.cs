using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace poolz.finance.csharp.contracts.SimpleBuilder.ContractDefinition
{
    public partial class UserPool : UserPoolBase { }

    public class UserPoolBase 
    {
        [Parameter("address", "user", 1)]
        public string User { get; set; }
        [Parameter("uint256", "amount", 2)]
        public BigInteger Amount { get; set; }
    }
}
