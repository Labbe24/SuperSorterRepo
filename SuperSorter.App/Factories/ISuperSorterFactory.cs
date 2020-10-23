using SuperSorter.App.SortingStrageties;

namespace SuperSorter.App.Factories
{
    public interface ISuperSorterFactory
    {
        ISortStrategy MakeSortStrategy(string name);
    }
}