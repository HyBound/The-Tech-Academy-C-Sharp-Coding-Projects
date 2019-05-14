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
            Employee<string> sample = new Employee<string>() { FirstName = "Sample", LastName = "Student", things = { "pants", "shirt", "shoes" } };
            Employee<int> sample2 = new Employee<int>() { id=1, FirstName = "Tyler", LastName = "Student", things = { 2,8,17,32} };
            sample.SayThings(sample);
            sample2.SayThings(sample2);
            Console.WriteLine(sample.id + " and " + sample2.id);

            Console.ReadLine();

            //Console.WriteLine("Type the letter 'q' to quit: ");
            //string q = Convert.ToString(Console.ReadLine());
            //if (q == "q")
            //{
            //    quitter.Quit(sample);
            //}
            
            Console.ReadKey();
        }
    }
}
