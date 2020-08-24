using ChainOfResponsibilityPattern.Handler.UserValidations;
using System;

namespace ChainOfResponsibilityPattern.Actions
{
    public class UserAction
    {
        public void AddUser1(User user)
        {
            if (!user.Email.Contains("@"))
            {
                throw new Exception("OLD Email is not valid");
            }

            if (user.Age < 18)
            {
                throw new Exception("OLD below 18 age is not allowed ");
            }

            if (user.RecentDegree == Degree.None)
            {
                throw new Exception("OLD We need a post graduates");
            }

            // AddUser to Db operations
            Console.WriteLine("OLD Add user done");
        }

        public void AddUser2(User user)
        {
            var handler = new AgeValidationHandler()
                .SetNext(new NameValidationHandler())
                .SetNext(new AgeValidationHandler())
                .SetNext(new DegreeValidationHandler());


            handler.Handle(user);


            // AddUser to Db operations
            Console.WriteLine("Add user done");

        }

        public void AddUser3(User user)
        {
            var handler = new AgeValidationHandler()
                .SetNext(new NameValidationHandler())
                .SetNext(new AgeValidationHandler())
                .SetNext(new DegreeValidationHandler());


            handler.Handle(user);


            // AddUser to Db operations
            Console.WriteLine("Add user done");

        }
    }
}
