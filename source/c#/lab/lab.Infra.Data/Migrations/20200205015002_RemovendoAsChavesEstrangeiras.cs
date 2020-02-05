using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class RemovendoAsChavesEstrangeiras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regs0035EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0035EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0100EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0100EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0110EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0110EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0120EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0120EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0140EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0140EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0500EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0500EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0600EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0600EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0110EFDC_Reg0000EFDCId",
                table: "Regs0110EFDC");

            migrationBuilder.DropColumn(
                name: "Reg0000EFDCId",
                table: "Regs0110EFDC");

            migrationBuilder.AlterColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0600EFDC",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DtFin",
                table: "Regs0600EFDC",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtIni",
                table: "Regs0600EFDC",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0500EFDC",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DtFin",
                table: "Regs0500EFDC",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtIni",
                table: "Regs0500EFDC",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0140EFDC",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DtFin",
                table: "Regs0140EFDC",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtIni",
                table: "Regs0140EFDC",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Reg0145EFDCId",
                table: "Regs0140EFDC",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0120EFDC",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DtFin",
                table: "Regs0120EFDC",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtIni",
                table: "Regs0120EFDC",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtFin",
                table: "Regs0110EFDC",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtIni",
                table: "Regs0110EFDC",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0100EFDC",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DtFin",
                table: "Regs0100EFDC",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtIni",
                table: "Regs0100EFDC",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0035EFDC",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DtFin",
                table: "Regs0035EFDC",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtIni",
                table: "Regs0035EFDC",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0001EFDC",
                maxLength: 4,
                nullable: false,
                defaultValue: "0001",
                oldClrType: typeof(string),
                oldType: "varchar(4) CHARACTER SET utf8mb4",
                oldMaxLength: 4,
                oldDefaultValue: "0000");

            migrationBuilder.AddColumn<int>(
                name: "Regs0110EFDCId",
                table: "Regs0000EFDC",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reg0145EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(nullable: true),
                    CodIncTrib = table.Column<int>(nullable: false),
                    VlRecTot = table.Column<int>(nullable: false),
                    VlRecAtiv = table.Column<int>(nullable: false),
                    VlRecDemaisAtiv = table.Column<int>(nullable: false),
                    InfoCompl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reg0145EFDC", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Regs0140EFDC_Reg0145EFDCId",
                table: "Regs0140EFDC",
                column: "Reg0145EFDCId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0000EFDC_Regs0110EFDCId",
                table: "Regs0000EFDC",
                column: "Regs0110EFDCId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0000EFDC_Regs0110EFDC_Regs0110EFDCId",
                table: "Regs0000EFDC",
                column: "Regs0110EFDCId",
                principalTable: "Regs0110EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0035EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0035EFDC",
                column: "Reg0000EFDCId",
                principalTable: "Regs0000EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0100EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0100EFDC",
                column: "Reg0000EFDCId",
                principalTable: "Regs0000EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0120EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0120EFDC",
                column: "Reg0000EFDCId",
                principalTable: "Regs0000EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0140EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0140EFDC",
                column: "Reg0000EFDCId",
                principalTable: "Regs0000EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0140EFDC_Reg0145EFDC_Reg0145EFDCId",
                table: "Regs0140EFDC",
                column: "Reg0145EFDCId",
                principalTable: "Reg0145EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0500EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0500EFDC",
                column: "Reg0000EFDCId",
                principalTable: "Regs0000EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0600EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0600EFDC",
                column: "Reg0000EFDCId",
                principalTable: "Regs0000EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regs0000EFDC_Regs0110EFDC_Regs0110EFDCId",
                table: "Regs0000EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0035EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0035EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0100EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0100EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0120EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0120EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0140EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0140EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0140EFDC_Reg0145EFDC_Reg0145EFDCId",
                table: "Regs0140EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0500EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0500EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0600EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0600EFDC");

            migrationBuilder.DropTable(
                name: "Reg0145EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0140EFDC_Reg0145EFDCId",
                table: "Regs0140EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0000EFDC_Regs0110EFDCId",
                table: "Regs0000EFDC");

            migrationBuilder.DropColumn(
                name: "DtFin",
                table: "Regs0600EFDC");

            migrationBuilder.DropColumn(
                name: "DtIni",
                table: "Regs0600EFDC");

            migrationBuilder.DropColumn(
                name: "DtFin",
                table: "Regs0500EFDC");

            migrationBuilder.DropColumn(
                name: "DtIni",
                table: "Regs0500EFDC");

            migrationBuilder.DropColumn(
                name: "DtFin",
                table: "Regs0140EFDC");

            migrationBuilder.DropColumn(
                name: "DtIni",
                table: "Regs0140EFDC");

            migrationBuilder.DropColumn(
                name: "Reg0145EFDCId",
                table: "Regs0140EFDC");

            migrationBuilder.DropColumn(
                name: "DtFin",
                table: "Regs0120EFDC");

            migrationBuilder.DropColumn(
                name: "DtIni",
                table: "Regs0120EFDC");

            migrationBuilder.DropColumn(
                name: "DtFin",
                table: "Regs0110EFDC");

            migrationBuilder.DropColumn(
                name: "DtIni",
                table: "Regs0110EFDC");

            migrationBuilder.DropColumn(
                name: "DtFin",
                table: "Regs0100EFDC");

            migrationBuilder.DropColumn(
                name: "DtIni",
                table: "Regs0100EFDC");

            migrationBuilder.DropColumn(
                name: "DtFin",
                table: "Regs0035EFDC");

            migrationBuilder.DropColumn(
                name: "DtIni",
                table: "Regs0035EFDC");

            migrationBuilder.DropColumn(
                name: "Regs0110EFDCId",
                table: "Regs0000EFDC");

            migrationBuilder.AlterColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0600EFDC",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0500EFDC",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0140EFDC",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0120EFDC",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0110EFDC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0100EFDC",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0035EFDC",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0001EFDC",
                type: "varchar(4) CHARACTER SET utf8mb4",
                maxLength: 4,
                nullable: false,
                defaultValue: "0000",
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValue: "0001");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0110EFDC_Reg0000EFDCId",
                table: "Regs0110EFDC",
                column: "Reg0000EFDCId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0035EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0035EFDC",
                column: "Reg0000EFDCId",
                principalTable: "Regs0000EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0100EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0100EFDC",
                column: "Reg0000EFDCId",
                principalTable: "Regs0000EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0110EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0110EFDC",
                column: "Reg0000EFDCId",
                principalTable: "Regs0000EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0120EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0120EFDC",
                column: "Reg0000EFDCId",
                principalTable: "Regs0000EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0140EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0140EFDC",
                column: "Reg0000EFDCId",
                principalTable: "Regs0000EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0500EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0500EFDC",
                column: "Reg0000EFDCId",
                principalTable: "Regs0000EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0600EFDC_Regs0000EFDC_Reg0000EFDCId",
                table: "Regs0600EFDC",
                column: "Reg0000EFDCId",
                principalTable: "Regs0000EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
