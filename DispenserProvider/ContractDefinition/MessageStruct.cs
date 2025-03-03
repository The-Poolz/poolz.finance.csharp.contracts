using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace poolz.finance.csharp.contracts.DispenserProvider.ContractDefinition
{
    public partial class MessageStruct : MessageStructBase { }

    public class MessageStructBase 
    {
        [Parameter("uint256", "poolId", 1)]
        public BigInteger PoolId { get; set; }
        [Parameter("address", "receiver", 2)]
        public string Receiver { get; set; }
        [Parameter("uint256", "validUntil", 3)]
        public BigInteger ValidUntil { get; set; }
        [Parameter("tuple[]", "data", 4)]
        public List<Builder> Data { get; set; }
    }
}
