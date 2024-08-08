using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Color = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Price = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    PlateNumber = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    LastModified = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "BIT", nullable: false),
                    LastDeleted = table.Column<DateTime>(type: "DATETIME2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(254)", nullable: false),
                    PasswordHash = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    LastModified = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "BIT", nullable: false),
                    LastDeleted = table.Column<DateTime>(type: "DATETIME2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "INT", nullable: false),
                    CarId = table.Column<int>(type: "INT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    TypeOfInsurance = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    Premium = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    Status = table.Column<int>(type: "INT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "BIT", nullable: false),
                    LastDeleted = table.Column<DateTime>(type: "DATETIME2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Insurances_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Insurances_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_CarId",
                table: "Insurances",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_UserId",
                table: "Insurances",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
