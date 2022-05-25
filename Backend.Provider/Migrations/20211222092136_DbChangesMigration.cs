using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DealStoreweb.Backend.Migrations
{
    public partial class DbChangesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase(
                collation: "SQL_Latin1_General_CP1_CI_AS");

            migrationBuilder.CreateTable(
                name: "CategoryTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRef = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDatetimeOn = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDatetimeOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CreatedDatetimeOn = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDatetimeOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTbl",
                columns: table => new
                {
                    UserRef = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsNotifyEmail = table.Column<bool>(type: "bit", nullable: false),
                    IsNotifySms = table.Column<bool>(type: "bit", nullable: false),
                    IsServiceProvider = table.Column<bool>(type: "bit", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CreatedDatetimeOn = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDatetimeOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.UserRef);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description_Short = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDatetimeOn = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDatetimeOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceTbl_CategoryTbl",
                        column: x => x.CategoryId,
                        principalTable: "CategoryTbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProviderTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Occupation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserRef = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDatetimeOn = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDatetimeOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderTbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProviderTbl_UserTbl",
                        column: x => x.UserRef,
                        principalTable: "UserTbl",
                        principalColumn: "UserRef",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Provider_RequestTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    RequestId = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    IsDenied = table.Column<bool>(type: "bit", nullable: false),
                    IsHandled = table.Column<bool>(type: "bit", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDatetimeOn = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Provider_RequestTbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Provider_RequestTbl_CustomerTbl",
                        column: x => x.CustomerId,
                        principalTable: "CustomerTbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Provider_RequestTbl_ProviderTbl",
                        column: x => x.ProviderId,
                        principalTable: "ProviderTbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Provider_RequestTbl_RequestTbl",
                        column: x => x.RequestId,
                        principalTable: "RequestTbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Provider_RequestTbl_CustomerId",
                table: "Customer_Provider_RequestTbl",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Provider_RequestTbl_ProviderId",
                table: "Customer_Provider_RequestTbl",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Provider_RequestTbl_RequestId",
                table: "Customer_Provider_RequestTbl",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderTbl_UserRef",
                table: "ProviderTbl",
                column: "UserRef");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTbl_CategoryId",
                table: "ServiceTbl",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer_Provider_RequestTbl");

            migrationBuilder.DropTable(
                name: "ServiceTbl");

            migrationBuilder.DropTable(
                name: "CustomerTbl");

            migrationBuilder.DropTable(
                name: "ProviderTbl");

            migrationBuilder.DropTable(
                name: "RequestTbl");

            migrationBuilder.DropTable(
                name: "CategoryTbl");

            migrationBuilder.DropTable(
                name: "UserTbl");

            migrationBuilder.AlterDatabase(
                oldCollation: "SQL_Latin1_General_CP1_CI_AS");
        }
    }
}
