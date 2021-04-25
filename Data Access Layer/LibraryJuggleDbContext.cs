using System;
using System.Configuration;
using Library_Juggle.Business_Logic_Layer;
using Library_Juggle.Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Library_Juggle.Data_Access_Layer
{
    public class LibraryJuggleDbContext : DbContext
    {
        public LibraryJuggleDbContext()
        {
        }

        public LibraryJuggleDbContext(DbContextOptions<LibraryJuggleDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(
                    ConfigurationManager.ConnectionStrings["default connection"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
                entity.HasData(new User
                {
                    UserId = 1,
                    Name = "Library Admin",
                    Email = "admin@libraryjuggle.com",
                    Password = StaticMethods.CreateMd5("library123"),
                    Token = Guid.NewGuid(),
                    RoleId = 1
                });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        private void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }
    }
}