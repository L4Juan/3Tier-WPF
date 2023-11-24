using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    internal class Customer
    {
        public string Id { get; set; }
        public string Loyalty { get; set; }
        public string Enabling { get; set; }
        public Customer(string id, int loyalty, bool enabling)
        {
            Id = id.ToString();
            Loyalty = loyalty.ToString();
            if (enabling)
            {
                Enabling = "true";
            }
            else { Enabling = "false"; }

        }
    }
}
