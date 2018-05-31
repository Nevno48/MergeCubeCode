using System;

namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use Ctrl + f5 to run.");
            int integer = 12;
            Console.WriteLine("integer is: " + integer);
            string word = "True or false?";
            Console.WriteLine("Word is: " + word);
            bool result = true;
            Console.WriteLine("result: " + result);
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            //var variable identifies type of variable for you.
            var maxVar = int.MaxValue;
            Console.WriteLine(maxVar);
            Console.WriteLine("maxVar is a {0} " + maxVar.GetTypeCode());
            string numword1 = "21";
            double numword2 = double.Parse(numword1);
            string numword3 = numword2.ToString();
        }
    }
}
