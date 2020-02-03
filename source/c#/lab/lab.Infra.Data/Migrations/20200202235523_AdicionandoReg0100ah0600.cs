using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class AdicionandoReg0100ah0600 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0035EFDC",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(4) CHARACTER SET utf8mb4",
                oldMaxLength: 4,
                oldDefaultValue: "0000");

            migrationBuilder.AlterColumn<string>(
                name: "InfoCompl",
                table: "Regs0035EFDC",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "DescSCP",
                table: "Regs0035EFDC",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4",
                oldMaxLength: 255);

            migrationBuilder.CreateTable(
                name: "Regs0100EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(maxLength: 4, nullable: false, defaultValue: "0100"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    CPF = table.Column<int>(maxLength: 11, nullable: false),
                    CRC = table.Column<string>(maxLength: 15, nullable: false),
                    CNPJ = table.Column<int>(maxLength: 14, nullable: false),
                    CEP = table.Column<int>(maxLength: 8, nullable: false),
                    End = table.Column<string>(maxLength: 60, nullable: true),
                    Num = table.Column<string>(maxLength: 5, nullable: true),
                    Compl = table.Column<string>(maxLength: 60, nullable: true),
                    Bairro = table.Column<string>(maxLength: 60, nullable: true),
                    Fone = table.Column<string>(maxLength: 11, nullable: true),
                    Fax = table.Column<string>(maxLength: 11, nullable: true),
                    Email = table.Column<string>(maxLength: 255, nullable: true),
                    MunicipioId = table.Column<int>(nullable: false),
                    Reg0000EFDCId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0100EFDC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regs0100EFDC_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Regs0100EFDC_Regs0000EFDC_Reg0000EFDCId",
                        column: x => x.Reg0000EFDCId,
                        principalTable: "Regs0000EFDC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Regs0110EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(nullable: true),
                    CodIncTrib = table.Column<int>(nullable: false),
                    IndAproCred = table.Column<int>(nullable: false),
                    CodTipoCont = table.Column<int>(nullable: false),
                    IndRegCum = table.Column<int>(nullable: false),
                    Reg0000EFDCId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0110EFDC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regs0110EFDC_Regs0000EFDC_Reg0000EFDCId",
                        column: x => x.Reg0000EFDCId,
                        principalTable: "Regs0000EFDC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Regs0120EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(nullable: true),
                    MesRefer = table.Column<DateTime>(nullable: false),
                    InfoCompl = table.Column<int>(nullable: false),
                    Reg0000EFDCId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0120EFDC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regs0120EFDC_Regs0000EFDC_Reg0000EFDCId",
                        column: x => x.Reg0000EFDCId,
                        principalTable: "Regs0000EFDC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Regs0140EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(nullable: true),
                    CodEstab = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    CNPJ = table.Column<int>(nullable: false),
                    UF = table.Column<string>(nullable: true),
                    IE = table.Column<string>(nullable: true),
                    MunicipioId = table.Column<int>(nullable: false),
                    IM = table.Column<string>(nullable: true),
                    Suframa = table.Column<string>(nullable: true),
                    Reg0000EFDCId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0140EFDC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regs0140EFDC_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Regs0140EFDC_Regs0000EFDC_Reg0000EFDCId",
                        column: x => x.Reg0000EFDCId,
                        principalTable: "Regs0000EFDC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Regs0500EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(nullable: true),
                    DtAlteracao = table.Column<DateTime>(nullable: false),
                    CodNatCC = table.Column<int>(nullable: false),
                    IndCTA = table.Column<string>(nullable: false),
                    Nivel = table.Column<int>(nullable: false),
                    CodCTA = table.Column<string>(nullable: true),
                    NomeCTA = table.Column<string>(nullable: true),
                    CodCTARef = table.Column<string>(nullable: true),
                    CNPJEstab = table.Column<int>(nullable: false),
                    Reg0000EFDCId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0500EFDC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regs0500EFDC_Regs0000EFDC_Reg0000EFDCId",
                        column: x => x.Reg0000EFDCId,
                        principalTable: "Regs0000EFDC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Regs0600EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(nullable: true),
                    DtAlteracao = table.Column<DateTime>(nullable: false),
                    CodCCusto = table.Column<string>(nullable: true),
                    NomeCCusto = table.Column<string>(nullable: true),
                    Reg0000EFDCId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0600EFDC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regs0600EFDC_Regs0000EFDC_Reg0000EFDCId",
                        column: x => x.Reg0000EFDCId,
                        principalTable: "Regs0000EFDC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Regs0100EFDC_MunicipioId",
                table: "Regs0100EFDC",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0100EFDC_Reg0000EFDCId",
                table: "Regs0100EFDC",
                column: "Reg0000EFDCId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0110EFDC_Reg0000EFDCId",
                table: "Regs0110EFDC",
                column: "Reg0000EFDCId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Regs0120EFDC_Reg0000EFDCId",
                table: "Regs0120EFDC",
                column: "Reg0000EFDCId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0140EFDC_MunicipioId",
                table: "Regs0140EFDC",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0140EFDC_Reg0000EFDCId",
                table: "Regs0140EFDC",
                column: "Reg0000EFDCId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0500EFDC_Reg0000EFDCId",
                table: "Regs0500EFDC",
                column: "Reg0000EFDCId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0600EFDC_Reg0000EFDCId",
                table: "Regs0600EFDC",
                column: "Reg0000EFDCId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Regs0100EFDC");

            migrationBuilder.DropTable(
                name: "Regs0110EFDC");

            migrationBuilder.DropTable(
                name: "Regs0120EFDC");

            migrationBuilder.DropTable(
                name: "Regs0140EFDC");

            migrationBuilder.DropTable(
                name: "Regs0500EFDC");

            migrationBuilder.DropTable(
                name: "Regs0600EFDC");

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0035EFDC",
                type: "varchar(4) CHARACTER SET utf8mb4",
                maxLength: 4,
                nullable: false,
                defaultValue: "0000",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InfoCompl",
                table: "Regs0035EFDC",
                type: "varchar(255) CHARACTER SET utf8mb4",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescSCP",
                table: "Regs0035EFDC",
                type: "varchar(255) CHARACTER SET utf8mb4",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
