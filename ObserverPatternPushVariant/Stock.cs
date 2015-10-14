using System.Collections.Generic;

namespace ObserverPatternPushVariant
{
    /// <summary>
    ///     The Subject interface
    /// </summary>
    public abstract class Stock
    {
        private readonly string _name;
        private readonly List<IObserver> _observers = new List<IObserver>();
        private double _price;

        public Stock(double price, string name)
        {
            _price = price;
            _name = name;
        }

        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
                Notify();
            }
        }

        public string Name
        {
            get { return _name; }
        }


        public void Attach(IObserver observerMe)
        {
            if (!_observers.Contains(observerMe))
            {
                _observers.Add(observerMe);
            }
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
                observer.Update(this);
            }
        }
    }
}