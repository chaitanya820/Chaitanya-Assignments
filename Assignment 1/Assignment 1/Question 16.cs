using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Question_16
    {
        static void Main()
        {
         
            Console.Write("Enter a word: ");

            string userInput = Console.ReadLine();

            int wordLength = userInput.Length;

            Console.WriteLine($"The length of the word '{userInput}' is {wordLength}.");
        }
    }
}
