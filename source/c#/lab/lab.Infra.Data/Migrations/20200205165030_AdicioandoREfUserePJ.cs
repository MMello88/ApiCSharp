using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class AdicioandoREfUserePJ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regs0000EFDC_Users_UserId",
                table: "Regs0000EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0035EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0035EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0035EFDC_Users_UserId",
                table: "Regs0035EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0000EFDC_UserId",
                table: "Regs0000EFDC");

            migrationBuilder.AddColumn<int>(
                name: "PessoaJuridicaId",
                table: "Regs0600EFDC",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Regs0600EFDC",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PessoaJuridicaId",
                table: "Regs0500EFDC",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Regs0500EFDC",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PessoaJuridicaId",
                table: "Regs0140EFDC",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Regs0140EFDC",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PessoaJuridicaId",
                table: "Regs0120EFDC",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Regs0120EFDC",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PessoaJuridicaId",
                table: "Regs0110EFDC",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Regs0110EFDC",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PessoaJuridicaId",
                table: "Regs0100EFDC",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Regs0100EFDC",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Regs0035EFDC",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PessoaJuridicaId",
                table: "Regs0035EFDC",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Regs0000EFDC",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0600EFDC_PessoaJuridicaId",
                table: "Regs0600EFDC",
                column: "PessoaJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0600EFDC_UserId",
                table: "Regs0600EFDC",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0500EFDC_PessoaJuridicaId",
                table: "Regs0500EFDC",
                column: "PessoaJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0500EFDC_UserId",
                table: "Regs0500EFDC",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0140EFDC_PessoaJuridicaId",
                table: "Regs0140EFDC",
                column: "PessoaJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0140EFDC_UserId",
                table: "Regs0140EFDC",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0120EFDC_PessoaJuridicaId",
                table: "Regs0120EFDC",
                column: "PessoaJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0120EFDC_UserId",
                table: "Regs0120EFDC",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0110EFDC_PessoaJuridicaId",
                table: "Regs0110EFDC",
                column: "PessoaJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0110EFDC_UserId",
                table: "Regs0110EFDC",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0100EFDC_PessoaJuridicaId",
                table: "Regs0100EFDC",
                column: "PessoaJuridicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0100EFDC_UserId",
                table: "Regs0100EFDC",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0000EFDC_UserId",
                table: "Regs0000EFDC",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0000EFDC_Users_UserId",
                table: "Regs0000EFDC",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0035EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0035EFDC",
                column: "PessoaJuridicaId",
                principalTable: "PessoasJuridica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0035EFDC_Users_UserId",
                table: "Regs0035EFDC",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0100EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0100EFDC",
                column: "PessoaJuridicaId",
                principalTable: "PessoasJuridica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0100EFDC_Users_UserId",
                table: "Regs0100EFDC",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0110EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0110EFDC",
                column: "PessoaJuridicaId",
                principalTable: "PessoasJuridica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0110EFDC_Users_UserId",
                table: "Regs0110EFDC",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0120EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0120EFDC",
                column: "PessoaJuridicaId",
                principalTable: "PessoasJuridica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0120EFDC_Users_UserId",
                table: "Regs0120EFDC",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0140EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0140EFDC",
                column: "PessoaJuridicaId",
                principalTable: "PessoasJuridica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0140EFDC_Users_UserId",
                table: "Regs0140EFDC",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0500EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0500EFDC",
                column: "PessoaJuridicaId",
                principalTable: "PessoasJuridica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0500EFDC_Users_UserId",
                table: "Regs0500EFDC",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0600EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0600EFDC",
                column: "PessoaJuridicaId",
                principalTable: "PessoasJuridica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0600EFDC_Users_UserId",
                table: "Regs0600EFDC",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regs0000EFDC_Users_UserId",
                table: "Regs0000EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0035EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0035EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0035EFDC_Users_UserId",
                table: "Regs0035EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0100EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0100EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0100EFDC_Users_UserId",
                table: "Regs0100EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0110EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0110EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0110EFDC_Users_UserId",
                table: "Regs0110EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0120EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0120EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0120EFDC_Users_UserId",
                table: "Regs0120EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0140EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0140EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0140EFDC_Users_UserId",
                table: "Regs0140EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0500EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0500EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0500EFDC_Users_UserId",
                table: "Regs0500EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0600EFDC_PessoasJuridica_PessoaJuridicaId",
                table: "Regs0600EFDC");

            migrationBuilder.DropForeignKey(
                name: "FK_Regs0600EFDC_Users_UserId",
                table: "Regs0600EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0600EFDC_PessoaJuridicaId",
                table: "Regs0600EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0600EFDC_UserId",
                table: "Regs0600EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0500EFDC_PessoaJuridicaId",
                table: "Regs0500EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0500EFDC_UserId",
                table: "Regs0500EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0140EFDC_PessoaJuridicaId",
                table: "Regs0140EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0140EFDC_UserId",
                table: "Regs0140EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0120EFDC_PessoaJuridicaId",
                table: "Regs0120EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0120EFDC_UserId",
                table: "Regs0120EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0110EFDC_PessoaJuridicaId",
                table: "Regs0110EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0110EFDC_UserId",
                table: "Regs0110EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0100EFDC_PessoaJuridicaId",
                table: "Regs0100EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0100EFDC_UserId",
                table: "Regs0100EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0000EFDC_UserId",
                table: "Regs0000EFDC");

            migrationBuilder.DropColumn(
                name: "PessoaJuridicaId",
                table: "Regs0600EFDC");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Regs0600EFDC");

            migrationBuilder.DropColumn(
                name: "PessoaJuridicaId",
                table: "Regs0500EFDC");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Regs0500EFDC");

            migrationBuilder.DropColumn(
                name: "PessoaJuridicaId",
                table: "Regs0140EFDC");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Regs0140EFDC");

            migrationBuilder.DropColumn(
                name: "PessoaJuridicaId",
                table: "Regs0120EFDC");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Regs0120EFDC");

            migrationBuilder.DropColumn(
                name: "PessoaJuridicaId",
                table: "Regs0110EFDC");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Regs0110EFDC");

            migrationBuilder.DropColumn(
                name: "PessoaJuridicaId",
                table: "Regs0100EFDC");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Regs0100EFDC");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Regs0035EFDC",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PessoaJuridicaId",
                table: "Regs0035EFDC",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Regs0000EFDC",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Regs0000EFDC_UserId",
                table: "Regs0000EFDC",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0000EFDC_Users_UserId",
                table: "Regs0000EFDC",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
