using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisment_7
{
    internal class question_2
    {
        class student_lists
        {
            static void Main() 
            {
                List<string> students = new List<string>() { "ravi", "raju", "somu", "kerthi" };
                
                var sorted_students = students.OrderByDescending(n => n);
                Console.WriteLine("sorted list in decending order\n" );
                foreach (string student in sorted_students) ;
                {
                    Console.WriteLine(students + " " );
                }
            }

        }
    }
}
