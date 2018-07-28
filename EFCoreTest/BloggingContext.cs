using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTest
{
    public  class BloggingContext:DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MyDatabase;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var etPerson = modelBuilder.Entity<Person>();
            etPerson.ToTable("t_persons");
        }
    }

    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool? Gender { get; set; }
    }





}
