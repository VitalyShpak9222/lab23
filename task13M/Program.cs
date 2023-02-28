using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13M
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
                for (int k = 0; k < height; k++)
                {
                    matrix[i, k] = int.Parse(line[k]);
                }
            }
            return matrix;
        }

        private static int[] GetSelectLine(int[,] matrix, int number)
        {
            int[] line = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                line[i] = matrix[number, i];
            }
            return line;
        }

        private static void PrintMatrix(int[,] matrix) 
        {
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write($"{matrix[i,k]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int rankArray = int.Parse(Console.ReadLine());
            string[] lines = Console.ReadLine().Split(' ');
            int numberLines_A = 0;//int.Parse(lines[0]) - 1;
            int numberLines_B = 2;//int.Parse(lines[1]) - 1;
            int[,] matrix = Reader(rankArray, rankArray);
            int[] line_A = GetSelectLine(matrix, numberLines_A);
            int[] line_B = GetSelectLine(matrix, numberLines_B);
            for (int i = 0; i < rankArray; i++)
            {
                matrix[numberLines_A, i] = line_B[i];
                Console.WriteLine($"{matrix[i, numberLines_A]} = {line_B[i]}");
                matrix[numberLines_B, i] = line_A[i];
            }
            PrintMatrix(matrix);
            Console.ReadKey();
        }
    }
}
