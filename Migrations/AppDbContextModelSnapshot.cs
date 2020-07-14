﻿// <auto-generated />
using AutheDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutheDemo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutheDemo.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvatarPath = "images/gem.png",
                            Department = ".Net IT",
                            Email = "trungvd@gemvietnam.com",
                            FullName = " Vu Duc Trung"
                        },
                        new
                        {
                            Id = 2,
                            AvatarPath = "images/gem.png",
                            Department = ".Net IT",
                            Email = "hungnv@gemvietnam.com",
                            FullName = " Nguyen Van Hung"
                        },
                        new
                        {
                            Id = 3,
                            AvatarPath = "images/gem.png",
                            Department = ".Net IT",
                            Email = "Namhv@gemvietnam.com",
                            FullName = " Hoang Van Nam"
                        },
                        new
                        {
                            Id = 4,
                            AvatarPath = "images/gem.png",
                            Department = "Java IT",
                            Email = "DatNQ@gemvietnam.com",
                            FullName = "Nguyen Quy Dat"
                        },
                        new
                        {
                            Id = 5,
                            AvatarPath = "images/gem.png",
                            Department = "Java IT",
                            Email = "DuyDN@gemvietnam.com",
                            FullName = "Dao Ngoc Duy"
                        },
                        new
                        {
                            Id = 6,
                            AvatarPath = "images/gem.png",
                            Department = "Mobile IT",
                            Email = "DuyetDD@gemvietnam.com",
                            FullName = " Dao Duc Duyet"
                        },
                        new
                        {
                            Id = 7,
                            AvatarPath = "images/gem.png",
                            Department = "Mobile IT",
                            Email = "DatPT@gemvietnam.com",
                            FullName = "Pham Thanh Dat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
