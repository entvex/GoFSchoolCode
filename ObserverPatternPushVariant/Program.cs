using System;

namespace ObserverPatternPushVariant
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            StockConcrete dell = new StockConcrete("Dell",100);
            StockConcrete google = new StockConcrete("google", 100);
            StockConcrete microsoft = new StockConcrete("microsoft", 100);

            dell.Attach(new StockGuy("Henrik"));
            google.Attach(new StockGuy("David"));
            microsoft.Attach(new StockGuy("Kasper"));

            dell.Price = (random.Next(70,150) + random.NextDouble());
            google.Price = (random.Next(70, 150) + random.NextDouble());
            microsoft.Price = (random.Next(70, 150) + random.NextDouble());
        }
    }
}
