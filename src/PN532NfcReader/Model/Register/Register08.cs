using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PN532NfcReader.Model.Register
{
    public class Register08 : RegisterXX
    {
        public Register08(byte value) : base(0x08, value) { }

        protected override string FormatDetail()
        {
            return $"Ver{data >> 4}.0{data & 0xf}";
        }

    }
}
