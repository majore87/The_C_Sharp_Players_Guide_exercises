using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_type_system
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integral Types
            /*
            Type   Bytes   Range
            byte    1       0 to 255
            short   2       -32,768 to 32,767  
            int     4       -2,147,483,648 to 2,147,483,647
            long    8       -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            shor, int, long are all signed types.
            */

            byte aSignleByte = 34;
            aSignleByte = 17;

            short aNumber = 5039;
            aNumber = -4354;

            long aVeryBigNumber = 395904282569;
            aVeryBigNumber = 13;

            /*
            Type   Bytes   Range
            sbyte    1       -128 to +127
            ushort   2       0 to 65,535  
            uint     4       0 to 4,294,967,295
            ulong    8       0 to 18,446,744,073,709,551,615
            char     2       U+0000 to U+ffff (All Unicode characters)
            */

            // Floating point numbers
        }
    }
}
