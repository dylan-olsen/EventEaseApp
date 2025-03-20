using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventEaseApp.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "EventName",
                value: "Music Festival 2025");

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "Description", "EventDate", "EventName" },
                values: new object[,]
                {
                    { 3, "Latest trends and innovations in AI and ML.", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AI & Machine Learning Summit" },
                    { 4, "Networking with top entrepreneurs worldwide.", new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "International Business Expo" },
                    { 5, "A gathering for fans of comics, movies, and gaming.", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comic-Con 2025" }
                });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Location" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/3/3f/Grand_Hall_Interior.jpg", "New York, USA" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Location" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/8/89/Arena_in_LA.jpg", "Los Angeles, USA" });

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "VenueId", "Capacity", "ImageUrl", "Location", "VenueName" },
                values: new object[,]
                {
                    { 3, 750, "https://upload.wikimedia.org/wikipedia/commons/6/68/Modern_Pavilion.jpg", "Chicago, USA", "Skyline Pavilion" },
                    { 4, 1200, "https://upload.wikimedia.org/wikipedia/commons/5/5a/Conference_Center.jpg", "London, UK", "Crystal Conference Center" },
                    { 5, 2000, "https://upload.wikimedia.org/wikipedia/commons/2/27/Modern_Stadium.jpg", "Miami, USA", "Blue Wave Stadium" }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingId", "BookingDate", "EventId", "VenueId" },
                values: new object[,]
                {
                    { 3, new DateTime(2025, 3, 22, 10, 30, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 4, new DateTime(2025, 3, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 5, new DateTime(2025, 3, 24, 18, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                column: "EventName",
                value: "Music Festival");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Location" },
                values: new object[] { "https://via.placeholder.com/150", "New York" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Location" },
                values: new object[] { "https://via.placeholder.com/150", "Los Angeles" });
        }
    }
}
