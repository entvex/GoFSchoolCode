using System.Collections.Generic;

namespace ObserverPattern
{
    /// <summary>
    /// The ConcreteSubject class
    /// </summary>
    public class StockOption : ISubject
    {
        List<IObserver> _observers = new List<IObserver>();

        public string Name { get; }

        public double Price { get; set; }

        public StockOption(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void UpdatePrice(double price)
        {
            Price = price;
            Notify();
        }

        public void Attach(IObserver observerMe)
        {
                _observers.Add(observerMe);
        }

        public void Detach(IObserver observerMe)
        {
            if (_observers.Contains(observerMe))
            {
                _observers.Remove(observerMe);
            }
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                //Using this because this is a StockOption!
                observer.Update(this);
            }
        }
    }
}