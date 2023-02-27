using System;
using System.Linq;

namespace task22V
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int magicnum = int.Parse(Console.ReadLine());
            magicnum %= alfabet.Length;
            string text = Console.ReadLine();
            text = text.ToUpper();
            string newchar;
            for (int i = 0; i < text.Length; i++)
            {
                if (alfabet.IndexOf(text[i].ToString()) - magicnum < 0)
                {
                    newchar = alfabet[alfabet.Count() - magicnum + alfabet.IndexOf(text[i])].ToString();
                }
                else 
                {
                    newchar = alfabet[alfabet.IndexOf(text[i]) - magicnum].ToString();
                }
                Console.Write(newchar);
            }
            Console.ReadKey();
        }
    }
}
