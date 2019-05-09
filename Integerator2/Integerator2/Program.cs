using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integerator2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Give me a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Mathing math = new Mathing();
            math.Maths(num1, num2);
            Console.ReadKey();
            
        }
    }
}
