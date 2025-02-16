namespace CommandPatternRestaurant
{
    public class Tv
    {
        bool _isOn;
        int _channel;
        public void SwitchOn()
        {
            _isOn = true;
        }
        public void SwitchOff()
        {
            _isOn = false;
        }

        public void SwitchChannel(int channel)
        {
            _channel = channel;
        }
        public bool IsOn()
        {
            return _isOn;
        }
        public int GetChannel()
        {
            return _channel;
        }
    };
}
