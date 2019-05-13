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
        
    }
}
