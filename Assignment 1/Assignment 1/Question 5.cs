using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Question_5
    {
        static void Main()
        {
            Console.Write("How many numbers do you want to enter? ");
            int numberInputs = Convert.ToInt32(Console.ReadLine());

            if (numberInputs <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            int evenCount = 0, oddCount = 0;

            for (int i = 0; i < numberInputs; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine($"Total even numbers: {evenCount}");
            Console.WriteLine($"Total odd numbers: {oddCount}");
        }
    }
}
