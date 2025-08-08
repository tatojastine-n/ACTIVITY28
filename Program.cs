using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualWordReversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Error: No word entered.");
                return;
            }
            Console.Write("Reversed word: ");

            //start from the last character and move backwards
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine(); //for clean output
        }
    }
}
