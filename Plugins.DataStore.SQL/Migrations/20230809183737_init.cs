using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyPackage");

            migrationBuilder.DropTable(
                name: "CompanyUserShortlistedJobSeeker");

            migrationBuilder.DropTable(
                name: "JobKeyword");

            migrationBuilder.DropTable(
                name: "JobSeekerAppliedJob");

            migrationBuilder.DropTable(
                name: "JobSeekerEducationDetail");

            migrationBuilder.DropTable(
                name: "JobSeekerEmployementDetail");

            migrationBuilder.DropTable(
                name: "JobSeekerKeySkill");

            migrationBuilder.DropTable(
                name: "JobSeekerLanguage");

            migrationBuilder.DropTable(
                name: "JobSeekerPersonalDetail");

            migrationBuilder.DropTable(
                name: "JobSeekerProfessionalDetail");

            migrationBuilder.DropTable(
                name: "JobSeekerProfileSummary");

            migrationBuilder.DropTable(
                name: "JobSeekerSavedJob");

            migrationBuilder.DropTable(
                name: "JobSeekerSkillsCertification");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "QuestionsAnswer");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "WorkplaceType");

            migrationBuilder.DropTable(
                name: "CompanyUser");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "Religion");

            migrationBuilder.DropTable(
                name: "VisaStatus");

            migrationBuilder.DropTable(
                name: "Availability");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "WorkLevel");

            migrationBuilder.DropTable(
                name: "JobSeeker");

            migrationBuilder.DropTable(
                name: "JobQuestion");

            migrationBuilder.DropTable(
                name: "CompanyJob");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "FunctionalArea");

            migrationBuilder.DropTable(
                name: "JobType");

            migrationBuilder.DropTable(
                name: "Nationality");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Industry");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.CreateTable(
                name: "UserDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CapsuleName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDatas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDatas");

            migrationBuilder.CreateTable(
                name: "Availability",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availability", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreationUserName = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FunctionalArea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunctionalArea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Industry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobSeeker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoverLetterPath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    CurrentCity = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CVHeadline = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    Eamil = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FullNameAr = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FullNameEn = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProfilePicturePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ResumePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeeker", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidatesShortlist = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(750)", maxLength: 750, nullable: true),
                    FeatureList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    JobPostAllowed = table.Column<int>(type: "int", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VisaStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisaStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkplaceType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkplaceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Country",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerAppliedJob",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerAppliedJob", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSeekerAppliedJob_JobSeeker",
                        column: x => x.JobSeekerId,
                        principalTable: "JobSeeker",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerEducationDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    InstituteLocationId = table.Column<int>(type: "int", nullable: false),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    InstituteName = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PassingYear = table.Column<int>(type: "int", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerEducationDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSeekerEducationDetail_Country",
                        column: x => x.InstituteLocationId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekerEducationDetail_Course",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekerEducationDetail_JobSeeker",
                        column: x => x.JobSeekerId,
                        principalTable: "JobSeeker",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerEmployementDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    CompanyLocation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FromMonth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FromYear = table.Column<int>(type: "int", nullable: false),
                    IsCurrentCompany = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    JobProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ToMonth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ToYear = table.Column<int>(type: "int", nullable: true),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerEmployementDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSeekerEmployementDetail_JobSeeker",
                        column: x => x.JobSeekerId,
                        principalTable: "JobSeeker",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerKeySkill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerKeySkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSeekerKeySkill_JobSeeker",
                        column: x => x.JobSeekerId,
                        principalTable: "JobSeeker",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelKnown = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
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

            migrationBuilder.CreateTable(
                name: "JobSeekerProfileSummary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerProfileSummary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSeekerProfileSummary_JobSeeker",
                        column: x => x.JobSeekerId,
                        principalTable: "JobSeeker",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerSavedJob",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerSavedJob", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSeekerSavedJob_JobSeeker",
                        column: x => x.JobSeekerId,
                        principalTable: "JobSeeker",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerSkillsCertification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExperienceMonth = table.Column<int>(type: "int", nullable: false),
                    ExperienceYear = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastUsed = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerSkillsCertification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSeekerSkillsCertification_JobSeeker",
                        column: x => x.JobSeekerId,
                        principalTable: "JobSeeker",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerProfessionalDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailabilityToJoinId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    FunctionalAreaId = table.Column<int>(type: "int", nullable: false),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    WorkLevelId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MonthlySalary = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    TotalWorkExperienceMonth = table.Column<int>(type: "int", nullable: false),
                    TotalWorkExperienceYear = table.Column<int>(type: "int", nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerProfessionalDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSeekerProfessionalDetail_Availability",
                        column: x => x.AvailabilityToJoinId,
                        principalTable: "Availability",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekerProfessionalDetail_Currency",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekerProfessionalDetail_FunctionalArea",
                        column: x => x.FunctionalAreaId,
                        principalTable: "FunctionalArea",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekerProfessionalDetail_Industry",
                        column: x => x.IndustryId,
                        principalTable: "Industry",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekerProfessionalDetail_JobSeeker",
                        column: x => x.JobSeekerId,
                        principalTable: "JobSeeker",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekerProfessionalDetail_WorkLevel",
                        column: x => x.WorkLevelId,
                        principalTable: "WorkLevel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    CRNumber = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EstablishmentYear = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_City",
                        column: x => x.LocationId,
                        principalTable: "City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Company_Country",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Company_Industry",
                        column: x => x.IndustryId,
                        principalTable: "Industry",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerPersonalDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentCityId = table.Column<int>(type: "int", nullable: false),
                    CurrentCountryId = table.Column<int>(type: "int", nullable: false),
                    IssuingCountryId = table.Column<int>(type: "int", nullable: false),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    MaritalStatusId = table.Column<int>(type: "int", nullable: false),
                    NationalityId = table.Column<int>(type: "int", nullable: false),
                    ReligionId = table.Column<int>(type: "int", nullable: false),
                    VisaStatusId = table.Column<int>(type: "int", nullable: false),
                    AlternateCountryCode = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    AlternateEmailId = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    AlternateMobile = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    DOB = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDrivingLicense = table.Column<bool>(type: "bit", nullable: false),
                    LanguagesKnown = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerPersonalDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSeekerPersonalDetail_City",
                        column: x => x.CurrentCityId,
                        principalTable: "City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekerPersonalDetail_Country",
                        column: x => x.IssuingCountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekerPersonalDetail_Country1",
                        column: x => x.CurrentCountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekerPersonalDetail_JobSeeker",
                        column: x => x.JobSeekerId,
                        principalTable: "JobSeeker",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekerPersonalDetail_MaritalStatus",
                        column: x => x.MaritalStatusId,
                        principalTable: "MaritalStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekerPersonalDetail_Nationality",
                        column: x => x.NationalityId,
                        principalTable: "Nationality",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekerPersonalDetail_Religion",
                        column: x => x.ReligionId,
                        principalTable: "Religion",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekerPersonalDetail_VisaStatus",
                        column: x => x.VisaStatusId,
                        principalTable: "VisaStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompanyJob",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    FunctinalAreaId = table.Column<int>(type: "int", nullable: false),
                    JobLocationId = table.Column<int>(type: "int", nullable: false),
                    JobTypeId = table.Column<int>(type: "int", nullable: false),
                    NationalityId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    Experieance = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    JobViews = table.Column<int>(type: "int", nullable: true),
                    KeySkill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TotalNoOfVacancy = table.Column<int>(type: "int", nullable: true),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyJob", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyJob_City",
                        column: x => x.JobLocationId,
                        principalTable: "City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyJob_Company",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyJob_Country",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyJob_FunctionalArea",
                        column: x => x.FunctinalAreaId,
                        principalTable: "FunctionalArea",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyJob_JobType",
                        column: x => x.JobTypeId,
                        principalTable: "JobType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyJob_Nationality",
                        column: x => x.NationalityId,
                        principalTable: "Nationality",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompanyPackage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PackageId = table.Column<int>(type: "int", maxLength: 250, nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPackage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyPackage_Company",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompanyUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyUser_Company",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobKeyword",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobKeyword", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobKeyword_CompanyJob",
                        column: x => x.JobId,
                        principalTable: "CompanyJob",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Question = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobQuestion_CompanyJob",
                        column: x => x.JobId,
                        principalTable: "CompanyJob",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompanyUserShortlistedJobSeeker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyUserId = table.Column<int>(type: "int", nullable: false),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "QuestionsAnswer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(dateadd(hour,(3),getutcdate()))"),
                    CreationUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    DeletedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    JobSeekerId = table.Column<int>(type: "int", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserDefined1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDefined4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionsAnswer_JobQuestion",
                        column: x => x.QuestionId,
                        principalTable: "JobQuestion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_CountryId",
                table: "Company",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_IndustryId",
                table: "Company",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_LocationId",
                table: "Company",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJob_CompanyId",
                table: "CompanyJob",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJob_CountryId",
                table: "CompanyJob",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJob_FunctinalAreaId",
                table: "CompanyJob",
                column: "FunctinalAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJob_JobLocationId",
                table: "CompanyJob",
                column: "JobLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJob_JobTypeId",
                table: "CompanyJob",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJob_NationalityId",
                table: "CompanyJob",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPackage_CompanyId",
                table: "CompanyPackage",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUser_CompanyId",
                table: "CompanyUser",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUserShortlistedJobSeeker_CompanyUserId",
                table: "CompanyUserShortlistedJobSeeker",
                column: "CompanyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUserShortlistedJobSeeker_JobSeekerId",
                table: "CompanyUserShortlistedJobSeeker",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobKeyword_JobId",
                table: "JobKeyword",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobQuestion_JobId",
                table: "JobQuestion",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerAppliedJob_JobSeekerId",
                table: "JobSeekerAppliedJob",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerEducationDetail_CourseId",
                table: "JobSeekerEducationDetail",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerEducationDetail_InstituteLocationId",
                table: "JobSeekerEducationDetail",
                column: "InstituteLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerEducationDetail_JobSeekerId",
                table: "JobSeekerEducationDetail",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerEmployementDetail_JobSeekerId",
                table: "JobSeekerEmployementDetail",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerKeySkill_JobSeekerId",
                table: "JobSeekerKeySkill",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerLanguage_JobSeekerId",
                table: "JobSeekerLanguage",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerPersonalDetail_CurrentCityId",
                table: "JobSeekerPersonalDetail",
                column: "CurrentCityId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerPersonalDetail_CurrentCountryId",
                table: "JobSeekerPersonalDetail",
                column: "CurrentCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerPersonalDetail_IssuingCountryId",
                table: "JobSeekerPersonalDetail",
                column: "IssuingCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerPersonalDetail_JobSeekerId",
                table: "JobSeekerPersonalDetail",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerPersonalDetail_MaritalStatusId",
                table: "JobSeekerPersonalDetail",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerPersonalDetail_NationalityId",
                table: "JobSeekerPersonalDetail",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerPersonalDetail_ReligionId",
                table: "JobSeekerPersonalDetail",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerPersonalDetail_VisaStatusId",
                table: "JobSeekerPersonalDetail",
                column: "VisaStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerProfessionalDetail_AvailabilityToJoinId",
                table: "JobSeekerProfessionalDetail",
                column: "AvailabilityToJoinId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerProfessionalDetail_CurrencyId",
                table: "JobSeekerProfessionalDetail",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerProfessionalDetail_FunctionalAreaId",
                table: "JobSeekerProfessionalDetail",
                column: "FunctionalAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerProfessionalDetail_IndustryId",
                table: "JobSeekerProfessionalDetail",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerProfessionalDetail_JobSeekerId",
                table: "JobSeekerProfessionalDetail",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerProfessionalDetail_WorkLevelId",
                table: "JobSeekerProfessionalDetail",
                column: "WorkLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerProfileSummary_JobSeekerId",
                table: "JobSeekerProfileSummary",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerSavedJob_JobSeekerId",
                table: "JobSeekerSavedJob",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerSkillsCertification_JobSeekerId",
                table: "JobSeekerSkillsCertification",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionsAnswer_QuestionId",
                table: "QuestionsAnswer",
                column: "QuestionId");
        }
    }
}
