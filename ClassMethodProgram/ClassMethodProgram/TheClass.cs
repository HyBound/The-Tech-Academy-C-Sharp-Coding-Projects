using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodProgram
{
    class TheClass
    {
        public int num1;
        public string word1;
        public void Divider(int number)
        {
            
            num1 = number / 2;
        }

        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Now give me another number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("And another number: ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public void Divider(string number)
        {
            int length = number.Length;
            word1 = number.Substring(0, length / 2);
        }

    }
}
