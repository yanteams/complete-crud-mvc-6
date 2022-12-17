﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using complete_crud_mvc_6.Models;

#nullable disable

namespace completecrudmvc6.Migrations
{
    [DbContext(typeof(TransDbContext))]
    partial class TransDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("complete_crud_mvc_6.Models.Trans", b =>
                {
                    b.Property<int>("TransID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransID"));

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("BeneficiaryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("SWIFTCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TransID");

                    b.ToTable("Trans");
                });
#pragma warning restore 612, 618
        }
    }
}
