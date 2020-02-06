using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class AdicioandoTAmanhoAosNovosCAmpo0145ah0450 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regs0140EFDC_Reg0145EFDC_Reg0145EFDCId",
                table: "Regs0140EFDC");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reg0145EFDC",
                table: "Reg0145EFDC");

            migrationBuilder.RenameTable(
                name: "Reg0145EFDC",
                newName: "Regs0145EFDC");

            migrationBuilder.AlterColumn<decimal>(
                name: "VlRecTot",
                table: "Regs0145EFDC",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "VlRecDemaisAtiv",
                table: "Regs0145EFDC",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "VlRecAtiv",
                table: "Regs0145EFDC",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0145EFDC",
                maxLength: 4,
                nullable: false,
                defaultValue: "0145",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InfoCompl",
                table: "Regs0145EFDC",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regs0145EFDC",
                table: "Regs0145EFDC",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Regs0150EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(maxLength: 4, nullable: false, defaultValue: "0150"),
                    CodPart = table.Column<string>(maxLength: 60, nullable: false),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    PaisId = table.Column<int>(nullable: true),
                    CNPJ = table.Column<int>(maxLength: 14, nullable: false),
                    CPF = table.Column<int>(maxLength: 11, nullable: false),
                    IE = table.Column<string>(maxLength: 14, nullable: true),
                    MunicipioId = table.Column<int>(nullable: false),
                    Suframa = table.Column<string>(maxLength: 9, nullable: true),
                    End = table.Column<string>(maxLength: 60, nullable: true),
                    Num = table.Column<string>(maxLength: 20, nullable: true),
                    Compl = table.Column<string>(maxLength: 60, nullable: true),
                    Bairro = table.Column<string>(maxLength: 60, nullable: true),
                    DtIni = table.Column<DateTime>(nullable: false),
                    DtFin = table.Column<DateTime>(nullable: false),
                    PessoaJuridicaId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0150EFDC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regs0150EFDC_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Regs0150EFDC_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Regs0150EFDC_PessoasJuridica_PessoaJuridicaId",
                        column: x => x.PessoaJuridicaId,
                        principalTable: "PessoasJuridica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Regs0150EFDC_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Regs0190EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(maxLength: 4, nullable: false, defaultValue: "0190"),
                    Unidade = table.Column<string>(maxLength: 6, nullable: false),
                    Descrição = table.Column<string>(maxLength: 255, nullable: false),
                    DtIni = table.Column<DateTime>(nullable: false),
                    DtFin = table.Column<DateTime>(nullable: false),
                    PessoaJuridicaId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0190EFDC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regs0190EFDC_PessoasJuridica_PessoaJuridicaId",
                        column: x => x.PessoaJuridicaId,
                        principalTable: "PessoasJuridica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Regs0190EFDC_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Regs0400EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(maxLength: 4, nullable: false, defaultValue: "0400"),
                    CodNat = table.Column<string>(maxLength: 10, nullable: false),
                    DescricaoNat = table.Column<string>(maxLength: 255, nullable: false),
                    DtIni = table.Column<DateTime>(nullable: false),
                    DtFin = table.Column<DateTime>(nullable: false),
                    PessoaJuridicaId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0400EFDC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regs0400EFDC_PessoasJuridica_PessoaJuridicaId",
                        column: x => x.PessoaJuridicaId,
                        principalTable: "PessoasJuridica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Regs0400EFDC_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Regs0450EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(maxLength: 4, nullable: false, defaultValue: "0450"),
                    CodInf = table.Column<string>(maxLength: 6, nullable: false),
                    Txt = table.Column<string>(maxLength: 255, nullable: false),
                    DtIni = table.Column<DateTime>(nullable: false),
                    DtFin = table.Column<DateTime>(nullable: false),
                    PessoaJuridicaId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0450EFDC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regs0450EFDC_PessoasJuridica_PessoaJuridicaId",
                        column: x => x.PessoaJuridicaId,
                        principalTable: "PessoasJuridica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Regs0450EFDC_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Regs0200EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(maxLength: 4, nullable: false, defaultValue: "0200"),
                    CodItem = table.Column<string>(maxLength: 60, nullable: false),
                    DescricaoItem = table.Column<string>(maxLength: 255, nullable: false),
                    CodBarra = table.Column<string>(maxLength: 255, nullable: true),
                    CodAntItem = table.Column<string>(maxLength: 60, nullable: true),
                    Reg0190EFDCId = table.Column<int>(nullable: true),
                    TipoItem = table.Column<int>(nullable: false),
                    CodNcm = table.Column<string>(maxLength: 8, nullable: true),
                    ExIpi = table.Column<string>(maxLength: 3, nullable: true),
                    CodGen = table.Column<int>(maxLength: 2, nullable: false),
                    CodLst = table.Column<int>(maxLength: 5, nullable: false),
                    AliqIcms = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    DtIni = table.Column<DateTime>(nullable: false),
                    DtFin = table.Column<DateTime>(nullable: false),
                    PessoaJuridicaId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0200EFDC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regs0200EFDC_PessoasJuridica_PessoaJuridicaId",
                        column: x => x.PessoaJuridicaId,
                        principalTable: "PessoasJuridica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Regs0200EFDC_Regs0190EFDC_Reg0190EFDCId",
                        column: x => x.Reg0190EFDCId,
                        principalTable: "Regs0190EFDC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Regs0200EFDC_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Regs0150EFDC_MunicipioId",
                table: "Regs0150EFDC",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0150EFDC_PaisId",
                table: "Regs0150EFDC",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0150EFDC_PessoaJuridicaId",
                table: "Regs0150EFDC",
                column: "PessoaJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0150EFDC_UserId",
                table: "Regs0150EFDC",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0190EFDC_PessoaJuridicaId",
                table: "Regs0190EFDC",
                column: "PessoaJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0190EFDC_UserId",
                table: "Regs0190EFDC",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0200EFDC_PessoaJuridicaId",
                table: "Regs0200EFDC",
                column: "PessoaJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0200EFDC_Reg0190EFDCId",
                table: "Regs0200EFDC",
                column: "Reg0190EFDCId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0200EFDC_UserId",
                table: "Regs0200EFDC",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0400EFDC_PessoaJuridicaId",
                table: "Regs0400EFDC",
                column: "PessoaJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0400EFDC_UserId",
                table: "Regs0400EFDC",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0450EFDC_PessoaJuridicaId",
                table: "Regs0450EFDC",
                column: "PessoaJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0450EFDC_UserId",
                table: "Regs0450EFDC",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0140EFDC_Regs0145EFDC_Reg0145EFDCId",
                table: "Regs0140EFDC",
                column: "Reg0145EFDCId",
                principalTable: "Regs0145EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regs0140EFDC_Regs0145EFDC_Reg0145EFDCId",
                table: "Regs0140EFDC");

            migrationBuilder.DropTable(
                name: "Regs0150EFDC");

            migrationBuilder.DropTable(
                name: "Regs0200EFDC");

            migrationBuilder.DropTable(
                name: "Regs0400EFDC");

            migrationBuilder.DropTable(
                name: "Regs0450EFDC");

            migrationBuilder.DropTable(
                name: "Regs0190EFDC");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regs0145EFDC",
                table: "Regs0145EFDC");

            migrationBuilder.RenameTable(
                name: "Regs0145EFDC",
                newName: "Reg0145EFDC");

            migrationBuilder.AlterColumn<int>(
                name: "VlRecTot",
                table: "Reg0145EFDC",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<int>(
                name: "VlRecDemaisAtiv",
                table: "Reg0145EFDC",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<int>(
                name: "VlRecAtiv",
                table: "Reg0145EFDC",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Reg0145EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValue: "0145");

            migrationBuilder.AlterColumn<string>(
                name: "InfoCompl",
                table: "Reg0145EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reg0145EFDC",
                table: "Reg0145EFDC",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0140EFDC_Reg0145EFDC_Reg0145EFDCId",
                table: "Regs0140EFDC",
                column: "Reg0145EFDCId",
                principalTable: "Reg0145EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
