using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisment_2
{
    internal class Question_6
    { }
    namespace ShapesExample
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Example usage
                Shapes rect = new Shapes("Rectangle", 5, 10);
                Console.WriteLine($"Name: {rect.Name}, Balance: {rect.Balance}");
                Console.WriteLine($"Area: {rect.Area()}");

                Shapes tri = new Shapes("Triangle", 0, 0, 0);
                Console.WriteLine($"Name: {tri.Name}, Balance: {tri.Balance}");
                Console.WriteLine($"Area: {tri.Area()}");

                Shapes cir = new Shapes("Circle", 0, 0, 0);
                Console.WriteLine($"Name: {cir.Name}, Balance: {cir.Balance}");
                Console.WriteLine($"Area: {cir.Area()}");

                Shapes sqr = new Shapes("Square", 0, 0);
                Console.WriteLine($"Name: {sqr.Name}, Balance: {sqr.Balance}");
                Console.WriteLine($"Area: {sqr.Area()}");
            }
        }

        public class Shapes
        {
            public string Name;
            public double Balance;

            public Shapes(string name, params object[] parameters)
            {
                Name = name;
                switch (name.ToLower())
                {
                    case "rectangle":
                        if (parameters.Length != 2) throw new ArgumentException("Rectangle requires length and width.");
                        Balance = 0;
                        break;
                    case "triangle":
                        if (parameters.Length != 3) throw new ArgumentException("Triangle requires base and height.");
                        Balance = 0;
                        break;
                    case "circle":
                        if (parameters.Length != 3) throw new ArgumentException("Circle requires radius.");
                        Balance = 0;
                        break;
                    case "square":
                        if (parameters.Length != 2) throw new ArgumentException("Square requires side length.");
                        Balance = 0;
                        break;
                    default:
                        throw new ArgumentException("Invalid shape type.");
                }
            }

            public virtual double Area()
            {
                return 0;
            }

            protected virtual double CalculateArea(params object[] parameters)
            {

                return 0;
            }
        }
    }

}