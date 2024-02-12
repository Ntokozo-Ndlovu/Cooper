using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class CreateLikeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Like",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    EntityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Like", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UUID",
                value: new Guid("333afdfc-c836-4a17-b381-87ea385e4673"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UUID",
                value: new Guid("ca4877dd-677c-43ba-bbca-6740d2205d05"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UUID",
                value: new Guid("d4f4625c-fedb-4c63-aa36-3870f17074e0"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UUID",
                value: new Guid("b599a3c6-23cd-4a13-a8bd-de0f5b0883b1"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UUID",
                value: new Guid("0ff78f8e-93c0-4c8d-94c0-63f6ebc526eb"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UUID",
                value: new Guid("c5b51598-0262-4bbb-a8fa-359ce695d1a4"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UUID",
                value: new Guid("de5b3e25-5851-4da2-aa05-81ee862f5193"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UUID",
                value: new Guid("70df340b-30ea-4c94-a72c-b97dcf304544"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UUID",
                value: new Guid("7fbbdc31-a4c5-4fdc-99fe-bd871051efe0"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UUID",
                value: new Guid("3781eaf6-c870-4901-99e1-0eb08dc9b045"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UUID",
                value: new Guid("680d2b0f-cdc4-440a-a8f7-d94760958d2b"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UUID",
                value: new Guid("9de47175-70d9-425b-a753-cac08c80798b"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UUID",
                value: new Guid("44fa2768-5be1-4c9c-b222-2e9cdae8ef2c"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UUID",
                value: new Guid("a7ba1bee-917b-4262-ae0e-a01eda194200"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UUID",
                value: new Guid("d13369d5-eadb-41c6-a92b-003596227961"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UUID",
                value: new Guid("ef5afcc7-d41e-463f-8677-f4c318e12f36"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UUID",
                value: new Guid("dc2dee3f-2eaa-4a82-84ef-83ff14f1af8c"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UUID",
                value: new Guid("1dd28b15-3dc7-4da9-9dc5-4953b1a1a659"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UUID",
                value: new Guid("a3bfed30-2d9a-42e9-9714-3e4be91ee0c2"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "MediaGuid",
                value: new Guid("9fb545ae-f3bf-4eee-b98d-2acc47254cf9"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "MediaGuid",
                value: new Guid("d0b49135-e15a-47fd-91e5-4deffd694d9d"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "MediaGuid",
                value: new Guid("24fac02b-7fe7-4cdf-8c41-c38a49941fcd"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "MediaGuid",
                value: new Guid("56fed7da-19f3-4ad4-a26b-0baf7860d823"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5,
                column: "MediaGuid",
                value: new Guid("7fed571e-5496-4b1a-b0b8-7e06bef94f99"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6,
                column: "MediaGuid",
                value: new Guid("c9d9eff2-12db-4dd4-9274-6d7107a4479f"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7,
                column: "MediaGuid",
                value: new Guid("bf5233a9-912d-414d-8d22-4f4f55aed379"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 8,
                column: "MediaGuid",
                value: new Guid("2c45a7ed-e1db-46a0-9031-c8740a2b2dc9"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 9,
                column: "MediaGuid",
                value: new Guid("6911192f-41ed-4351-8490-12914c31847e"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 10,
                column: "MediaGuid",
                value: new Guid("52999905-513b-487b-b5da-7274a0c6e427"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Like");

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UUID",
                value: new Guid("57b1f9bd-0733-459a-8529-0037b9ff89a0"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UUID",
                value: new Guid("100895bb-d558-4b54-b21c-3f0c63ee9c75"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UUID",
                value: new Guid("cb190719-e655-49b6-8828-dd775608f1f2"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UUID",
                value: new Guid("c106ac61-73f7-4731-985a-67b2e73092fd"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UUID",
                value: new Guid("59f8e3f6-6f94-44c8-b319-401e7b8c79e5"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UUID",
                value: new Guid("ac9c4675-9f1c-4e73-bbeb-4dcb7301d395"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UUID",
                value: new Guid("ce8a60f3-83fa-4af3-ab95-31682c3dacde"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UUID",
                value: new Guid("cba8c041-e53b-4901-94f7-850bf2b9e09e"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UUID",
                value: new Guid("03de708e-6104-4b42-a930-bbb37e7d6a8e"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UUID",
                value: new Guid("39b04ab9-c800-4fb6-b724-ca5b68d969d7"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UUID",
                value: new Guid("7c0878c4-af94-4f99-b366-a1e4024d2f6b"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UUID",
                value: new Guid("67de7ed7-d5a5-4401-ada6-696b779bd7a9"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UUID",
                value: new Guid("68db7b3f-1989-4a95-80cb-c0699de2e064"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UUID",
                value: new Guid("f36f9e3c-b242-4fa1-8a75-f4cdb9e598b4"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UUID",
                value: new Guid("707a6c62-091c-41f5-8842-0735e4cd9b71"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UUID",
                value: new Guid("b740e504-c6c4-4c59-a49e-e0ea1cce0909"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UUID",
                value: new Guid("8f9374ed-f307-4568-a636-81f62762eaca"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UUID",
                value: new Guid("1a0f794c-17f1-4ad3-bfd9-a36d2bfcfc0d"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UUID",
                value: new Guid("e52ceea5-f48c-4e63-8ac8-184546bd9539"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "MediaGuid",
                value: new Guid("4f741073-eef3-46b3-8f7f-7708e91292dd"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "MediaGuid",
                value: new Guid("ff57bc21-6fda-40be-8e93-6421c1bbabfe"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "MediaGuid",
                value: new Guid("7cb6a56d-f21c-4cc9-ad50-78612686a3ba"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "MediaGuid",
                value: new Guid("6c9f027e-c9ba-4024-a79b-f3aad7f592de"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5,
                column: "MediaGuid",
                value: new Guid("fbfcf816-3af5-4b5e-a149-038a642e8cb3"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6,
                column: "MediaGuid",
                value: new Guid("576217ad-2001-4679-9e07-bda264ea4a6a"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7,
                column: "MediaGuid",
                value: new Guid("59a03fb2-f336-4a00-8e1b-9bfabec84172"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 8,
                column: "MediaGuid",
                value: new Guid("16a4d831-b626-4a99-9f9c-2dbdfcb2338b"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 9,
                column: "MediaGuid",
                value: new Guid("636df1a7-f48a-4d0c-8725-18fa63e8ef6b"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 10,
                column: "MediaGuid",
                value: new Guid("96703af9-55e7-4eba-be73-d77e55b93956"));
        }
    }
}
