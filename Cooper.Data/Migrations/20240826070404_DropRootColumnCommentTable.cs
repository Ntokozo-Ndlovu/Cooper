using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class DropRootColumnCommentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Root",
                table: "Comment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Root",
                table: "Comment",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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
        }
    }
}
