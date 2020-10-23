namespace SuperSorter.App.StopWatch
{
    public class SortingStopwatchMilliseconds : SortingStopwatch
    {
        protected override double GetElapsedTime()
        {
            return stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}