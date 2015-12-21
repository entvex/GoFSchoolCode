using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsorted = new List<int>() {5,3,2,5,7,4,2,1};
            IntBubble intBubbule = new IntBubble();

            Console.WriteLine("Before sort");
            foreach (var num in unsorted)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine("");

            intBubbule.Sort(unsorted);

            Console.WriteLine("After sort using {0} ", intBubbule.GetType());

            foreach (var num in unsorted)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine("");
        }
    }

    /// <summary>
    /// This is the template that contains the essential methods to be used by bubblesort.
    /// </summary>
    public abstract class BubbleSorterTemplated
    {
        public void swap<T>(List<T> data, int m, int n)
        {
            var temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
    }

    /// <summary>
    /// This class uses the template methods but it 
    /// </summary>
    public class IntBubble : BubbleSorterTemplated
    {
        public void Sort(List<int> data)
        {
            int i, j;
            var N = data.Count;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        swap(data, i, i + 1);
                }
            }
        }
    }
}