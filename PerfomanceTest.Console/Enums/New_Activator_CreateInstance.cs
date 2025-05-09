using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PerfomanceTest.Console1.OOP
{

    [MemoryDiagnoser]
    public class Enum_TryParse_IsDefined
    {
        enum Gender
        {
            none = 0,
            male = 1,
            famale = 2
        }

        public static void LogError(string error, [CallerMemberName] string caller = "", [CallerLineNumber] int? CallerLineNumber = 0, [CallerFilePath] string CallerFilePath = "")
        {
            Console.WriteLine($"خطا در متد {caller}: {error}");
        }
        [Benchmark]
        public void Get_IsDefined_int()
        {
            int value1 = 1;
       

            if (Enum.IsDefined(typeof(Gender), value1))
            {
                Gender gender1 = (Gender)value1;
                // value is valid
            }
            else
            {
                // value is invalid
            }

        

        }
        [Benchmark]
        public void Get_TryParse_int()
        {

            int value2 = 1;
                // بررسی مقدار معتبر با TryParse
            if (Enum.TryParse(value2.ToString(), out Gender gender2))
            {
                // value is valid
            }
            else
            {
                // value is invalid
            }

        }

        [Benchmark]
        public void Get_IsDefined_string()
        {
            string value1 = "1";


            if (Enum.IsDefined(typeof(Gender), value1))
            {
                Gender gender1 = (Gender)int.Parse(value1);
                // value is valid
            }
            else
            {
                // value is invalid
            }



        }
        [Benchmark]
        public void Get_TryParse_string()
        {

            string value2 = "1";
            // بررسی مقدار معتبر با TryParse
            if (Enum.TryParse(value2.ToString(), out Gender gender2))
            {
                // value is valid
            }
            else
            {
                // value is invalid
            }

        }

    }

}