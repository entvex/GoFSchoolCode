namespace ObserverPattern
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    public interface IObserver
    {
        void Update(StockOption stock);
    }
}