using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PerfomanceTest.Data.Models;

namespace PerfomanceTest.Data.Context
{
    public class AppDbContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DB_TEST1;Integrated Security=True;Multiple Active Result Sets=True;Trust Server Certificate=True");
        //    base.OnConfiguring(optionsBuilder);
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseInMemoryDatabase("TestDb");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(AppDbContext)));
            base.OnModelCreating(modelBuilder);
        }

        #region DbSet


        public DbSet<Category> Category1 { get; set; }
    



        #endregion


    }
}
