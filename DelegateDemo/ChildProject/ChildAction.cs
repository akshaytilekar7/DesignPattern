using DelegateDemo;

namespace ChildProject
{
    public delegate string DelegateAddUser(Employee u);

    public class ChildAction
    {
        public Employee AssignUniqueId(DelegateAddUser myMethodName, Employee e)
        {
            e.Id = 100;
            DelegateAddUser delegateAddUser = new DelegateAddUser(myMethodName);
            delegateAddUser.Invoke(e);
            return e;
        }
    }
}
