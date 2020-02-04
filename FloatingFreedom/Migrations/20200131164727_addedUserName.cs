using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FloatingFreedom.Migrations
{
    public partial class addedUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "d720a020-3533-4714-90d1-0dc28d394d49", "Amin the Admin", "ADMIN", "AQAAAAEAACcQAAAAEHj/bJXDL5D78Z04LMz1HoAP+HHhyA2TSSmIppU9/SgwJTGwTZ5wc6BzpCE7O4XBmA==", "304-123-1234", "37451998-dfbf-4fef-854d-a0ee510f6869", "admin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name" },
                values: new object[] { "email@email.com", "John Doe" });

            migrationBuilder.UpdateData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KayakTypeId", "Name" },
                values: new object[] { 1, "Sun Dolphin Destin #01" });

            migrationBuilder.UpdateData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KayakTypeId", "Name" },
                values: new object[] { 1, "Sun Dolphin Destin #02" });

            migrationBuilder.UpdateData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "KayakTypeId", "Name" },
                values: new object[] { 1, "Sun Dolphin Destin #03" });

            migrationBuilder.InsertData(
                table: "Kayaks",
                columns: new[] { "Id", "KayakTypeId", "Name", "UserId" },
                values: new object[,]
                {
                    { 28, 5, "BKC PK12 #03", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 27, 5, "BKC PK12 #02", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 26, 5, "BKC PK12 #01", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 25, 4, "Intex Explorer K2 #10", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 24, 4, "Intex Explorer K2 #09", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 23, 4, "Intex Explorer K2 #08", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 22, 4, "Intex Explorer K2 #07", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 21, 4, "Intex Explorer K2 #06", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 20, 4, "Intex Explorer K2 #05", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 19, 4, "Intex Explorer K2 #04", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 18, 4, "Intex Explorer K2 #03", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 16, 4, "Intex Explorer K2 #01", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 15, 3, "Sun Dolphin Aruba #05", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 14, 3, "Sun Dolphin Aruba #04", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 13, 3, "Sun Dolphin Aruba #03", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 12, 3, "Sun Dolphin Aruba #02", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 11, 3, "Sun Dolphin Aruba #01", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 10, 2, "Sun Dolphin Phoenix #05", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 9, 2, "Sun Dolphin Phoenix #04", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 8, 2, "Sun Dolphin Phoenix #03", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 7, 2, "Sun Dolphin Phoenix #02", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 6, 2, "Sun Dolphin Phoenix #01", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 5, 1, "Sun Dolphin Destin #05", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 17, 4, "Intex Explorer K2 #02", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 4, 1, "Sun Dolphin Destin #04", "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "KayakId", "Name", "PhoneNumber", "RentalDate", "ReturnDate", "UserId" },
                values: new object[] { 2, "email@email.com", 18, "Anne Example", "304-321-1111", new DateTime(2020, 1, 27, 3, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 28, 5, 30, 0, 0, DateTimeKind.Unspecified), "00000000-ffff-ffff-ffff-ffffffffffff" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "fcc6a837-16c9-46e8-b923-3309b70a7562", "admin", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHOWbG0B7VMC8a+ro2RZdsQKjWa9N+SY2e+SZY6cJUOG1zm1ikRiewiSt1e7um/xqQ==", null, "61bd745b-3414-4145-8e56-22995484d170", "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name" },
                values: new object[] { "emailboy@email.com", "Customer Boy" });

            migrationBuilder.UpdateData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KayakTypeId", "Name" },
                values: new object[] { 2, "Kayak boy" });

            migrationBuilder.UpdateData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KayakTypeId", "Name" },
                values: new object[] { 3, "Kayak boy but for the long boy" });

            migrationBuilder.UpdateData(
                table: "Kayaks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "KayakTypeId", "Name" },
                values: new object[] { 2, "Kayak boy but for a different boy" });
        }
    }
}
