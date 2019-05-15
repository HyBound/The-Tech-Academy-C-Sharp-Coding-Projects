using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num1 = new Number();
            num1.Amount = 6.8m;
            Console.WriteLine("My number is " + num1.Amount);
            Console.ReadLine();

        }
        public struct Number
        {
            public decimal Amount;
        }
    }
}
