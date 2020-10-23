using System.Diagnostics;

namespace SuperSorter.App.StopWatch
{
    public abstract class SortingStopwatch
    {
        protected Stopwatch stopwatch;

        protected abstract double GetElapsedTime();

        public SortingStopwatch()
        {
            stopwatch = new Stopwatch();
        }
        public void Start()
        {
            stopwatch.Reset();
            stopwatch.Start();
        }

        public double Stop()
        {
            stopwatch.Stop();
            return GetElapsedTime();
        }
    }
}