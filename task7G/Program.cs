using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7G
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] strings = Console.ReadLine().Split(' ');
            int index = int.Parse(Console.ReadLine());
            string str1 = strings[index];
            string str2 = strings[count - index - 1];
            strings[count - index - 1] = str1;
            strings[index] = str2;
            foreach (string item in strings)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
}
