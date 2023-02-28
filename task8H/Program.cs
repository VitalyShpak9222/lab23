using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8H
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            List<int[]> positin = new List<int[]>();
            int[] positinPlayer= new int[2];
            string[] stroka = new string[weight];
            int element = 0; 
            for (int i = 0; i < height; i++)
            {
                stroka = Console.ReadLine().Split(' ');
                for (int k = 0; k < weight; k++)
                {
                    element = int.Parse(stroka[k]);
                    switch (element) 
                    {
                        case 0:
                            continue;
                        case 1:
                            positinPlayer = new int[2] {(height - i + 1), k };
                            continue;
                        case 2:
                            positin.Add(new int[2] { (height - i + 1), k });
                            continue;
                        default:
                            Console.WriteLine("Вы ввели неучтенные числа. Вводиться должны только числа 0,1,2\nПрограмма продолжит работу приравнивая их к 0");
                            continue; 
                    }
                }
            }
            int[][] ints = new int[positin.Count()][];
            for (int i = 0; i < positin.Count(); i++)
            {
                ints[i] = new int[2] { positin[i][0] - positinPlayer[0], positin[i][1] - positinPlayer[1] };
            }
            var orderedNumbers = from i in ints
                                 orderby i[0],i[1] descending
                                 select i;
            foreach (int[] item in ints)
            {
                Console.WriteLine($"{item[0]} {item[1]}");
            }
            Console.ReadKey();
        }
    }
}
