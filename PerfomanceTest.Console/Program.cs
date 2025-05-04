using BenchmarkDotNet.Running;
using Console_benchmark.Linq;


namespace PerfomanceTest.Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var summary = BenchmarkRunner.Run<MemoryBenchmarkerDemo>();
            var summary = BenchmarkRunner.Run<Any_Exists_All>();



            Console.WriteLine("Hello, World!");
        }
    }

}
