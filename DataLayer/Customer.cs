using System;
namespace DataLayer
{
    public class Customer
    {
        public string Id { get; set; }
        public int Loyalty { get; set; }
        public bool Enabled { get; set; }
        public Customer(string id, int loyalty, bool enabled)
        {
            Id = id;
            Loyalty = loyalty;
            Enabled = enabled;
        }
        
         
        //Todo create functionality for loyalty (get set) (auto check if certain amount of orders)

    }
}

