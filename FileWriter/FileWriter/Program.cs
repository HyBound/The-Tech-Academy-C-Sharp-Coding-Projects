using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number: ");
            string fileName = @"C:\Users\hybou\Logs\numbers.txt";
            int number = Convert.ToInt32(Console.ReadLine());
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine(number);
            sw.Close();
            Console.ReadLine();
            using (TextReader reader = File.OpenText(fileName))
            {
                int x = int.Parse(reader.ReadLine());
                Console.WriteLine("The number {0} has been written to a file. That number was also read from that file.", x);
            }

            Console.ReadLine();
        }
    }
}
