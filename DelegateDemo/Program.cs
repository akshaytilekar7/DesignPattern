using ChildProject;
using System;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee() { Email = "Test@gmail.com" };

            EmployeeAction employeeAction = new EmployeeAction();
            ChildAction childAction = new ChildAction();

            var updatedEmployee = childAction.AssignUniqueId(employeeAction.AddEmployee, e); // get Id from child project

            Console.WriteLine(updatedEmployee);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
// but we can call AddEmployee here,??????
