using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisment_2
{
    internal class Question_no_7
    {
        public class Student
        {
            
            private int rollNo;
            private string studName;
            private int marksInEng;
            private int marksInMaths;
            private int marksInScience;
            public Student(int rollNo, string studName, int marksInEng, int marksInMaths, int marksInScience)
            {
                this.rollNo = rollNo;
                this.studName = studName;
                this.marksInEng = marksInEng;
                this.marksInMaths = marksInMaths;
                this.marksInScience = marksInScience;
            }
        }


    }
}
