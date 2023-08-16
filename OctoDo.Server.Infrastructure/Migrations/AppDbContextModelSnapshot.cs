﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OctoDo.Server.Infrastructure.Data;

#nullable disable

namespace OctoDo.Server.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OctoDo.Server.Domain.Entities.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<Guid>("RoutineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoutineId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("OctoDo.Server.Domain.Entities.Routine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DaysOfMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DaysOfWeek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecurrenceType")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Routine");
                });

            modelBuilder.Entity("OctoDo.Server.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("OctoDo.Server.Domain.Entities.Activity", b =>
                {
                    b.HasOne("OctoDo.Server.Domain.Entities.Routine", "Routine")
                        .WithMany("Activities")
                        .HasForeignKey("RoutineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Routine");
                });

            modelBuilder.Entity("OctoDo.Server.Domain.Entities.Routine", b =>
                {
                    b.HasOne("OctoDo.Server.Domain.Entities.User", "User")
                        .WithMany("Routines")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OctoDo.Server.Domain.Entities.Routine", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("OctoDo.Server.Domain.Entities.User", b =>
                {
                    b.Navigation("Routines");
                });
#pragma warning restore 612, 618
        }
    }
}