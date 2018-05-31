using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //escape sequences
            Console.WriteLine("\' \" \\ \b \n \t ");

            string sampleString = "A bunch of random words";

            Console.WriteLine("hello {0}", sampleString);

            //booelans
            Console.WriteLine("Is empty: " + String.IsNullOrEmpty(sampleString));
            Console.WriteLine("Is empty: " + String.IsNullOrWhiteSpace(sampleString));
            Console.WriteLine("String length: " + sampleString.Length);
            Console.WriteLine("Index of bunch: " + sampleString.IndexOf("bunch"));
            Console.WriteLine("2nd Word: " + sampleString.Substring(2, 6));

            string anotherString = "More random words";

            //comparisons
            Console.WriteLine("Strings Equal " + sampleString.Equals(anotherString));
            Console.WriteLine("Starts with \"A bunch\"" + sampleString.StartsWith("A bunch"));
            Console.WriteLine("Ends with \"words\"" + sampleString.EndsWith("words"));

            //replace indexes
            sampleString = sampleString.Trim();
            sampleString = sampleString.Replace("words", "characters");
            sampleString = sampleString.Remove(0, 2);

            //string array
            string[] names = new string[3] { "Matt", "joe", "paul" };
            Console.WriteLine("Name List" + String.Join(", ", names));

            //format String (in java printf)
            //format into currency
            string fmtStr = String.Format("{0}:c", 1.56);
            //format decimal places( # = automatic 0)
            string fmt2Str = String.Format("{0:00.00}{1:#.000}", 1.567, 12.99999);
        }
    }
}
