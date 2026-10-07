using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_And_Lists
{
    internal class Program
    {
        static void Main()
        {
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);

            int[] numArray = new int[5] {5, 2, 10, 20, 500};

            Console.WriteLine(numArray[3]);
            Console.ReadLine();
        }
    }
}