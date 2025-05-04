using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console_benchmark
{

    [MemoryDiagnoser]
    public class MemoryBenchmarkerDemo
    {
        public enum MyNames
        {
            abolfazl,
            ali
        }
        [Benchmark]
        public string GetByTostring()
        {
            return MyNames.abolfazl.ToString();
        }
        [Benchmark]
        public string GetByNameOf()
        {
            return nameof(MyNames.abolfazl);
        }

    }
}
