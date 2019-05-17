using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ageism
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                bool isSuccess = false;
                int age = 0;
                while (!isSuccess)
                {
                    Console.WriteLine("What is your age: ");
                    isSuccess = int.TryParse(Console.ReadLine(), out age);
                    if (age < 0) isSuccess = false;
                    if (!isSuccess) Console.WriteLine("Please enter a real number.");
                }
                
                var year = DateTime.Now.Year;
                var zeroCheck = year / age;
                var yearBorn = year - age;
                Console.WriteLine("{0} was the year you were born. And now I feel old.", yearBorn);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Try again, Please enter a real number.");
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You're not 0 years old! How would you be typing on a computer...");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Way to go, you failed at the simplest task...");
                Console.ReadLine();
            }
        }
    }
}
