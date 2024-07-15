using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisment_2
{               
    internal class Question_3
    {
        class Student
        {
            public int RollNo { get; set; }
            public string Name { get; set; }
            public string Class { get; set; }
            public int Sem { get; set; } 
            public string Branch { get; set; }
            public int[] Marks = new int[5]; 

            public Student(int rollNo, string name, string cls, int sem, string branch)
            {
                RollNo = rollNo;
                Name = name;
                Class = cls;
                Sem = sem;
                Branch = branch;
            }

            public void DisplayData()
            {
                Console.WriteLine($"Roll No.: {RollNo}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Class: {Class}");
                Console.WriteLine($"Semester: {Sem}");
                Console.WriteLine($"Branch: {Branch}");

                Console.WriteLine("Marks:");
                foreach (var mark in Marks)
                {
                    Console.Write($"{mark} ");
                }
                Console.WriteLine();
            }

            public void DisplayResult()
            {
                int totalMarks = 0;
                bool allSubjectsAbove35 = true;

                foreach (var mark in Marks)
                {
                    if (mark < 35)
                    {
                        Console.WriteLine("Failed");
                        return;
                    }
                    totalMarks += mark;
                    allSubjectsAbove35 &= mark >= 35;
                }

                double average = totalMarks / 5.0;
                if (!allSubjectsAbove35 || average < 50)
                {
                    Console.WriteLine("Failed");
                }
                else if (average >= 50)
                {
                    Console.WriteLine("Passed");
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var student = new Student(1, "chaitanya", "10th", 1, "Science");
                student.Marks = new int[] { 45, 55, 65, 75, 85 }; 

                student.DisplayData();
                student.DisplayResult();

                Console.ReadKey();
            }
        }
    }
}
    
     

