using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class FielAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CandidatesShortlist",
                table: "Package",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobPostAllowed",
                table: "Package",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "AlternateMobile",
                table: "JobSeekerPersonalDetail",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentCountryId",
                table: "JobSeekerPersonalDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CompanyUser",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "CompanyUser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "CompanyJob",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "KeySkill",
                table: "CompanyJob",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CompanyUserShortlistedJobSeeker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyUserId = table.Column<int>(type: "int", nullable: false),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyUserShortlistedJobSeeker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyUserShortlistedJobSeeker_CompanyUser",
                        column: x => x.CompanyUserId,
                        principalTable: "CompanyUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyUserShortlistedJobSeeker_JobSeeker",
                        column: x => x.JobSeekerId,
                        principalTable: "JobSeeker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LevelKnown = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerLanguage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSeekerLanguage_JobSeeker",
                        column: x => x.JobSeekerId,
                        principalTable: "JobSeeker",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerPersonalDetail_CurrentCountryId",
                table: "JobSeekerPersonalDetail",
                column: "CurrentCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJob_CountryId",
                table: "CompanyJob",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_CountryId",
                table: "Company",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUserShortlistedJobSeeker_CompanyUserId",
                table: "CompanyUserShortlistedJobSeeker",
                column: "CompanyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUserShortlistedJobSeeker_JobSeekerId",
                table: "CompanyUserShortlistedJobSeeker",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerLanguage_JobSeekerId",
                table: "JobSeekerLanguage",
                column: "JobSeekerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Country",
                table: "Company",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyJob_Country",
                table: "CompanyJob",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerPersonalDetail_Country1",
                table: "JobSeekerPersonalDetail",
                column: "CurrentCountryId",
                principalTable: "Country",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Country",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyJob_Country",
                table: "CompanyJob");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerPersonalDetail_Country1",
                table: "JobSeekerPersonalDetail");

            migrationBuilder.DropTable(
                name: "CompanyUserShortlistedJobSeeker");

            migrationBuilder.DropTable(
                name: "JobSeekerLanguage");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekerPersonalDetail_CurrentCountryId",
                table: "JobSeekerPersonalDetail");

            migrationBuilder.DropIndex(
                name: "IX_CompanyJob_CountryId",
                table: "CompanyJob");

            migrationBuilder.DropIndex(
                name: "IX_Company_CountryId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CandidatesShortlist",
                table: "Package");

            migrationBuilder.DropColumn(
                name: "JobPostAllowed",
                table: "Package");

            migrationBuilder.DropColumn(
                name: "CurrentCountryId",
                table: "JobSeekerPersonalDetail");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CompanyUser");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "CompanyUser");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "CompanyJob");

            migrationBuilder.DropColumn(
                name: "KeySkill",
                table: "CompanyJob");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Company");

            migrationBuilder.AlterColumn<string>(
                name: "AlternateMobile",
                table: "JobSeekerPersonalDetail",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldNullable: true);
        }
    }
}
