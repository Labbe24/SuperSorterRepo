using System;
using System.Globalization;

namespace SuperSorter.App.SortingStrageties
{
    public class QuickSort : ISortStrategy
    {
        public void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pi = Partition(arr, left, right);
                Sort(arr, left, pi-1);
                Sort(arr, pi+1, right);
            }
        }

        private int Partition(int[] arr, int low, int hi)
        {
            int pivot = arr[hi];
            int i = low - 1;

            for (int j = low; j <= hi; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i+1, hi);

            return i + 1;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}