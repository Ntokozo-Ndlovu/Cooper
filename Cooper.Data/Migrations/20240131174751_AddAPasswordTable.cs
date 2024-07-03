using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class AddAPasswordTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passwords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PasswordKey = table.Column<string>(type: "text", nullable: false),
                    EntityId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passwords", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UUID",
                value: new Guid("ad03a754-54ed-4214-a2d0-079181d24217"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UUID",
                value: new Guid("e83ee0ba-a096-4615-b715-40bf8be5aa84"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UUID",
                value: new Guid("48f01c74-a957-4fdc-b2e1-c53c4a0e7b83"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UUID",
                value: new Guid("2465aee8-63c9-42db-8498-fc942205d34d"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UUID",
                value: new Guid("a2f10d7b-36f8-4438-9f75-3872ba3af83a"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UUID",
                value: new Guid("dd8913ae-63d5-4fed-8dbe-cfff65a531f7"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UUID",
                value: new Guid("bad95bc3-e8c4-4064-8681-2d1e2a7ef438"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UUID",
                value: new Guid("02adc54b-62b3-49e9-a0f4-519c6fed498b"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UUID",
                value: new Guid("0760ff33-eb20-4b45-ba8f-4bbe6e6c44ea"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UUID",
                value: new Guid("3219fad2-0652-46b2-b38e-b059b753ed29"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UUID",
                value: new Guid("df15f55b-8bf2-4398-aa59-2274ecb469a5"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UUID",
                value: new Guid("595e8143-fa74-453e-82e0-8f2ba454d9b4"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UUID",
                value: new Guid("630c8a3f-77e6-4565-9ecd-5163b3f1669d"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UUID",
                value: new Guid("d5b485f6-41af-4dd3-b3ec-28cd1e114066"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UUID",
                value: new Guid("d7833865-41b2-402d-a5a2-48a5fac3e7dc"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UUID",
                value: new Guid("02700663-51e2-42e2-85eb-4cd0ce6aa6b8"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UUID",
                value: new Guid("9ee0bddc-a357-409e-ab1d-82f4814232b6"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UUID",
                value: new Guid("5ac48813-68d0-47eb-b88c-2a8dc4696c93"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UUID",
                value: new Guid("00b66687-1696-4e44-8a19-843f2fea58df"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "MediaGuid",
                value: new Guid("3ab7c85f-baa5-4b45-9f89-d474b61a370a"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "MediaGuid",
                value: new Guid("9bc8c1e1-fbb6-40d3-98f6-b352c0d7eaa8"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "MediaGuid",
                value: new Guid("602fdeda-fa4f-43c8-b78d-097241e9df79"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "MediaGuid",
                value: new Guid("e12d1945-ea8b-43f2-9187-9c769ecdef80"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5,
                column: "MediaGuid",
                value: new Guid("846e620a-83c4-484a-8f3b-55c39626ca74"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6,
                column: "MediaGuid",
                value: new Guid("89107414-4b9d-41eb-80c9-1164aa6c1311"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7,
                column: "MediaGuid",
                value: new Guid("576e0d4a-4d75-4821-962d-a282bce9c7cc"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 8,
                column: "MediaGuid",
                value: new Guid("388fff24-c32b-446a-9172-d10611013eaf"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 9,
                column: "MediaGuid",
                value: new Guid("ed5a1dad-85ae-411e-ba9f-57ee3b59c653"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 10,
                column: "MediaGuid",
                value: new Guid("87299b9b-5478-450c-b619-af4044b7ad14"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passwords");

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UUID",
                value: new Guid("4a6c3d56-1dd3-46f4-bc32-c0989abd37ad"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UUID",
                value: new Guid("f3f6828b-ee7d-4a36-ad66-2107aac3421a"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UUID",
                value: new Guid("8c67c58c-50b5-4882-ac19-0d4bf034b8ad"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UUID",
                value: new Guid("f2e9d792-7df9-4af2-99f9-0062c2bd037a"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UUID",
                value: new Guid("06c006bb-1dae-4a36-9f57-f6f0fc83f685"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UUID",
                value: new Guid("77e9d4c5-dae4-4acc-82ba-04f5e6372dde"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UUID",
                value: new Guid("1769bffa-ecff-4d4d-9df1-57e020aae5aa"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UUID",
                value: new Guid("d6d205f0-8ad9-4d45-8258-089eb6371175"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UUID",
                value: new Guid("41174498-7afe-4ff6-ad9c-d056ae618e49"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UUID",
                value: new Guid("431802af-9df1-465b-a240-7b277088ab2c"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UUID",
                value: new Guid("2a93ae7f-f0b8-4226-929c-a3c6775f4b51"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UUID",
                value: new Guid("c2743596-76d2-4761-ae9e-1187268da476"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UUID",
                value: new Guid("3a4d2fa2-f5d9-43eb-9f4c-704d6e2d7522"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UUID",
                value: new Guid("bf9360df-2f51-4786-aaaa-2e16dd3d4b54"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UUID",
                value: new Guid("e9f1e3bf-485e-4be7-9736-d42b2e62375a"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UUID",
                value: new Guid("ae09db8e-2c2b-4b71-84e5-55d436638b31"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UUID",
                value: new Guid("2588ffe0-fc48-417f-a5a4-835a8ec4adcd"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UUID",
                value: new Guid("098a9339-88ef-4631-a3a4-5de65e9869be"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UUID",
                value: new Guid("c4ab4e6c-b1fb-4fe9-8f9c-be14f57551a1"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "MediaGuid",
                value: new Guid("e68bac28-3d61-4bf5-9624-28a11e39751c"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "MediaGuid",
                value: new Guid("7b800aa6-a349-413e-be8d-8aab827614eb"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "MediaGuid",
                value: new Guid("5678e46c-8313-48b9-9467-71458782aee0"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "MediaGuid",
                value: new Guid("f45348ed-43da-461e-b760-7c9a470a27bb"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5,
                column: "MediaGuid",
                value: new Guid("78cd9b66-bd0b-4df5-8f2c-371c20ff90bd"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6,
                column: "MediaGuid",
                value: new Guid("88fee955-f781-4b1d-ac98-7e0f31ff207d"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7,
                column: "MediaGuid",
                value: new Guid("f5ee9568-43fe-47d8-bef9-97caf2df3650"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 8,
                column: "MediaGuid",
                value: new Guid("64812249-3c1d-42f0-9d47-91733a20c5c9"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 9,
                column: "MediaGuid",
                value: new Guid("7bcb74bf-8fcd-4d73-a45a-74bc4ca0858c"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 10,
                column: "MediaGuid",
                value: new Guid("2e48ce70-18a0-4816-85d0-f51938391339"));
        }
    }
}
