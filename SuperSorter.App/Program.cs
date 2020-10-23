using System;
using System.Diagnostics;
using System.Threading;
using SuperSorter.App.ArrayStrageties;
using SuperSorter.App.Factories;
using SuperSorter.App.SortingStrageties;
using SuperSorter.App.StopWatch;

namespace SuperSorter.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create stopwatch
            SortingStopwatchMilliseconds sortingStopwatch = new SortingStopwatchMilliseconds();

            // Using Factory pattern to use specified sorting-stragety
            ISuperSorterFactory superSorterFactory = new SuperSorterFactoryImplementation();
            SuperSorter superSorter = new SuperSorter(superSorterFactory, "QuickSort");
            
            // Using Factory pattern to use specified arraygenerator-stragety
            IArrayStragetyFactory arrayStragetyFactory = new ArrayStragetyFactoryImplementation();
            ArrayGenerator arrayGenerator = new ArrayGenerator(arrayStragetyFactory, "Completely");

            // Create random generated array
            int[] arr = arrayGenerator.GenerateArray(50, 200, 1);

            // Display unsorted array
            Console.WriteLine("[{0}]", string.Join(", ", arr));

            // Sort array
            sortingStopwatch.Start();
            int[] sortedarr = superSorter.Sort(arr);
            double elapsedTime = sortingStopwatch.Stop();

            // Display sorted array
            Console.WriteLine("[{0}]", string.Join(", ", sortedarr));

            // Display name of used sorting-algorithm
            Console.WriteLine(superSorter.SortStrategy.GetType().ToString());

            // Display elapsed time of sorting
            Console.WriteLine("Elapsed time: {0:R} ms", elapsedTime);

        }
    }
}
