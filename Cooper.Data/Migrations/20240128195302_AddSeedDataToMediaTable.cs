using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class AddSeedDataToMediaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "UUID" },
                values: new object[,]
                {
                    { 14, new Guid("bd7ca71c-7321-4da9-826c-852a0e9a5aae") },
                    { 15, new Guid("e884b323-35ba-4f7c-ad97-5a36c5960138") },
                    { 16, new Guid("780d853d-8a58-44ec-a5fd-0d7e15b0bb19") },
                    { 17, new Guid("0397f834-fb76-470a-a34f-5258f9d31120") },
                    { 18, new Guid("50966827-0837-4832-9e8f-d6e813af41f8") },
                    { 19, new Guid("0ab5ff49-0dee-4d39-a169-b3b5778a32fb") }
                });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1,
                column: "MediaGuid",
                value: new Guid("9dec897f-9071-4ba8-9ab9-1133cf2beea5"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2,
                column: "MediaGuid",
                value: new Guid("ed03d970-86b0-42a5-884d-ca5e5cae3cb2"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3,
                column: "MediaGuid",
                value: new Guid("56948657-b056-4413-b21e-44a75a311292"));

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "MediaGuid",
                value: new Guid("c4569147-a20a-4c83-bf4d-2dd9f73b4508"));

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "Entity", "EntityId", "Link", "MediaGuid", "MediaType" },
                values: new object[,]
                {
                    { 5, 14, 6, "https://i.abcnewsfe.com/a/aae2e440-73a2-4252-a4c9-c7d27f0efda7/mcdonalds-gty-thg-230728_1690559943139_hpMain.jpg", new Guid("680fc6f2-7361-4a84-9f48-dacf1faaa8cf"), 0 },
                    { 6, 14, 7, "https://www.allrecipes.com/thmb/3YpMeC2Za5PkXZFnlNFaBOCtC3c=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/mcdonalds-store-front-4x3-0a58d7e370ce48f7b050203fd478c407.png", new Guid("9ae7a573-0371-4b5e-92c6-27dc50089bda"), 0 },
                    { 7, 15, 8, "https://www.foodandwine.com/thmb/K_t1B_xBKIKYm_ZoNIEqaBvuXcQ=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/Burger-King-Everything-Seasoned-Bun-FT-BLOG0922-c8c7859b9c794c42af7700b5b957a874.jpg", new Guid("adec5eb7-6702-44e9-8fec-15d36eaa855c"), 0 },
                    { 8, 15, 9, "https://www.thestreet.com/.image/ar_16:9%2Cc_fill%2Ccs_srgb%2Cfl_progressive%2Cq_auto:good%2Cw_1200/MTg3NTA5NzAzMTQ2NzQzMzU2/burger-king-yeti-super-one-pound-beef-burger.jpg", new Guid("e9a05f47-d3f5-46ec-b1fb-efcc47a3a1c2"), 0 },
                    { 9, 1, 16, "https://media-cdn.tripadvisor.com/media/photo-s/11/70/80/ac/chciken.jpg", new Guid("b2065da8-4742-4fec-a8b5-44abb7c6f219"), 0 },
                    { 10, 1, 17, "https://www.kimberley.co.za/wp-content/uploads/2022/01/38784_STEERS-AsPhande_Sharing_Meal_Promotion-20220113-KCP-SP-v1_00a.jpg", new Guid("019541fa-40f9-401e-ab69-70df415eec4a"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "ChallengeId", "Description", "EntityId", "Likes", "Title" },
                values: new object[,]
                {
                    { 4, new Guid("a3bb21c7-9ea2-4c9b-9811-e3526856d05b"), "Best McDonald picture", 14, 12, "Mc Donalds" },
                    { 5, new Guid("a3bb21c7-9ea2-4c9b-9811-e3526856d05b"), "King Burger Tastes really good", 15, 150, "King Burger" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5);

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

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UUID",
                value: new Guid("c2255524-508a-485c-a6e8-732aacd2fef2"));

            migrationBuilder.UpdateData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UUID",
                value: new Guid("90975a8e-ddc8-4dc8-b483-57473913c87e"));

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
        }
    }
}
