using CommandPatternRestaurant.Interface;
using System;

namespace CommandPatternRestaurant.ConcreateClass
{
    public class SwitchCommand : ICommand
    {
        Tv _tv;
        int _oldChannel;
        int _newChannel;

        public SwitchCommand(Tv tv, int channel)
        {
            _tv = tv;
            _newChannel = channel;
        }

        public void Execute()
        {
            if (!_tv.IsOn())
            {
                Console.WriteLine("tv is off, can't change channel");
                return;
            }

            Console.WriteLine("switch channel to : " + _newChannel);
            _oldChannel = _tv.GetChannel();
            _tv.SwitchChannel(_newChannel);
        }

        public void Undo()
        {
            if (!_tv.IsOn())
            {
                Console.WriteLine("tv is off, can't change channel");
                return;
            }
            _tv.SwitchChannel(_oldChannel);
        }

        public void Redo()
        {
            if (!_tv.IsOn())
            {
                Console.WriteLine("tv is off, can't change channel");
                return;
            }
            _tv.SwitchChannel(_newChannel);
        }
    };
}
