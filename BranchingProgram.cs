using System;

namespace BranchingProgram
{
    class Program
    {
        private static object decimalVar;

        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());
            double dim = width + height + length;

            if (dim > 50)
            {
                Console.WriteLine("Package too large to be shipped via Package Express. Have a good day.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            double total = dim * weight / 100;
            String totalStr = String.Format("{0:0.00}", total);

            Console.WriteLine("Your estimated total for shipping this package is: $" + totalStr );
            Console.WriteLine("Thank you for using Package Express.");

            Console.ReadKey();
        }
    }
}
