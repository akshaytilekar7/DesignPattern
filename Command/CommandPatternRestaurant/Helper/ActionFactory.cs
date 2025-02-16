using CommandPatternRestaurant.ConcreateClass;
using CommandPatternRestaurant.Interface;

namespace CommandPatternRestaurant.Helper
{
    public enum Status
    {
        On = 1,
        Off = 2,
        Switch = 3
    }
    public class ActionFactory
    {
        Tv tv;
        public ActionFactory(Tv tv)
        {
            this.tv = tv;
        }
        public ICommand Get(Status status, int ch = 0)
        {
            switch (status)
            {
                case Status.On:
                    return new OnCommand(tv);
                case Status.Off:
                    return new OffCommand(tv);
                case Status.Switch:
                    return new SwitchCommand(tv, ch);
                default:
                    return null;
            }
        }
    }
}
