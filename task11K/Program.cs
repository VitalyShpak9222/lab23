using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace task11K
{
    internal class Program
    {
        private static int[][] Multiplication(int[][] matrix, int line, int num) 
        {
            int lenLine = matrix[line].Count();
            int[] newLine= new int[lenLine];
            for (int i = 0; i < lenLine; i++)
            {
                newLine[i] = matrix[line][i] * num;
            }
            matrix[line] = newLine;
            return matrix;
        }

        private static int[][] MovingLine(int[][] matrix, int line1, int line2) 
        {
            int[] newLine = matrix[line2];
            matrix[line2] = matrix[line1];
            for (int i = 0; i < newLine.Count(); i++)
            {
                newLine[i] = -newLine[i];
            }
            matrix[line1] = newLine;
            return matrix;
        }

        private static int[][] DifferenceLine(int[][] matrix, int line1, int line2) 
        {
            for (int i = 0; i < matrix[0].Count(); i++)
            {
                matrix[line1][i]-=matrix[line2][i];
            }
            return matrix;
        }

        private static void PrintMatrix(int[][] matrix) 
        {
            Console.WriteLine("----------------------------------------");
            foreach (int[] item in matrix)
            {
                foreach (int it in item)
                {
                    Console.Write(it.ToString() + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[][] Reader(int h, int w) 
        {
            int[][] matrix = new int[h][];
            string[] line = new string[w];
            for (int i = 0; i < h; i++)
            {
                matrix[i] = new int[w];
                line = Console.ReadLine().Split(' ');
                for (int k = 0; k < w; k++)
                {
                    matrix[i][k] = int.Parse(line[k]);
                }
            }
            return matrix;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту и ширену через enter");
            int height = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            int[][] matrix = new int[height][];
            string[] strings = new string[weight];
            int[] line = new int[weight];
            Console.WriteLine($"Заполните матрицу размерами {height} * {weight}");
            matrix = Reader(height, weight);
            bool indef = false;
            int selected_variation;
            int numLine;
            int num;
            string text = "Все операции выполняются для обновленной матрицы!!!";
            while (indef != true) 
            {
                Console.WriteLine("Выберите операцию согласно ее носеру\n" +
                    "1 - умножение строки на число альфа\n" +
                    "2 - вычитание строки i из строки j\n" +
                    "3 - перестановка строк i,j\n" +
                    "4 - выход");
                selected_variation= int.Parse(Console.ReadLine());
                Console.WriteLine(text.ToUpper());
                switch (selected_variation) 
                {
                    case 1:
                        Console.WriteLine("Введите номер строки");
                        numLine = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите множитель");
                        num = int.Parse(Console.ReadLine());
                        PrintMatrix(Multiplication(matrix, numLine - 1, num));
                        continue;
                    case 2:
                        Console.WriteLine("Введите номер вычитаемой строки");
                        numLine= int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите номер уменьшаемой строки");
                        num = int.Parse(Console.ReadLine());
                        PrintMatrix(DifferenceLine(matrix, num - 1, numLine - 1));
                        continue;
                    case 3:
                        Console.WriteLine("Введите номер первой строки");
                        num= int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите номер второй строки");
                        numLine= int.Parse(Console.ReadLine());
                        PrintMatrix(MovingLine(matrix, num - 1, numLine - 1));
                        continue;
                   case 4:
                        indef = true;
                        continue;
                }
            }
            Console.ReadKey();
        }
    }
}
