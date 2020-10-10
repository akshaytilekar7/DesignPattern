using System;


namespace DelegateDemo
{
    public class EmployeeAction
    {
        public string AddEmployee(Employee u)
        {
            Console.WriteLine("User added" + this.GetType().Name);
            return DateTime.UtcNow.ToLongTimeString();
        }

    }
}
