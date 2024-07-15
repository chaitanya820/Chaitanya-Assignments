using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Question_8
    {
        static void Main()
        {
            Console.Write("Enter a positive integer: ");
            int num = Convert.ToInt32(Console.ReadLine());


            if (num < 0)
            {
                Console.WriteLine("Factorial of a negative number doesn't exist.");
            }
            else
            {
                long factorial = CalculateFactorial(num);
                Console.WriteLine($"The factorial of {num} is {factorial}");
            }
        }

        static long CalculateFactorial(int n)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
