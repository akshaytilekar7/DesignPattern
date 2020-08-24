namespace BuilderPattern.Product
{
    public class Mobile
    {
        public Mobile(string name)
        {
            PhoneName = name;
        }
        public string PhoneName { get; }

        public ScreenType PhoneScreen { get; set; }

        public Battery PhoneBattery { get; set; }

        public OperatingSystem PhoneOs { get; set; }

        public Stylus PhoneStylus { get; set; }

        // Method to display phone details in our own representation
        public override string ToString()
        {
            return $"\nName: {PhoneName}\nScreen: {PhoneScreen}\nBattery {PhoneBattery}\nOS: {PhoneOs}\nStylus: {PhoneStylus}";
        }
    }
}
