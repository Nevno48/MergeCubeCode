using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randNumArray;
            int[] randArray = new int[5];
            int[] randArray2 = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array Length: " + randArray2.Length);
            Console.WriteLine("Item 0: " + randArray2[0]);

            //loops
            for(int x = 0; x < randArray2.Length; x++)
            {
                Console.WriteLine("[{0}:{1}", x, randArray[x]);
            }
            foreach (int num in randArray2)
            {
                Console.WriteLine(num);
            }

            //multi-Dimensional
            int[,] multArray = new int[5, 3];
            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            foreach (int num in multArray2)
            {
                Console.WriteLine(num);
            }
            for(int x = 0; x <  multArray2.GetLength(0); x++)
            {
                for(int y = 0; y < multArray2.GetLength(1); y++)
                {
                    Console.WriteLine("{0} | {1}: {2}", x, y, multArray2[x,y]);
                }
            }

        }
    }
}
