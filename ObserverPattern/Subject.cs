using System.Collections.Generic;
using System.Net.Mail;

namespace ObserverPattern
{  /// <summary>
   /// The Subject interface
   /// </summary>
    public abstract class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();

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
                observer.Update();
            }
        }
    }
}