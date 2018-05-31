using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Typecasting");
            double numPi = 3.14;
            int wordPi = (int)numPi;

            Random rand = new Random();
            Console.WriteLine("Random number between 1 and 10 :" + rand.Next(1, 11));

            int age = 17;
            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to Elementary School");

            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to Middle School");

            }
            else
            {
                Console.Write("Go to High School.");
            }
            //assigns the value of canDrive as a value of 1 or 2 depending on the value of the condition
            int canDrive = age >= 16 ? 1 : 0;

            switch(age)
            {
                case 0:
                    Console.WriteLine("infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Go to elementary School.");
                    goto Cute;
                default:
                    Console.WriteLine("Child");
                    break;

            }

            Cute:
            Console.WriteLine("Toddlers are cute");

        }
    }
}