﻿using System.Windows;
namespace DataLayer
{
	public class DataHandler
	{
		private List<LogInDetails> logInDetails = new List<LogInDetails>();
        private List<Item> items;
        private List<Offer> offers;
        public List<Message> messages = new List<Message>();
        public List<Customer> customers = new List<Customer>();
        public List<Order> orders = new List<Order>();
		public DataHandler()
		{
			for(int i = 0; i < 4; i++)
            {
				logInDetails.Add(new LogInDetails(i.ToString(), "pass"));
            }
            logInDetails[0].MakeAdmin();

            items = new List<Item>() {
                new Item("apple", 1.5, 300, "3 for 2"),
                new Item("bread", 0.9, 30, "20%"),
                new Item("water", 1, 1000, "2 for 1"),
                new Item("banana", 0.5, 0, "")
            };

            offers = new List<Offer>() {
                new Offer("2 for 1"),
                new Offer("3 for 1"),
                new Offer("20%")
            };

            foreach (LogInDetails l in logInDetails)
            {
                if (!l.IsAdmin())
                {
                    customers.Add(new Customer(l.GetID(), 0, false));
                }
            }
        }
        public List<string> GetOrders()
        {
            List<string> os = new List<string>();
            foreach (Order o in orders)
            {
                os.Add(o.Details.ToString());
            }
            return os;
        }
        public void PlaceOrder(string v)
        {
            orders.Add(new Order(v));
        }

        public (string, int, bool) GetCustomerData(int i)
        {
            return (customers[i].Id, customers[i].Loyalty, customers[i].Enabled);
        }

        public int GetNumOfCustomers()
        {
            return customers.Count;
        }

        public string[] GetMessages()
        {
            List<string> msgs = new List<string>();
            foreach (Message message in messages)
            {
                msgs.Add(message.MessageContent);
            }
            return msgs.ToArray();
        }

        public int GetNumOfItems()
        {
            return items.Count;
        }

        public (string, double, int, string) GetItemData(int i)
        {
            Item item = items[i];
            return (item.GetID(), item.GetPrice(), item.GetStock(), item.GetOffers());
        }
        public int GetItemIndex(string id)
        {
            for (int i=0; i<items.Count; i++)
            {
                if (items[i].GetID() == id)
                {
                    return i;
                }
            }
            return -1;
            
        }

        public void UpdateCustomer(string? id, string? value)
        {
            for (int i =0; i < customers.Count; i++)
            {
                if (customers[i].Id == id)
                {
                    if (int.TryParse(value, out int v))
                    {
                        customers[i].Loyalty = v;
                    }
                    else 
                    {
                        if (value == "true")
                        {
                            customers[i].Enabled = true;
                        }
                        else { customers[i].Enabled = false; }
                    }
                }
            }
        }

        public bool Exists(string id)
        {
            foreach (Item item in items)
            {
                if (item.GetID() == id)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddItem(string id, double price, int stock, string offers)
        {
            items.Add(new Item(id, price, stock, offers));
        }

		public string CheckLogInDetails(string id, string pwd)
        {
			if(logInDetails.Count == 0)
            {
				return "";
            }
			foreach (LogInDetails log in logInDetails)
            {
				if (log.GetID() == id)
                {
					if (log.GetPwd() == pwd)
                    {
                        if (log.IsAdmin())
                        {
                            return "admin";
                        }
                        return "customer";
                    }
                }
            }
            return "";
        }

        public bool updateItem(int i, int changeIndex, (string, double, int, string) newItem)
        {
            if (changeIndex == 0)
            {
                foreach (Item item in items)
                {
                    if (newItem.Item1 == item.GetID())
                    {
                        return false;
                    }
                }
                items[i].SetID(newItem.Item1);
            }
            else if (changeIndex == 1)
            {
                
                items[i].SetPrice(newItem.Item2);
                
            }
            else if (changeIndex == 2)
            {
              
                items[i].SetStock(newItem.Item3);
                
            }
            else if (changeIndex == 3)
            {
                items[i].SetOffers(newItem.Item4);
            }
            return true;

            
        }

        public bool LowStockItems()
        {
            messages.Clear();
            bool r = false;
            foreach(Item item in items)
            {
                if (item.GetStock() < 10 && item.GetStock() != 0)
                {
                    messages.Add(new Message($"Message: {item.GetID()} is low in stock"));
                    r = true;
                }
            }
            return r;
        }

        public void ReStock(int v)
        {
            foreach(Item item in items)
            {
                if (item.GetStock() == 0)
                {
                    item.SetStock(v);
                }
            }
        }

        public List<string> OutOfStockItems()
        {
            List<string> outOfStockItems = new List<string>();

            foreach(Item item in items)
            {
                if (item.GetStock() == 0)
                {
                    outOfStockItems.Add(item.GetID());
                }
            }
            return outOfStockItems;
        }

        public List<string> GetOffers()
        {
            List<string> returnOffers = new List<string>();
        
            foreach (Offer o in offers)
            {
                returnOffers.Add(o.GetOffer());
            }
            if(returnOffers != null){
                return returnOffers;
            }
            return null;
            
        }

        public bool updateValidOffers()
        {
            return true;
        }

        public void DeleteItem(string itemID)
        {
            foreach (Item i in items)
            {
                if (i.GetID() == itemID)
                {
                    items.Remove(i);
                    return;
                }
            }
        }
    }
}

