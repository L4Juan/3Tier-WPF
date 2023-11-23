using System;
namespace BusinessLayer
{
    public class HandlerBusiness
    {
		DataLayer.DataHandler dataHandler;
		private string userType;
		public string getUserType() {  return userType; }

		public HandlerBusiness(string id, string pwd)
		{
			dataHandler = new DataLayer.DataHandler();
			userType = dataHandler.CheckLogInDetails(id, pwd);
		}

		public int GetNumOfItems()
        {
			return dataHandler.GetNumOfItems();
        }
        public (string, double, int, string) GetItemData(int i)
        {
			(string, double, int, string) itemData = dataHandler.GetItemData(i);
			return (itemData);
        }
		public int GetItemIndex(string id)
		{
			int itemIndex = dataHandler.GetItemIndex(id);
			return (itemIndex);
		}

		public string AddItem(string id, string price, string stock, string offers)
        {
            if (!dataHandler.Exists(id))
            {
				if (double.TryParse(price, out double doublePrice) && !price.Contains(","))
				{
					if (int.TryParse(stock, out int intStock))
					{
						if (offersIsValid(offers))
                        {
							dataHandler.AddItem(id, doublePrice, intStock, offers);
							return "success";
						}
						
						else { return "offers"; }
					}
                    else { return "stock";  }
                }
				else { return "price"; }
            }
            else { return "id"; }

			
        }
        public bool offersIsValid(string offers)
        {
			if (offers == "")
            {
				return true;
            }
			HashSet<string> validOffers = dataHandler.GetOffers().ToHashSet();
            string[] offersSeparated = offers.Split('\u002C');
			for (int i = 0; i < offersSeparated.Length; i++)
            {
				offersSeparated[i] = offersSeparated[i].Trim();
				if (!validOffers.Contains(offersSeparated[i])) 
				{
					return false;
				}
            }
			return true;
        }
        public bool updateItem(int index, int changeIndex, (string, double, int, string) item)
        {
			if (changeIndex == 0)
            {
                if (!dataHandler.updateItem(index, changeIndex, item))
                {
					return false;
                }
            }
			else if (changeIndex == 1 )
			{
				if (item.Item2 < 0 )
                {
					return false;
                }
            }
			else if (changeIndex  == 2) 
			{
				if (item.Item3 < 0)
				{
					return false;
				}
			}
			else if (changeIndex == 3) 
			{
                if (!offersIsValid(item.Item4))
                {
					return false;
                }
			}
			else { return false; }

			dataHandler.updateItem(index, changeIndex, item);
			return true;
        }
		public void updateValidOffers(string newOffers)
		{
			
		}

        public void DeleteItem(string itemID)
        {
			dataHandler.DeleteItem(itemID);
        }
		public bool IsIdUnique(string id)
        {
			if (dataHandler.Exists(id))
            {
				return false ;
            }
			return true;
        }

        public string[] OutOfStockItems()
        {
			string[] outOfStockItems = dataHandler.OutOfStockItems().ToArray();
			return outOfStockItems;
		}

        public void ReStock()
        {
			dataHandler.ReStock(100);
        }
    }
}
