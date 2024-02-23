using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace poolz.finance.csharp.contracts.DelayVaultProvider.ContractDefinition
{
    public partial class ProviderData : ProviderDataBase { }

    public class ProviderDataBase 
    {
        [Parameter("address", "provider", 1)]
        public virtual string Provider { get; set; }
        [Parameter("uint256[]", "params", 2)]
        public virtual List<BigInteger> Params { get; set; }
        [Parameter("uint256", "limit", 3)]
        public virtual BigInteger Limit { get; set; }
    }
}
