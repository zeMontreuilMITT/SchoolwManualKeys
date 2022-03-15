﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolwManualKeys.Data;

#nullable disable

namespace SchoolwManualKeys.Migrations
{
    [DbContext(typeof(SchoolwManualKeysContext))]
    [Migration("20220315143255_EnrolledCourseAndStudentFK")]
    partial class EnrolledCourseAndStudentFK
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolwManualKeys.Models.Course", b =>
                {
                    b.Property<int>("CourseNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseNumber"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CourseNumber");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("SchoolwManualKeys.Models.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EnrolledCourseNumber")
                        .HasColumnType("int");

                    b.Property<int>("EnrolledStudent")
                        .HasColumnType("int");

                    b.Property<int>("EnrolledStudentNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnrolledCourseNumber");

                    b.HasIndex("EnrolledStudent");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("SchoolwManualKeys.Models.Student", b =>
                {
                    b.Property<int>("StudentNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentNumber"), 1L, 1);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("StudentNumber");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("SchoolwManualKeys.Models.Enrollment", b =>
                {
                    b.HasOne("SchoolwManualKeys.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("EnrolledCourseNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolwManualKeys.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("EnrolledStudent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SchoolwManualKeys.Models.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("SchoolwManualKeys.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
