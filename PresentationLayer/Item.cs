namespace PresentationLayer
{
    public class Item
    {
        public Item(string id, double price, int stock, string offers)
        {
            Id = id;
            Price = price;  
            Stock = stock;
            Offers = offers;
        }
        public string Id { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Offers { get; set; }
    }
        
}
