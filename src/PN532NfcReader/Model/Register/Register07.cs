﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PN532NfcReader.Model.Register
{
    public class Register07 : RegisterXX
    {
        public Register07(byte value) : base(0x06, value) { }

        protected override string FormatDetail()
        {
            return $"※ Write Only";
        }

    }
}
