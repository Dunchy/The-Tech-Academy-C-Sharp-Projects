using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            while (counter < 10)
            {
                Console.WriteLine("Number " + counter);

                counter ++;
            }

            do
            {

                Console.WriteLine("Number " + counter);

                counter--;
            } while (counter > 0);
        }
    }
}
