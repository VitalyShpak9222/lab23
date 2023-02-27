using System;

namespace task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            short entranceNum = short.Parse(Console.ReadLine());
            int exitNum = 0;
            while (entranceNum > 0)
            {
                exitNum += entranceNum * entranceNum;
                entranceNum -= 1;
            }
            Console.WriteLine(exitNum);
            Console.ReadKey();
        }
    }
}
