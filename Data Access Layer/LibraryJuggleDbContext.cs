using System;
using System.Configuration;
using Library_Juggle.Business_Logic_Layer;
using Library_Juggle.Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Library_Juggle.Data_Access_Layer
{
    public partial class LibraryJuggleDbContext : DbContext
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
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["default connection"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Book>(entity =>
            {
                entity.HasIndex(e => e.GenreId, "IX_Books_GenreId");

                entity.HasIndex(e => e.UsersUserId, "IX_Books_UsersUserId");

                entity.Property(e => e.BookAuthor).IsRequired();

                entity.Property(e => e.BookPublishedDate).IsRequired();

                entity.Property(e => e.BookPublisher).IsRequired();

                entity.Property(e => e.BookTitle).IsRequired();

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.GenreId);

                entity.HasOne(d => d.UsersUser)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.UsersUserId);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasIndex(e => e.UsersUserId, "IX_Genres_UsersUserId");

                entity.Property(e => e.GenreName)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.HasOne(d => d.UsersUser)
                    .WithMany(p => p.Genres)
                    .HasForeignKey(d => d.UsersUserId);
            });

            modelBuilder.Entity<Loan>(entity =>
            {
                entity.HasIndex(e => e.BooksBookId, "IX_Loans_BooksBookId");

                entity.HasIndex(e => e.UsersUserId, "IX_Loans_UsersUserId");

                entity.HasOne(d => d.BooksBook)
                    .WithMany(p => p.Loans)
                    .HasForeignKey(d => d.BooksBookId);

                entity.HasOne(d => d.UsersUser)
                    .WithMany(p => p.Loans)
                    .HasForeignKey(d => d.UsersUserId);
            });

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
                entity.HasIndex(e => e.Email).IsUnique(true);
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

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
