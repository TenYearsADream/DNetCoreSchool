using Microsoft.EntityFrameworkCore;

namespace efcoreConsole2
{
    public class MyDbContext:DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //("Server=127.0.0.1;database=zszdb;uid=root;pwd=root");
            var etPerson = modelBuilder.Entity<Person>();
            etPerson.ToTable("t_persons");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("Server=192.168.1.104;database=efcoreTest;uid=root;pwd=123456");
        }
    }
}
