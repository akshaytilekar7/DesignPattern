using BuilderPattern.Builder;

namespace BuilderPattern.Director
{
    public class Manufacturer
    {
        public void ConstructInSequence(IPhoneBuilder phoneBuilder)
        {
            phoneBuilder.BuildBattery();
            phoneBuilder.BuildOs();
            phoneBuilder.BuildScreen();
            phoneBuilder.BuildStylus();
        }
    }
}
