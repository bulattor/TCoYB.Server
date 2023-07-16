﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TCoYB.Server.Repository;

#nullable disable

namespace TCoYB.Server.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TCoYB.Server.Models.AppUser", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Activity")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Plan")
                        .HasColumnType("int");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Username");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("TCoYB.Server.Models.FoodItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MealType")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Username");

                    b.ToTable("FoodItem");
                });

            modelBuilder.Entity("TCoYB.Server.Models.UserToken", b =>
                {
                    b.Property<string>("AccessToken")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ExpiredAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AccessToken");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("TCoYB.Server.Models.FoodItem", b =>
                {
                    b.HasOne("TCoYB.Server.Models.AppUser", null)
                        .WithMany("FoodItems")
                        .HasForeignKey("Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TCoYB.Server.Models.UserToken", b =>
                {
                    b.HasOne("TCoYB.Server.Models.AppUser", null)
                        .WithOne("UserToken")
                        .HasForeignKey("TCoYB.Server.Models.UserToken", "Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TCoYB.Server.Models.AppUser", b =>
                {
                    b.Navigation("FoodItems");

                    b.Navigation("UserToken");
                });
#pragma warning restore 612, 618
        }
    }
}