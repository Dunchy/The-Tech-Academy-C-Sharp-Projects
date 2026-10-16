using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Console_App
{
    public static class CoolClass
    {

        public static void DivideByTwo(int num, out int dividedNumber)
        {
            dividedNumber = num / 2;
        }
        public static void DivideByTwo(float num, out float dividedNumber)
        {
            dividedNumber = num / 2;
        }
    }
}
