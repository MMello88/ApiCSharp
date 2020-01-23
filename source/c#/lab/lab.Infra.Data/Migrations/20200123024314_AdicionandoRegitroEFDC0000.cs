using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class AdicionandoRegitroEFDC0000 : Migration
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
                name: "Regs0000EFDC",
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
                    IND_NAT_PJ = table.Column<int>(maxLength: 2, nullable: false),
                    IND_ATIV = table.Column<int>(maxLength: 1, nullable: false),
                    PessoaJuridicaId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    MunicipioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0000EFDC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regs0000EFDC_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Regs0000EFDC_PessoasJuridica_PessoaJuridicaId",
                        column: x => x.PessoaJuridicaId,
                        principalTable: "PessoasJuridica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Regs0000EFDC_Ref311_Ref311Id",
                        column: x => x.Ref311Id,
                        principalTable: "Ref311",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Regs0000EFDC_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ref311",
                columns: new[] { "Id", "Codigo", "Leiaout", "Periodo", "Versao" },
                values: new object[,]
                {
                    { 1, "001", "ADE Cofis nº 31/2010", new DateTime(2011, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1.00" },
                    { 2, "002", "ADE Cofis nº 34/2010, atualizado pelo ADE Cofis nº 37/2010", new DateTime(2011, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1.01" },
                    { 3, "002", "ADE Cofis nº 20/2012", new DateTime(2011, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2.00" },
                    { 4, "003", "ADE Cofis nº 20/2012", new DateTime(2012, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2.01A" },
                    { 5, "004", "ADE Cofis nº 20/2012", new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3.0.0" },
                    { 6, "005", "ADE Cofis nº 82/2018", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3.1.0" },
                    { 7, "006", "ADE Cofis nº 82/2018", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3.2.0" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Regs0000EFDC_MunicipioId",
                table: "Regs0000EFDC",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0000EFDC_PessoaJuridicaId",
                table: "Regs0000EFDC",
                column: "PessoaJuridicaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Regs0000EFDC_Ref311Id",
                table: "Regs0000EFDC",
                column: "Ref311Id");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0000EFDC_UserId",
                table: "Regs0000EFDC",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Regs0000EFDC");

            migrationBuilder.DropTable(
                name: "Ref311");
        }
    }
}
