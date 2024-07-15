using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Question_17
    {
        static void main(string[] args)
        {
            Console.Write("Enter a word: ");
            string userInput = Console.ReadLine();

            string reversedWord = ReverseString(userInput);

            Console.WriteLine($"The reverse of '{userInput}' is: {reversedWord}");
        }
        static string ReverseString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
