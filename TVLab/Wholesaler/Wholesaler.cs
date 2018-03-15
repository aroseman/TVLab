using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVLab.Wholesaler
{
    class Wholesaler
    {
        public TV tv { get; private set; }

        public TV BuyTV(int budget)
        {
            return new TV();
        }
        public string ShowTV(TV tv)
        {
            
            string information = tv.GetTypeOfTV() + ": " + tv.Price;
            return information;
        }
    }
}
