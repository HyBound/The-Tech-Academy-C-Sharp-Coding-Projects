using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    public class Employee<T> : Person, IQuittable
    {
        

        public int id = 0;
        public List<T> things = new List<T>();

        public void Quit(Person person)
        {
            Environment.Exit(id);
        }

        public void SayThings(Employee<T> employee)
        {
            foreach (var thing in things)
            {
                Console.WriteLine(thing.ToString());
            }
        }

        public static Boolean operator== (Employee<T> employee, Employee<T> employee2)
        {
            if (employee.id == employee2.id)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static Boolean operator!= (Employee<T> employee, Employee<T> employee2)
        {
            if (employee.id == employee2.id)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}
