﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SecondTask.Data;

#nullable disable

namespace SecondTask.Migrations
{
    [DbContext(typeof(SecondDbContext))]
    [Migration("20220531051208_Final")]
    partial class Final
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SecondTask.Data.EsplEmployee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Home"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Open"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Completed"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Pending"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Pree Review"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
