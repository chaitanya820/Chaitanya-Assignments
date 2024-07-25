using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisment_8
{
     static void Main(string[] args)
    {
        string userName;
       
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();
            File.AppendAllText("UserNames.txt", userName + Environment.NewLine);

            Console.WriteLine($"Your name has been added to the UserNames.txt file.");
        
    }




}

