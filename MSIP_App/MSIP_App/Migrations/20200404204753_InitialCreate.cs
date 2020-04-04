using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MSIP_App.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calendars",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(nullable: true),
                    Designator = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    DateJoined = table.Column<DateTime>(nullable: false),
                    Bio = table.Column<string>(nullable: true),
                    LinkedInURL = table.Column<string>(nullable: true),
                    GitHubURL = table.Column<string>(nullable: true),
                    ForumPriv = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignmentName = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    AssignmentClassId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignments_Courses_AssignmentClassId",
                        column: x => x.AssignmentClassId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Forums",
                columns: table => new
                {
                    MessageId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicName = table.Column<string>(nullable: true),
                    Importance = table.Column<int>(nullable: false),
                    MessageBody = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    ForumUserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Forums_Users_ForumUserId",
                        column: x => x.ForumUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    TaskOwnerId = table.Column<long>(nullable: true),
                    IsComplete = table.Column<bool>(nullable: false),
                    CalendarId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Calendars_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "Calendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_TaskOwnerId",
                        column: x => x.TaskOwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GradeTrackers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeTrackerUserId = table.Column<long>(nullable: true),
                    UserClassId = table.Column<long>(nullable: true),
                    UserAssignmentId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeTrackers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GradeTrackers_Users_GradeTrackerUserId",
                        column: x => x.GradeTrackerUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GradeTrackers_Assignments_UserAssignmentId",
                        column: x => x.UserAssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GradeTrackers_Courses_UserClassId",
                        column: x => x.UserClassId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventData = table.Column<string>(nullable: true),
                    EventDate = table.Column<DateTime>(nullable: false),
                    EventUserId = table.Column<long>(nullable: true),
                    EventTaskId = table.Column<long>(nullable: true),
                    CalendarId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Calendars_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "Calendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Tasks_EventTaskId",
                        column: x => x.EventTaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Users_EventUserId",
                        column: x => x.EventUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_AssignmentClassId",
                table: "Assignments",
                column: "AssignmentClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CalendarId",
                table: "Events",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTaskId",
                table: "Events",
                column: "EventTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventUserId",
                table: "Events",
                column: "EventUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumUserId",
                table: "Forums",
                column: "ForumUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GradeTrackers_GradeTrackerUserId",
                table: "GradeTrackers",
                column: "GradeTrackerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GradeTrackers_UserAssignmentId",
                table: "GradeTrackers",
                column: "UserAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_GradeTrackers_UserClassId",
                table: "GradeTrackers",
                column: "UserClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CalendarId",
                table: "Tasks",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskOwnerId",
                table: "Tasks",
                column: "TaskOwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Forums");

            migrationBuilder.DropTable(
                name: "GradeTrackers");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Calendars");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
