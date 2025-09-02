using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task2.Migrations
{
    /// <inheritdoc />
    public partial class Task2Relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentID",
                table: "Students",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_Course_ID",
                table: "Stud_Courses",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors",
                column: "Dept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerId",
                table: "Departments",
                column: "ManagerId",
                unique: true,
                filter: "[ManagerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses",
                column: "Top_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_Course_ID",
                table: "Course_Insts",
                column: "Course_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Courses_Course_ID",
                table: "Course_Insts",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Instructors_Inst_ID",
                table: "Course_Insts",
                column: "Inst_ID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                table: "Courses",
                column: "Top_ID",
                principalTable: "Topics",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_ManagerId",
                table: "Departments",
                column: "ManagerId",
                principalTable: "Instructors",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors",
                column: "Dept_ID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Courses_Course_ID",
                table: "Stud_Courses",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Students_Stud_ID",
                table: "Stud_Courses",
                column: "Stud_ID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentID",
                table: "Students",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Courses_Course_ID",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Instructors_Inst_ID",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_ManagerId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Courses_Course_ID",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Students_Stud_ID",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Courses_Course_ID",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ManagerId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Course_Insts_Course_ID",
                table: "Course_Insts");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Departments");
        }
    }
}
