﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Contexts;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20250218205751_Seed")]
    partial class Seed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.User.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("InsertTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2025, 2, 19, 0, 27, 51, 171, DateTimeKind.Local).AddTicks(5999));

                    b.Property<bool>("IsRemoved")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RemoveTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("159a8a45-b0dd-4ad5-bcb4-8fc37b542f9d"),
                            Password = "AQAAAAIAAYagAAAAEAis+HeDjVqC7QAfX702TY0wFbHBBKk62aShB9OfIy/Ntfmb81LhTVE95ZhbqoRutg==",
                            Role = "role_admin",
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("e43174b4-c6f8-4cca-9c0c-26aa87a7b88a"),
                            Password = "AQAAAAIAAYagAAAAEP0y4mWLZe0BrBUIq6W7d4U1UhvGY/DvYTKEHoKwJFgzWPsAwAJzddTr7Ca1Wbdqug==",
                            Role = "role_user",
                            Username = "user"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
