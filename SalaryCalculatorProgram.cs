using System;

namespace FirstProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int hr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hw1 = Convert.ToInt32(Console.ReadLine());
            int p1Total = hr1 * hw1;

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int hr2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hw2 = Convert.ToInt32(Console.ReadLine());
            int p2Total = hr2 * hw2;
            bool comp = p1Total > p2Total;

            Console.WriteLine("Weekly salary of Person 1: " + p1Total);

            Console.WriteLine("Weekly salary of Person 2: " + p2Total);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(comp);

            Console.ReadKey();

            Console.WriteLine("Thank you for calculating with us today.");

            Console.ReadKey();
        }
    }
}
