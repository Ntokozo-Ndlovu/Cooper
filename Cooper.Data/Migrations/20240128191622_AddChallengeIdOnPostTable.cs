using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class AddChallengeIdOnPostTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ChallengeId",
                table: "Post",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChallengeId",
                table: "Post");

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1,
                column: "ChallengeGuid",
                value: new Guid("3d7e87a2-a92b-435c-b624-5e8f6cf3f8d8"));

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2,
                column: "ChallengeGuid",
                value: new Guid("f9ea64d6-8ab4-4968-83d2-5e95d5b6a6de"));

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 3,
                column: "ChallengeGuid",
                value: new Guid("641d1a06-728c-4703-81b4-02028964665c"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UUID",
                value: new Guid("b04f4e79-616d-4ed4-9d57-5b17a7dfbce7"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UUID",
                value: new Guid("d1d2b9ef-ae69-4812-8d9c-cd6d72bbf8c7"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UUID",
                value: new Guid("8ac86909-e3de-4b85-9625-ac0865935e31"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UUID",
                value: new Guid("021d201a-351d-4b6d-a93a-3e81cd4ae091"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UUID",
                value: new Guid("8cf66b38-cce1-4490-9104-e4fd95805583"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UUID",
                value: new Guid("71217ece-6739-4054-8662-0db3a02accd3"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UUID",
                value: new Guid("083613e3-1e38-4ae1-8f6e-4b38ec186189"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UUID",
                value: new Guid("2554e0c3-5f7c-4d36-95d9-add69567b788"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UUID",
                value: new Guid("002ff885-d2fd-4050-952d-ac018738f2ee"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UUID",
                value: new Guid("d1344d9b-1644-4cdf-871d-26e3ff23f577"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UUID",
                value: new Guid("1311ded0-a92e-4c58-bf6d-539e64119a96"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "MediaGuid",
                value: new Guid("ba56b848-c6d3-4aa6-97b1-f26a5ef0b761"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "MediaGuid",
                value: new Guid("953f1b42-9546-4e5b-9b35-6749e9c16382"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "MediaGuid",
                value: new Guid("292aef0d-6c99-4df9-ae62-34de9fe6d324"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "MediaGuid",
                value: new Guid("c11e2a91-ee47-45bf-9f31-656581202f02"));
        }
    }
}
