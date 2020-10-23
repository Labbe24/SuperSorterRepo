using SuperSorter.App.ArrayStrageties;

namespace SuperSorter.App.Factories
{
    public interface IArrayStragetyFactory
    {
        IArrayStrategy MakeArrayStrategy(string name);
    }
}