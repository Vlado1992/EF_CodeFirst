﻿// <auto-generated />
using System;
using EF_CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_CodeFirst.Migrations
{
    [DbContext(typeof(StudentGradesDbContext))]
    [Migration("20241015175934_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_CodeFirst.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeId"));

                    b.Property<int?>("GradeId1")
                        .HasColumnType("int");

                    b.Property<string>("GradeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Section")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("GradeId");

                    b.HasIndex("GradeId1");

                    b.HasIndex("StudentId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            GradeId = 1,
                            GradeName = "Odličan",
                            Section = "Geografija",
                            StudentId = 1
                        },
                        new
                        {
                            GradeId = 2,
                            GradeName = "Vrlo dobar",
                            Section = "Matematika",
                            StudentId = 1
                        },
                        new
                        {
                            GradeId = 3,
                            GradeName = "Odličan",
                            Section = "Povijest",
                            StudentId = 1
                        },
                        new
                        {
                            GradeId = 4,
                            GradeName = "Dobar",
                            Section = "Geografija",
                            StudentId = 2
                        },
                        new
                        {
                            GradeId = 5,
                            GradeName = "Vrlo dobar",
                            Section = "Matematika",
                            StudentId = 2
                        },
                        new
                        {
                            GradeId = 6,
                            GradeName = "Odličan",
                            Section = "Povijest",
                            StudentId = 2
                        },
                        new
                        {
                            GradeId = 7,
                            GradeName = "Dobar",
                            Section = "Engleski jezik",
                            StudentId = 2
                        });
                });

            modelBuilder.Entity("EF_CodeFirst.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("StudentID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentID = 1,
                            DateOfBirth = new DateTime(2003, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 185.5m,
                            StudentName = "Pero Perić",
                            Weight = 91.5f
                        },
                        new
                        {
                            StudentID = 2,
                            DateOfBirth = new DateTime(2004, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 167.5m,
                            StudentName = "Ana Anić",
                            Weight = 62.3f
                        });
                });

            modelBuilder.Entity("EF_CodeFirst.Models.Grade", b =>
                {
                    b.HasOne("EF_CodeFirst.Models.Grade", null)
                        .WithMany("Grades")
                        .HasForeignKey("GradeId1");

                    b.HasOne("EF_CodeFirst.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EF_CodeFirst.Models.Grade", b =>
                {
                    b.Navigation("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}
