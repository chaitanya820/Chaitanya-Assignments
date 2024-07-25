
using System.IO;

using static Assisment_8.Program;

namespace Assisment_8
{
    internal class Program
    {
        public class Car
        {
            public string Model { get; set; }
            public int YearOfMaking { get; set; }

            public Car(string model, int year)
            {
                Model = model;
                YearOfMaking = year;


                 static void Serialize_Car(Car car, string filePath)
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine($"{car.Model},{car.YearOfMaking}");
                    }
                 }
            }
        }
    }
}

