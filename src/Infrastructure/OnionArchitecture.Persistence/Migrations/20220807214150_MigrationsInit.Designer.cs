﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnionArchitecture.Persistence.Context;

#nullable disable

namespace OnionArchitecture.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220807214150_MigrationsInit")]
    partial class MigrationsInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnionArchitecture.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3e281664-a133-42e5-9f9a-5749d105d00b"),
                            Description = "Product 1 Description",
                            Name = "Product 1 Name",
                            Price = 1000,
                            Stock = 10
                        },
                        new
                        {
                            Id = new Guid("d5560b6f-9daa-47ef-8e7d-905ca78e3b85"),
                            Description = "Product 2 Description",
                            Name = "Product 2 Name",
                            Price = 2000,
                            Stock = 20
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
