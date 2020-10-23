using System;
using SuperSorter.App.SortingStrageties;

namespace SuperSorter.App.Factories
{
    public class SuperSorterFactoryImplementation : ISuperSorterFactory
    {
        public ISortStrategy MakeSortStrategy(string name)
        {
            if(name.Equals("QuickSort"))
                return new QuickSort();
            else
                throw new ArgumentException(name);
        }
    }
}