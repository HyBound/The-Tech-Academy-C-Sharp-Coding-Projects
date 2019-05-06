using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProgram
{
    class Program
    {
        static void Main()
        {
            String[] words = { "cobble", "wobble", "bobble", "tobble", "mobble" };
            int[] numbers = { 7, 22, 83, 63, 21, 3 };
            List<string> stList = new List<string>();
            stList.Add("Apple");
            stList.Add("Pear");
            stList.Add("Pineapple");
            stList.Add("Cucumber");
            int wrdIndex = 0;
            int numIndex = 0;
            int listIndex = 0;

            Console.WriteLine("What index (0-4)?");
            wrdIndex = Convert.ToInt16(Console.ReadLine());
            if (wrdIndex >4 || wrdIndex < 0)
            {
                Console.WriteLine("It must be between 0 and 4");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine("The word at that index is: " + words[wrdIndex]);

            Console.WriteLine("What index (0-5)?");
            if (wrdIndex > 5 || wrdIndex < 0)
            {
                Console.WriteLine("It must be between 0 and 5");
                Console.ReadKey();
                Environment.Exit(0);
            }
            numIndex = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The number at that index is: " + numbers[numIndex]);

            Console.WriteLine("What index (0-3)?");
            if (wrdIndex > 3 || wrdIndex < 0)
            {
                Console.WriteLine("It must be between 0 and 3");
                Console.ReadKey();
                Environment.Exit(0);
            }
            numIndex = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The word in the list at that index is: " + stList[listIndex]);

            Console.ReadKey();
        }
    }
}
