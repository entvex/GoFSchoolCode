namespace ObserverPatternPushVariant
{
    /// <summary>
    ///     The ConcreteSubject class
    /// </summary>
    public class StockConcrete : Stock
    {
        public StockConcrete(string name, double price)
            : base(price, name)
        {
        }
    }
}