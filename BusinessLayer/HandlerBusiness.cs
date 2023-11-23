using System;
namespace BusinessLayer
{
    public class HandlerBusiness
    {
		DataLayer.DataHandler dataHandler;
		private string userType;
		private HashSet<string> validOffers;

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

		public bool AddItem(string id, string price, string stock, string offers)
        {
            if (!dataHandler.Exists(id))
            {
				if (int.TryParse(stock, out int intStock))
                {
					if (double.TryParse(price, out double doublePrice))
                    {
						if (offersIsValid(offers))
                        {
							dataHandler.AddItem(id, doublePrice, intStock, offers);
							return true;
						}
					}
                }
            }

			return false;
        }
        private bool offersIsValid(string offers)
        {

            List<string> offersSeparated = dataHandler.GetOffers();
			for (int i = 0; i < offersSeparated.Count; i++)
            {
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
    }
}
