﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WorkoutApi.Models;

namespace WorkoutApi.Migrations
{
    [DbContext(typeof(WorkoutApiContext))]
    [Migration("20171002191950_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorkoutApi.Models.Exercise", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("MuscleGroup");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("WorkoutApi.Models.Set", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ExcerciseId");

                    b.Property<int>("RepetitionsCount");

                    b.Property<decimal>("Weight");

                    b.Property<int>("WorkoutId");

                    b.HasKey("ID");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Set");
                });

            modelBuilder.Entity("WorkoutApi.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Gender");

                    b.Property<string>("Lastname");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<DateTime>("RegistrationDate");

                    b.Property<int>("UserLevel");

                    b.Property<int>("UserStatus");

                    b.HasKey("Username");

                    b.ToTable("User");
                });

            modelBuilder.Entity("WorkoutApi.Models.UserInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<decimal>("BicepsSize");

                    b.Property<decimal>("ChestSize");

                    b.Property<DateTime>("Date");

                    b.Property<decimal>("Height");

                    b.Property<decimal>("Mass");

                    b.Property<decimal>("ThightSize");

                    b.Property<int?>("UserInfoID");

                    b.Property<string>("Username");

                    b.Property<decimal>("WaistSize");

                    b.HasKey("ID");

                    b.HasIndex("UserInfoID");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("WorkoutApi.Models.Workout", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Name");

                    b.Property<int?>("UserInfoID");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.HasIndex("UserInfoID");

                    b.ToTable("Workout");
                });

            modelBuilder.Entity("WorkoutApi.Models.Set", b =>
                {
                    b.HasOne("WorkoutApi.Models.Workout")
                        .WithMany("SetsList")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorkoutApi.Models.UserInfo", b =>
                {
                    b.HasOne("WorkoutApi.Models.UserInfo")
                        .WithMany("UserHistory")
                        .HasForeignKey("UserInfoID");
                });

            modelBuilder.Entity("WorkoutApi.Models.Workout", b =>
                {
                    b.HasOne("WorkoutApi.Models.UserInfo")
                        .WithMany("WorkoutHistory")
                        .HasForeignKey("UserInfoID");
                });
#pragma warning restore 612, 618
        }
    }
}
