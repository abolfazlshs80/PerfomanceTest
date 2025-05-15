using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfomanceTest.Console1.OOP
{
    [MemoryDiagnoser]
    public class TupleType_TupleValue
    {
        [Benchmark]
        public  (string, int) GetByValueTuple_VariableName()
        {
            // یا با نام‌گذاری:
            var p2 = (Name: "Ali", Age: 25);
            string valueTuple_Name_VariableName = p2.Name;
            int valueTuple_Age_VariableName = p2.Age;
            return p2;
        }
        [Benchmark]
        public  (string, int) GetByValueTuple()
        {
            var valueTuple = ("Ali", 25);
            string valueTuple_Name = valueTuple.Item1;
            int valueTuple_Age = valueTuple.Item2;
            return valueTuple;
        }
        [Benchmark]
        public  Tuple<string, int> GetByTupleType()
        {
            var p1 = new Tuple<string, int>("Ali", 25);
            string name = p1.Item1;
            int age = p1.Item2;
            return p1;
        }
        [Benchmark]
        public PersonRecord GetByRecord()
        {
            var p1 = new PersonRecord("Ali", 25);
            string name = p1.name;
            int age = p1.age;
            return p1;
        }
        [Benchmark]
        public PersonClass GetByClass()
        {
            var p1 = new PersonClass{ name = "Ali",age= 25};
            string name = p1.name;
            int age = p1.age;
            return p1;
        }
    }

    public record PersonRecord(string name, int age);

    public class PersonClass
    {
       
        public string name { get; set; }
        public int age { get; set; }
    }
}
