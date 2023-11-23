using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Offer
    {
        private string offer;
        public Offer(string offer) {
            this.offer = offer;
            valid = true;
        }
        public bool valid {get;set;}
        public string GetOffer()
        {
            return offer;
        }
    }
}