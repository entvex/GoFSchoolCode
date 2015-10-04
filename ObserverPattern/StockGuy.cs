using System;

namespace ObserverPattern
{
    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    public class StockGuy : IObserver
    {
        private readonly string _name;
        public StockGuy(string name)
        {
            _name = name;
        }

        public void Update(StockOption stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", _name, stock.Name, stock.Price);
        }
    }
}