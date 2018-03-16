using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVLab.Retailer
{
    class Retailer
    {
        

        public static Wholesaler.Wholesaler WS1 = new Wholesaler.Wholesaler();

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your budget?");
            int budget = Convert.ToInt32(Console.ReadLine());
            WS1.BuyTV(budget);

            Console.ReadLine();
        }
    }
}
