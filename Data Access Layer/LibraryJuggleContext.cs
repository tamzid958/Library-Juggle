using System;
using System.Configuration;
using Library_Juggle.Business_Logic_Layer;
using Library_Juggle.Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library_Juggle.Data_Access_Layer
{
    public partial class LibraryJuggleContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = ConfigurationManager.ConnectionStrings["default connection"].ConnectionString;
            optionsBuilder.UseSqlServer(connection);
        }
        public LibraryJuggleContext()
        {
        }
        public LibraryJuggleContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }

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
                        Email = "admin@libraryjuggle.com",
                        Password = StaticMethods.CreateMd5("library123"),
                        Token = StaticMethods.CreateToken(),
                        RoleId = 1
                    });
                });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
