using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Question_4
    {
        static void Main()
        {
            Console.WriteLine("enter the number: ");
            int number = Int32.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("your number is even");
            }
            else {
                Console.WriteLine("your number is odd");
            }

        }
    }
}
