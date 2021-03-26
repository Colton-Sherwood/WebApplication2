﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Models;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(StudentContext))]
    partial class StudentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GPA")
                        .HasColumnType("float");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Colton",
                            GPA = 4.0,
                            LastName = "Sherwood"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Sally",
                            GPA = 3.0,
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Billy",
                            GPA = 2.0,
                            LastName = "Bob"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Mickey",
                            GPA = 1.0,
                            LastName = "Mouse"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Bugs",
                            GPA = 0.0,
                            LastName = "Bunny"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
