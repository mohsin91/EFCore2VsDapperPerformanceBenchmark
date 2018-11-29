using BenchmarkDotNet.Running;
using NowMobRep.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

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
