﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentMgmtAPI.Data;

namespace StudentMgmtAPI.Migrations
{
    [DbContext(typeof(StudentMgmtAPIContext))]
    partial class StudentMgmtAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("StudentMgmtAPI.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("course_Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("course_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("student_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("student_Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("student_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
