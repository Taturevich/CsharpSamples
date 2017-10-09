using Shared;
using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        private static StreamWriter stdout = new StreamWriter(Console.OpenStandardOutput());
        static void Main()
        {
            Utilities.DumpTimer(Evaluate, "Optimized output");
            Console.ReadLine();
        }

        static void Evaluate()
        {
            for (var i = 0; i< 20; i++)
            {
                for (var j = 0; j < 20; j++)
                {
                    var t = (i + j) * 25;
                    foreach (var charNumber in t.ToString())
                    {
                        stdout.Write(charNumber);
                    }
                    stdout.WriteLine();
                }
            }
        }
    }
}
