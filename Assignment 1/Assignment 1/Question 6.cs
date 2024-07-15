using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Question_6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = FahrenheitToCelsius(fahrenheit);

            Console.WriteLine($"Temperature in Celsius: {celsius}");
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
            

    }
}
