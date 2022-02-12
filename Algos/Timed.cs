using System;
using System.Diagnostics;

namespace Algos
{
    public class Timed
    {
        public static (T result, TimeSpan time) DoWithTiming<T>(Func<T> action)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var result = action();
            stopWatch.Stop();
            return (result, stopWatch.Elapsed);
        }
    }
}
