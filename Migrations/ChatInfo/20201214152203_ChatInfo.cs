using Microsoft.EntityFrameworkCore.Migrations;

namespace chatbot.Migrations.ChatInfo
{
    public partial class ChatInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "allusers",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_allusers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "chatinfo",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    warns_quantity = table.Column<int>(type: "int", nullable: true),
                    welcome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rules = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    disabled_commands = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chatinfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    warns = table.Column<int>(type: "int", nullable: true),
                    chatid = table.Column<long>(type: "bigint", nullable: true),
                    userid = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "allusers");

            migrationBuilder.DropTable(
                name: "chatinfo");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
