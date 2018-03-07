using System;
using System.IO;
using Shared;

namespace StdOut
{
    internal class Program
    {
        private static readonly StreamWriter Stdout = new StreamWriter(Console.OpenStandardOutput());

        private static void Main()
        {
            Utilities.DumpTimer(Evaluate, "Optimized output");
            Console.ReadLine();
        }

        /// <summary>
        /// Avarge execution time - 3 ms
        /// </summary>
        private static void Evaluate()
        {
            for (var i = 0; i < 20; i++)
            {
                for (var j = 0; j < 20; j++)
                {
                    var t = (i + j) * 25;
                    foreach (var charNumber in t.ToString())
                    {
                        Stdout.Write(charNumber);
                    }
                    Stdout.WriteLine();
                }
            }
        }
    }
}
