﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using usue_online_tests.Data;

namespace usue_online_tests.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("usue_online_tests.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateTimeEnd")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateTimeStart")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Group")
                        .HasColumnType("text");

                    b.Property<int?>("PresetId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PresetId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("usue_online_tests.Models.TestPreset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("OwnerID")
                        .HasColumnType("integer");

                    b.Property<int[]>("Tests")
                        .HasColumnType("integer[]");

                    b.HasKey("Id");

                    b.HasIndex("OwnerID");

                    b.ToTable("Presets");
                });

            modelBuilder.Entity("usue_online_tests.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Group")
                        .HasColumnType("text");

                    b.Property<bool>("IsDark")
                        .HasColumnType("boolean");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("usue_online_tests.Models.Exam", b =>
                {
                    b.HasOne("usue_online_tests.Models.TestPreset", "Preset")
                        .WithMany()
                        .HasForeignKey("PresetId");

                    b.Navigation("Preset");
                });

            modelBuilder.Entity("usue_online_tests.Models.TestPreset", b =>
                {
                    b.HasOne("usue_online_tests.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerID");

                    b.Navigation("Owner");
                });
#pragma warning restore 612, 618
        }
    }
}
