namespace Assisment_5
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Furniture chair = new Chair();
            chair.GetData();
            chair.ShowData();

            Furniture cot = new Cot();
            cot.GetData();
            cot.ShowData();
        }
    }

    abstract class Furniture
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string FurnitureType { get; set; }
        public int Qty { get; set; }
        public decimal TotalAmt { get; set; }
        public string PaymentMode { get; set; }

        public virtual void GetData()
        {
            Console.WriteLine("Enter Order ID:");
            OrderId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Order Date (MM/DD/YYYY):");
            OrderDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity:");
            Qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Total Amount:");
            TotalAmt = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Payment Mode (Credit/Debit Card):");
            PaymentMode = Console.ReadLine();
        }

        public virtual void ShowData()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Order Date: {OrderDate.ToShortDateString()}");
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine($"Total Amount: {TotalAmt}");
            Console.WriteLine($"Payment Mode: {PaymentMode}");
        }
    }

    class Chair : Furniture
    {
        public enum ChairMaterial { Wood, Steel, Plastic }
        public enum ChairPurpose { Home, Office }
        public ChairMaterial Material { get; set; }
        public ChairPurpose Purpose { get; set; }
        public string WoodType { get; set; } 
        public string SteelType { get; set; }
        public string PlasticColor { get; set; }
        public decimal Rate { get; set; }

        public override void GetData()
        {
            base.GetData();
            Console.WriteLine("Enter Chair Type (Wood/Steel/Plastic):");
            Material = (ChairMaterial)Enum.Parse(typeof(ChairMaterial), Console.ReadLine().ToUpper(), true);
            Console.WriteLine("Enter Chair Purpose (Home/Office):");
            Purpose = (ChairPurpose)Enum.Parse(typeof(ChairPurpose), Console.ReadLine().ToUpper(), true);
            switch (Material)
            {
                case ChairMaterial.Wood:
                    Console.WriteLine("Enter Wood Type (Teak Wood/Rose Wood):");
                    WoodType = Console.ReadLine();
                    break;
                case ChairMaterial.Steel:
                    Console.WriteLine("Enter Steel Type (Gray Steel/Green Steel/Brown Steel):");
                    SteelType = Console.ReadLine();
                    break;
                case ChairMaterial.Plastic:
                    Console.WriteLine("Enter Plastic Color (Green/Red/Blue/White):");
                    PlasticColor = Console.ReadLine();
                    break;
            }
            Console.WriteLine("Enter Rate:");
            Rate = Convert.ToDecimal(Console.ReadLine());
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Chair Type: {Material}");
            Console.WriteLine($"Purpose: {Purpose}");
            if (Material == ChairMaterial.Wood)
            {
                Console.WriteLine($"Wood Type: {WoodType}");
            }
            else if (Material == ChairMaterial.Steel)
            {
                Console.WriteLine($"Steel Type: {SteelType}");
            }
            else if (Material == ChairMaterial.Plastic)
            {
                Console.WriteLine($"Plastic Color: {PlasticColor}");
            }
            Console.WriteLine($"Rate: {Rate}");
        }
    }

    class Cot : Furniture
    {
        public enum CotMaterial { Wood, Steel }
        public enum CotCapacity { Single, Double }
        public CotMaterial Material { get; set; }
        public CotCapacity Capacity { get; set; }
        public decimal Rate { get; set; }

        public override void GetData()
        {
            base.GetData();
            Console.WriteLine("Enter Cot Type (Wood/Steel):");
            Material = (CotMaterial)Enum.Parse(typeof(CotMaterial), Console.ReadLine().ToUpper(), true);
            Console.WriteLine("Enter Capacity (Single/Double):");
            Capacity = (CotCapacity)Enum.Parse(typeof(CotCapacity), Console.ReadLine().ToUpper(), true);
            Console.WriteLine("Enter Rate:");
            Rate = Convert.ToDecimal(Console.ReadLine());
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Cot Type: {Material}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Rate: {Rate}");
        }
    }

}
