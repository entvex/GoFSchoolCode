using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            StockOption dell = new StockOption("Dell",100);
            StockOption google = new StockOption("google", 100);
            StockOption microsoft = new StockOption("microsoft", 100);

            StockGuy stockGuy = new StockGuy("Carl");

            dell.Attach(stockGuy);
            google.Attach(stockGuy);
            microsoft.Attach(stockGuy);

            dell.UpdatePrice(random.Next(70,150) + random.NextDouble());
            google.UpdatePrice(random.Next(70, 150) + random.NextDouble());
            microsoft.UpdatePrice(random.Next(70, 150) + random.NextDouble());
        }
    }
}
