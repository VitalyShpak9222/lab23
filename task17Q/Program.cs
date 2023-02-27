using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task17Q
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ');
            int maxlen = -10;
            string maxstr = "";
            foreach  (string i in strings)
            {
                if (i.Length > maxlen) 
                {
                    maxlen = i.Length;
                    maxstr = i;
                }
            }
            Console.WriteLine($"{maxstr}\n{maxlen}");
            Console.ReadKey();
        }
    }
}
