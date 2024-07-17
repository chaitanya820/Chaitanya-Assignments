using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisment_7 
{ 
  class list
  {
    static void Main(string[] args)
    {
        List< Employee > employees = new List<Employee>();
        employees.Add(new Employee { code = "E01", name = "raju" });
        employees.Add(new Employee { Code = "E02", name = "varma" });

        employees.Sort((x, y) => string.Compare(x.name, y.name));
        foreach (var emp in employees)
        {
            Console.WriteLine($"code{emp.Code},name{emp.name}");
        }
    }

   }
}

 

