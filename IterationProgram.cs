using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayProgram
{
    class Program
    {
        private static object time;
        private static int timeout;

        static void Main()
        {
            string[] cake = { "butter", "eggs", "flour", "sugar", "clam"};

            Console.WriteLine("Add a special ingredient for a cake: ");
            string word = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < cake.Length; i++)
            {
                cake[i] = cake[i].Replace("clam", word);
            }

            foreach (string x in cake)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();

            int goat = 6;
            int processed = 0;
            while (goat == 6)
            {
                Console.WriteLine("Ah, ah, ah, you didn't say the magic word...");
                if (++processed == 25) break; //the fix
            }

            while (goat <12){
                Console.Write("Ah, ");
                goat++;
            }

            while(goat <= 15)
            {
                Console.WriteLine("You didn't say the magic word.");
                goat++;
            }


            List<string> names = new List<string>() { "Tyler", "Gemma", "Ashley", "Pops", "Sienna" };
            Console.WriteLine("Ok, fine, name a person within my family (Tyler, Gemma, Ashley...): ");

            string name = Convert.ToString(Console.ReadLine());

            foreach (string index in names)
            {
                if (index == name)
                {
                    Console.WriteLine("The index of that name in my String is: " + names.IndexOf(index));
                }
            }

            if (!names.Contains(name))
            {
                Console.WriteLine("That person is not in my family.");
            }

            List<string> balls = new List<string>() { "base", "basket", "bowling", "base", "soccer", "little", "basket", "big", "foot", "bowling" };
            Console.WriteLine("Now name a type of ball: ");
            string balltype = Convert.ToString(Console.ReadLine());
            int dupl = 0;
            int indexer = 0;
            foreach (string index in balls)
            {
                if (index == balltype)
                {
                    Console.WriteLine("The index of that ball in my String is: " + indexer);
                    indexer++;
                    dupl++;
                }
                else if (!balls.Contains(balltype))
                {
                    Console.WriteLine("That ball does not exist in my world.");
                }
                else { 
                indexer++;
                }
            }

            if (dupl > 0)
            {
                Console.WriteLine("That item is in the list " + dupl + " times.");
            }







            Console.ReadLine();
        }
    }
}
