using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class addEntityFieldToMediaAndComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Entity",
                table: "Media",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Entity",
                table: "Comment",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "Body", "Entity", "EntityId" },
                values: new object[,]
                {
                    { 1, "You are the best", 1, 7 },
                    { 2, "You are the best", 1, 8 }
                });

            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "UUID" },
                values: new object[,]
                {
                    { 1, new Guid("b1ae4bed-3058-41b2-97ef-eda07bbb3938") },
                    { 2, new Guid("8220b3da-d64c-46c6-8f97-78685f2a201f") },
                    { 3, new Guid("cd78e654-55a5-48a2-821a-7fa6c99d0b77") },
                    { 4, new Guid("7521efa1-ed0e-4f55-bd9c-b00c66ba7bbd") },
                    { 5, new Guid("fc608335-ba0d-4e14-99fa-b64e86bbb2b0") },
                    { 6, new Guid("9b4fc516-3760-4d01-b68e-d743ca4bdd20") },
                    { 7, new Guid("7a37f7fb-2a68-4ec1-a5ab-524fb277e2c4") },
                    { 8, new Guid("0356e095-a5b7-42b6-868f-68096bd333b4") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "Entity", "EntityId", "Link", "MediaGuid", "MediaType" },
                values: new object[,]
                {
                    { 1, 1, 2, "https://imageio.forbes.com/specials-images/imageserve/5d35eacaf1176b0008974b54/2020-Chevrolet-Corvette-Stingray/0x0.jpg?format=jpg&crop=4560,2565,x790,y784,safe&width=960", new Guid("3a357933-53bc-4216-a0a2-33c814bc4e87"), 0 },
                    { 2, 1, 3, "https://carwow-uk-wp-3.imgix.net/18015-MC20BluInfinito-scaled-e1666008987698.jpg", new Guid("3fa8d526-d192-41e5-968f-f66ff91f814d"), 0 },
                    { 3, 1, 4, "https://cdn.motor1.com/images/mgl/JO94P6/s1/most-expensive-cars-in-the-world.jpg", new Guid("3236a54a-dbe8-4c96-9f10-e7c62c101efb"), 0 },
                    { 4, 1, 5, "https://carwow-uk-wp-3.imgix.net/18015-MC20BluInfinito-scaled-e1666008987698.jpg", new Guid("c6a138a4-b2cb-4253-8f62-cc4f7783e590"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Description", "EntityId", "Likes" },
                values: new object[] { 1, "School Post", 1, 12 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Entity",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "Entity",
                table: "Comment");
        }
    }
}
