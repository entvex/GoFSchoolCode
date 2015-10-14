using System;

namespace ObserverPattern
{
    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    public class StockGuy : IObserver
    {
        private readonly string _name;
        private readonly StockOption _stockOption;

        public StockGuy(string name, StockOption stock)
        {
            _name = name;
            _stockOption = stock;
        }

        public void Update()
        {
            Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", _name, _stockOption.Name, _stockOption.Price);
        }
    }
}