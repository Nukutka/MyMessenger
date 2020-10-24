using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMessenger.EntityFramework.Migrations
{
    public partial class UpdateSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("09661f65-7381-47cf-bbbc-4d616c4ec4d9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("20a6e612-1aa7-4015-bb98-48ae54a0d8b0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("27be630a-901f-4534-b621-0ea28be8e90d"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2c6cd90e-109d-4160-9298-7d05322ec8c8"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("301526d5-3cbb-4106-909e-3f898634317c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("32a9f45b-33f7-49c2-839b-d9893c5ef664"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("39ae7247-87af-4feb-a44d-85290d4f5b3e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5064ed62-0f0b-4394-b5a6-e25000131b15"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5c090bd2-821b-4f44-88e1-38ec2bc8b09b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("75044ff7-bb1e-4a92-b1d6-ea2dc1c30e92"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("814aeb44-4e30-4083-94c7-addd7eed69e0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8ce308e9-a7f3-4548-be71-d4ea0e2883f9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9404d889-223f-4c92-9245-41985470d085"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("94d740ac-a745-43f3-ac85-f28fc2b4013c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d5330673-0945-4c43-a4b4-dea8c01c283b"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dc612102-bd1a-40d7-8d93-1be66d5269ea"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e84c7043-677a-4004-a530-a61d6343abd3"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("eaf706e0-eb6f-407a-be70-1effff53afe7"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("fdad02c3-0ceb-47fe-9d81-467dcea65153"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("fe585d0e-b10e-4c54-877b-a6221fe20f41"));

            migrationBuilder.DeleteData(
                table: "UserChatAssociations",
                keyColumn: "Id",
                keyValue: new Guid("2e66ddb7-b93d-4882-80a2-8950da779abe"));

            migrationBuilder.DeleteData(
                table: "UserChatAssociations",
                keyColumn: "Id",
                keyValue: new Guid("5f3b54aa-6006-4739-8fb9-a8302b08b5ac"));

            migrationBuilder.DeleteData(
                table: "UserChatAssociations",
                keyColumn: "Id",
                keyValue: new Guid("6d3025af-76d6-4bde-aa9f-c4101b2ceb77"));

            migrationBuilder.DeleteData(
                table: "UserChatAssociations",
                keyColumn: "Id",
                keyValue: new Guid("822b24e1-3225-4f54-b2ca-ef27d7c43a9e"));

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("56d8c417-ed2d-48d9-8b5a-4697b85865f9"));

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("776a2f5e-090c-41c2-9d11-a49d49da45fe"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("8a6bd227-963c-4621-81d9-a61ada3f1cc6"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("a266d520-5fc6-405c-a5df-5da6be408913"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c7fcdd8-f8de-41b0-8927-42c07b27a207"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce571cb2-8900-4f32-8db2-54be8caf9253"));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "ConcurrencyStamp", "CreationTime", "CreatorId", "ExtraProperties", "LastModificationTime", "LastModifierId", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000005"), "27f6907bba0441338c2844d7a7966c2a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, "Chat 1" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "cff3b1cf6db44236a99873db1defe002", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, "Chat 2" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConcurrencyStamp", "CreationTime", "CreatorId", "ExtraProperties", "HashPassword", "LastModificationTime", "LastModifierId", "Login" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "27e66d61f9c7477595ef8f973a4bdebd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", "6298AA0670BFE6313A68AD4F3B4E82845C9CACE4D9CAD1B5883FF4BCE6B53AB84FC5C0191AACFC1FF650E45B673D014B67708AEA9FB5620287E703D95DA77BFB", null, null, "user1" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "9e3abf41077d4bc4b243c41049ffea49", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", "9A0E11B587FCBD3D236C80BBF8E43A59AC122CED771EBAB6EA54E579DEAB0DB8DF2EC592EDBE70EB6DFFD6B8834E2B3682E39F183DFCA53E01939348B4D519EC", null, null, "user2" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Body", "ChatId", "ConcurrencyStamp", "CreationTime", "CreatorId", "ExtraProperties", "LastModificationTime", "LastModifierId", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Message 1", new Guid("00000000-0000-0000-0000-000000000005"), "97acdabfcbf14b1681d81af65831238e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000026"), "Message 20", new Guid("00000000-0000-0000-0000-000000000006"), "ffbb6e42934840e4b8413fe8553a1e69", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000025"), "Message 19", new Guid("00000000-0000-0000-0000-000000000006"), "ecc5c4cd45db4fcd9490737212c7cf07", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000024"), "Message 18", new Guid("00000000-0000-0000-0000-000000000006"), "23787a5ab19740e895d29fb682b995e7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000023"), "Message 17", new Guid("00000000-0000-0000-0000-000000000006"), "78e58195318c499ca048420e846f80fa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000022"), "Message 16", new Guid("00000000-0000-0000-0000-000000000006"), "908fd2140f6c4b5794bb5c98e119c9b3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000021"), "Message 15", new Guid("00000000-0000-0000-0000-000000000006"), "049e89082a884558b78fd84b307475c2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000020"), "Message 14", new Guid("00000000-0000-0000-0000-000000000006"), "3c3c51e6c03b479781b71565ca50186f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "Message 12", new Guid("00000000-0000-0000-0000-000000000006"), "60b703620c4b48b3b065eebcf30f49a4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000017"), "Message 11", new Guid("00000000-0000-0000-0000-000000000006"), "f159752ec2454b129a5b5ff3f03aca40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000019"), "Message 13", new Guid("00000000-0000-0000-0000-000000000006"), "5c8ff68b14d048df850cd48938afa93f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "Message 9", new Guid("00000000-0000-0000-0000-000000000005"), "3011bfa843c14c24a9a87333467b2ed7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "Message 8", new Guid("00000000-0000-0000-0000-000000000005"), "b1edf39ea8764681addbf1df87b8d08d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "Message 7", new Guid("00000000-0000-0000-0000-000000000005"), "d1a4b54325d04b619eb7466d4b4520fe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "Message 6", new Guid("00000000-0000-0000-0000-000000000005"), "0149b859c63a4fe19abe04bbeba5ebfd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Message 5", new Guid("00000000-0000-0000-0000-000000000005"), "1203a5fdeeed45838c71d118d685a91e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Message 4", new Guid("00000000-0000-0000-0000-000000000005"), "3328b25bae6e4f16bcb3899c83e5950f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Message 3", new Guid("00000000-0000-0000-0000-000000000005"), "edb2927214e84f37ae618b0aa38d1a8d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Message 2", new Guid("00000000-0000-0000-0000-000000000005"), "ae171adf37db40f5a2e7af2272fab979", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "Message 10", new Guid("00000000-0000-0000-0000-000000000005"), "b790448781c84f53887ec118bbb80655", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("00000000-0000-0000-0000-000000000003") }
                });

            migrationBuilder.InsertData(
                table: "UserChatAssociations",
                columns: new[] { "Id", "ChatId", "CreationTime", "CreatorId", "LastModificationTime", "LastModifierId", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000028"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000027"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000029"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new Guid("00000000-0000-0000-0000-000000000001") }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "ActiveStatus", "CreationTime", "CreatorId", "Email", "Firstname", "LastModificationTime", "LastModifierId", "Lastname", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000002"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "test@test.com", "Nikita", null, null, "Nagovitsyn", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "test2@test.com", "Darya", null, null, "Shigabytdinova", new Guid("00000000-0000-0000-0000-000000000003") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "UserChatAssociations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "UserChatAssociations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "UserChatAssociations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "UserChatAssociations",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "ConcurrencyStamp", "CreationTime", "CreatorId", "ExtraProperties", "LastModificationTime", "LastModifierId", "Name" },
                values: new object[,]
                {
                    { new Guid("8a6bd227-963c-4621-81d9-a61ada3f1cc6"), "7705e3bf9b0f440c9ff27fd910497426", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, "Chat 1" },
                    { new Guid("a266d520-5fc6-405c-a5df-5da6be408913"), "02347e4e547841d99caea8475dcf160f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, "Chat 2" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConcurrencyStamp", "CreationTime", "CreatorId", "ExtraProperties", "HashPassword", "LastModificationTime", "LastModifierId", "Login" },
                values: new object[,]
                {
                    { new Guid("ce571cb2-8900-4f32-8db2-54be8caf9253"), "487cb2894c624b82b5186879a767e8c1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", "6298AA0670BFE6313A68AD4F3B4E82845C9CACE4D9CAD1B5883FF4BCE6B53AB84FC5C0191AACFC1FF650E45B673D014B67708AEA9FB5620287E703D95DA77BFB", null, null, "user1" },
                    { new Guid("6c7fcdd8-f8de-41b0-8927-42c07b27a207"), "1e4aaf44740748c086a06b1287ac025c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", "9A0E11B587FCBD3D236C80BBF8E43A59AC122CED771EBAB6EA54E579DEAB0DB8DF2EC592EDBE70EB6DFFD6B8834E2B3682E39F183DFCA53E01939348B4D519EC", null, null, "user2" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Body", "ChatId", "ConcurrencyStamp", "CreationTime", "CreatorId", "ExtraProperties", "LastModificationTime", "LastModifierId", "UserId" },
                values: new object[,]
                {
                    { new Guid("eaf706e0-eb6f-407a-be70-1effff53afe7"), "Message 1", new Guid("8a6bd227-963c-4621-81d9-a61ada3f1cc6"), "1ff029bf3c6d417090c552bfa777ef68", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("ce571cb2-8900-4f32-8db2-54be8caf9253") },
                    { new Guid("e84c7043-677a-4004-a530-a61d6343abd3"), "Message 20", new Guid("a266d520-5fc6-405c-a5df-5da6be408913"), "489f3201b3364e2d9a01d48f7b905903", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("6c7fcdd8-f8de-41b0-8927-42c07b27a207") },
                    { new Guid("20a6e612-1aa7-4015-bb98-48ae54a0d8b0"), "Message 19", new Guid("a266d520-5fc6-405c-a5df-5da6be408913"), "61a9f6f77515496abf6765994762a27f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("6c7fcdd8-f8de-41b0-8927-42c07b27a207") },
                    { new Guid("d5330673-0945-4c43-a4b4-dea8c01c283b"), "Message 18", new Guid("a266d520-5fc6-405c-a5df-5da6be408913"), "10e65cdb72724d50b5fda7216aefe157", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("6c7fcdd8-f8de-41b0-8927-42c07b27a207") },
                    { new Guid("8ce308e9-a7f3-4548-be71-d4ea0e2883f9"), "Message 17", new Guid("a266d520-5fc6-405c-a5df-5da6be408913"), "d8fb3d72f3c04318a7b40aa83aee7508", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("6c7fcdd8-f8de-41b0-8927-42c07b27a207") },
                    { new Guid("dc612102-bd1a-40d7-8d93-1be66d5269ea"), "Message 16", new Guid("a266d520-5fc6-405c-a5df-5da6be408913"), "6b336a9fb9da4626a43330a0be759583", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("6c7fcdd8-f8de-41b0-8927-42c07b27a207") },
                    { new Guid("5064ed62-0f0b-4394-b5a6-e25000131b15"), "Message 15", new Guid("a266d520-5fc6-405c-a5df-5da6be408913"), "412caef692614c3cae1c9aae9d0bfc38", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("ce571cb2-8900-4f32-8db2-54be8caf9253") },
                    { new Guid("301526d5-3cbb-4106-909e-3f898634317c"), "Message 14", new Guid("a266d520-5fc6-405c-a5df-5da6be408913"), "dbd0baf95fad49bb962498e13beab80b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("ce571cb2-8900-4f32-8db2-54be8caf9253") },
                    { new Guid("9404d889-223f-4c92-9245-41985470d085"), "Message 12", new Guid("a266d520-5fc6-405c-a5df-5da6be408913"), "1aad93d646214414a37494e4032f1744", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("ce571cb2-8900-4f32-8db2-54be8caf9253") },
                    { new Guid("09661f65-7381-47cf-bbbc-4d616c4ec4d9"), "Message 11", new Guid("a266d520-5fc6-405c-a5df-5da6be408913"), "8a03e5fad61043b2adc47bed93fb4d07", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("ce571cb2-8900-4f32-8db2-54be8caf9253") },
                    { new Guid("39ae7247-87af-4feb-a44d-85290d4f5b3e"), "Message 13", new Guid("a266d520-5fc6-405c-a5df-5da6be408913"), "43ec7bed9bac4095888703c8781affed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("ce571cb2-8900-4f32-8db2-54be8caf9253") },
                    { new Guid("32a9f45b-33f7-49c2-839b-d9893c5ef664"), "Message 9", new Guid("8a6bd227-963c-4621-81d9-a61ada3f1cc6"), "09d8b9fb7471468b8797cae070378578", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("6c7fcdd8-f8de-41b0-8927-42c07b27a207") },
                    { new Guid("fdad02c3-0ceb-47fe-9d81-467dcea65153"), "Message 8", new Guid("8a6bd227-963c-4621-81d9-a61ada3f1cc6"), "459f47e09eef47d0b5fd640c7a8dc501", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("6c7fcdd8-f8de-41b0-8927-42c07b27a207") },
                    { new Guid("2c6cd90e-109d-4160-9298-7d05322ec8c8"), "Message 7", new Guid("8a6bd227-963c-4621-81d9-a61ada3f1cc6"), "3ad07417ae9c456da8a0e6e12a57328b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("6c7fcdd8-f8de-41b0-8927-42c07b27a207") },
                    { new Guid("fe585d0e-b10e-4c54-877b-a6221fe20f41"), "Message 6", new Guid("8a6bd227-963c-4621-81d9-a61ada3f1cc6"), "9330ca50c1e246fcaa5fc57c12bfc548", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("6c7fcdd8-f8de-41b0-8927-42c07b27a207") },
                    { new Guid("27be630a-901f-4534-b621-0ea28be8e90d"), "Message 5", new Guid("8a6bd227-963c-4621-81d9-a61ada3f1cc6"), "f3874236713f4b3c94e553d909a72bf1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("ce571cb2-8900-4f32-8db2-54be8caf9253") },
                    { new Guid("75044ff7-bb1e-4a92-b1d6-ea2dc1c30e92"), "Message 4", new Guid("8a6bd227-963c-4621-81d9-a61ada3f1cc6"), "a764f781b0af446d899ecfe3a1336cc4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("ce571cb2-8900-4f32-8db2-54be8caf9253") },
                    { new Guid("814aeb44-4e30-4083-94c7-addd7eed69e0"), "Message 3", new Guid("8a6bd227-963c-4621-81d9-a61ada3f1cc6"), "cbfaea1c84c142f3a8b76b1ce97d365e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("ce571cb2-8900-4f32-8db2-54be8caf9253") },
                    { new Guid("5c090bd2-821b-4f44-88e1-38ec2bc8b09b"), "Message 2", new Guid("8a6bd227-963c-4621-81d9-a61ada3f1cc6"), "db49c7252843499b9a4b290252671957", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("ce571cb2-8900-4f32-8db2-54be8caf9253") },
                    { new Guid("94d740ac-a745-43f3-ac85-f28fc2b4013c"), "Message 10", new Guid("8a6bd227-963c-4621-81d9-a61ada3f1cc6"), "f5d5ad7818cb496192e2bbe7877abd31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "{}", null, null, new Guid("6c7fcdd8-f8de-41b0-8927-42c07b27a207") }
                });

            migrationBuilder.InsertData(
                table: "UserChatAssociations",
                columns: new[] { "Id", "ChatId", "CreationTime", "CreatorId", "LastModificationTime", "LastModifierId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2e66ddb7-b93d-4882-80a2-8950da779abe"), new Guid("a266d520-5fc6-405c-a5df-5da6be408913"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new Guid("6c7fcdd8-f8de-41b0-8927-42c07b27a207") },
                    { new Guid("5f3b54aa-6006-4739-8fb9-a8302b08b5ac"), new Guid("8a6bd227-963c-4621-81d9-a61ada3f1cc6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new Guid("ce571cb2-8900-4f32-8db2-54be8caf9253") },
                    { new Guid("822b24e1-3225-4f54-b2ca-ef27d7c43a9e"), new Guid("a266d520-5fc6-405c-a5df-5da6be408913"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new Guid("ce571cb2-8900-4f32-8db2-54be8caf9253") },
                    { new Guid("6d3025af-76d6-4bde-aa9f-c4101b2ceb77"), new Guid("8a6bd227-963c-4621-81d9-a61ada3f1cc6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new Guid("6c7fcdd8-f8de-41b0-8927-42c07b27a207") }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "ActiveStatus", "CreationTime", "CreatorId", "Email", "Firstname", "LastModificationTime", "LastModifierId", "Lastname", "UserId" },
                values: new object[,]
                {
                    { new Guid("56d8c417-ed2d-48d9-8b5a-4697b85865f9"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "test@test.com", "Nikita", null, null, "Nagovitsyn", new Guid("ce571cb2-8900-4f32-8db2-54be8caf9253") },
                    { new Guid("776a2f5e-090c-41c2-9d11-a49d49da45fe"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "test2@test.com", "Darya", null, null, "Shigabytdinova", new Guid("6c7fcdd8-f8de-41b0-8927-42c07b27a207") }
                });
        }
    }
}
