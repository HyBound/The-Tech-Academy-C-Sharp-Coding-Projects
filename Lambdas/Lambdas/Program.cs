using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<String> employee1 = new Employee<String>() { id = 0, FirstName = "Joe", LastName = "Stevens" };
            Employee<String> employee2 = new Employee<String>() { id = 1, FirstName = "Amon", LastName = "Tobin" };
            Employee<String> employee3 = new Employee<String>() { id = 2, FirstName = "Steve", LastName = "Perry" };
            Employee<String> employee4 = new Employee<String>() { id = 3, FirstName = "Joe", LastName = "Johnson" };
            Employee<String> employee5 = new Employee<String>() { id = 4, FirstName = "Rance", LastName = "Francer" };
            Employee<String> employee6 = new Employee<String>() { id = 5, FirstName = "Joe", LastName = "Anders" };
            Employee<String> employee7 = new Employee<String>() { id = 6, FirstName = "Bradley", LastName = "Gooch" };
            Employee<String> employee8 = new Employee<String>() { id = 7, FirstName = "John", LastName = "Berry" };
            Employee<String> employee9 = new Employee<String>() { id = 8, FirstName = "Joel", LastName = "Quackenbush" };
            Employee<String> employee10 = new Employee<String>() { id = 9, FirstName = "Randy", LastName = "Johnson" };

            List<Employee<String>> employees = new List<Employee<string>> { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };
            List<Employee<String>> joesFor = new List<Employee<string>>();

            foreach (Employee<String> employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joesFor.Add(employee);
                    Console.WriteLine("Joes List is " + employee.ToString());
                }
            }
            Console.WriteLine(employees);
            List<Employee<String>> joesLam = employees.Where(x => x.FirstName == "joe").ToList();
            List<Employee<String>> newList = employees.Where(x => x.id > 5).ToList();

            foreach (Employee<String> employee in joesFor)
            {
                Console.WriteLine("This for loop contains: " + employee.ToString());
            }

            foreach (Employee<String> employee in joesLam)
            {
                Console.WriteLine("This lambda of joes contains: " + employee.ToString());
            }
            foreach (Employee<String> employee in newList)
            {
                Console.WriteLine("This lambda above 5 contains: " + employee.ToString());
            }

            Console.ReadLine();


            //List<Employee<T>> employees = new List<Employee<T>>()
            //{

            //};


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
