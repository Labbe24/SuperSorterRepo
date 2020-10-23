using System;
using SuperSorter.App.ArrayStrageties;
using SuperSorter.App.Factories;

namespace SuperSorter.App
{
    public class ArrayGenerator
    {
        public IArrayStrategy ArrayStrategy { private get; set; }

        public ArrayGenerator(IArrayStragetyFactory arrayStragetyFactory, string name)
        {
            ArrayStrategy = arrayStragetyFactory.MakeArrayStrategy(name);
        }

        public int[] GenerateArray(int n, int max, int seed)
        {
            return ArrayStrategy.GenerateArray(n, max, seed);
        }

        
    }
}