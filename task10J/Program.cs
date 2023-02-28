using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10J
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mera = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int[][] hods = new int[8][] { new int[] {i-2,j+1 }, new int[] { i-1, j+2 },
                new int[] { i+1, j+2 }, new int[] { i+2, j+1 }, new int[] { i+2, j-1 },
                new int[] { i+1, j-2 }, new int[] { i-1, j-2 }, new int[] { i-2, j-1 }, };
            foreach (int[] item in hods)
            {
                if (item[0] <= mera && item[0] > 0 && item[1] <= mera && item[1] > 0) 
                {
                    Console.WriteLine($"{item[0]} {item[1]}");
                }
            }
            Console.ReadKey();
        }
    }
}
