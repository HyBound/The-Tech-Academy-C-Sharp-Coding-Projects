using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionProgram
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<int> numbers = new List<int> { 5, 10, 15, 20, 42, 72, 82, 100 };
                Console.WriteLine("Pick a number to divide my numbers by: ");
                int diviser = Convert.ToInt16(Console.ReadLine());

                foreach (int number in numbers)
                {
                    int answer = number / diviser;
                    Console.WriteLine(number + " divided by " + diviser + " equals: " + answer);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("It has to be a number, ya rube.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero, dummy.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("You're out of the try/catch loop, daddy-o.");

            Console.ReadLine();

        }
    }
}
