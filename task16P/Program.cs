using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task16P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "qwertyuiopasdfghjklzxcvbnm";
            string[] strings = Console.ReadLine().Split(' ');
            int countworlds = 0;
            bool indef = false;
            foreach (string item in strings)
            {
                if (item.Count() == 2 && alphabet.IndexOf(item.ToLower()[0]) != -1 && alphabet.IndexOf(item.ToLower()[1]) != -1) 
                {
                    countworlds++;
                }
                indef = false;
                for (int i = 0; i < item.Count() - 2; i++)
                {
                    if (alphabet.IndexOf(item.ToLower()[i]) == -1 && alphabet.IndexOf(item.ToLower()[i+1]) != -1 && alphabet.IndexOf(item.ToLower()[i+2]) != -1) 
                    {
                        countworlds++;
                    }
                    if (indef == false && alphabet.IndexOf(item.ToLower()[0]) != -1 && alphabet.IndexOf(item.ToLower()[i + 1]) != -1 && alphabet.IndexOf(item.ToLower()[i+2]) != -1)
                    {
                        countworlds++;
                        indef = true;
                    }
                }
            }
            Console.WriteLine(countworlds);
            Console.ReadKey();
        }
    }
}
