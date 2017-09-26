using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                int i, number, fact;
                Console.WriteLine("Welcome to the Facotrial Calculator!");
                Console.WriteLine("Enter an integer that's greater than 0 but less than 10");
                number = int.Parse(Console.ReadLine());
                fact = number;
                for (i = number - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }
                Console.Write("\nFactorial of " + number);
                Console.Write(" is: ");
                Console.WriteLine(fact);
                run = Continue();
            }

            
        }

        public static bool Continue()
        {
            Console.WriteLine("Do you wish to Continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }
            return goOn;
        }

    }
}
