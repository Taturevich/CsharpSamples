using Shared;
using System;

namespace Baseline
{
    class Program
    {
        static void Main()
        {
            Utilities.DumpTimer(Evaluate, "Baseline");
            Console.ReadLine();
        }

        static void Evaluate()
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
