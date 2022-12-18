using System;

namespace ALLAHDIYENTURBISON
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("What day is today? ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It is Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It is Tuesday!");
                    break;
                case "Wednesday":
                    Console.WriteLine("It is Wednesday!");
                    break;
                case "Thursday":
                    Console.WriteLine("It is Thursday!");
                    break;
                case "Friday":
                    Console.WriteLine("It is Friday!");
                    break;
                case "Saturday":
                    Console.WriteLine("It is Saturday!");
                    break;
                case "Sunday":
                    Console.WriteLine("It is Sunday!");
                    break;
                default:
                    Console.WriteLine(day + " is not a day!");
                    break;

            }
            Console.ReadKey();
 
        }
    }
}

