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
            Employee sample = new Employee() { FirstName = "Sample", LastName = "Name" };
            sample.SayName();
            Console.ReadKey();
        }
    }
}
