using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integerator4
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathing maths = new Mathing();
            int result = 0;
            Console.WriteLine("Tell me the number of times you have cussed today (let's be honest,there's at least one time): ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now tell me how many times you felt bad about it (let's be honest, you can leave this blank): ");
            string num2 = Convert.ToString(Console.ReadLine());
            if (num2 == "")
            {
                result = maths.Maths(num1);
            }
            else
            {
                result = maths.Maths(num1, Convert.ToInt32(num2));
            }
            Console.WriteLine("Ah, so you have a {0}% chance of going to hell. Good for you.",result);
            Console.ReadLine();
        }
    }
}
