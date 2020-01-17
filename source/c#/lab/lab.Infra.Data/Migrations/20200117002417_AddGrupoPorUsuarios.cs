using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class AddGrupoPorUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GrupoUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 350, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 350, nullable: false),
                    Sobrenome = table.Column<string>(maxLength: 250, nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    UrlFoto = table.Column<string>(nullable: true),
                    Ativo = table.Column<int>(nullable: false, defaultValue: 1),
                    Criacao = table.Column<DateTime>(nullable: false),
                    Usuario = table.Column<string>(maxLength: 250, nullable: false),
                    Email = table.Column<string>(maxLength: 250, nullable: false),
                    Senha = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersGrupo",
                columns: table => new
                {
                    GrupoUserId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Ativo = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersGrupo", x => new { x.UserId, x.GrupoUserId });
                    table.ForeignKey(
                        name: "FK_UsersGrupo_GrupoUsers_GrupoUserId",
                        column: x => x.GrupoUserId,
                        principalTable: "GrupoUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersGrupo_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersGrupo_GrupoUserId",
                table: "UsersGrupo",
                column: "GrupoUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersGrupo");

            migrationBuilder.DropTable(
                name: "GrupoUsers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
