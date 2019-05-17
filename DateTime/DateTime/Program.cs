using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimor
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Give me a number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            DateTime future = now.AddHours(number);
            Console.WriteLine("It will be {0}, {1} hours from now", future, number);
            Console.ReadLine();
        }
    }
}
