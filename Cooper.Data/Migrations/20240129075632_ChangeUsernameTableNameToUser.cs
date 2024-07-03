using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class ChangeUsernameTableNameToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Username_EntityId",
                table: "Username");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Username",
                table: "Username");

            migrationBuilder.RenameTable(
                name: "Username",
                newName: "User");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_User_EntityId",
                table: "User",
                column: "EntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_User_EntityId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Username");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Username_EntityId",
                table: "Username",
                column: "EntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Username",
                table: "Username",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UUID",
                value: new Guid("86dbf81d-d3e2-4a39-a4a8-372e01c873ad"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UUID",
                value: new Guid("af75625a-e3fd-4c52-a238-f7021fd80ef0"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UUID",
                value: new Guid("86c5a6dc-bc11-438e-ba04-2163f7c1d873"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UUID",
                value: new Guid("85b90351-5b44-4e4f-9120-b60d3f511e27"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UUID",
                value: new Guid("64925dca-45b2-45c6-9287-c8eb841db42a"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UUID",
                value: new Guid("af56e76b-dc29-4a3f-a25d-53c2ceda6318"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UUID",
                value: new Guid("04c5f954-1859-4c80-a988-b2fe5ee9367c"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UUID",
                value: new Guid("8591f2d9-04c7-4587-8ac1-5272306bfc5e"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UUID",
                value: new Guid("64988bdb-95b6-4eff-a10c-4884a27212de"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UUID",
                value: new Guid("7ed9d516-b801-465d-a315-65fd0928f1b2"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UUID",
                value: new Guid("96db3426-fc65-4914-bce0-acc35f8ffd62"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UUID",
                value: new Guid("4e59276a-5332-46b9-85d2-3fc0721d3620"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UUID",
                value: new Guid("902f8c51-2cc4-4793-8b4d-6688b0ecbfe1"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UUID",
                value: new Guid("a45a3f3d-280e-4d88-a85d-4e367cacfade"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UUID",
                value: new Guid("864880f9-96aa-4d36-a2d8-ee51020cba5f"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UUID",
                value: new Guid("f5d3d846-cc98-47f1-93bd-80dee02bb73e"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UUID",
                value: new Guid("06ae4ebc-27b2-4a49-974e-a3e4faff6a05"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UUID",
                value: new Guid("7d8b146f-ebf7-406e-bbb7-c15fcd25a484"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UUID",
                value: new Guid("68d7943a-7c04-4ffa-b662-ba694331b466"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "MediaGuid",
                value: new Guid("67c4f168-07f2-4509-a640-0f969d810d7e"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "MediaGuid",
                value: new Guid("313950d7-4287-491b-a53f-9c3617c89fce"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "MediaGuid",
                value: new Guid("220c9a62-3ecd-4deb-b0a7-721512acfbbd"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "MediaGuid",
                value: new Guid("4ac640b2-0a84-4854-996b-4ae10e9de95b"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5,
                column: "MediaGuid",
                value: new Guid("c341b81c-7003-4d22-92e7-8b6b0f9a746c"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6,
                column: "MediaGuid",
                value: new Guid("1100168c-38a9-4532-baf8-2dc3e1746587"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7,
                column: "MediaGuid",
                value: new Guid("a8e59e0a-85d4-4f1a-aae4-fcfea2e9e4e7"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 8,
                column: "MediaGuid",
                value: new Guid("434de396-424e-4ebc-be38-5bde124902c0"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 9,
                column: "MediaGuid",
                value: new Guid("657c70f7-c8a3-41af-ba49-15325218fded"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 10,
                column: "MediaGuid",
                value: new Guid("3a0a150c-a100-4e13-b93e-047452c08d6c"));
        }
    }
}
