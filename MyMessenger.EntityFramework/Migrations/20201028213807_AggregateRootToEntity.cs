using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMessenger.EntityFramework.Migrations
{
    public partial class AggregateRootToEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "Chats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Users",
                type: "character varying(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Messages",
                type: "character varying(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "Messages",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Chats",
                type: "character varying(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "Chats",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "27f6907bba0441338c2844d7a7966c2a", "{}" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "cff3b1cf6db44236a99873db1defe002", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "97acdabfcbf14b1681d81af65831238e", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "ae171adf37db40f5a2e7af2272fab979", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "edb2927214e84f37ae618b0aa38d1a8d", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "3328b25bae6e4f16bcb3899c83e5950f", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "1203a5fdeeed45838c71d118d685a91e", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "0149b859c63a4fe19abe04bbeba5ebfd", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "d1a4b54325d04b619eb7466d4b4520fe", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "b1edf39ea8764681addbf1df87b8d08d", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "3011bfa843c14c24a9a87333467b2ed7", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "b790448781c84f53887ec118bbb80655", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "f159752ec2454b129a5b5ff3f03aca40", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "60b703620c4b48b3b065eebcf30f49a4", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "5c8ff68b14d048df850cd48938afa93f", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "3c3c51e6c03b479781b71565ca50186f", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "049e89082a884558b78fd84b307475c2", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "908fd2140f6c4b5794bb5c98e119c9b3", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "78e58195318c499ca048420e846f80fa", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "23787a5ab19740e895d29fb682b995e7", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "ecc5c4cd45db4fcd9490737212c7cf07", "{}" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "ffbb6e42934840e4b8413fe8553a1e69", "{}" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "27e66d61f9c7477595ef8f973a4bdebd", "{}" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "ExtraProperties" },
                values: new object[] { "9e3abf41077d4bc4b243c41049ffea49", "{}" });
        }
    }
}
