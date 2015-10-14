using System.Collections.Generic;

namespace ObserverPattern
{
    /// <summary>
    /// The ConcreteSubject class
    /// </summary>
    public class StockOption : Subject
    {
        List<IObserver> _observers = new List<IObserver>();
        private double _price;
        public string Name { get; }

        public double Price
        {
            
            get { return _price; }
            set
            {
                _price = value;
                Notify();
            }
        }

        public StockOption(string name, double price)
        {
            Name = name;
            _price = price;
        }
    }
}