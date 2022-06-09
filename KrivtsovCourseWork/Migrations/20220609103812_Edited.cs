using Microsoft.EntityFrameworkCore.Migrations;

namespace KrivtsovCourseWork.Migrations
{
    public partial class Edited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Patient",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patient_DoctorId",
                table: "Patient",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Doctors_DoctorId",
                table: "Patient",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Doctors_DoctorId",
                table: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_Patient_DoctorId",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Patient");
        }
    }
}
