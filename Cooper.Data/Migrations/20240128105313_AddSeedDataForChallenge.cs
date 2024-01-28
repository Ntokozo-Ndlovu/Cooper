using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class AddSeedDataForChallenge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Challenge",
                columns: new[] { "Id", "ChallengeGuid", "Description", "EntityId", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("8bfc524f-4b71-48ec-9ec3-6cc883868890"), "Please take a good soccer photo", 9, "Best Soccer Picture" },
                    { 2, new Guid("8b1be872-9111-4f33-8ec8-151c4956bb29"), "Please take a nice picture eating out", 10, "Best Steers Picture" },
                    { 3, new Guid("a8dfc141-be2e-42f8-b3b1-a2c07900a12a"), "Please take a nice picture eating out", 11, "Best Sunday Chill Picture" }
                });

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

            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "UUID" },
                values: new object[,]
                {
                    { 9, new Guid("c195a501-6fe8-45bc-b652-48ffb9ad3cc8") },
                    { 10, new Guid("b8ad9df4-a79d-49e6-909b-06447e95142d") },
                    { 11, new Guid("ca042759-e697-49e1-aebb-e1701aad0577") }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UUID",
                value: new Guid("9b4e7796-807a-435e-b777-0595a0b9cc14"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UUID",
                value: new Guid("6e9b40b1-a813-4bce-bc36-3f7e457c3d1a"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UUID",
                value: new Guid("e6a7c895-1d9e-40af-a467-4f6c879d3a9f"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UUID",
                value: new Guid("45870931-fc34-4ff8-858a-b9a0a5267a18"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UUID",
                value: new Guid("e18e490a-1114-4b54-b3f1-272dfde25689"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UUID",
                value: new Guid("8240db1a-af3f-4d0e-b841-ff7dae0c5d73"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UUID",
                value: new Guid("2d7faf4f-a3c8-4460-9477-d6e6daa05dda"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UUID",
                value: new Guid("5073f39c-2c3c-4cb8-b049-ba46dd00dd88"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "MediaGuid",
                value: new Guid("c10357a5-d791-4551-8614-00e04bddf287"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "MediaGuid",
                value: new Guid("b3ad1879-3899-42a3-9f9e-c26402ea0d33"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "MediaGuid",
                value: new Guid("f90d5334-13e9-4f53-bbfa-2733240dc801"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "MediaGuid",
                value: new Guid("9fe68a0c-3bc7-4ca7-90b1-69e10ead1ed8"));
        }
    }
}
