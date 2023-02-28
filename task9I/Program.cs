using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            int a = int.Parse(nums[1]);
            int b = int.Parse(nums[2]);
            int c = int.Parse(nums[3]);
            int d = int.Parse(nums[4]);
            while (a != b + 1) 
            {
                Console.Write($"{a} ");
                a++;
            }
            while (c != d + 1)
            {
                Console.Write($"{c} ");
                c++;
            }
            Console.ReadKey();
        }
    }
}
