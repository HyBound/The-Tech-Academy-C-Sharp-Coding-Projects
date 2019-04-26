using System;

namespace FirstProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            String courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            String needHelp = Console.ReadLine();
            bool helpBool = bool.Parse(needHelp);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            String exp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            String feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hours = Console.Read();
            Console.WriteLine("Your answers are: " + courseName + ", " + pageNo + ", " + needHelp + ", " + exp + ", " + hours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadKey();

        }
    }
}
