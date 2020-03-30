using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelRating.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "City", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "Hanoi", "Vietnam", "Ha Long Bay" },
                    { 2, "Reykjavik", "Iceland", "Thingvellir Park" },
                    { 3, "Kerry", "Ireland", "Killarney National Park" },
                    { 4, "New York", "United States", "Clock Walk" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4);
        }
    }
}
