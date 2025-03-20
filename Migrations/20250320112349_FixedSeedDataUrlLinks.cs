using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventEaseApp.Migrations
{
    /// <inheritdoc />
    public partial class FixedSeedDataUrlLinks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRN57LMlQjGAAO4dkv1yUjWMyxFPHvfkHKOSg&s");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHaUFzC27bQO5Est2gNRpmULPBJTwHhgDQfQ&s");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://media.istockphoto.com/id/1467962890/photo/above-chicago.jpg?s=612x612&w=0&k=20&c=lZJbZiT10L_9-mjS07rEwCOT6wUigyUdKYJxrEbeuvY=");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://canvas-events-locations.imgix.net/ea7aaad0e8647fe5b9c77efdefb2b95a54215bd95f5c80.02567362/1/Crystal2.jpg?w=1200&fit=crop&mark=https://www.canvas-events.co.uk/images/canvas-yellow-watermark-v1.1.png&markw=150&markalign=top,left&markpad=50&dpr=2&q=20&usm=20&auto=format&h=675");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://stadiumdb.com/img/news/2022/08/19978-thumbnail.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/3/3f/Grand_Hall_Interior.jpg");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/8/89/Arena_in_LA.jpg");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/6/68/Modern_Pavilion.jpg");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/5/5a/Conference_Center.jpg");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/2/27/Modern_Stadium.jpg");
        }
    }
}
