using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assisment_2
{
    internal class Question_1
    {
        class Program
        {
            static void Main()
            {
                Console.Write("Enter the monthly payment: ");
                double monthlyPayment = Convert.ToDouble(Console.ReadLine());

                double initialBalance = 10000; 
                int months = 0;
                double totalPayments = 0;

                while (initialBalance > 0)
                {
                    double interest = initialBalance * 0.015 / 12; 
                    double newBalance = initialBalance - monthlyPayment + interest; 

                    Console.WriteLine($"Month: {months + 1} balance: {newBalance:F2} total payments: {totalPayments:F2}");
                    initialBalance = newBalance; 
                    totalPayments += monthlyPayment;
                    months++; 
                }
            }
        }
    }
}
