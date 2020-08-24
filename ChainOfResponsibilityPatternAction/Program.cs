using ChainOfResponsibilityPatternAction.Actions;
using System;

namespace ChainOfResponsibilityPatternAction
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User()
            {
                Id = 10,
                Name = "aaa",
                Email = "a@a.com",
                RecentDegree = Degree.None,
                Age = 25
            };

            UserAction ua = new UserAction();
            ua.AddUser(u);


            Console.ReadLine();

        }
    }
}
