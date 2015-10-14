namespace ObserverPatternPushVariant
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    public interface IObserver
    {
        void Update(Stock stock);
    }
}