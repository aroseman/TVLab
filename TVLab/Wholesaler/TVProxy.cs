using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVLab.Wholesaler
{
    class TVProxy : TV, TVIF
    {
        public TV tv { get; private set; }
        public TVIF tvIF { get; private set; }

        public TV BuyTV(int budget)
        {
            TV tv = new TV();

            if(budget <= 480 && budget > 450)
            {
                tv = (TV)new SonyUltraHD();
            }
            else if(budget <= 450 && budget > 400)
            {
                tv = (TV)new VizioUltraHD();
            }
            else if(budget <= 400 && budget > 380)
            {
                tv = (TV)new UltraHD();
            }
            else if(budget <= 380 && budget > 350)
            {
                tv = (TV)new SonySmartTV();
            }
            else if(budget <= 350 && budget > 300)
            {
                tv = (TV)new VizioSmartTV();
            }
            else if(budget <= 300 && budget > 280)
            {
                tv = (TV)new SmartTV();
            }
            else if(budget <= 280 && budget > 250)
            {
                tv = (TV)new SonyTV();
            }
            else if(budget <= 250 && budget > 200)
            {
                tv = (TV)new VizioTV();
            }
            else if(budget <= 200 && budget > 0)
            {
                Console.WriteLine("Normal TV");
            }
            else
            {
                return null;
            }
            return tv;
        }

    }

  
}
