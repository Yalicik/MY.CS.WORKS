using System;

namespace ALLAHDIYENTURBISON
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are signed up!");
            }
            else
            {
                Console.WriteLine("You must be at least 18 yeras old to sign up.");
            }

            Console.ReadKey();
        }
    }
}
