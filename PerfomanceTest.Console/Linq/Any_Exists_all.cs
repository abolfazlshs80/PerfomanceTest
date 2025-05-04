using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_benchmark.Linq
{
    [MemoryDiagnoser]
    public class Any_Exists_All
    {
        private List<Person> lst_numbers;
        public Any_Exists_All()
        {
            lst_numbers = new()
            {
                new("ali", 22),
                new("reza", 24),
                new("maryam", 18),
            };
        }
        [Benchmark]
        public void Get1Any_Empty()
        {


            lst_numbers.Any();
        }
        [Benchmark]
        public void Get1Any()
        {


            lst_numbers.Any(a => a.Age > 17);
        }
        [Benchmark]
        public void Get1All_Empty()
        {


            lst_numbers.All(a => a.Age > 17);
        }
        [Benchmark]
        public void Get1Exists()
        {


            lst_numbers.Exists(a => a.Age > 17);
        }
    }
    public record Person(string Name, int Age);
}