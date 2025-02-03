using BuilderPattern.Builder;

namespace BuilderPattern.Director
{
    public class Manufacturer
    {
        public void ConstructInSequence(IMobileBuilder phoneBuilder)
        {
            phoneBuilder.BuildBattery();
            phoneBuilder.BuildOs();
            phoneBuilder.BuildScreen();
            phoneBuilder.BuildStylus();
        }
    }
}
