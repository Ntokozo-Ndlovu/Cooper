using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class AddSeedDataForChallengeWithPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Challenge",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Challenge",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Challenge",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ChallengeGuid", "Price" },
                values: new object[] { new Guid("3d7e87a2-a92b-435c-b624-5e8f6cf3f8d8"), 11f });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ChallengeGuid", "Price" },
                values: new object[] { new Guid("f9ea64d6-8ab4-4968-83d2-5e95d5b6a6de"), 12f });

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ChallengeGuid", "Price" },
                values: new object[] { new Guid("641d1a06-728c-4703-81b4-02028964665c"), 13f });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Challenge");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Challenge");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Challenge");

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1,
                column: "ChallengeGuid",
                value: new Guid("8bfc524f-4b71-48ec-9ec3-6cc883868890"));

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2,
                column: "ChallengeGuid",
                value: new Guid("8b1be872-9111-4f33-8ec8-151c4956bb29"));

            migrationBuilder.UpdateData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 3,
                column: "ChallengeGuid",
                value: new Guid("a8dfc141-be2e-42f8-b3b1-a2c07900a12a"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UUID",
                value: new Guid("ded76e2c-b289-474c-a4dc-ca8f6f51259c"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UUID",
                value: new Guid("8ed7c4a2-5084-4420-8ca3-58ee70148e00"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UUID",
                value: new Guid("68fee093-91ec-4adb-80bc-ae7235771755"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UUID",
                value: new Guid("7ea1a59a-b614-4f80-acc1-35b52f1bb75f"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UUID",
                value: new Guid("b847994c-7014-4697-a0a5-ad85e9f759bf"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UUID",
                value: new Guid("53bf182d-c6d8-4107-8ec2-01f2fc643f51"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UUID",
                value: new Guid("f79b38a9-4322-4cc6-bf9c-c7d73f0c05fe"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UUID",
                value: new Guid("df0c0e78-00ee-4aaf-a5ac-8d0975a92c73"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UUID",
                value: new Guid("c195a501-6fe8-45bc-b652-48ffb9ad3cc8"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UUID",
                value: new Guid("b8ad9df4-a79d-49e6-909b-06447e95142d"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UUID",
                value: new Guid("ca042759-e697-49e1-aebb-e1701aad0577"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "MediaGuid",
                value: new Guid("ed11b1a9-db69-4266-b6af-a557a246bc95"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "MediaGuid",
                value: new Guid("aed5b676-9ed4-4ba0-985e-d2b612984c57"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "MediaGuid",
                value: new Guid("061c429e-cf95-4229-9ccd-dd5284e39851"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "MediaGuid",
                value: new Guid("234dabd7-a7bb-45a5-9228-a659f920abf3"));
        }
    }
}
