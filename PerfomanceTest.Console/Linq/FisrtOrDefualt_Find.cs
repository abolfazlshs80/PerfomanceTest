using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PerfomanceTest.Data.Context;
using PerfomanceTest.Data.Models;

namespace Console_benchmark.Linq
{
    [MemoryDiagnoser]
    public class FisrtOrDefualt_Find
    {
        private AppDbContext _context = null!;
        [GlobalSetup]
        public async Task Setup()
        {
            _context = new AppDbContext();
            if (!_context.Category1.Any())
            {
                for (int i = 1; i <= 1000; i++)
                    _context.Category1.Add(new Category() { Name = $"User {i}" });
                await _context.SaveChangesAsync();
            }
        }

        [Benchmark]
        public async Task Try_Find()
        {
     
            var category = await _context.Category1.FindAsync(196);

        }

        [Benchmark]
        public async Task Try_FirtOrDefualt()
        {
     

            var category = await _context.Category1.FirstOrDefaultAsync(a => a.Id == 196);
          
        }

        public (int, string) get()
        {
            return (1, "a");
        }

    }

}