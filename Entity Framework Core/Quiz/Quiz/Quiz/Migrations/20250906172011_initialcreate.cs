using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quiz.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    MemberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.MemberID);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "TapeDVD",
                columns: table => new
                {
                    CopyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchasedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchasedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapeDVD", x => x.CopyID);
                    table.ForeignKey(
                        name: "FK_TapeDVD_Movie_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movie",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TapeDVD_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rent",
                columns: table => new
                {
                    RentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    charge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MemberID = table.Column<int>(type: "int", nullable: false),
                    CopyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rent", x => x.RentID);
                    table.ForeignKey(
                        name: "FK_Rent_Member_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rent_TapeDVD_CopyID",
                        column: x => x.CopyID,
                        principalTable: "TapeDVD",
                        principalColumn: "CopyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rent_CopyID",
                table: "Rent",
                column: "CopyID");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_MemberID",
                table: "Rent",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_TapeDVD_MovieID",
                table: "TapeDVD",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_TapeDVD_SupplierID",
                table: "TapeDVD",
                column: "SupplierID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rent");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "TapeDVD");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}
