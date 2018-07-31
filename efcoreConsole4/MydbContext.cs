using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace efcoreConsole4
{
    public  class MydbContext:DbContext
    {
        public  DbSet<User> Users { get; set; }
        public  DbSet<Role> Roles { get; set; }
        public  DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("Server=192.168.1.104;database=efcoreTest;uid=root;pwd=123456");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var typeUser = modelBuilder.Entity<User>();
            typeUser.ToTable("t_user");
            var typeRole = modelBuilder.Entity<Role>();
            typeRole.ToTable("t_role");
            var typeUserRoleRelation = modelBuilder.Entity<UserRole>();
            typeUserRoleRelation.ToTable("t_userRole");
            typeUserRoleRelation.HasOne(e => e.Role).WithMany().HasForeignKey(e =>
                e.RoleId).IsRequired();
            typeUserRoleRelation.HasOne(e => e.User).WithMany().HasForeignKey(e =>
                e.UserId).IsRequired();
        }
    }
}
