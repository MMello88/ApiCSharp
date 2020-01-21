using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class AdicionandoRegitro0000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ref311",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Versao = table.Column<string>(maxLength: 5, nullable: false),
                    Leiaout = table.Column<string>(maxLength: 100, nullable: false),
                    Periodo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref311", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regs0000",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    REG = table.Column<string>(maxLength: 4, nullable: false, defaultValue: "0000"),
                    Ref311Id = table.Column<int>(nullable: false),
                    TIPO_ESCRIT = table.Column<int>(maxLength: 1, nullable: false),
                    IND_SIT_ESP = table.Column<int>(maxLength: 1, nullable: false),
                    NUM_REC_ANTERIOR = table.Column<string>(maxLength: 41, nullable: true),
                    DT_INI = table.Column<DateTime>(nullable: false),
                    DT_FIN = table.Column<DateTime>(nullable: false),
                    NOME = table.Column<string>(maxLength: 100, nullable: false),
                    CNPJ = table.Column<int>(maxLength: 14, nullable: false),
                    MunicipioId = table.Column<int>(nullable: false),
                    SUFRAMA = table.Column<string>(maxLength: 9, nullable: true),
                    IND_NAT_PJ = table.Column<int>(maxLength: 2, nullable: false),
                    IND_ATIV = table.Column<int>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0000", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regs0000_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Regs0000_Ref311_Ref311Id",
                        column: x => x.Ref311Id,
                        principalTable: "Ref311",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Regs0000_MunicipioId",
                table: "Regs0000",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0000_Ref311Id",
                table: "Regs0000",
                column: "Ref311Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Regs0000");

            migrationBuilder.DropTable(
                name: "Ref311");
        }
    }
}
