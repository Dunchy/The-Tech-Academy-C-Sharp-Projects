using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FromTheVoid mathing = new FromTheVoid { };

            int num1;
            int num2;

            Console.WriteLine("Give me a number to do math on:");
            int.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Give me another number to show on the screen:");
            int.TryParse(Console.ReadLine(), out num2);

            mathing.MathMethod(num1, num2);

        }
    }
}
