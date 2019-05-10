using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integerator4
{
    class Mathing
    {
        public int Maths(int num1, int num2 = 8)
        {
            int result = (num1 + num2) * 9;
            if (result >= 100)
            {
                result = 100;
            }
            return result;
        }
    }
}
