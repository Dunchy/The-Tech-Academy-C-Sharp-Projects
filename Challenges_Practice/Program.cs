using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number test = new Number();
            test.Amount = 8.3m;

            Console.WriteLine(test.Amount);
        }
        public struct Number
        {
            public decimal Amount { get; set; }
        }
    }
}
