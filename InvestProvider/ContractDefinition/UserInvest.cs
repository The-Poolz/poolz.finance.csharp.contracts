using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace poolz.finance.csharp.contracts.InvestProvider.ContractDefinition
{
    public partial class UserInvest : UserInvestBase { }

    public class UserInvestBase 
    {
        [Parameter("uint256", "blockTimestamp", 1)]
        public BigInteger BlockTimestamp { get; set; }
        [Parameter("uint256", "amount", 2)]
        public BigInteger Amount { get; set; }
    }
}
