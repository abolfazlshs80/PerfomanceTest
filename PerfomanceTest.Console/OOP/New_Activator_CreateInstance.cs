using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PerfomanceTest.Console1.OOP
{
    public class Category()
    {
        public string Name { get; set; }
    }
    [MemoryDiagnoser]
    public class New_Activator_CreateInstance
    {

    
        [Benchmark]
        public void Get_Activator()
        {
            var Category = typeof(Category);
            for (int i = 0; i < 100; i++)
            {
                var instancePerson = Activator.CreateInstance(Category);
            }

        }
        [Benchmark]
        public void Get_New()
        {

            for (int i = 0; i < 100; i++)
            {
                var Category = new Category();
            }

        }

    }

}