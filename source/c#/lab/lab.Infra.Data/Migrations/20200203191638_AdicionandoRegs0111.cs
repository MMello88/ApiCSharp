using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class AdicionandoRegs0111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regs0110EFDC_Reg0111EFDC_Reg0111EFDCId",
                table: "Regs0110EFDC");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reg0111EFDC",
                table: "Reg0111EFDC");

            migrationBuilder.RenameTable(
                name: "Reg0111EFDC",
                newName: "Regs0111EFDC");

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0600EFDC",
                maxLength: 4,
                nullable: false,
                defaultValue: "0600",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeCCusto",
                table: "Regs0600EFDC",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodCCusto",
                table: "Regs0600EFDC",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0500EFDC",
                maxLength: 4,
                nullable: false,
                defaultValue: "0500",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeCTA",
                table: "Regs0500EFDC",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodCTARef",
                table: "Regs0500EFDC",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodCTA",
                table: "Regs0500EFDC",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "Regs0140EFDC",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Suframa",
                table: "Regs0140EFDC",
                maxLength: 9,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0140EFDC",
                maxLength: 4,
                nullable: false,
                defaultValue: "0140",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Regs0140EFDC",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IM",
                table: "Regs0140EFDC",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IE",
                table: "Regs0140EFDC",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodEstab",
                table: "Regs0140EFDC",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0120EFDC",
                maxLength: 4,
                nullable: false,
                defaultValue: "0120",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0110EFDC",
                maxLength: 4,
                nullable: false,
                defaultValue: "0110",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0111EFDC",
                maxLength: 4,
                nullable: false,
                defaultValue: "0111",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regs0111EFDC",
                table: "Regs0111EFDC",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0110EFDC_Regs0111EFDC_Reg0111EFDCId",
                table: "Regs0110EFDC",
                column: "Reg0111EFDCId",
                principalTable: "Regs0111EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regs0110EFDC_Regs0111EFDC_Reg0111EFDCId",
                table: "Regs0110EFDC");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regs0111EFDC",
                table: "Regs0111EFDC");

            migrationBuilder.RenameTable(
                name: "Regs0111EFDC",
                newName: "Reg0111EFDC");

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0600EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValue: "0600");

            migrationBuilder.AlterColumn<string>(
                name: "NomeCCusto",
                table: "Regs0600EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "CodCCusto",
                table: "Regs0600EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0500EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValue: "0500");

            migrationBuilder.AlterColumn<string>(
                name: "NomeCTA",
                table: "Regs0500EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "CodCTARef",
                table: "Regs0500EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodCTA",
                table: "Regs0500EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "Regs0140EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Suframa",
                table: "Regs0140EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0140EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValue: "0140");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Regs0140EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "IM",
                table: "Regs0140EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IE",
                table: "Regs0140EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodEstab",
                table: "Regs0140EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0120EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValue: "0120");

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Regs0110EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValue: "0110");

            migrationBuilder.AlterColumn<string>(
                name: "Reg",
                table: "Reg0111EFDC",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValue: "0111");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reg0111EFDC",
                table: "Reg0111EFDC",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0110EFDC_Reg0111EFDC_Reg0111EFDCId",
                table: "Regs0110EFDC",
                column: "Reg0111EFDCId",
                principalTable: "Reg0111EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
