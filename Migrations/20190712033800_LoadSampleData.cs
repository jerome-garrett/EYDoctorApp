using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorsApp.Migrations
{
    public partial class LoadSampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Doctors (Name, Gender, MedicalSchoolId) VALUES ('Melvin Johnson', 'Male', 4)");
            migrationBuilder.Sql("INSERT INTO DoctorSpecialties (DoctorId, SpecialtyId) VALUES (1,1)");
            migrationBuilder.Sql("INSERT INTO DoctorSpecialties (DoctorId, SpecialtyId) VALUES (1,2)");
            migrationBuilder.Sql("INSERT INTO DoctorLanguages(DoctorId, LanguageId) VALUES (1,1)");
            migrationBuilder.Sql("INSERT INTO DoctorLanguages (DoctorId, LanguageId) VALUES (1,5)");
            migrationBuilder.Sql("INSERT INTO PatientRatings(DoctorId, Comments, Rating) VALUES (1, 'Great bedside manner', 5)");
            migrationBuilder.Sql("INSERT INTO PatientRatings(DoctorId, Comments, Rating) VALUES (1, 'His delivery is dry', 4)");
            migrationBuilder.Sql("INSERT INTO PatientRatings(DoctorId, Comments, Rating) VALUES (1, 'Not enough time to talk to him', 3)");

            migrationBuilder.Sql("INSERT INTO Doctors (Name, Gender, MedicalSchoolId) VALUES ('Brenda Williams', 'Female', 1)");
            migrationBuilder.Sql("INSERT INTO DoctorSpecialties (DoctorId, SpecialtyId) VALUES (2,2)");
            migrationBuilder.Sql("INSERT INTO DoctorSpecialties (DoctorId, SpecialtyId) VALUES (2,3)");
            migrationBuilder.Sql("INSERT INTO DoctorLanguages(DoctorId, LanguageId) VALUES (2,1)");
            migrationBuilder.Sql("INSERT INTO DoctorLanguages (DoctorId, LanguageId) VALUES (2,5)");
            migrationBuilder.Sql("INSERT INTO PatientRatings(DoctorId, Comments, Rating) VALUES (2, 'Great bedside manner', 5)");
            migrationBuilder.Sql("INSERT INTO PatientRatings(DoctorId, Comments, Rating) VALUES (2, 'His delivery is dry', 4)");
            migrationBuilder.Sql("INSERT INTO PatientRatings(DoctorId, Comments, Rating) VALUES (2, 'Shows concern', 4)");
            migrationBuilder.Sql("INSERT INTO PatientRatings(DoctorId, Comments, Rating) VALUES (2, 'Communicates well', 5)");
            migrationBuilder.Sql("INSERT INTO PatientRatings(DoctorId, Comments, Rating) VALUES (2, 'Not enough time to talk to him', 3)");

            migrationBuilder.Sql("INSERT INTO Doctors (Name, Gender, MedicalSchoolId) VALUES ('Dennis Zimmerman', 'Male', 2)");
            migrationBuilder.Sql("INSERT INTO DoctorSpecialties (DoctorId, SpecialtyId) VALUES (3,6)");
            migrationBuilder.Sql("INSERT INTO DoctorLanguages(DoctorId, LanguageId) VALUES (3,1)");
            migrationBuilder.Sql("INSERT INTO PatientRatings(DoctorId, Comments, Rating) VALUES (3, 'His delivery is dry', 4)");
            migrationBuilder.Sql("INSERT INTO PatientRatings(DoctorId, Comments, Rating) VALUES (3, 'Shows concern', 4)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM DoctorLanguages");
            migrationBuilder.Sql("DELETE FROM DoctorSpecialties");
            migrationBuilder.Sql("DELETE FROM PatientRatings");
            migrationBuilder.Sql("DELETE FROM Doctors");
        }
    }
}
