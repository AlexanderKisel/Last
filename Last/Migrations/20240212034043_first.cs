using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Last.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oborudovanie",
                columns: table => new
                {
                    Id_obor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_obor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oborudovanie", x => x.Id_obor);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id_role = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id_role);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id_status = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id_status);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id_type = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id_type);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id_user = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id_user);
                    table.ForeignKey(
                        name: "FK_User_Role",
                        column: x => x.role_id,
                        principalTable: "Role",
                        principalColumn: "Id_role");
                });

            migrationBuilder.CreateTable(
                name: "Zayavki",
                columns: table => new
                {
                    Id_zayavki = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_zayavki = table.Column<DateTime>(type: "date", nullable: false),
                    obor_id = table.Column<int>(type: "int", nullable: false),
                    type_id = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    Date_start = table.Column<DateTime>(type: "date", nullable: true),
                    Date_end = table.Column<DateTime>(type: "date", nullable: true),
                    rab_id = table.Column<int>(type: "int", nullable: true),
                    status_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zayavki", x => x.Id_zayavki);
                    table.ForeignKey(
                        name: "FK_Zayavki_Oborudovanie",
                        column: x => x.obor_id,
                        principalTable: "Oborudovanie",
                        principalColumn: "Id_obor");
                    table.ForeignKey(
                        name: "FK_Zayavki_Status",
                        column: x => x.status_id,
                        principalTable: "Status",
                        principalColumn: "Id_status");
                    table.ForeignKey(
                        name: "FK_Zayavki_Type",
                        column: x => x.type_id,
                        principalTable: "Type",
                        principalColumn: "Id_type");
                    table.ForeignKey(
                        name: "FK_Zayavki_User",
                        column: x => x.rab_id,
                        principalTable: "User",
                        principalColumn: "Id_user");
                    table.ForeignKey(
                        name: "FK_Zayavki_User1",
                        column: x => x.client_id,
                        principalTable: "User",
                        principalColumn: "Id_user");
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_role_id",
                table: "User",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_Zayavki_client_id",
                table: "Zayavki",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_Zayavki_obor_id",
                table: "Zayavki",
                column: "obor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Zayavki_rab_id",
                table: "Zayavki",
                column: "rab_id");

            migrationBuilder.CreateIndex(
                name: "IX_Zayavki_status_id",
                table: "Zayavki",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_Zayavki_type_id",
                table: "Zayavki",
                column: "type_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zayavki");

            migrationBuilder.DropTable(
                name: "Oborudovanie");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
