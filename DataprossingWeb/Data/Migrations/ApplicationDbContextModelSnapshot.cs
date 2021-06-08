﻿// <auto-generated />
using DataprossingWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataprossingWeb.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dataprossing.Models.PopulationAgeGroupInBaishaPenghu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("age0")
                        .HasColumnType("int");

                    b.Property<int>("age1")
                        .HasColumnType("int");

                    b.Property<int>("age10")
                        .HasColumnType("int");

                    b.Property<int>("age11")
                        .HasColumnType("int");

                    b.Property<int>("age12")
                        .HasColumnType("int");

                    b.Property<int>("age13")
                        .HasColumnType("int");

                    b.Property<int>("age14")
                        .HasColumnType("int");

                    b.Property<int>("age15")
                        .HasColumnType("int");

                    b.Property<int>("age16")
                        .HasColumnType("int");

                    b.Property<int>("age17")
                        .HasColumnType("int");

                    b.Property<int>("age18")
                        .HasColumnType("int");

                    b.Property<int>("age19")
                        .HasColumnType("int");

                    b.Property<int>("age2")
                        .HasColumnType("int");

                    b.Property<int>("age3")
                        .HasColumnType("int");

                    b.Property<int>("age4")
                        .HasColumnType("int");

                    b.Property<int>("age5")
                        .HasColumnType("int");

                    b.Property<int>("age6")
                        .HasColumnType("int");

                    b.Property<int>("age7")
                        .HasColumnType("int");

                    b.Property<int>("age8")
                        .HasColumnType("int");

                    b.Property<int>("age9")
                        .HasColumnType("int");

                    b.Property<int>("month")
                        .HasColumnType("int");

                    b.Property<int>("sum")
                        .HasColumnType("int");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PopulationAgeGroupInBaishaPenghus");
                });
#pragma warning restore 612, 618
        }
    }
}
