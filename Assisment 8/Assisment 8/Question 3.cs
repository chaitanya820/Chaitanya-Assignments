using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisment_8
{
    internal class Question_3
    {
        class Program
        {
            static void Main(string[] args)
            {

                string logFilePath = "error.txt";


                if (!File.Exists(logFilePath))
                {
                    using (FileStream fs = File.Create(logFilePath)) { }
                }

                try
                {
                    int v = 10;
                    int result = v / 0;
                }
                catch (Exception ex)
                {

                    using (StreamWriter sw = new StreamWriter(logFilePath, true))
                    {
                        sw.WriteLine("Error occurred at: " + DateTime.Now);
                        sw.WriteLine("Error Details: " + ex.Message);
                        sw.WriteLine("------");
                    }
                }
            }
        }
    }
}

