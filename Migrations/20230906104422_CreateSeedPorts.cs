using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagementOfAccidentsOnVessels.Migrations
{
    public partial class CreateSeedPorts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ports",
                columns: new[] { "Id", "Capacity", "Lat", "Lon", "Name" },
                values: new object[,]
                {
                    { 1L, 4, 83m, 79m, "اروندکنار" },
                    { 2L, 8, 171m, 43m, "ماهشهر" },
                    { 3L, 3, 261m, 54m, "دیلم" },
                    { 4L, 3, 313m, 106m, "گناوه" },
                    { 5L, 4, 288m, 143m, "خارگ" },
                    { 6L, 4, 327m, 134m, "ریگ" },
                    { 7L, 12, 355m, 172m, "بوشهر" },
                    { 8L, 3, 381m, 212m, "بوالخیر" },
                    { 9L, 4, 469m, 246m, "کنگان" },
                    { 10L, 3, 529m, 263m, "نخل تقی" },
                    { 11L, 9, 573m, 267m, "عسلویه" },
                    { 12L, 8, 685m, 349m, "آفتاب" },
                    { 13L, 9, 664m, 371m, "کیش" },
                    { 14L, 7, 824m, 365m, "شهید رجایی" },
                    { 15L, 5, 881m, 362m, "لافت" },
                    { 16L, 3, 864m, 435m, "ابوموسی" },
                    { 17L, 6, 928m, 325m, "حقانی" },
                    { 18L, 11, 941m, 360m, "قشم" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Ports",
                keyColumn: "Id",
                keyValue: 18L);
        }
    }
}
