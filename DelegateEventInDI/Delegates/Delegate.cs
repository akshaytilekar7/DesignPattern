namespace DelegateEventInDI.Delegates
{
    public delegate void MyCustomDelegate();
    public class Delegate
    {
        public MyCustomDelegate InvertedMember1 { get; set; }
        public MyCustomDelegate InvertedMember2 { get; set; }

        public Delegate(MyCustomDelegate method1, MyCustomDelegate method2)
        {
            this.InvertedMember1 = method1;
            this.InvertedMember2 = method2;
        }

        public void MyMethod()
        {
            this.InvertedMember1();
            this.InvertedMember2();
        }

    }
}
