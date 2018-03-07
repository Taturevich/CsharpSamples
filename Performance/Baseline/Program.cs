using Shared;
using System;

namespace Baseline
{
    internal class Program
    {
        private static void Main()
        {
            Utilities.DumpTimer(Evaluate, "Baseline");
            Console.ReadLine();
        }

        /// <summary>
        /// Avarge execution time - 40 ms
        /// </summary>
        private static void Evaluate()
        {
            for (var i = 0; i < 20; i++)
            {
                for (var j = 0; j < 20; j++)
                {
                    var t = (i + j) * 25;
                    Console.WriteLine(t);
                }
            }
        }
    }
}
