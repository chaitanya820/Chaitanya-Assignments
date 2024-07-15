using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Question_10
    {
        static void Main()
        {

            Console.Write("Enter an integer N: ");
            int N;
            if (int.TryParse(Console.ReadLine(), out N))
            {
                int sumOfCubes = 0;
                for (int i = 1; i <= N; i++)
                {
                    sumOfCubes += (int)Math.Pow(i, 3);
                }
                Console.WriteLine($"The sum of cubes from 1 to {N} is {sumOfCubes}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }
    }
    
}
