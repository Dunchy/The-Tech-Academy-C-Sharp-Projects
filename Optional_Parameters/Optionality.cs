using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    internal class Optionality
    {
        public static int Mathing(int num1, int num2 = 0)
        {
            return num1 + num2;
        }
    }
}
