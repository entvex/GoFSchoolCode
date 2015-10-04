using System.Net.Mail;

namespace ObserverPattern
{  /// <summary>
   /// The Subject interface
   /// </summary>
    public interface ISubject
    {
        void Attach(IObserver observerMe);
        void Detach(IObserver observerMe);
        void Notify();
    }
}