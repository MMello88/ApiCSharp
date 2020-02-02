using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class removendoChavePJ00000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PessoaJuridicaId",
                table: "Regs0035EFDC",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Regs0035EFDC",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Regs0035EFDC_PessoaJuridicaId",
                table: "Regs0035EFDC",
                column: "PessoaJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0035EFDC_UserId",
                table: "Regs0035EFDC",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0035EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0035EFDC",
                column: "PessoaJuridicaId",
                principalTable: "PessoasJuridica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0035EFDC_Users_UserId",
                table: "Regs0035EFDC",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regs0035EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0035EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0035EFDC_Users_UserId",
                table: "Regs0035EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0035EFDC_PessoaJuridicaId",
                table: "Regs0035EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0035EFDC_UserId",
                table: "Regs0035EFDC");

            migrationBuilder.DropColumn(
                name: "PessoaJuridicaId",
                table: "Regs0035EFDC");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Regs0035EFDC");
        }
    }
}
