using Shared;
using System;
using System.IO;
using System.Text;

namespace StdOutCodeOptimization
{
    internal class Program
    {
        private static readonly StreamWriter Stdout = new StreamWriter(Console.OpenStandardOutput());

        private static void Main()
        {
            Utilities.DumpTimer(Evaluate, "Optimized code plus output");
            Console.ReadLine();
        }

        /// <summary>
        /// Avarge execution time - 3 ms
        /// </summary>
        private static void Evaluate()
        {
            var textBuilder = new StringBuilder();
            for (var i = 0; i < 20; i++)
            {
                for (var j = 0; j < 20; j++)
                {
                    var t = (i + j) * 25;
                    textBuilder.Append(t).AppendLine();
                }
            }
            foreach(var charSymbol in textBuilder.ToString())
            {
                Stdout.Write(charSymbol);
            }
        }
    }
}
