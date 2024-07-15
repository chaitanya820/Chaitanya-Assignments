using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class question_13
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int largest = (num1 > num2) ? ((num1 > num3) ? num1 : num3) : ((num2 > num3) ? num2 : num3);

            Console.WriteLine($"The largest number is: {largest}");
        }
    }

}
    

