namespace FactoryMethod
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class GummyBearsEater : CandyEater
    {
        public override Sugar EatSugar()
        {
            return Sugar = new Gummybears();
        }
    }
}