using ChainOfResponsibilityPattern.Actions;
using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User()
            {
                Id = 1,
                Name = "Akshay",
                Email = "a@a.com",
                RecentDegree = Degree.None,
                Age = 25
            };

            UserAction ua = new UserAction();
            //ua.AddUser1(u);
            ua.AddUser2(u);


            Console.ReadLine();

        }
    }
}
