﻿// <auto-generated />
using System;
using MSIP_App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MSIP_App.Migrations
{
    [DbContext(typeof(MSIPContext))]
    [Migration("20200409133936_Users")]
    partial class Users
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MSIP_App.Models.Assignments", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AssignmentClassId")
                        .HasColumnType("bigint");

                    b.Property<string>("AssignmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentClassId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("MSIP_App.Models.Calendar", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("MSIP_App.Models.Classes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designator")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("MSIP_App.Models.Events", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CalendarId")
                        .HasColumnType("bigint");

                    b.Property<string>("EventData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("EventTaskId")
                        .HasColumnType("bigint");

                    b.Property<long?>("EventUserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CalendarId");

                    b.HasIndex("EventTaskId");

                    b.HasIndex("EventUserId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("MSIP_App.Models.Forum", b =>
                {
                    b.Property<long>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ForumUserId")
                        .HasColumnType("bigint");

                    b.Property<int>("Importance")
                        .HasColumnType("int");

                    b.Property<string>("MessageBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("TopicName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageId");

                    b.HasIndex("ForumUserId");

                    b.ToTable("Forums");
                });

            modelBuilder.Entity("MSIP_App.Models.GradeTracker", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("GradeTrackerUserId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserAssignmentId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserClassId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("GradeTrackerUserId");

                    b.HasIndex("UserAssignmentId");

                    b.HasIndex("UserClassId");

                    b.ToTable("GradeTrackers");
                });

            modelBuilder.Entity("MSIP_App.Models.Tasks", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CalendarId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("TaskOwnerId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CalendarId");

                    b.HasIndex("TaskOwnerId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("MSIP_App.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ForumPriv")
                        .HasColumnType("int");

                    b.Property<string>("GitHubURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedInURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MSIP_App.Models.Assignments", b =>
                {
                    b.HasOne("MSIP_App.Models.Classes", "AssignmentClass")
                        .WithMany()
                        .HasForeignKey("AssignmentClassId");
                });

            modelBuilder.Entity("MSIP_App.Models.Events", b =>
                {
                    b.HasOne("MSIP_App.Models.Calendar", null)
                        .WithMany("Events")
                        .HasForeignKey("CalendarId");

                    b.HasOne("MSIP_App.Models.Tasks", "EventTask")
                        .WithMany()
                        .HasForeignKey("EventTaskId");

                    b.HasOne("MSIP_App.Models.User", "EventUser")
                        .WithMany()
                        .HasForeignKey("EventUserId");
                });

            modelBuilder.Entity("MSIP_App.Models.Forum", b =>
                {
                    b.HasOne("MSIP_App.Models.User", "ForumUser")
                        .WithMany()
                        .HasForeignKey("ForumUserId");
                });

            modelBuilder.Entity("MSIP_App.Models.GradeTracker", b =>
                {
                    b.HasOne("MSIP_App.Models.User", "GradeTrackerUser")
                        .WithMany()
                        .HasForeignKey("GradeTrackerUserId");

                    b.HasOne("MSIP_App.Models.Assignments", "UserAssignment")
                        .WithMany()
                        .HasForeignKey("UserAssignmentId");

                    b.HasOne("MSIP_App.Models.Classes", "UserClass")
                        .WithMany()
                        .HasForeignKey("UserClassId");
                });

            modelBuilder.Entity("MSIP_App.Models.Tasks", b =>
                {
                    b.HasOne("MSIP_App.Models.Calendar", null)
                        .WithMany("Tasks")
                        .HasForeignKey("CalendarId");

                    b.HasOne("MSIP_App.Models.User", "TaskOwner")
                        .WithMany()
                        .HasForeignKey("TaskOwnerId");
                });
#pragma warning restore 612, 618
        }
    }
}
