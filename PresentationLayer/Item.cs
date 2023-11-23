namespace PresentationLayer
{
    public class Item
    {
        public Item(string id, double price, int stock, string offers)
        {
            Id = id;
            Price = price.ToString();  
            Stock = stock.ToString();
            Offers = offers;
        }
        public string Id { get; set; }
        public string Price { get; set; }
        public string Stock { get; set; }
        public string Offers { get; set; }
    }
        
}
