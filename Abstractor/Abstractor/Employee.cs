using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretor
{
    public class Employee : Person, IQuittable
    {
        public int id = 0;
        public void Quit(Person person)
        {
            Environment.Exit(id);
        }

        public static Boolean operator== (Employee employee, Employee employee2)
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

        public static Boolean operator!= (Employee employee, Employee employee2)
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
