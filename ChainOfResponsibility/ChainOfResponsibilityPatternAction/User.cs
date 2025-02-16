namespace ChainOfResponsibilityPatternAction
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public Degree RecentDegree { get; set; }

    }

    public enum Degree
    {
        None = 1,
        Ssc = 2,
        Hsc,
        Graduate,
        PostGraduate
    }
}
