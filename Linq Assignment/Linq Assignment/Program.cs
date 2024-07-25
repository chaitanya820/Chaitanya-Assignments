using System;
using System.Linq;

class Program
{
    static void Main()
    {
       
        int[] numbers = { 50, 150, 300, 500, 750, 1200 };

         
        var cubes = numbers.Where(n => n > 100 && n < 1000).Select(n => n * n * n);

        Console.WriteLine("Cubes of numbers between 100 and 1000:");
        foreach (var cube in cubes)
        {
            Console.WriteLine(cube);
        }
        numbers[0] = 200; 
        numbers[5] = 900; 

        var modifiedCubes = numbers.Where(n => n > 100 && n < 1000).Select(n => n * n * n);

        Console.WriteLine("\nModified cubes of numbers between 100 and 1000:");
        foreach (var cube in modifiedCubes)
        {
            Console.WriteLine(cube);
        }
    }
}
