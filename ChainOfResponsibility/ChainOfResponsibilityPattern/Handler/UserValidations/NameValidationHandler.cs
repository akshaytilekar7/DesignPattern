using System;

namespace ChainOfResponsibilityPattern.Handler.UserValidations
{
    public class NameValidationHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            if (user.Name.Length <= 1)
            {
                throw new Exception("Your name is unlikely this short.");
            }

            base.Handle(user);
        }
    }
}
