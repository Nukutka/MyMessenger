using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMessenger.EntityFramework.Migrations
{
    public partial class ChangeLoginToNickname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Login",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Nickname",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "UserChatAssociations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "HashPassword", "Nickname" },
                values: new object[] { "5465017272A333BC1A0A3EB99AFB2EE77013BFBC2A0E30AE61F5A5DDAA9CD9DD4231A633CF55F0A1493999FD0F22D8D8547A6AF109B0EF3C9328914289B36839", "Nukutka" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "HashPassword", "Nickname" },
                values: new object[] { "5465017272A333BC1A0A3EB99AFB2EE77013BFBC2A0E30AE61F5A5DDAA9CD9DD4231A633CF55F0A1493999FD0F22D8D8547A6AF109B0EF3C9328914289B36839", "Dashasexy" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Nickname",
                table: "Users",
                column: "Nickname",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Nickname",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Nickname",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "UserChatAssociations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                column: "UserId",
                value: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "HashPassword", "Login" },
                values: new object[] { "6298AA0670BFE6313A68AD4F3B4E82845C9CACE4D9CAD1B5883FF4BCE6B53AB84FC5C0191AACFC1FF650E45B673D014B67708AEA9FB5620287E703D95DA77BFB", "user1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "HashPassword", "Login" },
                values: new object[] { "9A0E11B587FCBD3D236C80BBF8E43A59AC122CED771EBAB6EA54E579DEAB0DB8DF2EC592EDBE70EB6DFFD6B8834E2B3682E39F183DFCA53E01939348B4D519EC", "user2" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Login",
                table: "Users",
                column: "Login",
                unique: true);
        }
    }
}
