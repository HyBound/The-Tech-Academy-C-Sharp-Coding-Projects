using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegeratorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Type a number to add, multiply and divide by ten: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int num1 = math.Add10(number);
            int num2 = math.Mult10(number);
            int num3 = math.Div10(number);

            Console.WriteLine("Your answers are: " + num1 + " and " + num2 + " and " + num3 + ", respectively.");
            Console.ReadLine();
        }
    }
}
