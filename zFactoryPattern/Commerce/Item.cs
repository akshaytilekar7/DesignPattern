namespace zFactoryPattern.Commerce
{
    public class Item
    {
        private string v1;
        private string v2;
        private decimal v3;

        public Item(string v1, string v2, decimal v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public string Id { get; }
        public string Name { get; }
        public decimal Price { get; }

    }
}