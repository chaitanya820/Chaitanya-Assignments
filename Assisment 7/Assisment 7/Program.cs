using System;
using System.Collections.Generic;
namespace Assisment_7
{
    class lists
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter the number" +  (i + 1) +  ":");
                int input_number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(input_number);
            }
            numbers.Sort();
            Console.WriteLine("Numbers in acending order");
            foreach (int number in  numbers)
            {
                Console.WriteLine(number);

            }

        }
    }
}
