using System;

namespace task4D
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int massNum = int.Parse(Console.ReadLine());
            string[] masselementstring = Console.ReadLine().Split(' ');
            int count = 1;
            for (int i = 0; i < massNum - 1; i++)
            {
                if (masselementstring[i] != masselementstring[i + 1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
