﻿// <auto-generated />
using System;
using Library_Juggle.Data_Access_Layer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library_Juggle.Migrations
{
    [DbContext(typeof(LibraryJuggleDbContext))]
    [Migration("20210424093140_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library_Juggle.Data_Access_Layer.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookAuthor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookPublishedDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookPublisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int?>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.HasIndex(new[] { "GenreId" }, "IX_Books_GenreId");

                    b.HasIndex(new[] { "UsersUserId" }, "IX_Books_UsersUserId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Library_Juggle.Data_Access_Layer.Entities.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int?>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("GenreId");

                    b.HasIndex(new[] { "UsersUserId" }, "IX_Genres_UsersUserId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Library_Juggle.Data_Access_Layer.Entities.Loan", b =>
                {
                    b.Property<int>("LoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BooksBookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateIssued")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("LoanId");

                    b.HasIndex(new[] { "BooksBookId" }, "IX_Loans_BooksBookId");

                    b.HasIndex(new[] { "UsersUserId" }, "IX_Loans_UsersUserId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("Library_Juggle.Data_Access_Layer.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = "Student"
                        },
                        new
                        {
                            RoleId = 3,
                            RoleName = "Librarian"
                        });
                });

            modelBuilder.Entity("Library_Juggle.Data_Access_Layer.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<Guid>("Token")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "admin@libraryjuggle.com",
                            Name = "Library Admin",
                            Password = "CD6FA8ABA065897E5A56061882350B66",
                            RoleId = 1,
                            Token = new Guid("ca82e45c-1306-409c-b4fe-8c2e62eb3a18")
                        });
                });

            modelBuilder.Entity("Library_Juggle.Data_Access_Layer.Entities.Book", b =>
                {
                    b.HasOne("Library_Juggle.Data_Access_Layer.Entities.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library_Juggle.Data_Access_Layer.Entities.User", "UsersUser")
                        .WithMany("Books")
                        .HasForeignKey("UsersUserId");

                    b.Navigation("Genre");

                    b.Navigation("UsersUser");
                });

            modelBuilder.Entity("Library_Juggle.Data_Access_Layer.Entities.Genre", b =>
                {
                    b.HasOne("Library_Juggle.Data_Access_Layer.Entities.User", "UsersUser")
                        .WithMany("Genres")
                        .HasForeignKey("UsersUserId");

                    b.Navigation("UsersUser");
                });

            modelBuilder.Entity("Library_Juggle.Data_Access_Layer.Entities.Loan", b =>
                {
                    b.HasOne("Library_Juggle.Data_Access_Layer.Entities.Book", "BooksBook")
                        .WithMany("Loans")
                        .HasForeignKey("BooksBookId");

                    b.HasOne("Library_Juggle.Data_Access_Layer.Entities.User", "UsersUser")
                        .WithMany("Loans")
                        .HasForeignKey("UsersUserId");

                    b.Navigation("BooksBook");

                    b.Navigation("UsersUser");
                });

            modelBuilder.Entity("Library_Juggle.Data_Access_Layer.Entities.User", b =>
                {
                    b.HasOne("Library_Juggle.Data_Access_Layer.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Library_Juggle.Data_Access_Layer.Entities.Book", b =>
                {
                    b.Navigation("Loans");
                });

            modelBuilder.Entity("Library_Juggle.Data_Access_Layer.Entities.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library_Juggle.Data_Access_Layer.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Library_Juggle.Data_Access_Layer.Entities.User", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("Genres");

                    b.Navigation("Loans");
                });
#pragma warning restore 612, 618
        }
    }
}