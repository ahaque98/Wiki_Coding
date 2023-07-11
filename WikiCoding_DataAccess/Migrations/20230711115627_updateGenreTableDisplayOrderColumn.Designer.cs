﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WikiCoding_DataAccess.Data;

#nullable disable

namespace WikiCoding_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230711115627_updateGenreTableDisplayOrderColumn")]
    partial class updateGenreTableDisplayOrderColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WikiCoding_Model.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 5)
                        .HasColumnType("decimal(10,5)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ISBN = "1100001584279",
                            Price = 12.98m,
                            Title = "The new tale"
                        },
                        new
                        {
                            Id = 2,
                            ISBN = "01561216803",
                            Price = 34.23m,
                            Title = "once upon a time"
                        },
                        new
                        {
                            Id = 3,
                            ISBN = "01725797413",
                            Price = 32.45m,
                            Title = "Making a new faith"
                        },
                        new
                        {
                            Id = 4,
                            ISBN = "10892163360",
                            Price = 22.41m,
                            Title = "Big Star"
                        },
                        new
                        {
                            Id = 5,
                            ISBN = "9877654",
                            Price = 11.21m,
                            Title = "B&H"
                        });
                });

            modelBuilder.Entity("WikiCoding_Model.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int")
                        .HasColumnName("Display Order");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tb_genres");
                });
#pragma warning restore 612, 618
        }
    }
}
