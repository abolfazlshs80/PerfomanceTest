using BenchmarkDotNet.Attributes;
using Console_benchmark.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PerfomanceTest.Console1.OOP
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    [MemoryDiagnoser]
    public class ProperyPatterns
    {
        [Benchmark]
        public void Get_ProperyPatternsByIf()
        {
            Person person = new Person { Name = "Ali", Age = 25 };
            string message;
            if (person is { Name: "Ali", Age: 30 })
                 message= "Found Ali with age 30.";
            else
                 message = "The details do not match.";
        }
        [Benchmark]
        public void Get_ProperyPatternsBySwitch()
        {
            Person person = new Person { Name = "Ali", Age = 25 };
            string message = person switch
            {
                { Name: "Ali", Age: 30 } => "Hello Mr. Ali!",
                { Name: "Sara", Age: 25 } => "Hello Ms. Sara!",
                { Age: < 18 } => "Young user",
                { Age: >= 60 } => "Senior user",
                _ => "Regular user"
            };

        }
        [Benchmark]
        public void Get_NotProperyPatternsIf()
        {
            Person person = new Person { Name = "Sara", Age = 25 };
            string message;
            if (person != null && person.Name == "Ali" && person.Age == 30)
                 message ="Found Ali with age 30.";
            else
                 message = "The details do not match.";

        }
        [Benchmark]
        public void Get_NotProperyPatternsSwitch()
        {
            Person person = new Person { Name = "Sara", Age = 25 };

            string message = (person.Name, person.Age) switch
            {
                ("Ali", 30) => "Hello Mr. Ali!",
                ("Sara", 25) => "Hello Ms. Sara!",
                (_, int age) when age < 18 => "Young user",
                (_, int age) when age >= 60 => "Senior user",
                _ => "Regular user"
            };

        }
    }

}