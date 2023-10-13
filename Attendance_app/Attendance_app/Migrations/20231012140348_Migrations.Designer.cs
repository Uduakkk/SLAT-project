﻿// <auto-generated />
using System;
using Attendance.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Attendance_app.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231012140348_Migrations")]
    partial class Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Attendance.Core.DataModels.AdminsDataModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Attendance.Core.DataModels.AttendeesDataModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LecturesDataModelId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("LecturesDataModelId");

                    b.ToTable("Attendees");
                });

            modelBuilder.Entity("Attendance.Core.DataModels.CoursesDataModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Attendance.Core.DataModels.LecturerCoursesDataModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoursesDataModelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LecturerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CoursesDataModelId");

                    b.HasIndex("LecturerId");

                    b.ToTable("LecturerCourses");
                });

            modelBuilder.Entity("Attendance.Core.DataModels.LecturersDataModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessCode")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("Attendance.Core.DataModels.LecturesDataModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LecturerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("LecturerId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("Attendance.Core.DataModels.StudentCoursesDataModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("Attendance.Core.DataModels.StudentsDataModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessCode")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatricNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Attendance.Core.DataModels.AttendeesDataModel", b =>
                {
                    b.HasOne("Attendance.Core.DataModels.LecturesDataModel", null)
                        .WithMany("Attendees")
                        .HasForeignKey("LecturesDataModelId");
                });

            modelBuilder.Entity("Attendance.Core.DataModels.LecturerCoursesDataModel", b =>
                {
                    b.HasOne("Attendance.Core.DataModels.CoursesDataModel", null)
                        .WithMany("Lecturers")
                        .HasForeignKey("CoursesDataModelId");

                    b.HasOne("Attendance.Core.DataModels.LecturersDataModel", "Lecturer")
                        .WithMany()
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecturer");
                });

            modelBuilder.Entity("Attendance.Core.DataModels.LecturesDataModel", b =>
                {
                    b.HasOne("Attendance.Core.DataModels.CoursesDataModel", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Attendance.Core.DataModels.LecturersDataModel", "Lecturer")
                        .WithMany("Lectures")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Lecturer");
                });

            modelBuilder.Entity("Attendance.Core.DataModels.StudentCoursesDataModel", b =>
                {
                    b.HasOne("Attendance.Core.DataModels.CoursesDataModel", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Attendance.Core.DataModels.StudentsDataModel", "Student")
                        .WithMany("RegisteredCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Attendance.Core.DataModels.CoursesDataModel", b =>
                {
                    b.Navigation("Lecturers");
                });

            modelBuilder.Entity("Attendance.Core.DataModels.LecturersDataModel", b =>
                {
                    b.Navigation("Lectures");
                });

            modelBuilder.Entity("Attendance.Core.DataModels.LecturesDataModel", b =>
                {
                    b.Navigation("Attendees");
                });

            modelBuilder.Entity("Attendance.Core.DataModels.StudentsDataModel", b =>
                {
                    b.Navigation("RegisteredCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
