using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class SetUniqueContraintOnEntityIdOnAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_Username_EntityId",
                table: "Username",
                column: "EntityId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Post_EntityId",
                table: "Post",
                column: "EntityId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Person_EntityId",
                table: "Person",
                column: "EntityId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Media_EntityId",
                table: "Media",
                column: "EntityId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Comment_EntityId",
                table: "Comment",
                column: "EntityId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Challenge_EntityId",
                table: "Challenge",
                column: "EntityId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Address_EntityId",
                table: "Address",
                column: "EntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Username_EntityId",
                table: "Username");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Post_EntityId",
                table: "Post");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Person_EntityId",
                table: "Person");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Media_EntityId",
                table: "Media");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Comment_EntityId",
                table: "Comment");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Challenge_EntityId",
                table: "Challenge");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Address_EntityId",
                table: "Address");
        }
    }
}
