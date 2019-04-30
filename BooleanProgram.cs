using System;

namespace BooleanProgram
{
    class Program
    {
        static void Main()
        {
            bool result = false;
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            if (age > 14 && dui == false && tickets < 3)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            Console.WriteLine("Qualified to receive insurance?");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
