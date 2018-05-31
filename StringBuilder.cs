using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("This is the first sentence.");
            sb.AppendFormat("My name is {0} and I live in {1}", "The Beatles", "Yellow Submarine");
            sb.Replace("a", "e");
            sb.Remove(5, 7);
            Console.WriteLine(sb.ToString());
        }
    }
}
