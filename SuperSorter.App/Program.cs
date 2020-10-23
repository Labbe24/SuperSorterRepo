using System;
using System.Diagnostics;
using System.Threading;
using SuperSorter.App.ArrayStrageties;
using SuperSorter.App.SortingStrageties;
using SuperSorter.App.StopWatch;

namespace SuperSorter.App
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperSorter superSorter = new SuperSorter();
            ArrayGenerator arrayGenerator = new ArrayGenerator();
            SortingStopwatchMilliseconds sortingStopwatch = new SortingStopwatchMilliseconds();

            superSorter.SortStrategy = new QuickSort();
            arrayGenerator.ArrayStrategy = new CompletelyRandom();

            int[] arr = arrayGenerator.GenerateArray(50, 200, 1);

            Console.WriteLine("[{0}]", string.Join(", ", arr));

            sortingStopwatch.Start();
            int[] sortedarr = superSorter.Sort(arr);
            double elapsedTime = sortingStopwatch.Stop();

            Console.WriteLine("[{0}]", string.Join(", ", sortedarr));
            Console.WriteLine(superSorter.SortStrategy.GetType().ToString());
            Console.WriteLine("Elapsed time: {0:R}", elapsedTime);

        }
    }
}
