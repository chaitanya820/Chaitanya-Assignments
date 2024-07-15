using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Question_15
    {
        static void Main()
        {
            int[] marks = new int[10];
            int sum = 0;
            double average;

            // Accepting marks input
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum += marks[i];
            }

            // Calculating average, minimum, and maximum marks
            average = (double)sum / marks.Length;
            int minMark = marks.Min();
            int maxMark = marks.Max();

            // Displaying results
            Console.WriteLine($"Total: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Minimum Mark: {minMark}");
            Console.WriteLine($"Maximum Mark: {maxMark}");

            // Sorting and displaying marks in ascending and descending order
            Array.Sort(marks);
            Console.WriteLine("Marks in Ascending Order:");
            foreach (var mark in marks)
            {
                Console.WriteLine(mark);
            }

            Array.Sort(marks);
            Array.Reverse(marks);
            Console.WriteLine("\nMarks in Descending Order:");
            foreach (var mark in marks)
            {
                Console.WriteLine(mark);
            }
        }
    }
}






