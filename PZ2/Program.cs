using System;

namespace EmployeeApp
{
    partial class Employee
    {
        private string lastName;
        private string firstName;
        private string position;
        private double salary;
        private int yearsOfExperience;

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public void SetPositionAndExperience(string position, int yearsOfExperience)
        {
            this.position = position;
            this.yearsOfExperience = yearsOfExperience;
        }


        /*public string Prop_position
        {
            set { position = value; }
        }

        public int Prop_yearsOfExperience;
        {
            set { yearsOfExperience = value; }
        }*/




        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Employee Information:");
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"Salary: {salary:C}");
            Console.WriteLine($"Tax: {CalculateTax():C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Ivanov", "Ivan");
            emp.SetPositionAndExperience("Developer", 6); 

            emp.CalculateSalary();
            emp.DisplayEmployeeInfo();

            Console.ReadKey();
        }
    }
}
