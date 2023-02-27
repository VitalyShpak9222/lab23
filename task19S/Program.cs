using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task19S
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split('.');
            if (strings.Count() != 4)
            {
                Console.WriteLine("NO");
            }
            else 
            {
                bool indef = true;
                for (int i = 0; i < 4; i++)
                {
                    if (int.Parse(strings[i]) < 0 || int.Parse(strings[i]) > 255)
                    {
                        indef = false;
                        break;
                    }
                }
                if (indef == true)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
 
            Console.ReadKey();
        }
    }
}
