using Microsoft.EntityFrameworkCore.Migrations;

namespace FloatingFreedom.Migrations
{
    public partial class addedUserToModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_ApplicationUserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Kayaks_AspNetUsers_ApplicationUserId",
                table: "Kayaks");

            migrationBuilder.DropIndex(
                name: "IX_Kayaks_ApplicationUserId",
                table: "Kayaks");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ApplicationUserId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Kayaks");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Kayaks",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcc6a837-16c9-46e8-b923-3309b70a7562", "AQAAAAEAACcQAAAAEHOWbG0B7VMC8a+ro2RZdsQKjWa9N+SY2e+SZY6cJUOG1zm1ikRiewiSt1e7um/xqQ==", "61bd745b-3414-4145-8e56-22995484d170" });

            migrationBuilder.CreateIndex(
                name: "IX_Kayaks_UserId",
                table: "Kayaks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_UserId",
                table: "Customers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kayaks_AspNetUsers_UserId",
                table: "Kayaks",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_UserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Kayaks_AspNetUsers_UserId",
                table: "Kayaks");

            migrationBuilder.DropIndex(
                name: "IX_Kayaks_UserId",
                table: "Kayaks");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UserId",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Kayaks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Kayaks",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "712f4ed2-7830-493f-b41a-2bc42557c9a4", "AQAAAAEAACcQAAAAEA7V/ijWUvMHbgRO7Kjaou4yeGjGz1TMluKM+o9X/WoRRgESbpKIKqFR+QVWpGGvyQ==", "00e32a79-b64a-4fd6-bdb0-e1863a8dcdc6" });

            migrationBuilder.CreateIndex(
                name: "IX_Kayaks_ApplicationUserId",
                table: "Kayaks",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ApplicationUserId",
                table: "Customers",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_ApplicationUserId",
                table: "Customers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kayaks_AspNetUsers_ApplicationUserId",
                table: "Kayaks",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
