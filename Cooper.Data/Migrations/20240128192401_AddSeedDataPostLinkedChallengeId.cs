using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class AddSeedDataPostLinkedChallengeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1,
                column: "ChallengeGuid",
                value: new Guid("162ff745-7807-4b06-8660-5c7cc89a392f"));

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2,
                column: "ChallengeGuid",
                value: new Guid("520a4d3a-e6ce-458c-8c72-360a5ffc92eb"));

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 3,
                column: "ChallengeGuid",
                value: new Guid("a3bb21c7-9ea2-4c9b-9811-e3526856d05b"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UUID",
                value: new Guid("a8307e5d-516d-4a64-b803-150ae5345aca"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UUID",
                value: new Guid("70909fa2-6fbe-4583-9d64-9e2e32b409a0"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UUID",
                value: new Guid("c2c02631-78de-4554-90d1-61bc0d7eb8dc"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UUID",
                value: new Guid("4252b21b-a94d-49d7-8102-b2a9c64e8117"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UUID",
                value: new Guid("61499f56-662e-48bf-9c21-59c0e19e78c3"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UUID",
                value: new Guid("8a4c5a0b-0bc3-4875-baf5-3d9b8c04373b"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UUID",
                value: new Guid("410f7ea6-e827-40f8-b517-9c7de5625b4b"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UUID",
                value: new Guid("820bcef3-4009-4cee-9a54-4a3bebda4092"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UUID",
                value: new Guid("278f14ff-9778-4207-860a-f2c185177310"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UUID",
                value: new Guid("80de646c-99dc-4899-b14c-8064b8c26601"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UUID",
                value: new Guid("75ad1522-e402-418d-a9a5-3f1976172c2d"));

            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "UUID" },
                values: new object[,]
                {
                    { 12, new Guid("c2255524-508a-485c-a6e8-732aacd2fef2") },
                    { 13, new Guid("90975a8e-ddc8-4dc8-b483-57473913c87e") }
                });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "MediaGuid",
                value: new Guid("3811cb44-e945-4810-b423-70bbaadabdbb"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "MediaGuid",
                value: new Guid("b2dbaca5-35fb-4a70-b38d-33014b458995"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "MediaGuid",
                value: new Guid("23ac576e-2e93-4d78-9e39-f43ae35b37f4"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "MediaGuid",
                value: new Guid("b4c2bf32-f50b-4a87-9a64-d36ff9240e61"));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ChallengeId", "Title" },
                values: new object[] { new Guid("a3bb21c7-9ea2-4c9b-9811-e3526856d05b"), "Steer Burger" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "ChallengeId", "Description", "EntityId", "Likes", "Title" },
                values: new object[,]
                {
                    { 2, new Guid("520a4d3a-e6ce-458c-8c72-360a5ffc92eb"), "Ronaldhino the best playyer", 12, 20, "Ball for Soccer Peeps" },
                    { 3, new Guid("162ff745-7807-4b06-8660-5c7cc89a392f"), "Everything we care about", 13, 25, "Hello Wold" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1,
                column: "ChallengeGuid",
                value: new Guid("5922fe70-a2a2-4a9e-8e11-62b667f47bd4"));

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2,
                column: "ChallengeGuid",
                value: new Guid("d5c7d318-5c86-46b9-83f9-c1024333b35c"));

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 3,
                column: "ChallengeGuid",
                value: new Guid("6b53be13-baaf-4910-9862-f38ed4363e0f"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UUID",
                value: new Guid("219a4b5b-d75c-4046-b3dd-250708067a5c"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UUID",
                value: new Guid("765666f9-8758-49bd-9b59-160c582b4351"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UUID",
                value: new Guid("28d7dabb-84d2-4220-a6fa-4577bab5fadb"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UUID",
                value: new Guid("3770bf8b-98f8-4eb9-b27c-0a3578e54b22"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UUID",
                value: new Guid("24e9e74e-9855-4355-a6ea-2fc817fe6645"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UUID",
                value: new Guid("60728cab-44fc-4af8-9699-5008d539a0c3"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UUID",
                value: new Guid("06a187d1-f9f8-472f-910c-76e6cbed504b"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UUID",
                value: new Guid("5d56f91a-f5a1-438d-af6f-c63298733d85"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UUID",
                value: new Guid("ca93a189-053b-4126-90f1-841325f769e0"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UUID",
                value: new Guid("96c4929b-56dc-44c6-b9dc-2a569d76147b"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UUID",
                value: new Guid("d0de398c-92aa-428e-9aea-cd2154a92d01"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "MediaGuid",
                value: new Guid("cfdf0669-da10-4566-8d29-e8751363ba5c"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "MediaGuid",
                value: new Guid("fa35be62-d405-4f47-a791-81a64173214f"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "MediaGuid",
                value: new Guid("5383c383-a48b-4aa6-8b83-2fc83259a40b"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "MediaGuid",
                value: new Guid("5cacbebd-110b-4d25-941f-bdaf13872a20"));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ChallengeId", "Title" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), "Hello Wold" });
        }
    }
}
