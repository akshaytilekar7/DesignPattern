using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    class AndroidPhoneBuilder : IMobileBuilder
    {
        readonly Mobile _phone;
        Mobile IMobileBuilder.Phone => _phone;

        public AndroidPhoneBuilder()
        {
            _phone = new Mobile("Android Phone");
        }

        public void BuildBattery() => _phone.PhoneBattery = Battery.MAH_1500;

        public void BuildOs() => _phone.PhoneOs = OperatingSystem.ANDROID;

        public void BuildScreen() => _phone.PhoneScreen = ScreenType.ScreenType_TOUCH_RESISTIVE;

        public void BuildStylus() => _phone.PhoneStylus = Stylus.YES;
    }
}
