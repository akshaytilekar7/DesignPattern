using DelegateDemo;
using System;

namespace ChildProject
{
    public delegate string DelegateAddUser(Employee u);

    public class ChildAction
    {
        public Employee AssignUniqueId(DelegateAddUser myMethodName, Employee e)
        {
            e.Id = 100;
            DelegateAddUser delegateAddUser = myMethodName;
            delegateAddUser.Invoke(e);
            return e;
        }

        public Employee AssignUniqueIdFunc(Func<Employee, string> func, Employee e)
        {
            e.Id = 100;
            var data = func(e);
            return e;
        }


    }
}
