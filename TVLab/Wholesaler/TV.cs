using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVLab.Wholesaler
{
     class TV
    {
        public int Price { get; private set; }

        int getPrice()
        {
            return Price;
        }

        public string GetTypeOfTV()
        {
            return "TV";
        }
    }
}
