using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PN532NfcReader.Model.Register
{
    public class Register01 : RegisterXX
    {
        public Register01(byte value) : base(0x01, value) { }

        protected override string FormatDetail()
        {
            return $"ADDL(ｱﾄﾞﾚｽ下位):0x{data:X2}";
        }
    }
}
