using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    public interface IPhoneBuilder
    {
        void BuildScreen();
        void BuildBattery();
        void BuildOs();
        void BuildStylus();
        Mobile Phone { get; }
    }
}
