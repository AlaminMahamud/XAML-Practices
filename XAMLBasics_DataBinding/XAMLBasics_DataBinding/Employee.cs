using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLBasics_DataBinding
{
    class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public static Employee getEmployee()
        {
            Employee emp = new Employee()
            {
                Name = "Md. Alamin",
                Title = "Mahamud"
            };

            return emp;
        }
    }
}
