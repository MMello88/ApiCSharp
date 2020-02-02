using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class CriandoChaveUmParaMuitosPJe0000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regs0000EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0000EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0000EFDC_PessoaJuridicaId",
                table: "Regs0000EFDC");

            migrationBuilder.AlterColumn<int>(
                name: "PessoaJuridicaId",
                table: "Regs0000EFDC",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0000EFDC_PessoaJuridicaId",
                table: "Regs0000EFDC",
                column: "PessoaJuridicaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0000EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0000EFDC",
                column: "PessoaJuridicaId",
                principalTable: "PessoasJuridica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regs0000EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0000EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0000EFDC_PessoaJuridicaId",
                table: "Regs0000EFDC");

            migrationBuilder.AlterColumn<int>(
                name: "PessoaJuridicaId",
                table: "Regs0000EFDC",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Regs0000EFDC_PessoaJuridicaId",
                table: "Regs0000EFDC",
                column: "PessoaJuridicaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0000EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0000EFDC",
                column: "PessoaJuridicaId",
                principalTable: "PessoasJuridica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
