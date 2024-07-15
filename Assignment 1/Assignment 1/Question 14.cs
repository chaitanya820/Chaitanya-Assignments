using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Question_14
    {
        static void Main()
        {

            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fifth number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());


            int smallestNumber = Math.Min(num1, Math.Min(num2, Math.Min(num3, Math.Min(num4, num5))));


            Console.WriteLine($"The smallest number is: {smallestNumber}");
        }
    }
}



