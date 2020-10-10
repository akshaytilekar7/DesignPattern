namespace ChainOfResponsibilityPattern.Handler
{
    public abstract class Handler<T> where T : class
    {
        private Handler<T> Next { get; set; }

        public virtual void Handle(T request)
        {
            Next?.Handle(request);
        }

        public Handler<T> SetNext(Handler<T> next)
        {
            Next = next;
            return Next;
        }
    }


    public abstract class UserHandler // : IUserHandler
    {
        private UserHandler Next { get; set; }

        public UserHandler SetNext(UserHandler next)
        {
            Next = next;
            return Next;
        }

        public virtual void Handle(User request)
        {
            Next?.Handle(request);
        }
    }


}
