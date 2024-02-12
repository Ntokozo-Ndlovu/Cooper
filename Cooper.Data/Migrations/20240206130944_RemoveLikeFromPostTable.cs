using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class RemoveLikeFromPostTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Post");

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UUID",
                value: new Guid("649e7995-b1b5-461f-bc42-39f5b2d3c944"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UUID",
                value: new Guid("353a6b24-d626-4fc6-a58b-9c96ab5177f9"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UUID",
                value: new Guid("aee2b86b-8d30-4b1d-b2f0-a6b0a2c0be6e"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UUID",
                value: new Guid("7d5dd39f-d988-4f39-9097-100836e3e233"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UUID",
                value: new Guid("0862d34a-2b89-4e29-9d75-4fcdaeb0902a"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UUID",
                value: new Guid("fd53f6a8-e36a-4d40-8166-e921664404df"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UUID",
                value: new Guid("fb5979d4-739b-4e15-b783-7d66e3c2992b"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UUID",
                value: new Guid("1e3acfbc-4785-4705-ba36-ece45ec72f59"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UUID",
                value: new Guid("406f0fba-77ef-4663-94b8-e9e343151137"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UUID",
                value: new Guid("492f04f5-a6a4-4a6d-bddb-9f796680cecd"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UUID",
                value: new Guid("da32f098-4c14-4f0b-99e8-af1b4e14ed2f"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UUID",
                value: new Guid("bcea1275-6bf6-456e-99a2-efc754c57026"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UUID",
                value: new Guid("2412069f-b0ed-47b9-a64b-ebd21d8a6071"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UUID",
                value: new Guid("fed21c1c-074d-40db-974d-ad58385b628b"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UUID",
                value: new Guid("4e3277d1-fea7-417f-a4a3-4c984ecf3925"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UUID",
                value: new Guid("6fe96931-d783-4263-96d0-33c1d6e27f5e"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UUID",
                value: new Guid("3f5a127e-eddd-4327-8170-46a58f1889b7"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UUID",
                value: new Guid("91fab4e6-dc05-4787-a795-5c333470478f"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UUID",
                value: new Guid("30ef3b80-049c-4807-ac7a-b19ccfcd5278"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "MediaGuid",
                value: new Guid("3d2bcf67-0db0-43c7-be29-5941358fde64"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "MediaGuid",
                value: new Guid("1a1c1c38-d39d-4983-928e-8fc1d805243f"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "MediaGuid",
                value: new Guid("f96a12c4-b88c-482a-9b1b-ba050f59a500"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "MediaGuid",
                value: new Guid("c3502e15-24fd-4340-b3b4-ec73d4e783a1"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5,
                column: "MediaGuid",
                value: new Guid("2b28b7a2-2726-41d1-8340-10556e1c735b"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6,
                column: "MediaGuid",
                value: new Guid("c84d15aa-0b92-4f56-a5b3-f32b7ae3f3df"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7,
                column: "MediaGuid",
                value: new Guid("70a58269-8cc5-4955-b2e1-1ab515fc125b"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 8,
                column: "MediaGuid",
                value: new Guid("c89d6490-6f5d-4586-8f1e-54818cc051fc"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 9,
                column: "MediaGuid",
                value: new Guid("e280a85c-c38a-4f17-a8e1-d6130cfe89b3"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 10,
                column: "MediaGuid",
                value: new Guid("7035e881-202b-4f36-bb32-052e1af36eb2"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "Post",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Likes",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Likes",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                column: "Likes",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                column: "Likes",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                column: "Likes",
                value: 150);
        }
    }
}
