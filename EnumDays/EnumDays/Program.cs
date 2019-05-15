using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a day of the week: ");
                string day = Convert.ToString(Console.ReadLine());
                eDays.Days eDay = (eDays.Days) Enum.Parse(typeof(eDays.Days), day);

                Console.WriteLine(eDay + " is a day of the week");
                Console.ReadLine();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
            
        }

    }
}
