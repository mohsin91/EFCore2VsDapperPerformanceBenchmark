using BenchmarkDotNet.Running;
using System;

namespace EFCore2VSDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(EFCore2VsDapper));

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
