using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task20T
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ');
            for (int i = 0; i < strings.Count(); i++)
            {
                if (i == strings.Count() - 1) 
                {
                    Console.Write($"{strings[strings.Count() - i- 1]}");
                }
                else 
                {
                    Console.Write($"{strings[strings.Count() - i- 1]} ");
                }
            }
            Console.ReadKey();
        }
    }
}
