using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Question_18
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the first word: ");
            string v = Console.ReadLine();
          //  v.ToLower();

            string v2=Console.ReadLine();
            //v2.ToLower(); 

            if (v==v2) 
            {
                Console.WriteLine($"The words '{v}' and '{v2}' are the same.");
            }
            else
            {
                Console.WriteLine($"The words '{v}' and '{v2}' are not the same.");
            }

            Console.ReadKey();
        }
    }
        
    
}
