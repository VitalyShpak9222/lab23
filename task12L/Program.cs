using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12L
{
    internal class Program
    {
        private static int[,] Reader(int height, int weight) 
        {
            Console.WriteLine($"Заполните матрицу размерностью {height} * {weight}");
            int[,] matrix = new int[height, weight];
            string[] line = new string[weight];
            for (int i = 0; i < height; i++)
            {
                line = Console.ReadLine().Split(' ');
                for (int k = 0; k < weight; k++)
                {
                    matrix[i, k] = int.Parse(line[k]);
                }
            }
            return matrix;
        }

        private static int[] GetSelectColumn(int[,] matrix, int number) 
        {
            int[] column = new int[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                column.Append(matrix[number, i]);
            }
            return column;
        }

        private static int[] GetSelectLine(int[,] matrix, int number) 
        {
            int[] line = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                line[i] = matrix[i, number];
            }
            return line;
        }

        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            int[,] matrix = Reader(height, weight);
            int[] column = new int[height];
            int[] line = new int[weight];
            int indexMax;
            int indexMin;
            List<int[]> position = new List<int[]>();
            for (int i = 0; i < weight; i++)
            {
                column = GetSelectColumn(matrix, i);
                indexMax = Array.IndexOf(column, column.Max());
                line = GetSelectLine(matrix, indexMax);
                indexMin = Array.IndexOf(line, line.Min());
                if (indexMin == i)
                {
                    position.Add(new int[] {indexMin, indexMax + 1 });
                }
            }
            if (position.Count() == 0)
            {
                Console.WriteLine(0);
            }
            else 
            {
                foreach (int[] array in position)
                {
                    Console.WriteLine($"{array[0]} {array[1]}");
                }
            }
            Console.ReadKey();
        }
    }
}
