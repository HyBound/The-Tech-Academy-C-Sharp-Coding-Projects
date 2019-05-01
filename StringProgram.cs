using System;
using System.Text;

namespace StringProgram
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("");

            Console.WriteLine("What is your first name: ");
            String firstName = (Console.ReadLine());
            Console.WriteLine("What is your middle name: ");
            String middleName = (Console.ReadLine());
            Console.WriteLine("What is your last name: ");
            String lastName = (Console.ReadLine());
            String fullName = firstName + " " + middleName + " " + lastName;
            Console.WriteLine("So your full name is: " + fullName + "\n");

            sb.AppendFormat("My name is {0} and I have been quiet for too long. ", fullName);
            Console.WriteLine("What is your favorite battle cry: ");
            String battleCry = (Console.ReadLine().ToUpper());
            
            Console.WriteLine("So you like to yell: " + battleCry);
            Console.ReadKey();

            sb.AppendFormat("The injustice of our people will no longer stand. ");
            sb.AppendFormat("We want to watch Game of Thrones without having to subscribe to HBO. ");
            sb.AppendFormat("Upon this hill we fight and die for our principles with an anguished yell of \"{0}\"!!!", battleCry);
            Console.WriteLine(sb);

            Console.ReadKey();
        }
    }
}
