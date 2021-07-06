﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210706161936_AdressData")]
    partial class AdressData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("API.Entities.AddressData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("city")
                        .HasColumnType("TEXT");

                    b.Property<string>("state")
                        .HasColumnType("TEXT");

                    b.Property<string>("streetAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("zip")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("adress");
                });

            modelBuilder.Entity("API.Entities.RegUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RegUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("userEmail")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
