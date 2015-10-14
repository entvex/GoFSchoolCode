namespace FactoryMethod
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class PantteriEater : CandyEater
    {
        public override Sugar EatSugar()
        {
            return new Pantteri();
        }
    }
}