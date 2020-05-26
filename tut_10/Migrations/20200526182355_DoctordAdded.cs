using Microsoft.EntityFrameworkCore.Migrations;

namespace tut_10.Migrations
{
    public partial class DoctordAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 1,
                column: "LastName",
                value: "Kus");

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 2,
                column: "LastName",
                value: "Kus");

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 3,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "refia@gmail.com", "Refia" });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[] { 4, "illia@gmail.com", "Illia", "Rymar" });

            migrationBuilder.UpdateData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 1,
                column: "Description",
                value: "for pain");

            migrationBuilder.UpdateData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 2,
                column: "Description",
                value: "for pain");

            migrationBuilder.UpdateData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 3,
                column: "Description",
                value: "for cold");

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "FirstName",
                value: "Michail");

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Piotr", "Samsel" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "FirstName",
                value: "Busra");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 1,
                column: "LastName",
                value: "Ozgur");

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 2,
                column: "LastName",
                value: "Ozgur");

            migrationBuilder.UpdateData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 3,
                columns: new[] { "Email", "FirstName" },
                values: new object[] { "ali@gmail.com", "Ali" });

            migrationBuilder.UpdateData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 1,
                column: "Description",
                value: "for pain");

            migrationBuilder.UpdateData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 2,
                column: "Description",
                value: "for pain");

            migrationBuilder.UpdateData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 3,
                column: "Description",
                value: "for cold");

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "FirstName",
                value: "Busra");

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Berkay", "Koyuncu" });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "FirstName",
                value: "Merve");
        }
    }
}
