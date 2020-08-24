using System;

namespace ChainOfResponsibilityPattern.Handler.UserValidations
{
    public class EmailValidationHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            if (!user.Email.Contains("@"))
            {
                throw new Exception("email is not valid");
            }

            base.Handle(user);
        }
    }
}
