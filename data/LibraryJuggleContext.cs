using System;
using System.Configuration;
using System.Data;
using Library_Juggle.model;
using Library_Juggle.service;
using Microsoft.EntityFrameworkCore;

namespace Library_Juggle.data
{
    public partial class LibraryJuggleContext : DbContext
    {
        private string Connection { get; } = ConfigurationManager.ConnectionStrings["default connection"].ConnectionString;

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer(Connection);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Role>(entity =>
                {
                    entity.HasData(
                        new Role
                        {
                            RoleId = 1,
                            RoleName = "Admin"
                        },
                        new Role
                        {
                            RoleId = 2,
                            RoleName = "Student"
                        },
                        new Role
                        {
                            RoleId = 3,
                            RoleName = "Librarian"
                        });
                }
            );
            modelBuilder.Entity<User>(entity =>
                {
                    entity.HasIndex(e => e.Email).IsUnique(true);

                    entity.HasData(new User
                    {
                        UserId = 1,
                        Name = "Library Admin",
                        Email = "admin@libraryjungle.com",
                        Password = StaticMethods.CreateMd5("library123"),
                        Token = StaticMethods.CreateMd5("admin@libraryjungle.com"),
                        RoleId = 1
                    });
                });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
