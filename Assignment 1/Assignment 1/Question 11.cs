using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Question_11
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            long result = 1;
            for (int i = 1; i <= 20; i++)
            {
                result *= num;
            }

            Console.WriteLine($"The multiplication of {num} till 20 is: {result}");
        }
    }
    
}
