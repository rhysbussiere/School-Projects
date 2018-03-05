using System;
using FinalExercise.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace FinalExercise.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("StudentDatabase")
        { }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}