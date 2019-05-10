using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integerator3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathing maths = new Mathing();
            Console.WriteLine("Type a number, friend: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int result1 = maths.Operator(num1);
            Console.WriteLine("Thanks, friend-o, that number has been taken by lab monkeys and turned into the number {0}", result1);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Ok, the monkeys want to show off, give me a decimal: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            int result2 = maths.Operator(num2);
            Console.WriteLine("Those crazy monkeys say that your number converts to {0} in Monkeysian numbers.", result2);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Ok, one more time, type a number, but this time type the number while thinking of a word.");
            string num3 = Convert.ToString(Console.ReadLine());
            int result3 = maths.Operator(num3);
            Console.WriteLine("Ok, so, the monkeys have {0} grievances against you for choosing that number. They are angry. Very Angry.", result2);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("DON'T LOOK BEHIND YOU!");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
