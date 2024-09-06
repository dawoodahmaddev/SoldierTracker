﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoldierTracker.Data;

#nullable disable

namespace SoldierTracker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240906162030_AddSoldierToDb")]
    partial class AddSoldierToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SoldierTracker.Models.Soldier", b =>
                {
                    b.Property<Guid>("SoldierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainingInfo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SoldierID");

                    b.ToTable("Soldiers");
                });
#pragma warning restore 612, 618
        }
    }
}
