using System.Xml.Linq;

namespace Assignment6
{
    public interface GovtRules
    {
        double EmployeePF(double basicSalary);
        string LeaveDetails();
        double GratuityAmount(float serviceCompleted, double basicSalary);
    }

    public class TCS : GovtRules
    {
        public int empId { get; }
        public string name { get; }
        public string dept { get; }
        public string desg { get; }
        public double basicSalary { get; }

        public TCS(int empId, string name, string dept, string desg, double basicSalar)
        {
            this.empId = empId;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalar;
        }

        public double EmployeePF(double basicSalary)
        {
            double employeePF = basicSalary * 0.12;
            double employerPF = basicSalary * 0.0833;
            double pensionFund = basicSalary * 0.0367;
            return employeePF + employerPF + pensionFund;
        }

        public string LeaveDetails()
        {
            return "1 day of Casual Leave per month\n" +
               "12 days of Sick Leave per year\n" +
               "10 days of Privilege Leave per year";
        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 20)
                return 3 * basicSalary;
            else if (serviceCompleted > 10)
                return 2 * basicSalary;
            else if (serviceCompleted > 5)
                return basicSalary;
            else
                return 0;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("TCS Employee Details are : ");
            Console.WriteLine($"Employee ID: {empId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Department: {dept}");
            Console.WriteLine($"Designation: {desg}");
            Console.WriteLine($"Basic Salary: {basicSalary}");
            Console.WriteLine($"PF Amount: {EmployeePF(basicSalary)}");
            Console.WriteLine($"Leave Details: {LeaveDetails()}");
            Console.WriteLine($"Gratuity Amount: {GratuityAmount(6, basicSalary)}");
        }


    }

    public class Accenture : GovtRules
    {

        public int empId { get; }
        public string name { get; }
        public string dept { get; }
        public string desg { get; }
        public double basicSalary { get; }

        public Accenture(int empId, string name, string dept, string desg, double basicSalar)
        {
            this.empId = empId;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalar;
        }

        public double EmployeePF(double basicSalary)
        {
            return 2 * basicSalary * 0.12;
        }

        public string LeaveDetails()
        {
            return "2 days of Casual Leave per month\n" +
               "5 days of Sick Leave per year\n" +
               "5 days of Privilege Leave per year";
        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Accenture Employee Details are : ");
            Console.WriteLine($"Employee ID: {empId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Department: {dept}");
            Console.WriteLine($"Designation: {desg}");
            Console.WriteLine($"Basic Salary: {basicSalary}");
            Console.WriteLine($"PF Amount: {EmployeePF(basicSalary)}");
            Console.WriteLine($"Leave Details: {LeaveDetails()}");
            Console.WriteLine($"Gratuity Amount: {GratuityAmount(8, basicSalary)}");
        }

    }


    internal class EmployeeDetails
    {
        static void Main(string[] args)
        {
            TCS tcsEmployee = new TCS(1011, "chaitanya varma", "IT", "Developer", 100000);

            tcsEmployee.DisplayDetails();

            Console.WriteLine();


            Accenture accentureEmployee = new Accenture(1123, "subash", "IT", "Technology Manager", 300000);

            accentureEmployee.DisplayDetails();
        }
    }
}