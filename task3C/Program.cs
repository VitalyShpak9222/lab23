using System;

namespace task3C
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int masscount = int.Parse(Console.ReadLine());
            string[] masselementsstring = Console.ReadLine().Split(' ');
            int[] masselementsint = new int[masscount];
            for (int i = 0; i < masscount; i++)
            {
                masselementsint[i] = int.Parse(masselementsstring[i]);
            }
            int minA = 1000000000;
            int maxA = -1000000000;
            for (int i = 0; i < masscount; i++)
            {
                if (masselementsint[i] > maxA)
                {
                    maxA = masselementsint[i];
                }
                else
                {
                    if (minA > masselementsint[i])
                    {
                        minA = masselementsint[i];
                    }
                }
            }
            Console.WriteLine(minA + "\n" + maxA);
            Console.ReadKey();
        }
    }
}
