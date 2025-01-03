﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectFelixR.Models;

#nullable disable

namespace ProjectFelixR.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20250103053056_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectFelixR.Models.Templates", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("custom_int1_question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("custom_int1_state")
                        .HasColumnType("bit");

                    b.Property<string>("custom_int2_question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("custom_int2_state")
                        .HasColumnType("bit");

                    b.Property<string>("custom_int3_question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("custom_int3_state")
                        .HasColumnType("bit");

                    b.Property<string>("custom_int4_question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("custom_int4_state")
                        .HasColumnType("bit");

                    b.Property<string>("custom_string1_question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("custom_string1_state")
                        .HasColumnType("bit");

                    b.Property<string>("custom_string2_question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("custom_string2_state")
                        .HasColumnType("bit");

                    b.Property<string>("custom_string3_question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("custom_string3_state")
                        .HasColumnType("bit");

                    b.Property<string>("custom_string4_question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("custom_string4_state")
                        .HasColumnType("bit");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("topic_id")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Clubs");
                });
#pragma warning restore 612, 618
        }
    }
}