using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    public interface IMobileBuilder
    {
        void BuildScreen();
        void BuildBattery();
        void BuildOs();
        void BuildStylus();
        Mobile Phone { get; }
    }
}
