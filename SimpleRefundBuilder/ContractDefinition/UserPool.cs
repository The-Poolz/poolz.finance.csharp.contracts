using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace poolz.finance.csharp.SimpleRefundBuilder.ContractDefinition
{
    public partial class UserPool : UserPoolBase { }

    public class UserPoolBase 
    {
        [Parameter("address", "user", 1)]
        public virtual string User { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }
}
