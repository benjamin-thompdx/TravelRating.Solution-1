using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelRating.Migrations
{
    public partial class ExperienceSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "ExperienceId", "Author", "LocationId", "Rating", "Review" },
                values: new object[,]
                {
                    { 1, "Ben's Mom", 3, 2, "Hanoi" },
                    { 2, "Matt's Mom", 3, 2, "Reykjavik" },
                    { 3, "Katy's Mom", 3, 2, "Kerry" },
                    { 4, "Katy's Kids' Mom", 3, 2, "New York" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 4);
        }
    }
}
