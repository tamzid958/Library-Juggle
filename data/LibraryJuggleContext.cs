using System.Data;
using Library_Juggle.model;
using Microsoft.EntityFrameworkCore;

namespace Library_Juggle.data
{
    public partial class LibraryJuggleContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=LibraryJuggleDB;Trusted_Connection=True;MultipleActiveResultSets=true;");
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
                        });
                }
            );
            modelBuilder.Entity<User>(entity =>
                {
                    entity.HasIndex(e => e.Email).IsUnique(true);
                });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
