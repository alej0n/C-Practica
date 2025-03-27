using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        public double CalculateSalary()
        {
            if (position == "Manager")
            {
                salary = 5000 + (yearsOfExperience * 200);
            }
            else if (position == "Developer")
            {
                salary = 4000 + (yearsOfExperience * 150);
            }
            else
            {
                salary = 3000 + (yearsOfExperience * 100);
            }
            return salary;
        }

        public double CalculateTax()
        {
            return salary * 0.13; // 13% налог
        }
    }
}
