using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PN532NfcReader.Model.Register
{
    public class Register04 : RegisterXX
    {
        public Register04(byte value) : base(0x04, value) { }

        protected override string FormatDetail()
        {
            return $"ﾁｬﾝﾈﾙ:{data}ch";
        }
    }
}
