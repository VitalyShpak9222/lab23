using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14N
{
    internal class Program
    {
        private static void Print() 
        {

        }
        static void Main(string[] args)
        {
            string strings;
            int[][]position4 = new int[2][];
            int chet = 0;
            for (int i = 0; i < 2; i++)
            {
                position4[i] = new int[4];
            }
            for (int i = 0; i < 10; i++)
            {
                strings = Console.ReadLine();
                if (strings.IndexOf('4') != -1) 
                {
                    position4[0][chet] = strings.IndexOf("4");
                    position4[1][chet] = i;
                }
            }
            Array.Sort(position4[0]);
            Array.Sort(position4[1]);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{position4[0][i]} {position4[1][i]}");
            }
            Console.ReadKey();
        }
    }
}
