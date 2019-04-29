using System;

namespace FirstProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type a number: ");
            long n1 = Convert.ToInt64(Console.ReadLine());
            int tester1 = 50;
            long ans1 = (n1 * tester1);
            Console.WriteLine("Your number times 50 is: " + ans1);

            Console.WriteLine("Type a second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int tester2 = 25;
            int ans2 = (n2 + tester2);
            Console.WriteLine("Your number plus 25 is: " + ans2);

            Console.WriteLine("Type a third number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            double tester3 = 12.5;
            double ans3 = (n3 / tester3);
            Console.WriteLine("Your number divided by 12.5 is: " + ans3);

            Console.WriteLine("Type a fourth number: ");
            int n4 = Convert.ToInt32(Console.ReadLine());
            bool ans4 = n4 > tester1;
            Console.WriteLine("Your number is greater than 50: " + ans4);

            Console.WriteLine("Type a fifth number: ");
            int n5 = Convert.ToInt32(Console.ReadLine());
            int tester5 = 7;
            int ans5 = n5 % tester5;
            Console.WriteLine("Your number divided by 7 has a remainder of: " + ans5);

            Console.ReadKey();

        }
    }
}
