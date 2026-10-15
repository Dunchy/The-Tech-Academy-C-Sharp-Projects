using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Console_App
{
    internal class Overloaded
    {
        public static int Mathmatical(int num)
        {
            return num - 7;
        }

        public static int Mathmatical(float num)
        {
            return (int)(num * 100);
        }

        public static int Mathmatical(string num)
        {
            int parsedInt;

            int.TryParse(num, out parsedInt);

            return parsedInt + 666;
        }
    }
}
