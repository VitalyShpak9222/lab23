using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] masselement = Console.ReadLine().Split(' ');
            string[] del = Console.ReadLine().Split(' ');
            int a = int.Parse(del[0]);
            int b = int.Parse(del[1]);
            int sum = 0;
            List<int> ints = new List<int>();
            while (a != b) 
            {
                ints.Add(b-1);
                b--;
            }
            for (int i = 0; i < ints.Count(); i++)
            {
                sum+= int.Parse(masselement[ints[i]]);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
