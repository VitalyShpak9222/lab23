using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task18R
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringg = Console.ReadLine();
            string notusingchar = Console.ReadLine();
            for (int i = 0; i < notusingchar.Count(); i++)
            {
                stringg = stringg.Replace(notusingchar[i], '*');
            }
            Console.WriteLine(stringg);
            Console.ReadKey();
        }
    }
}
