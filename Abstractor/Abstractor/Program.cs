using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee() { FirstName = "Sample", LastName = "Student" };
            Employee sample2 = new Employee() { id=1, FirstName = "Tyler", LastName = "Student" };
            sample.SayName();
            Console.WriteLine(sample.id + " and " + sample2.id);
            Boolean eq = sample == sample2;
            Console.WriteLine(eq);
            Console.ReadLine();
            IQuittable quitter = new Employee();
            Console.WriteLine("Type the letter 'q' to quit: ");
            string q = Convert.ToString(Console.ReadLine());
            if (q == "q")
            {
                quitter.Quit(sample);
            }
            
            Console.ReadKey();
        }
    }
}
