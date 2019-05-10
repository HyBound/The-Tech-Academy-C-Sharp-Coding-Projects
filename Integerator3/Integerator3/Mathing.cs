using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integerator3
{
    class Mathing
    {
        public int Operator(int num1)
        {
            int result = num1 * 7 / 5 + 18;
            return result;
        }

        public int Operator(double num1)
        {
            double result = num1 * 100;
            int final = Convert.ToInt32(result)+10;
            return final;
        }

        public int Operator(string num1)
        {
            int result = Convert.ToInt32(num1) + 3 / 18 * 986 - 6 + 84;
            
            return result;
        }
    }
}
