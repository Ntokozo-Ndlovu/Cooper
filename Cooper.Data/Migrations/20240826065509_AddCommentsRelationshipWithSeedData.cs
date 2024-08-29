using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class AddCommentsRelationshipWithSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Comment");

            migrationBuilder.AddColumn<bool>(
                name: "Root",
                table: "Comment",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "CommentRelationship",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentId = table.Column<long>(type: "bigint", nullable: false),
                    CommentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentRelationship", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Root",
                value: true);

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Root",
                value: true);

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "Body", "Root", "Title" },
                values: new object[,]
                {
                    { 7L, "You are the best", false, "Comment 7 " },
                    { 8L, "You are the best", false, "Comment 8 " },
                    { 9L, "You are the best", false, "Comment 9 " },
                    { 10L, "You are the best", false, "Comment 10 " },
                    { 11L, "You are the best", false, "Comment 11 " },
                    { 12L, "You are the best", false, "Comment 12 " },
                    { 13L, "You are the best", false, "Comment 13 " },
                    { 14L, "You are the best", false, "Comment 14 " },
                    { 15L, "You are the best", false, "Comment 15 " },
                    { 16L, "You are the best", false, "Comment 16 " }
                });

            migrationBuilder.InsertData(
                table: "CommentRelationship",
                columns: new[] { "Id", "CommentId", "ParentId" },
                values: new object[,]
                {
                    { 1L, 1L, 0L },
                    { 2L, 2L, 0L },
                    { 3L, 2L, 1L },
                    { 4L, 4L, 2L },
                    { 5L, 5L, 1L },
                    { 6L, 6L, 1L },
                    { 7L, 7L, 5L },
                    { 8L, 8L, 5L },
                    { 9L, 9L, 4L },
                    { 10L, 10L, 4L },
                    { 11L, 11L, 4L },
                    { 12L, 12L, 4L },
                    { 13L, 13L, 12L },
                    { 14L, 1L, 13L },
                    { 15L, 1L, 12L },
                    { 16L, 1L, 4L }
                });

            migrationBuilder.InsertData(
                table: "PostComment",
                columns: new[] { "Id", "CommentId", "PostId" },
                values: new object[,]
                {
                    { 7L, 7L, 3L },
                    { 8L, 8L, 3L },
                    { 9L, 9L, 3L },
                    { 10L, 10L, 3L },
                    { 11L, 11L, 3L },
                    { 12L, 12L, 3L },
                    { 13L, 13L, 3L },
                    { 14L, 14L, 3L },
                    { 15L, 15L, 3L },
                    { 16L, 16L, 3L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentRelationship");

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DropColumn(
                name: "Root",
                table: "Comment");

            migrationBuilder.AddColumn<long>(
                name: "ParentId",
                table: "Comment",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ParentId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ParentId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ParentId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 5L,
                column: "ParentId",
                value: 3L);
        }
    }
}
