using System;
using SuperSorter.App.ArrayStrageties;

namespace SuperSorter.App.Factories
{
    public class ArrayStragetyFactoryImplementation : IArrayStragetyFactory
    {
        public IArrayStrategy MakeArrayStrategy(string name)
        {
            if (name.Equals("Completely"))
                return new CompletelyRandom();
            else
                throw new ArgumentException(name);
        }
    }
}