﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Moodle.DAL.Migrations
{
    [DbContext(typeof(MoodleContext))]
    [Migration("20240220192246_v8")]
    partial class v8
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Moodle.Domain.entities.Assessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Assessment");
                });

            modelBuilder.Entity("Moodle.Domain.entities.AssessmentResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssessmentId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentId");

                    b.HasIndex("UserId");

                    b.ToTable("AssessmentResult");
                });

            modelBuilder.Entity("Moodle.Domain.entities.Courses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CursusId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CursusId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CursusId = 1,
                            Description = "ASP.NET beginner",
                            EndDate = new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ASP.NET / Cours 1",
                            StartDate = new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CursusId = 1,
                            Description = "ASP.NET advanced",
                            EndDate = new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ASP.NET / Cours 2",
                            StartDate = new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CursusId = 1,
                            Description = "ASP.NET confirmed",
                            EndDate = new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ASP.NET / Cours 3",
                            StartDate = new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CursusId = 2,
                            Description = "Javascript beginner",
                            EndDate = new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Javascript / Cours 1",
                            StartDate = new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CursusId = 2,
                            Description = "Javascript advanced",
                            EndDate = new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Javascript / Cours 2",
                            StartDate = new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CursusId = 2,
                            Description = "Javascript confirmed",
                            EndDate = new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Javascript / Cours 3",
                            StartDate = new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CursusId = 4,
                            Description = "React beginner",
                            EndDate = new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "React / Cours 1",
                            StartDate = new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CursusId = 4,
                            Description = "React advanced",
                            EndDate = new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "React / Cours 2",
                            StartDate = new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CursusId = 4,
                            Description = "React confirmed",
                            EndDate = new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "React / Cours 3",
                            StartDate = new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Moodle.Domain.entities.Cursus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("images")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cursus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ASP.NET",
                            endDate = new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            startDate = new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Javascript",
                            endDate = new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            startDate = new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Name = "Python",
                            endDate = new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            startDate = new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Name = "React",
                            endDate = new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            startDate = new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Name = "Angular",
                            endDate = new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            startDate = new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Name = "Designer",
                            endDate = new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            startDate = new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Moodle.Domain.entities.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Module");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            EndDate = new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ASP.NET cours 1 / module 1",
                            StartDate = new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            EndDate = new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ASP.NET cours 1 / module 2",
                            StartDate = new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 1,
                            EndDate = new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ASP.NET cours 1 / module 3",
                            StartDate = new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            EndDate = new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ASP.NET cours 2 / module 1",
                            StartDate = new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 2,
                            EndDate = new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ASP.NET cours 2 / module 2",
                            StartDate = new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 2,
                            EndDate = new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ASP.NET cours 2 / module 3",
                            StartDate = new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 3,
                            EndDate = new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ASP.NET cours 3 / module 1",
                            StartDate = new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 3,
                            EndDate = new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ASP.NET cours 3 / module 2",
                            StartDate = new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 3,
                            EndDate = new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ASP.NET cours 3 / module 3",
                            StartDate = new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Moodle.Domain.entities.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "student",
                            RoleName = "student"
                        },
                        new
                        {
                            Id = 2,
                            Description = "teacher",
                            RoleName = "teacher"
                        },
                        new
                        {
                            Id = 3,
                            Description = "admin",
                            RoleName = "admin"
                        });
                });

            modelBuilder.Entity("Moodle.Domain.entities.UserCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("UserCourse");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 1,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 8,
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 4,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Moodle.Domain.entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "arnaud.vanderschrieck@gmail.com",
                            Password = new byte[] { 92, 234, 25, 31, 124, 81, 82, 232, 50, 91, 109, 190, 221, 246, 14, 194, 162, 218, 185, 191, 78, 61, 115, 178, 239, 110, 107, 112, 190, 62, 0, 136, 66, 251, 54, 26, 59, 201, 29, 13, 82, 121, 144, 164, 167, 21, 87, 161, 226, 220, 81, 151, 54, 200, 64, 239, 173, 255, 145, 44, 65, 216, 233, 210 },
                            RoleID = 1,
                            UserName = "Arnaud"
                        },
                        new
                        {
                            Id = 2,
                            Email = "yanis.oykonomou@gmail.com",
                            Password = new byte[] { 33, 170, 206, 201, 183, 161, 10, 33, 64, 74, 153, 152, 63, 130, 4, 88, 93, 90, 109, 11, 87, 113, 36, 195, 74, 145, 176, 215, 13, 25, 238, 105, 96, 191, 222, 75, 241, 199, 93, 65, 192, 156, 218, 128, 160, 158, 39, 129, 248, 180, 249, 8, 146, 19, 61, 43, 6, 77, 19, 221, 181, 9, 115, 209 },
                            RoleID = 1,
                            UserName = "Yanis"
                        },
                        new
                        {
                            Id = 3,
                            Email = "padraig.kisembe@gmail.com",
                            Password = new byte[] { 144, 6, 181, 197, 11, 38, 42, 22, 231, 52, 190, 238, 109, 16, 35, 37, 101, 18, 206, 10, 38, 102, 210, 6, 240, 227, 147, 108, 159, 188, 7, 128, 233, 63, 52, 84, 142, 221, 180, 112, 76, 172, 122, 184, 89, 220, 181, 5, 173, 146, 24, 227, 254, 41, 219, 126, 230, 117, 30, 172, 175, 111, 188, 143 },
                            RoleID = 1,
                            UserName = "Padraig"
                        },
                        new
                        {
                            Id = 4,
                            Email = "hamza.tsebien@gmail.com",
                            Password = new byte[] { 18, 63, 213, 210, 27, 123, 94, 78, 223, 137, 32, 49, 147, 136, 16, 72, 215, 77, 171, 217, 175, 153, 214, 153, 219, 53, 109, 234, 36, 117, 196, 64, 185, 65, 58, 102, 204, 66, 78, 23, 248, 43, 24, 9, 155, 239, 93, 100, 19, 209, 9, 153, 166, 154, 52, 53, 190, 10, 234, 99, 84, 187, 78, 84 },
                            RoleID = 1,
                            UserName = "Hamza"
                        },
                        new
                        {
                            Id = 5,
                            Email = "dumb.ledore@gmail.com",
                            Password = new byte[] { 222, 71, 3, 88, 232, 85, 168, 45, 78, 123, 226, 124, 141, 34, 156, 40, 171, 51, 48, 235, 200, 212, 30, 4, 8, 228, 155, 69, 26, 123, 175, 163, 144, 211, 231, 73, 197, 97, 234, 17, 3, 249, 97, 100, 135, 134, 145, 222, 227, 27, 176, 31, 147, 9, 14, 205, 114, 27, 49, 27, 163, 133, 190, 222 },
                            RoleID = 2,
                            UserName = "Dumbledore"
                        },
                        new
                        {
                            Id = 6,
                            Email = "cloud.strife@gmail.com",
                            Password = new byte[] { 62, 114, 205, 183, 87, 119, 128, 147, 48, 123, 39, 159, 201, 28, 39, 82, 17, 16, 207, 65, 206, 192, 52, 101, 85, 22, 3, 192, 117, 100, 47, 254, 124, 98, 96, 99, 162, 82, 128, 35, 50, 8, 111, 111, 47, 34, 223, 247, 65, 117, 101, 119, 188, 182, 233, 97, 252, 246, 198, 98, 79, 61, 209, 166 },
                            RoleID = 2,
                            UserName = "Cloud"
                        },
                        new
                        {
                            Id = 7,
                            Email = "test.test@gmail.com",
                            Password = new byte[] { 43, 190, 12, 72, 185, 26, 125, 27, 138, 103, 83, 168, 185, 203, 225, 219, 22, 184, 67, 121, 243, 249, 31, 225, 21, 98, 18, 132, 223, 122, 72, 241, 205, 113, 233, 190, 185, 14, 166, 20, 199, 189, 146, 66, 80, 170, 158, 68, 106, 134, 103, 37, 230, 133, 166, 93, 245, 209, 57, 165, 205, 24, 13, 201 },
                            RoleID = 2,
                            UserName = "test"
                        },
                        new
                        {
                            Id = 8,
                            Email = "boss.imtheboss@gmail.com",
                            Password = new byte[] { 162, 56, 58, 63, 77, 120, 123, 145, 11, 146, 207, 19, 255, 223, 111, 122, 97, 127, 240, 123, 91, 114, 35, 52, 64, 130, 222, 131, 188, 192, 5, 60, 7, 157, 2, 10, 29, 234, 40, 31, 181, 197, 191, 192, 36, 245, 108, 58, 47, 189, 92, 119, 157, 163, 226, 150, 85, 134, 109, 88, 130, 179, 205, 241 },
                            RoleID = 3,
                            UserName = "Boss"
                        });
                });

            modelBuilder.Entity("Moodle.Domain.entities.Assessment", b =>
                {
                    b.HasOne("Moodle.Domain.entities.Module", "Module")
                        .WithMany("Assessments")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");
                });

            modelBuilder.Entity("Moodle.Domain.entities.AssessmentResult", b =>
                {
                    b.HasOne("Moodle.Domain.entities.Assessment", "Assessment")
                        .WithMany("AssessmentResults")
                        .HasForeignKey("AssessmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moodle.Domain.entities.Users", "Users")
                        .WithMany("AssessmentResults")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assessment");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Moodle.Domain.entities.Courses", b =>
                {
                    b.HasOne("Moodle.Domain.entities.Cursus", "Cursus")
                        .WithMany("Courses")
                        .HasForeignKey("CursusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cursus");
                });

            modelBuilder.Entity("Moodle.Domain.entities.Module", b =>
                {
                    b.HasOne("Moodle.Domain.entities.Courses", "Course")
                        .WithMany("Modules")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Moodle.Domain.entities.UserCourse", b =>
                {
                    b.HasOne("Moodle.Domain.entities.Courses", "Course")
                        .WithMany("UserCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moodle.Domain.entities.Users", "User")
                        .WithMany("UserCourse")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Moodle.Domain.entities.Users", b =>
                {
                    b.HasOne("Moodle.Domain.entities.Roles", "Roles")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Moodle.Domain.entities.Assessment", b =>
                {
                    b.Navigation("AssessmentResults");
                });

            modelBuilder.Entity("Moodle.Domain.entities.Courses", b =>
                {
                    b.Navigation("Modules");

                    b.Navigation("UserCourses");
                });

            modelBuilder.Entity("Moodle.Domain.entities.Cursus", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Moodle.Domain.entities.Module", b =>
                {
                    b.Navigation("Assessments");
                });

            modelBuilder.Entity("Moodle.Domain.entities.Users", b =>
                {
                    b.Navigation("AssessmentResults");

                    b.Navigation("UserCourse");
                });
#pragma warning restore 612, 618
        }
    }
}
