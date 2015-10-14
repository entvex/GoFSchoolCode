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

            dell.Attach(new StockGuy("Henrik", dell));
            google.Attach(new StockGuy("David", google));
            microsoft.Attach(new StockGuy("Kasper", microsoft));

            dell.Price = (random.Next(70,150) + random.NextDouble());
            google.Price = (random.Next(70, 150) + random.NextDouble());
            microsoft.Price = (random.Next(70, 150) + random.NextDouble());
        }
    }
}
