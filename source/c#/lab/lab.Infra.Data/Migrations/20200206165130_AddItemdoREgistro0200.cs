using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class AddItemdoREgistro0200 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Reg0205EFDCId",
                table: "Regs0200EFDC",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reg0206EFDCId",
                table: "Regs0200EFDC",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reg020EFDCId",
                table: "Regs0200EFDC",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Regs0205EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(maxLength: 4, nullable: false, defaultValue: "0205"),
                    DescricaoAntItem = table.Column<string>(maxLength: 255, nullable: false),
                    CodAntItem = table.Column<string>(maxLength: 60, nullable: true),
                    DtIni = table.Column<DateTime>(nullable: false),
                    DtFin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0205EFDC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regs0206EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(maxLength: 4, nullable: false, defaultValue: "0206"),
                    CodComb = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0206EFDC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regs0208EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(maxLength: 4, nullable: false, defaultValue: "0208"),
                    CodTabIncidencia = table.Column<int>(nullable: false),
                    CodGrupo = table.Column<string>(maxLength: 2, nullable: false),
                    MarcaComercial = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0208EFDC", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Regs0200EFDC_Reg0205EFDCId",
                table: "Regs0200EFDC",
                column: "Reg0205EFDCId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0200EFDC_Reg0206EFDCId",
                table: "Regs0200EFDC",
                column: "Reg0206EFDCId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0200EFDC_Reg020EFDCId",
                table: "Regs0200EFDC",
                column: "Reg020EFDCId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0200EFDC_Regs0205EFDC_Reg0205EFDCId",
                table: "Regs0200EFDC",
                column: "Reg0205EFDCId",
                principalTable: "Regs0205EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0200EFDC_Regs0206EFDC_Reg0206EFDCId",
                table: "Regs0200EFDC",
                column: "Reg0206EFDCId",
                principalTable: "Regs0206EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0200EFDC_Regs0208EFDC_Reg020EFDCId",
                table: "Regs0200EFDC",
                column: "Reg020EFDCId",
                principalTable: "Regs0208EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regs0200EFDC_Regs0205EFDC_Reg0205EFDCId",
                table: "Regs0200EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0200EFDC_Regs0206EFDC_Reg0206EFDCId",
                table: "Regs0200EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0200EFDC_Regs0208EFDC_Reg020EFDCId",
                table: "Regs0200EFDC");

            migrationBuilder.DropTable(
                name: "Regs0205EFDC");

            migrationBuilder.DropTable(
                name: "Regs0206EFDC");

            migrationBuilder.DropTable(
                name: "Regs0208EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0200EFDC_Reg0205EFDCId",
                table: "Regs0200EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0200EFDC_Reg0206EFDCId",
                table: "Regs0200EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0200EFDC_Reg020EFDCId",
                table: "Regs0200EFDC");

            migrationBuilder.DropColumn(
                name: "Reg0205EFDCId",
                table: "Regs0200EFDC");

            migrationBuilder.DropColumn(
                name: "Reg0206EFDCId",
                table: "Regs0200EFDC");

            migrationBuilder.DropColumn(
                name: "Reg020EFDCId",
                table: "Regs0200EFDC");
        }
    }
}
