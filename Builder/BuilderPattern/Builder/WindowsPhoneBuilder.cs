using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    class WindowsPhoneBuilder : IMobileBuilder
    {
        readonly Mobile _phone;
        Mobile IMobileBuilder.Phone => _phone;

        public WindowsPhoneBuilder()
        {
            _phone = new Mobile("Windows Phone");
        }

        public void BuildBattery() => _phone.PhoneBattery = Battery.MAH_2000;

        public void BuildOs() => _phone.PhoneOs = OperatingSystem.WINDOWS_PHONE;

        public void BuildScreen() => _phone.PhoneScreen = ScreenType.ScreenType_TOUCH_CAPACITIVE;

        public void BuildStylus()
        {
            _phone.PhoneStylus = Stylus.NO;
        }
    }
}
