using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            numList.Clear();
            numList.Add(5);
            numList.Add(15);
            numList.Add(25);

            //add array to list
            int[] randArray = { 1, 2, 3, 4, 5 };
            numList.AddRange(randArray);

            //making list using array
            List<int> numList2 = new List<int>(randArray);
            List<int> numList3 = new List<int>(new int[] { 1, 2, 3, 4 });

            numList.Insert(1, 10);
            numList.Remove(5);
            numList.RemoveAt(2);

            //loop
            for(int x = 0; x < numList.Count; x++)
            {
                Console.WriteLine(numList[x]);
            }

            Console.WriteLine("4 is in the index: " + numList3.IndexOf(4));
            Console.WriteLine("5 in List: " + numList.Contains(5));
            List<string> strList = new List<string>(new string[] { "Tom", "Paul" });
            Console.WriteLine("Tom in list: " + strList.Contains("tom", StringComparer.OrdinalIgnoreCase));
            strList.Sort();


        }
    }
}
