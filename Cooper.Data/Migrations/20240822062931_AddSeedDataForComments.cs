using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class AddSeedDataForComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ParentId",
                value: 1L);

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "Body", "ParentId", "Title" },
                values: new object[,]
                {
                    { 3L, "You are the best", 2L, "Comment 3 " },
                    { 4L, "You are the best", 1L, "Comment 4 " },
                    { 5L, "You are the best", 3L, "Comment 5 " },
                    { 6L, "You are the best", 0L, "Comment 6 " }
                });

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
                    { 6L, 6L, 3L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ParentId",
                value: 0L);
        }
    }
}
