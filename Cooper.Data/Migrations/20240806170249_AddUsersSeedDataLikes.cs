using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class AddUsersSeedDataLikes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Like_PostId",
                table: "Like");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Like_UserId",
                table: "Like");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "PostalCode", "StreetName", "Suburb" },
                values: new object[,]
                {
                    { 1L, "user 1 city", "1021", "user 1 st", "user 1 sub" },
                    { 2L, "user 2 city", "1022", "user 2 st", "user 2 sub" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "Email", "PhoneNumber" },
                values: new object[,]
                {
                    { 1L, "user1@cooper.com", "078944599345" },
                    { 2L, " user2@cooper.com", "068004599345" }
                });

            migrationBuilder.InsertData(
                table: "Like",
                columns: new[] { "Id", "PostId", "UserId" },
                values: new object[,]
                {
                    { 1L, 1L, 1L },
                    { 2L, 1L, 2L },
                    { 3L, 3L, 1L },
                    { 4L, 5L, 1L },
                    { 5L, 5L, 2L },
                    { 6L, 2L, 1L }
                });

            migrationBuilder.InsertData(
                table: "Password",
                columns: new[] { "Id", "PasswordKey", "UserId" },
                values: new object[,]
                {
                    { 1L, "string1", 1L },
                    { 2L, "string2", 2L }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "Gender", "Name", "Surname" },
                values: new object[,]
                {
                    { 1L, 12, "male", "user 1", "surname1" },
                    { 2L, 14, "female", "user 2", "surname2" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AddressId", "ContactId", "PersonId", "UserName" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, 1L, "user1" },
                    { 2L, 2L, 2L, 2L, "user2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Like",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Like",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Like",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Like",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Like",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Like",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Password",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Password",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Like_PostId",
                table: "Like",
                column: "PostId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Like_UserId",
                table: "Like",
                column: "UserId");
        }
    }
}
