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
    [Migration("20200510181627_UrlsAdded")]
    partial class UrlsAdded
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
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentClassId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("MSIP_App.Models.Classes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

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

                    b.Property<string>("EventData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("EventTaskId")
                        .HasColumnType("bigint");

                    b.Property<long?>("EventUserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("TopicName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

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

                    b.HasIndex("TaskOwnerId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("MSIP_App.Models.Urls", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Urls");
                });

            modelBuilder.Entity("MSIP_App.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateJoined")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("ForumPriv")
                        .HasColumnType("int");

                    b.Property<string>("GitHubURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LinkedInURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

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
                    b.HasOne("MSIP_App.Models.User", "TaskOwner")
                        .WithMany()
                        .HasForeignKey("TaskOwnerId");
                });
#pragma warning restore 612, 618
        }
    }
}
