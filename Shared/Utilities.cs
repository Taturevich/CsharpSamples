using System;
using System.Diagnostics;

namespace Shared
{
    // Better to use BenchmarkNet for that
    public static class Utilities
    {
        public static void DumpTimer(Action action)
        {
            var stopWatch = MeasureExecution(action);
            Console.WriteLine($"{stopWatch.ElapsedMilliseconds} ms");
        }

        public static void DumpTimer(Action action, string methodDescriptor)
        {
            var stopWatch = MeasureExecution(action);
            Console.WriteLine($"{methodDescriptor}: {stopWatch.ElapsedMilliseconds} ms");
        }

        private static Stopwatch MeasureExecution(Action action)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            action();
            stopWatch.Stop();
            return stopWatch;
        }
    }
}
