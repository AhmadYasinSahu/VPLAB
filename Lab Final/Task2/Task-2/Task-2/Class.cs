namespace Task_2
{
    public class server
    {
        public string Name { get; set; }
        public string Gategory { get; set; }
        public float Price { get; set; }

        server(string name, string gategory, float price)
        {
            Name = name;
            Gategory = gategory;
            Price = price;
        }
    }
}
