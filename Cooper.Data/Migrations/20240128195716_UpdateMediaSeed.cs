using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class UpdateMediaSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UUID",
                value: new Guid("be3b0698-e7c4-4b37-b5bb-f9bb426d8c65"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UUID",
                value: new Guid("5adbcac3-99a5-431c-a0b3-1170ea9432c7"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UUID",
                value: new Guid("7ab8ba08-c13a-4784-ac7a-01a933cd6884"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UUID",
                value: new Guid("6b17ea11-04bc-4775-b1ef-06d4daa0c2b4"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UUID",
                value: new Guid("9b801c74-cf1f-4269-bb97-5b3218790f43"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UUID",
                value: new Guid("fed86877-678f-4e2f-a1e8-d6852f27e03b"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UUID",
                value: new Guid("e8180b3a-a4bd-4103-a485-d819cc720997"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UUID",
                value: new Guid("a6658653-c68f-447f-9888-9a0eb715d30a"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UUID",
                value: new Guid("9799fce3-6fe5-493f-9b6e-3f6f1d2f6222"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UUID",
                value: new Guid("406bb9a8-a0b2-4e57-868a-9a5e0c69e2aa"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UUID",
                value: new Guid("dd956e5d-955b-423c-8840-8ec5623bc70e"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UUID",
                value: new Guid("4a592a61-c501-449d-9619-b6798626b512"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UUID",
                value: new Guid("af918806-5179-452c-a6a1-883714438484"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UUID",
                value: new Guid("311c70f3-301c-4f9a-a8ef-32f53a91f237"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UUID",
                value: new Guid("d4f21bbd-3ee8-494e-ab9c-651ea4eefa8d"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UUID",
                value: new Guid("360aabf3-0c5c-416a-a5d7-e28c22fa769f"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UUID",
                value: new Guid("1eb75e1e-b377-449a-81b2-fbf7d5aff3d4"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UUID",
                value: new Guid("977b5a83-6419-4067-8a2f-0c2c0cf423e2"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UUID",
                value: new Guid("897549ff-a2fa-4601-a4f8-bfae10913d03"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Entity", "MediaGuid" },
                values: new object[] { 12, new Guid("8fc313a2-5557-4fc3-943d-b18f1b1cbf08") });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Entity", "MediaGuid" },
                values: new object[] { 12, new Guid("cc019fed-b314-433f-8460-79b331b4d6d4") });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Entity", "MediaGuid" },
                values: new object[] { 12, new Guid("e1adcdfb-003d-4c27-b61b-a792aef25b77") });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Entity", "MediaGuid" },
                values: new object[] { 12, new Guid("ea777ec6-cf30-4e7a-937f-1fb3a56d4cca") });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5,
                column: "MediaGuid",
                value: new Guid("bdd4010a-5e4f-4da2-905a-41c914dc29bd"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6,
                column: "MediaGuid",
                value: new Guid("2488c6a5-7fe7-4e6f-9f93-50471d841017"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7,
                column: "MediaGuid",
                value: new Guid("5bf4abe6-b9ef-41b6-96e2-7f316c47a966"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 8,
                column: "MediaGuid",
                value: new Guid("08ba3864-4a3e-44cf-9d15-50f82fda6872"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 9,
                column: "MediaGuid",
                value: new Guid("fbe4cb68-b650-4775-a1a7-2bc91e68ed42"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 10,
                column: "MediaGuid",
                value: new Guid("aab110bd-6b45-44a1-b508-bc2e18e402d3"));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Sport Cars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UUID",
                value: new Guid("6ca9c802-774e-4bf2-bb6c-34de3084f27a"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UUID",
                value: new Guid("b1739f82-9286-464a-a7af-c3b1e7bda15d"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UUID",
                value: new Guid("52ac88e2-71ed-4d0e-a9f4-3bc0717258e3"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UUID",
                value: new Guid("1dc08fa8-6643-426e-b151-13632790510e"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UUID",
                value: new Guid("ac8c547c-6b48-4f9a-80b7-57c86a41f3f8"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UUID",
                value: new Guid("9a2685c3-9e95-4bcc-8705-6033b7b93cc7"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UUID",
                value: new Guid("70a81b50-526c-4df1-9dc5-e3780e1b7825"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UUID",
                value: new Guid("382d68fa-b115-4ed6-907b-1a5dd9119ce0"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UUID",
                value: new Guid("f84d62c1-6e93-4c61-8c23-6b3468efbb26"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UUID",
                value: new Guid("4e8291c0-3e7a-4402-9424-f89396bed7e7"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UUID",
                value: new Guid("409a74c8-9f5f-428d-94ae-602db26fc886"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UUID",
                value: new Guid("b0ad7c26-c853-498b-a524-892e29bba78c"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UUID",
                value: new Guid("96de4de0-5223-45c2-a31d-1937f77dd9e0"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UUID",
                value: new Guid("bd7ca71c-7321-4da9-826c-852a0e9a5aae"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UUID",
                value: new Guid("e884b323-35ba-4f7c-ad97-5a36c5960138"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UUID",
                value: new Guid("780d853d-8a58-44ec-a5fd-0d7e15b0bb19"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UUID",
                value: new Guid("0397f834-fb76-470a-a34f-5258f9d31120"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UUID",
                value: new Guid("50966827-0837-4832-9e8f-d6e813af41f8"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UUID",
                value: new Guid("0ab5ff49-0dee-4d39-a169-b3b5778a32fb"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Entity", "MediaGuid" },
                values: new object[] { 1, new Guid("9dec897f-9071-4ba8-9ab9-1133cf2beea5") });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Entity", "MediaGuid" },
                values: new object[] { 1, new Guid("ed03d970-86b0-42a5-884d-ca5e5cae3cb2") });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Entity", "MediaGuid" },
                values: new object[] { 1, new Guid("56948657-b056-4413-b21e-44a75a311292") });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Entity", "MediaGuid" },
                values: new object[] { 1, new Guid("c4569147-a20a-4c83-bf4d-2dd9f73b4508") });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5,
                column: "MediaGuid",
                value: new Guid("680fc6f2-7361-4a84-9f48-dacf1faaa8cf"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6,
                column: "MediaGuid",
                value: new Guid("9ae7a573-0371-4b5e-92c6-27dc50089bda"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7,
                column: "MediaGuid",
                value: new Guid("adec5eb7-6702-44e9-8fec-15d36eaa855c"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 8,
                column: "MediaGuid",
                value: new Guid("e9a05f47-d3f5-46ec-b1fb-efcc47a3a1c2"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 9,
                column: "MediaGuid",
                value: new Guid("b2065da8-4742-4fec-a8b5-44abb7c6f219"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 10,
                column: "MediaGuid",
                value: new Guid("019541fa-40f9-401e-ab69-70df415eec4a"));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Ronaldhino the best playyer");
        }
    }
}
