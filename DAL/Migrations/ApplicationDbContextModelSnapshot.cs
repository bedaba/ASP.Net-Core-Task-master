﻿// <auto-generated />
using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LockedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("54fa99c7-4cba-4665-9a9b-ce6e20b558d3"),
                            Address = "Cairo",
                            LockedBy = "",
                            Name = "Ahmed",
                            Notes = "",
                            Phone = "+2015168138451"
                        },
                        new
                        {
                            Id = new Guid("d4e78b8c-1b1a-4832-a789-2bff07ba8f8d"),
                            Address = "Cairo",
                            LockedBy = "",
                            Name = "asd",
                            Notes = "",
                            Phone = "+2015676786871"
                        },
                        new
                        {
                            Id = new Guid("b9065a41-d1f8-421b-aec6-4e382d26bd7a"),
                            Address = "Cairo",
                            LockedBy = "",
                            Name = "dfg",
                            Notes = "",
                            Phone = "+2015176867884"
                        },
                        new
                        {
                            Id = new Guid("3306a4e1-9144-44bf-af59-0f3571cfe5ae"),
                            Address = "Cairo",
                            LockedBy = "",
                            Name = "Ahbcvbmed",
                            Notes = "",
                            Phone = "+2067867868384"
                        },
                        new
                        {
                            Id = new Guid("5e2e9bd5-f05b-4cb2-a3ef-12cc224ed133"),
                            Address = "Cairo",
                            LockedBy = "",
                            Name = "jghj",
                            Notes = "",
                            Phone = "+2018888888884"
                        },
                        new
                        {
                            Id = new Guid("89be456b-0052-4ffd-bc68-53a74e0c309d"),
                            Address = "Cairo",
                            LockedBy = "",
                            Name = "bmnmb",
                            Notes = "",
                            Phone = "+2066666681384"
                        },
                        new
                        {
                            Id = new Guid("1a25b416-007e-4f7c-9cfb-afb2cebb9d1d"),
                            Address = "Cairo",
                            LockedBy = "",
                            Name = "Ahbnmbnmed",
                            Notes = "",
                            Phone = "+2015168139999"
                        },
                        new
                        {
                            Id = new Guid("ce2a09f6-b311-4ed6-9dfd-c1c94692457f"),
                            Address = "Cairo",
                            LockedBy = "",
                            Name = "jkljll;",
                            Notes = "",
                            Phone = "+2015100000005"
                        },
                        new
                        {
                            Id = new Guid("cb7f4a56-d4ba-4a61-be84-eb4b99c651f2"),
                            Address = "Cairo",
                            LockedBy = "",
                            Name = "op[opp",
                            Notes = "",
                            Phone = "+2015333333845"
                        },
                        new
                        {
                            Id = new Guid("32712d3c-3baa-43bf-89b2-d18acd665be4"),
                            Address = "Cairo",
                            LockedBy = "",
                            Name = "p'wreer",
                            Notes = "",
                            Phone = "+201515553845"
                        },
                        new
                        {
                            Id = new Guid("5ccb79d7-9714-464c-afa1-0943c891b25e"),
                            Address = "Cairo",
                            LockedBy = "",
                            Name = "fdsf",
                            Notes = "",
                            Phone = "+201544443445"
                        },
                        new
                        {
                            Id = new Guid("e4ba3c2e-eb82-4945-b729-077341749525"),
                            Address = "Cairo",
                            LockedBy = "",
                            Name = "tyu",
                            Notes = "",
                            Phone = "+201516819999"
                        },
                        new
                        {
                            Id = new Guid("a2a77aec-69c1-4b40-b1dd-fcf644211b77"),
                            Address = "Cairo",
                            LockedBy = "",
                            Name = "oiio",
                            Notes = "",
                            Phone = "+202222238451"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}