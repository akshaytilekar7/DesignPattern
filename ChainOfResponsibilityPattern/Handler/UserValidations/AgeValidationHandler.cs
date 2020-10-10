using System;

namespace ChainOfResponsibilityPattern.Handler.UserValidations
{
    public class AgeValidationHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            if (user.Age < 18)
            {
                throw new Exception("You have to be 18 years or older");
            }

            base.Handle(user);
        }
    }

    public class AgeValidationHandler1 : UserHandler
    {
        public override void Handle(User user)
        {
            if (user.Age < 18)
            {
                throw new Exception("You have to be 18 years or older");
            }

            base.Handle(user);
        }
    }
}
