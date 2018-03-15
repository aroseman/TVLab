using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVLab.Wholesaler
{
    abstract class BrandTV: TV
    {
        string getType()
        {
            return "Sony TV";
        }
        public abstract string GetBrand();
       
    }
}
