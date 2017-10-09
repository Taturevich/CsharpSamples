﻿using Shared;
using System;
using System.Text;

namespace CodeOptimization
{
    class Program
    {
        static void Main()
        {
            Utilities.DumpTimer(Evaluate, "Optimized code");
            Console.ReadLine();
        }

        static void Evaluate()
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
            Console.WriteLine(textBuilder);
        }
    }
}
