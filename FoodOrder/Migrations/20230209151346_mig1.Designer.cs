﻿// <auto-generated />
using FoodOrder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodOrder.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230209151346_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodOrder.Models.Burger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ımgId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Burgers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            price = 20f,
                            type = "burger",
                            ımgId = 1
                        },
                        new
                        {
                            Id = 2,
                            price = 22f,
                            type = "burger",
                            ımgId = 2
                        },
                        new
                        {
                            Id = 3,
                            price = 23f,
                            type = "burger",
                            ımgId = 3
                        },
                        new
                        {
                            Id = 4,
                            price = 25f,
                            type = "burger",
                            ımgId = 4
                        },
                        new
                        {
                            Id = 5,
                            price = 24f,
                            type = "burger",
                            ımgId = 5
                        });
                });

            modelBuilder.Entity("FoodOrder.Models.Drink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ımgId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Drinks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            price = 25f,
                            type = "drink",
                            ımgId = 1
                        },
                        new
                        {
                            Id = 2,
                            price = 25f,
                            type = "drink",
                            ımgId = 2
                        },
                        new
                        {
                            Id = 3,
                            price = 25f,
                            type = "drink",
                            ımgId = 3
                        });
                });

            modelBuilder.Entity("FoodOrder.Models.Kebab", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ımgId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kebabs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            price = 25f,
                            type = "kebab",
                            ımgId = 1
                        },
                        new
                        {
                            Id = 2,
                            price = 27f,
                            type = "kebab",
                            ımgId = 3
                        },
                        new
                        {
                            Id = 3,
                            price = 28f,
                            type = "kebab",
                            ımgId = 4
                        },
                        new
                        {
                            Id = 4,
                            price = 29f,
                            type = "kebab",
                            ımgId = 5
                        },
                        new
                        {
                            Id = 5,
                            price = 30f,
                            type = "kebab",
                            ımgId = 6
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
