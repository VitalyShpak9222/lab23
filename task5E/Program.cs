using System;

namespace task5E
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int lenvector = int.Parse(Console.ReadLine());
            int skalar = 0;
            string[] vector1 = Console.ReadLine().Split(' ');
            string[] vector2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < lenvector; i++)
            {
                skalar += int.Parse(vector1[i]) * int.Parse(vector2[i]);
            }
            Console.WriteLine(skalar);
            Console.ReadKey();
        }
    }
}
