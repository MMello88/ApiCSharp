using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class EditandoPessoaFisicaConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrlFoto",
                table: "PessoaFisicas",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Criacao",
                table: "PessoaFisicas",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 11, 16, 13, 35, 755, DateTimeKind.Local).AddTicks(5542),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2020, 1, 11, 16, 10, 30, 635, DateTimeKind.Local).AddTicks(9203));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrlFoto",
                table: "PessoaFisicas",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Criacao",
                table: "PessoaFisicas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 11, 16, 10, 30, 635, DateTimeKind.Local).AddTicks(9203),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 11, 16, 13, 35, 755, DateTimeKind.Local).AddTicks(5542));
        }
    }
}
