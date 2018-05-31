using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop
            int i = 0;
            while(i < 10)
            {
                if(i == 7)
                {
                    i++;
                    //continue because there is no code
                    continue;
                }
                if(i == 10)
                {
                    break;
                }
                i++;
            }

            //do while
            string guess;
            do
            {
                Console.WriteLine("Guess A number: ");
                guess = Console.ReadLine();
            }
            while(!guess.Equals("15"));

            //for loop
            for(int x = 0; x < 10; x++)
            {
                if(x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            }

            //for each loop
            String randString = "Here is a random String";
            foreach(char c in randString)
            {
                Console.WriteLine(c);
            }
        }
    }
}
