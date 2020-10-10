using System;

namespace ChainOfResponsibilityPattern.Handler.UserValidations
{
    public class DegreeValidationHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            if (user.RecentDegree == Degree.None)
            {
                throw new Exception("We need a post graduates");
            }

            base.Handle(user);
        }
    }

    public class DegreeValidationHandler1 : UserHandler
    {
        public override void Handle(User user)
        {
            if (user.RecentDegree == Degree.None)
            {
                throw new Exception("We need a post graduates");
            }

            base.Handle(user);
        }
    }
}
