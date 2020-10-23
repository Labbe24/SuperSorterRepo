using System;
using SuperSorter.App.Factories;
using SuperSorter.App.SortingStrageties;

namespace SuperSorter.App
{
    public class SuperSorter
    {
        public ISortStrategy SortStrategy { get; set; }

        public SuperSorter(ISuperSorterFactory superSorterFactory, string name)
        {
            SortStrategy = superSorterFactory.MakeSortStrategy(name);
        }
        public int[] Sort(int[] arr)
        {
            int[] arrcopy = new int[arr.Length];
            arr.CopyTo(arrcopy, 0);
            SortStrategy.Sort(arrcopy, 0, arr.Length-1);
            return arrcopy;
        }
    }
}