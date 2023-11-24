using System;
namespace DataLayer
{
	public class Order
	{
		public string Details { get; set; }
		public Order(string orderDetails)
		{
			Details = orderDetails;
		}
	}
}

