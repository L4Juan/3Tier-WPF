using System;
namespace DataLayer
{
	public class Item
	{
		private string id;
		private double price;
		private int stock;
		private string offers;
		public Item(string id, double price, int stock, string offers)
		{
			this.id = id;
			this.price = price;
			this.stock = stock;
			this.offers = offers;
		}
		public string GetID() { return id; }
		public double GetPrice() { return price; }
		public int GetStock() { return stock; }
        public string GetOffers() { return offers; }

		//TODO Maybe create an update method that updates all the non null values passed
        public void SetID(string id) { this.id = id; }
		public void SetPrice(double price) { this.price = price; }
        public void SetStock(int stock) { this.stock = stock; }
		public void SetOffers(string offers) { this.offers = offers; }


    }
}

