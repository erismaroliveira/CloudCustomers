﻿// <auto-generated />
using CloudCustomers.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CloudCustomers.API.Migrations
{
    [DbContext(typeof(CloudCustomerContext))]
    partial class CloudCustomersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CloudCustomers.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "Teste@123",
                            Username = "Erismar"
                        },
                        new
                        {
                            Id = 2,
                            Password = "Teste@123",
                            Username = "Natalia"
                        },
                        new
                        {
                            Id = 3,
                            Password = "Teste@123",
                            Username = "Isabella"
                        },
                        new
                        {
                            Id = 4,
                            Password = "Teste@123",
                            Username = "Eloah"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}