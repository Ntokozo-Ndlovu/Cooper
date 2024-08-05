using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cooper.Data.Migrations
{
    public partial class RemoveEntityIdOnAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entities");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_User_EntityId",
                table: "User");

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

            migrationBuilder.DeleteData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2);

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
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "Password");

            migrationBuilder.DropColumn(
                name: "Entity",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "MediaGuid",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "Like");

            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Entity",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "Challenge");

            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "Address");

            migrationBuilder.AlterColumn<long>(
                name: "PersonId",
                table: "User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "ContactId",
                table: "User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "AddressId",
                table: "User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Post",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Person",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Password",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Password",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Media",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Like",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "PostId",
                table: "Like",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Like",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Contact",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Comment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Comment",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Challenge",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Address",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Like_PostId",
                table: "Like",
                column: "PostId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Like_UserId",
                table: "Like",
                column: "UserId");

            migrationBuilder.InsertData(
                table: "Challenge",
                columns: new[] { "Id", "ChallengeGuid", "Description", "EndDate", "Name", "Price", "StartDate" },
                values: new object[,]
                {
                    { 1L, new Guid("162ff745-7807-4b06-8660-5c7cc89a392f"), "Please take a good soccer photo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Best Soccer Picture", 11f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new Guid("520a4d3a-e6ce-458c-8c72-360a5ffc92eb"), "Please take a nice picture eating out", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Best Steers Picture", 12f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new Guid("a3bb21c7-9ea2-4c9b-9811-e3526856d05b"), "Please take a nice picture eating out", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Best Sunday Chill Picture", 13f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "Body", "Title" },
                values: new object[,]
                {
                    { 1L, "You are the best", "Comment 1" },
                    { 2L, "You are the best", "Comment 2 " }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "Link", "MediaType" },
                values: new object[,]
                {
                    { 1L, "https://imageio.forbes.com/specials-images/imageserve/5d35eacaf1176b0008974b54/2020-Chevrolet-Corvette-Stingray/0x0.jpg?format=jpg&crop=4560,2565,x790,y784,safe&width=960", 0 },
                    { 2L, "https://carwow-uk-wp-3.imgix.net/18015-MC20BluInfinito-scaled-e1666008987698.jpg", 0 },
                    { 3L, "https://cdn.motor1.com/images/mgl/JO94P6/s1/most-expensive-cars-in-the-world.jpg", 0 },
                    { 4L, "https://carwow-uk-wp-3.imgix.net/18015-MC20BluInfinito-scaled-e1666008987698.jpg", 0 },
                    { 5L, "https://i.abcnewsfe.com/a/aae2e440-73a2-4252-a4c9-c7d27f0efda7/mcdonalds-gty-thg-230728_1690559943139_hpMain.jpg", 0 },
                    { 6L, "https://www.allrecipes.com/thmb/3YpMeC2Za5PkXZFnlNFaBOCtC3c=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/mcdonalds-store-front-4x3-0a58d7e370ce48f7b050203fd478c407.png", 0 },
                    { 7L, "https://www.foodandwine.com/thmb/K_t1B_xBKIKYm_ZoNIEqaBvuXcQ=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/Burger-King-Everything-Seasoned-Bun-FT-BLOG0922-c8c7859b9c794c42af7700b5b957a874.jpg", 0 },
                    { 8L, "https://www.thestreet.com/.image/ar_16:9%2Cc_fill%2Ccs_srgb%2Cfl_progressive%2Cq_auto:good%2Cw_1200/MTg3NTA5NzAzMTQ2NzQzMzU2/burger-king-yeti-super-one-pound-beef-burger.jpg", 0 },
                    { 9L, "https://media-cdn.tripadvisor.com/media/photo-s/11/70/80/ac/chciken.jpg", 0 },
                    { 10L, "https://www.kimberley.co.za/wp-content/uploads/2022/01/38784_STEERS-AsPhande_Sharing_Meal_Promotion-20220113-KCP-SP-v1_00a.jpg", 0 }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "ChallengeId", "Description", "Title" },
                values: new object[,]
                {
                    { 1L, new Guid("a3bb21c7-9ea2-4c9b-9811-e3526856d05b"), "School Post", "Steer Burger" },
                    { 2L, new Guid("520a4d3a-e6ce-458c-8c72-360a5ffc92eb"), "Sport Cars", "Ball for Soccer Peeps" },
                    { 3L, new Guid("162ff745-7807-4b06-8660-5c7cc89a392f"), "Everything we care about", "Hello Wold" },
                    { 4L, new Guid("a3bb21c7-9ea2-4c9b-9811-e3526856d05b"), "Best McDonald picture", "Mc Donalds" },
                    { 5L, new Guid("a3bb21c7-9ea2-4c9b-9811-e3526856d05b"), "King Burger Tastes really good", "King Burger" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Like_PostId",
                table: "Like");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Like_UserId",
                table: "Like");

            migrationBuilder.DeleteData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Challenge",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Comment");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "User",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "User",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "User",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "User",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityId",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Post",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityId",
                table: "Post",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Person",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityId",
                table: "Person",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Password",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Password",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityId",
                table: "Password",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Media",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Entity",
                table: "Media",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EntityId",
                table: "Media",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "MediaGuid",
                table: "Media",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Like",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "Like",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Like",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityId",
                table: "Like",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Contact",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityId",
                table: "Contact",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Comment",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Entity",
                table: "Comment",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EntityId",
                table: "Comment",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Challenge",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityId",
                table: "Challenge",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Address",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EntityId",
                table: "Address",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_User_EntityId",
                table: "User",
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

            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UUID = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Challenge",
                columns: new[] { "Id", "ChallengeGuid", "Description", "EndDate", "EntityId", "Name", "Price", "StartDate" },
                values: new object[,]
                {
                    { 1, new Guid("162ff745-7807-4b06-8660-5c7cc89a392f"), "Please take a good soccer photo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Best Soccer Picture", 11f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new Guid("520a4d3a-e6ce-458c-8c72-360a5ffc92eb"), "Please take a nice picture eating out", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Best Steers Picture", 12f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new Guid("a3bb21c7-9ea2-4c9b-9811-e3526856d05b"), "Please take a nice picture eating out", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Best Sunday Chill Picture", 13f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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
                    { 1, new Guid("649e7995-b1b5-461f-bc42-39f5b2d3c944") },
                    { 2, new Guid("353a6b24-d626-4fc6-a58b-9c96ab5177f9") },
                    { 3, new Guid("aee2b86b-8d30-4b1d-b2f0-a6b0a2c0be6e") },
                    { 4, new Guid("7d5dd39f-d988-4f39-9097-100836e3e233") },
                    { 5, new Guid("0862d34a-2b89-4e29-9d75-4fcdaeb0902a") },
                    { 6, new Guid("fd53f6a8-e36a-4d40-8166-e921664404df") },
                    { 7, new Guid("fb5979d4-739b-4e15-b783-7d66e3c2992b") },
                    { 8, new Guid("1e3acfbc-4785-4705-ba36-ece45ec72f59") },
                    { 9, new Guid("406f0fba-77ef-4663-94b8-e9e343151137") },
                    { 10, new Guid("492f04f5-a6a4-4a6d-bddb-9f796680cecd") },
                    { 11, new Guid("da32f098-4c14-4f0b-99e8-af1b4e14ed2f") },
                    { 12, new Guid("bcea1275-6bf6-456e-99a2-efc754c57026") },
                    { 13, new Guid("2412069f-b0ed-47b9-a64b-ebd21d8a6071") },
                    { 14, new Guid("fed21c1c-074d-40db-974d-ad58385b628b") },
                    { 15, new Guid("4e3277d1-fea7-417f-a4a3-4c984ecf3925") },
                    { 16, new Guid("6fe96931-d783-4263-96d0-33c1d6e27f5e") },
                    { 17, new Guid("3f5a127e-eddd-4327-8170-46a58f1889b7") },
                    { 18, new Guid("91fab4e6-dc05-4787-a795-5c333470478f") },
                    { 19, new Guid("30ef3b80-049c-4807-ac7a-b19ccfcd5278") }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "Entity", "EntityId", "Link", "MediaGuid", "MediaType" },
                values: new object[,]
                {
                    { 1, 12, 2, "https://imageio.forbes.com/specials-images/imageserve/5d35eacaf1176b0008974b54/2020-Chevrolet-Corvette-Stingray/0x0.jpg?format=jpg&crop=4560,2565,x790,y784,safe&width=960", new Guid("3d2bcf67-0db0-43c7-be29-5941358fde64"), 0 },
                    { 2, 12, 3, "https://carwow-uk-wp-3.imgix.net/18015-MC20BluInfinito-scaled-e1666008987698.jpg", new Guid("1a1c1c38-d39d-4983-928e-8fc1d805243f"), 0 },
                    { 3, 12, 4, "https://cdn.motor1.com/images/mgl/JO94P6/s1/most-expensive-cars-in-the-world.jpg", new Guid("f96a12c4-b88c-482a-9b1b-ba050f59a500"), 0 },
                    { 4, 12, 5, "https://carwow-uk-wp-3.imgix.net/18015-MC20BluInfinito-scaled-e1666008987698.jpg", new Guid("c3502e15-24fd-4340-b3b4-ec73d4e783a1"), 0 },
                    { 5, 14, 6, "https://i.abcnewsfe.com/a/aae2e440-73a2-4252-a4c9-c7d27f0efda7/mcdonalds-gty-thg-230728_1690559943139_hpMain.jpg", new Guid("2b28b7a2-2726-41d1-8340-10556e1c735b"), 0 },
                    { 6, 14, 7, "https://www.allrecipes.com/thmb/3YpMeC2Za5PkXZFnlNFaBOCtC3c=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/mcdonalds-store-front-4x3-0a58d7e370ce48f7b050203fd478c407.png", new Guid("c84d15aa-0b92-4f56-a5b3-f32b7ae3f3df"), 0 },
                    { 7, 15, 8, "https://www.foodandwine.com/thmb/K_t1B_xBKIKYm_ZoNIEqaBvuXcQ=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/Burger-King-Everything-Seasoned-Bun-FT-BLOG0922-c8c7859b9c794c42af7700b5b957a874.jpg", new Guid("70a58269-8cc5-4955-b2e1-1ab515fc125b"), 0 },
                    { 8, 15, 9, "https://www.thestreet.com/.image/ar_16:9%2Cc_fill%2Ccs_srgb%2Cfl_progressive%2Cq_auto:good%2Cw_1200/MTg3NTA5NzAzMTQ2NzQzMzU2/burger-king-yeti-super-one-pound-beef-burger.jpg", new Guid("c89d6490-6f5d-4586-8f1e-54818cc051fc"), 0 },
                    { 9, 1, 16, "https://media-cdn.tripadvisor.com/media/photo-s/11/70/80/ac/chciken.jpg", new Guid("e280a85c-c38a-4f17-a8e1-d6130cfe89b3"), 0 },
                    { 10, 1, 17, "https://www.kimberley.co.za/wp-content/uploads/2022/01/38784_STEERS-AsPhande_Sharing_Meal_Promotion-20220113-KCP-SP-v1_00a.jpg", new Guid("7035e881-202b-4f36-bb32-052e1af36eb2"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "ChallengeId", "Description", "EntityId", "Title" },
                values: new object[,]
                {
                    { 1, new Guid("a3bb21c7-9ea2-4c9b-9811-e3526856d05b"), "School Post", 1, "Steer Burger" },
                    { 2, new Guid("520a4d3a-e6ce-458c-8c72-360a5ffc92eb"), "Sport Cars", 12, "Ball for Soccer Peeps" },
                    { 3, new Guid("162ff745-7807-4b06-8660-5c7cc89a392f"), "Everything we care about", 13, "Hello Wold" },
                    { 4, new Guid("a3bb21c7-9ea2-4c9b-9811-e3526856d05b"), "Best McDonald picture", 14, "Mc Donalds" },
                    { 5, new Guid("a3bb21c7-9ea2-4c9b-9811-e3526856d05b"), "King Burger Tastes really good", 15, "King Burger" }
                });
        }
    }
}
