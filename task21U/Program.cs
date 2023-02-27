using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21U
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string strings = Console.ReadLine();
            strings = strings.ToUpper();
            bool fislo = false;
            int chet = 0;
            foreach (Char item in alfabet)
            {
                strings = strings.Replace(item, ' ');
            }
            string[] strings1 = strings.Split(' ');
            foreach (string item in strings1)
            {
                fislo = false;
                foreach (char i in item)
                {
                    if (i.ToString() != "0") 
                    {
                        fislo = true;
                    }
                }
                if (fislo == true) 
                {
                    chet++;
                }
            }
            Console.WriteLine(chet);
            Console.ReadKey();
        }

    }
}
