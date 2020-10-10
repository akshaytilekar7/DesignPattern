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

            var updatedEmployee1 = childAction.AssignUniqueId(employeeAction.AddEmployee, e); // get Id from child project
            var updatedEmployee2 = childAction.AssignUniqueIdFunc(employeeAction.AddEmployee, e); // get Id from child project

            Console.WriteLine(updatedEmployee1);
            Console.WriteLine(updatedEmployee2);
            Console.WriteLine("Hello World!");


            Func<int> x = new Func<int>(Add);
            Console.WriteLine(x());
            Console.ReadLine();
        }
        public static int Add()
        {
            return (5);
        }
    }
}
// but we can call AddEmployee here,??????
