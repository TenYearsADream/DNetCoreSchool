using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace efcoreConsole3
{
    public class Mydbcontext:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var bookType = modelBuilder.Entity<Book>();
            bookType.ToTable("t_books");
            var authorType = modelBuilder.Entity<Author>();
            authorType.ToTable("t_authors");
            bookType.HasOne(e => e.Author).WithMany().HasForeignKey(e => e.AuthorId).IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("Server=192.168.1.104;database=efcoreTest;uid=root;pwd=123456");
        }
    }
}
