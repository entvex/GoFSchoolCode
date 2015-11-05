using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethodtester();
        }

        private static void FactoryMethodtester()
        {
            List<CandyEater> candyEaters = new List<CandyEater>();

            candyEaters.Add(new ChikkiEater());
            candyEaters.Add(new GummyBearsEater());
            candyEaters.Add(new PantteriEater());

            foreach (var candyEater in candyEaters)
            {
                Console.WriteLine(candyEater.GetType());
                candyEater.DisplayEatenSuger();
                Console.WriteLine();
            }

        }
    }
}
