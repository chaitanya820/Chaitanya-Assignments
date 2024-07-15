using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Question_9
    {
        static void Main()
        {

            int num1 = 0;
            int num2 = 1;
            int num3;

            Console.WriteLine("Fibonacci Series up to 40:");


            while (num1 <= 40)
            {
                Console.Write(num1 + " ");


                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
            }

            Console.WriteLine();
        }
    }

}




    




