using System;

namespace SuperSorter.App.ArrayStrageties
{
    public class CompletelyRandom : IArrayStrategy
    {
        public int[] GenerateArray(int n, int max, int seed)
        {
            int[] arr = new int[n];
            Random randNum = new Random(seed);

            for (int i = 0; i < n; i++)
            {
                arr[i] = randNum.Next(max);
            }

            return arr;
        }
    }
}