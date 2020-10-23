using SuperSorter.App.ArrayStrageties;

namespace SuperSorter.App
{
    public class ArrayGenerator
    {
        public IArrayStrategy ArrayStrategy { private get; set; }

        public int[] GenerateArray(int n, int max, int seed)
        {
            return ArrayStrategy.GenerateArray(n, max, seed);
        }

        
    }
}