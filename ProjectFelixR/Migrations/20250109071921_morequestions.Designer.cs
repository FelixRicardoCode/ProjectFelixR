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
    [Migration("20250109071921_morequestions")]
    partial class morequestions
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectFelixR.Models.Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("custom_int1_question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("custom_int2_question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("custom_int3_question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("custom_int4_question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("custom_string1_question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("custom_string2_question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("custom_string3_question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("custom_string4_question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("custom_text1_question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("custom_text2_question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("custom_text3_question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("custom_text4_question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Templates");
                });
#pragma warning restore 612, 618
        }
    }
}
