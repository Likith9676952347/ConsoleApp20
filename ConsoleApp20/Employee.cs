using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
   public class Employee : Department
    {
        public string GetEmployeeFirstName()
        {
            return "LUCIFER";
        }

        public string GetEmployeeLastName()
        {
            return "Lkith";
        }

        public override string GetDepartmentDetails()
        {
            return "B-TECH";
        }
        public static void Main(string[] args)
        {
            Department department = new Department();
            Department employee = new Employee();
            Console.WriteLine(department.GetDepartmentDetails()); //calling method of base class
            Console.WriteLine(employee.GetDepartmentDetails()); //calling method of child class, example of polymorphism 
            Console.ReadKey();
        }
    }
}
