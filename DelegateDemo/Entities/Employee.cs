namespace DelegateDemo
{
    public class Employee
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public override string ToString()
        {
            return Id + " " + Email;
        }
    }
}
