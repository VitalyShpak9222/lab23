using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task15O
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringg = Console.ReadLine();
            int polovinacount = (stringg.Count() / 2) - (stringg.Count()/2)%1;
            bool indeef = false;
            for (int i = 0; i < polovinacount; i++)
            {
                if (stringg[i].CompareTo(stringg[stringg.Count() - 1 - i]) != 0) 
                {
                    indeef = true;
                    break;
                }
            }
            if (indeef)
            {
                Console.WriteLine("NO");
            }
            else 
            {
                Console.WriteLine("YES");
            }
            Console.ReadKey();
        }
    }
}
