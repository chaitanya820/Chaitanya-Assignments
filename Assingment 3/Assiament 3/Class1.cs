using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiament_3 
{ 

class Building
    {
        
        public string type;
        public string capacity;
        public string dimension;
        public DateTime dateOfCompletion;
        public Building(string type, string capacity, string dimension, DateTime dateOfCompletion)
        {
            this.type = type;
            this.capacity = capacity;
            this.dimension = dimension;
            this.dateOfCompletion = dateOfCompletion;
        }

        public void ShowData()
        {
            Console.WriteLine($"Type: {this.type}");
            Console.WriteLine($"Capacity: {this.capacity}");
            Console.WriteLine($"Dimension: {this.dimension}");
            Console.WriteLine($"Date of Completion: {this.dateOfCompletion.ToShortDateString()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Building flat = new Building("Flat", "2BHK", "Floor 5", new DateTime(2020, 1, 1));
            flat.ShowData();

            Building villa = new Building("Villa", "", "20X30", new DateTime(2019, 6, 15));
            villa.ShowData();
        }
    }



}

