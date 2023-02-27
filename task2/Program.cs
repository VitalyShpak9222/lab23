using System;

namespace task2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int entranceNum = int.Parse(Console.ReadLine());
            int exitNum = 1;
            while (entranceNum > 0)
            {
                exitNum *= entranceNum;
                entranceNum -= 1;
            }
            Console.WriteLine(exitNum);
            Console.ReadKey();
        }
    }
}
