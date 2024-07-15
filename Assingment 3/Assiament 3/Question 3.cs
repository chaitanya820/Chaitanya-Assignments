using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiament_3
{
    public class Shapes
    {
        public double Area(double length, double width)
        {
            return length * width;
        }


        public double Area(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }


        public double Area(double radius)
        {
            return Math.PI * radius * radius;
        }


        public double Area(double sideLength)
        {
            return sideLength * sideLength;
        }


        class Program
        {
            static void Main(string[] args)
            {
                Shapes shapes = new Shapes();

                Console.WriteLine("Rectangle Area:");
                Console.WriteLine(shapes.Area(5, 10));

                Console.WriteLine("\nTriangle Area:");
                Console.WriteLine(shapes.Area(6, 8));

                Console.WriteLine("\nCircle Area:");
                Console.WriteLine(shapes.Area(7));

                Console.WriteLine("\nSquare Area:");
                Console.WriteLine(shapes.Area(9));
            }
        }
    }
}


