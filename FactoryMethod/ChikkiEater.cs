namespace FactoryMethod
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ChikkiEater : CandyEater
    {
        public override Sugar EatSugar()
        {
            return new Chikki();
        }
    }
}