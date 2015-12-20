using System;
using System.Collections.Generic;

namespace GOFStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var unsortedList = new List<int>() {8,4,2,4,6,7,3,2};

            //Here the context is made with the BubbleSort strategy
            var intSorter = new IntSorter(new BubbleSort());
            intSorter.Sort(unsortedList);

            unsortedList = new List<int>() {8, 4, 2, 4, 6, 7, 3, 2};
            //Here the context is made with the InsertionSort strategy
            intSorter = new IntSorter(new InsertionSort());
            intSorter.Sort(unsortedList);
        }
    }

    /// <summary>
    /// The strategy context
    /// </summary>
    public class IntSorter
    {
        private readonly ISortStrategy _sortStrategy;

        public IntSorter(ISortStrategy sortStrategy)
        {
            if (sortStrategy == null) throw new ArgumentNullException(nameof(sortStrategy));
            this._sortStrategy = sortStrategy;
        }

        public void Sort(List<int> data)
        {
            Console.WriteLine("Before sort");

            foreach (var num in data)
            {
                Console.Write("{0} ", num);
            }

            Console.WriteLine("");
            _sortStrategy.Sort(data);
            Console.WriteLine("After sort using {0} ", _sortStrategy.GetType());

            foreach (var num in data)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine("");
        }
    }

    /// <summary>
    /// Concrate implemation of a sorting strategy
    /// </summary>
    public class InsertionSort : ISortStrategy
    {
        public override void Sort(List<int> data)
        {
            int i, j;
            var N = data.Count;

            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && data[i] < data[i - 1]; i--)
                {
                    exchange(data, i, i - 1);
                }
            }
        }
    }

    /// <summary>
    /// Concrate implemation of a sorting strategy
    /// </summary>
    public class BubbleSort : ISortStrategy
    {
        public override void Sort(List<int> data)
        {
            int i, j;
            var N = data.Count;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        exchange(data, i, i + 1);
                }
            }
        }
    }

    /// <summary>
    /// The sort strategy interface
    /// </summary>
    public abstract class ISortStrategy
    {
        public void exchange(List<int> data, int m, int n)
        {
            var temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

        public abstract void Sort(List<int> listToSort);
    }
}
