using BuilderPattern.Builder;

namespace BuilderPattern.Director
{
    public class Manufacturer
    {
        public void Build(IMobileBuilder phoneBuilder)
        {
            phoneBuilder.BuildBattery();
            phoneBuilder.BuildOs();
            phoneBuilder.BuildScreen();
            phoneBuilder.BuildStylus();
        }
    }
}
