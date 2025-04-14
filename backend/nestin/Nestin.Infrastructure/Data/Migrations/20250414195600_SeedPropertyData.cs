using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPropertyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "CancellationPolicy", "Description", "HouseRules", "Latitude", "LocationId", "Longitude", "OwnerId", "PricePerNight", "PropertyTypeId", "SafteyInfo", "Title" },
                values: new object[,]
                {
                    { "3e7f99ab-228a-4d90-91c4-6adf8c12e048", "Free cancellation before May 17 , Cancel before check-in on May 18 for a partial refund.", "Relax with this listing Small 2-room 7-bed apartment near Alharam Al Makkah with a maximum of 10 to 12 minutes' walk away...", "Check-in after 3:00 PM , Checkout before 12:00 PM , 7 guests maximum", 21.4266m, 3, 39.8256m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 6000m, 3, "Carbon monoxide alarm ,Smoke alarm installed", "Rent an apartment near Alhar Mecca" },
                    { "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", "Free cancellation before Oct 22 , Cancel before check-in on Oct 23 for a partial refund.", "Romantic Loft with mezzanine and large balcony in front of the sea, double bed and 1 single bed, tv, wi-fi, fan...", "3 guests maximum , Pets allowed", -12.9711m, 5, -38.5108m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 1300m, 2, "Carbon monoxide alarm not reported , Smoke alarm not reported , Exterior security cameras on property", "(4 charming oceanfront loft!" },
                    { "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", "Free cancellation before May 17 , Cancel before check-in on May 18 for a partial refund.", "Updated pool and spa! Sitting on 100 acres, Hawkeye House, featured on the cover of the May 2019 issue of Dwell Magazine...", "Check-in after 3:00 PM , Checkout before 12:00 PM , 7 guests maximum", 34.114174m, 4, -116.432236m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 15000m, 1, "Carbon monoxide alarm ,Smoke alarm installed", "Hawkeye Dome - New Pool and Spa" },
                    { "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", "Free cancellation before May 17 , Cancel before check-in on May 18 for a partial refund.", "Elegant apartment inside the famous castle in Nolo, a royal choice right in the center of Milan...", "Check-in: 3:00 PM - 11:00PM ,Checkout before 11:00 AM ,4 guests maximum", 45.46427m, 2, 9.18951m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 5000m, 2, "Carbon monoxide alarm ,Smoke alarm installed", "Milano Duomo center 10 min Flat inside a castle" },
                    { "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", "Free cancellation before Jun 3. Cancel before check-in on Jun 4 for a partial refund", "Set in an architectural prize-winning building, this modern Barcelona apartment beauty has impressive detail...", "Check-in: 3:00 PM - 5:00 PM ,Checkout before 10:00 AM ,2 guests maximum", 41.3888m, 6, 2.159m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 6500m, 2, "No carbon monoxide alarm , No smoke alarm , Heights without rails or protectio", "Sunny and cozy Apartment Sagrada Familia" },
                    { "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", "Free cancellation before May 28 , Cancel before check-in on Jun 2 for a partial refund.", "Enjoy your stay with Panoramic View of the giza pyramids and sphinx .Yes! view and pictures are all 100% real...", "Check-in after 2:00 PM , Checkout before 11:00 AM , 2 guests maximum", 29.98333m, 1, 31.13333m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 3000m, 1, "No Carbon monoxide alarm , No Smoke alarm ", "Entire rental unit in Nazlet El-Semman, Egypt" },
                    { "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", "Free cancellation before Jun 3. Cancel before check-in on Jun 4 for a partial refund", "Interior designer's own guesthouse, this unique place has a style all its own...", "Check-in: 3:00 PM - 5:00 PM ,Checkout before 10:00 AM ,2 guests maximum", 43.5914m, 8, 6.8761m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 9000m, 1, "No carbon monoxide alarm , No smoke alarm , Heights without rails or protectio", "New! The View: See to Mouintain (with pool)" },
                    { "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", "Free cancellation before Jun 3. Cancel before check-in on Jun 4 for a partial refund", "To give you the best experience of the authentic Bedouin life style, we will gather around the fire...", "Check-in: 3:00 PM - 5:00 PM ,Checkout before 10:00 AM ,2 guests maximum", 29.5726m, 7, 35.4186m, "3dacdb51-fee9-4479-904c-cafe7dca22a7", 2200m, 4, "No carbon monoxide alarm , No smoke alarm , Heights without rails or protectio", "Wadi Rum Sunset Cave" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "3e7f99ab-228a-4d90-91c4-6adf8c12e048");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "cc4e48ea-ca54-4d32-a448-3c2c9d14f936");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7");
        }
    }
}
