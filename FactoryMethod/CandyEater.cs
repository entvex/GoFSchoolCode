using System;

namespace FactoryMethod
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    public abstract class CandyEater
    {
        public CandyEater()
        {
            Sugar = EatSugar();
        }


        public Sugar Sugar { get; set; }

        //FactoryMethod see overrides in ChikkiEater, GummyBearsEater and PantteriEater.
        public abstract Sugar EatSugar();

        public void DisplayEatenSuger()
        {
            Console.WriteLine(Sugar.GetType().ToString());
        }
    }

}



