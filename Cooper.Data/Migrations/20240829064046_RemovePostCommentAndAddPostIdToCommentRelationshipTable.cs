using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class RemovePostCommentAndAddPostIdToCommentRelationshipTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostComment");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "CommentRelationship",
                newName: "PostId");

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 1L,
                column: "PostId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 2L,
                column: "PostId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 3L,
                column: "PostId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 4L,
                column: "PostId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 5L,
                column: "PostId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 6L,
                column: "PostId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 7L,
                column: "PostId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 8L,
                column: "PostId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 9L,
                column: "PostId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 10L,
                column: "PostId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 11L,
                column: "PostId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 12L,
                column: "PostId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 13L,
                column: "PostId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 14L,
                column: "PostId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 15L,
                column: "PostId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 16L,
                column: "PostId",
                value: 3L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "CommentRelationship",
                newName: "CommentId");

            migrationBuilder.CreateTable(
                name: "PostComment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CommentId = table.Column<long>(type: "bigint", nullable: false),
                    PostId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComment", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CommentId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CommentId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CommentId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CommentId",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CommentId",
                value: 5L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CommentId",
                value: 6L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CommentId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CommentId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CommentId",
                value: 9L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CommentId",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CommentId",
                value: 11L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CommentId",
                value: 12L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CommentId",
                value: 13L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CommentId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CommentId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "CommentRelationship",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CommentId",
                value: 1L);

            migrationBuilder.InsertData(
                table: "PostComment",
                columns: new[] { "Id", "CommentId", "PostId" },
                values: new object[,]
                {
                    { 1L, 1L, 3L },
                    { 2L, 2L, 3L },
                    { 3L, 3L, 3L },
                    { 4L, 4L, 3L },
                    { 5L, 5L, 3L },
                    { 6L, 6L, 3L },
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
    }
}
