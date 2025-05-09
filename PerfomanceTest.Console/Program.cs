using BenchmarkDotNet.Running;
using Console_benchmark.Linq;

using PerfomanceTest.Console1.OOP;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace PerfomanceTest.Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var summary = BenchmarkRunner.Run<MemoryBenchmarkerDemo>();
            //var summary = BenchmarkRunner.Run<Any_Exists_All>();
            // var summary = BenchmarkRunner.Run<FisrtOrDefualt_Find>();
            //   var summary = BenchmarkRunner.Run<New_Activator_CreateInstance>();
               var summary = BenchmarkRunner.Run<Enum_TryParse_IsDefined>();
            //

            //DoSomething();
            Console.ReadKey();
        }


        static async void DoSomething()
        {

        }

      

    }

}
