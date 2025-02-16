using CommandPatternRestaurant.Interface;
using System;

namespace CommandPatternRestaurant.ConcreateClass
{
    public class OnCommand : ICommand
    {
        Tv _tv;

        public OnCommand(Tv tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            Console.WriteLine("Switch On");
            _tv.SwitchOn();
        }
        public void UnExecute()
        {
            Console.WriteLine("Switch Off");
            _tv.SwitchOff();
        }
    }
}
