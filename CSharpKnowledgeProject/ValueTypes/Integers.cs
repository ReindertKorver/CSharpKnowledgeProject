using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpKnowledgeProject.ValueTypes
{
    internal class Integers
    {
        public static void Main()
        {
            //Aliases followed by real struct
            // # Integral (signed/unsigned)
            sbyte c = 127;
            sbyte c1 = -128;
            //Signed 8-bit integer
            byte d = 255;
            //Unsigned 8-bit integer
            short e = 32767;
            Int16 f = -32767;
            //Signed 16-bit
            ushort g = 65535;
            UInt16 g1 = 65535;
            //Unsigned 16-bit
            int h = 2147483647;
            Int32 h1 = -2147483648;
            //Signed 32-bit
            uint i = 4294967295;
            UInt32 i1 = 0;
            //Unsigned 32-bit
            long j = 9223372036854775807;
            Int64 j1 = -9223372036854775808;
            //Signed 64-bit
            ulong k = 18446744073709551615;
            UInt64 k1 = 0;
            //default of int is 0
            //u in uint/ushort stands for unsigned and looking at it that means above 0 so positive integers (byte doesnt not have the u)
            //also remarkable there fits more in negative then positive probably because 0 is also an integer
            //A little deeper:
            int binary = 0b_0001;
            //0b is a literal for binary
            int hex = 0xF;
            //0x for hexadecimal 0-F 0-15
        }
    }
}