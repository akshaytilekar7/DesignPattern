namespace AbstractFactoryDemo.Models
{
    class Asha : INormal
    {
        public string Name()
        {
            return "Asha";
        }
    }

    class Primo : INormal
    {
        public string Name()
        {
            return "Guru";
        }
    }

    class Genie : INormal
    {
        public string Name()
        {
            return "Genie";
        }
    }
}
