using ChainOfResponsibilityPatternAction.ExceptionsHelper;
using ChainOfResponsibilityPatternAction.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibilityPatternAction.Actions
{
    public class UserAction
    {
        public void AddUser(User user)
        {
            var dbUsers = new List<User>()
            {
                new User(){Id = 10 }
            };

            var isUserExist = dbUsers.Any(y => y.Id != user.Id);

            var userValidations = new Handler<User>(user)
                .AddNext(x => x.Name.Length > 1, FaultCodes.NameIsNotValid)
                .AddNext(x => x.Age > 18, FaultCodes.AgeShouldBeGreaterThan18)
                .AddNext(x => isUserExist, FaultCodes.UserAlreadyExist)
                .Execute();

            // AddUser to Db operations
            Console.WriteLine("Add user done");

        }


    }
}
