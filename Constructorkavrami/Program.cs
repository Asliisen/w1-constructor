using System;

namespace Constructorkavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Employee employeeOne = new Employee("Asli","Sen",45678,"HR");
     
        employeeOne.GetEmployeeInfo();
        
        Console.WriteLine("*******************");

        Employee employeeTwo = new Employee("Ayse","Kara",4567890,"IT");
        
        employeeTwo.GetEmployeeInfo();
        }
    }


     class Employee
    {
        public string Name;
        public string LastName;
        public int No;
        public string Department;

        public Employee(string name, string lastname, int no, string department)
        {
            this.Name = name;
            this.LastName= lastname;
            this.No= no;
            this.Department= department;

        }

        public Employee(){}


        public void GetEmployeeInfo()
        {
            Console.WriteLine("Name of the employee: {0}",Name);
            Console.WriteLine("Last Name of the employee: {0}",LastName);
            Console.WriteLine("Id of the employee: {0}",No);
            Console.WriteLine("Department of the employee: {0}",Department);
        }
    }
}