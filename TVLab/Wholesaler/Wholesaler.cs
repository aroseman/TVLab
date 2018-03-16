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
            TVProxy proxy = new TVProxy();
            return proxy.BuyTV(budget);
        }
        public string ShowTV(TV tv)
        {
            
            string information = tv.GetTypeOfTV() + ": " + tv.Price;
            return information;
        }
    }
}
