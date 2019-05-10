using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassMethodProgram
{
    static class Program
    {
        static void Main(string[] args)
        {
            TheClass classy = new TheClass();
            Console.WriteLine("Hello, give me a number to cut in half with my bitchin' samurai sword: ");
            classy.num1 = Convert.ToInt16(Console.ReadLine());

            classy.Divider(classy.num1);

            Thread.Sleep(1000);
            Console.WriteLine("*Shink!*");
            Thread.Sleep(1000);
            Console.WriteLine(classy.num1);
            Console.WriteLine("Boom, there you go.");
            Thread.Sleep(1000);

            int a, b;
            classy.getValues(out a, out b);
            Console.WriteLine("Your first number is {0}", a);
            Console.WriteLine("And the second number is {0}", b);
            Thread.Sleep(1000);
            Console.WriteLine("I remembered!");
            Thread.Sleep(1000);

            Console.WriteLine("Ok, give me a word for me to cut in half with my katana: ");
            classy.word1 = Convert.ToString(Console.ReadLine());
            classy.Divider(classy.word1);

            Thread.Sleep(1000);
            Console.WriteLine("*Shink!*");
            Thread.Sleep(1000);
            Console.WriteLine(classy.word1);
            Console.WriteLine("Boom, there you go.");
            Console.WriteLine(StaticClass.words + "\n" + StaticClass.words2 + "\n"+ StaticClass.lie);
            Thread.Sleep(1000);
            Console.WriteLine(StaticClass.apology);
            Console.ReadKey();
        }
    }
}
