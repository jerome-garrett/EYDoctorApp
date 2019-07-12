using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorsApp.Migrations
{
    public partial class LoadLookupTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Languages (Name) VALUES ('English')");
            migrationBuilder.Sql("INSERT INTO Languages (Name) VALUES ('French')");
            migrationBuilder.Sql("INSERT INTO Languages (Name) VALUES ('Italian')");
            migrationBuilder.Sql("INSERT INTO Languages (Name) VALUES ('Mandarin')");
            migrationBuilder.Sql("INSERT INTO Languages (Name) VALUES ('Spanish')");

            migrationBuilder.Sql("INSERT INTO MedicalSchools (Name) VALUES ('Emory')");
            migrationBuilder.Sql("INSERT INTO MedicalSchools (Name) VALUES ('Harvard')");
            migrationBuilder.Sql("INSERT INTO MedicalSchools (Name) VALUES ('Johns Hopkins')");
            migrationBuilder.Sql("INSERT INTO MedicalSchools (Name) VALUES ('Morehouse')");
            migrationBuilder.Sql("INSERT INTO MedicalSchools (Name) VALUES ('Perelman')");

            migrationBuilder.Sql("INSERT INTO Specialties (Name) VALUES ('Cardiovascular Disease')");
            migrationBuilder.Sql("INSERT INTO Specialties (Name) VALUES ('Family Medical')");
            migrationBuilder.Sql("INSERT INTO Specialties (Name) VALUES ('Geriatric Medical')");
            migrationBuilder.Sql("INSERT INTO Specialties (Name) VALUES ('Genetics')");
            migrationBuilder.Sql("INSERT INTO Specialties (Name) VALUES ('Internal Medical')");
            migrationBuilder.Sql("INSERT INTO Specialties (Name) VALUES ('Oncology')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Languages");
            migrationBuilder.Sql("DELETE FROM MedicalSchools");
            migrationBuilder.Sql("DELETE FROM Specialties");
        }
    }
}
