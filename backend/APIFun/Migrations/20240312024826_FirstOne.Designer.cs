﻿// <auto-generated />
using APIFun.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIFun.Migrations
{
    [DbContext(typeof(FoodContext))]
    [Migration("20240312024826_FirstOne")]
    partial class FirstOne
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("APIFun.Data.MarriottFood", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("FoodRating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FoodId");

                    b.ToTable("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}