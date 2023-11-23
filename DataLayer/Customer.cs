using System;
namespace DataLayer
{
    public class Customer
    {
        private int id;
        private bool loyalty;
        private bool enabled;
        public Customer(int id, bool loyalty, bool enabled)
        {
            this.id = id;
            this.loyalty = loyalty;
            this.enabled = enabled;
        }
        public bool GetEnabled() { return enabled; }
        public void SetEnabled(bool enabled) { this.enabled = enabled; }
         
        //Todo create functionality for loyalty (get set) (auto check if certain amount of orders)

    }
}

