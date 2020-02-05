using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class RemovendoAsChavesEstrangeiras1 : Migration
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
                name: "IX_Regs0600EFDC_Reg0000EFDCId",
                table: "Regs0600EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0500EFDC_Reg0000EFDCId",
                table: "Regs0500EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0140EFDC_Reg0000EFDCId",
                table: "Regs0140EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0120EFDC_Reg0000EFDCId",
                table: "Regs0120EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0100EFDC_Reg0000EFDCId",
                table: "Regs0100EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0035EFDC_Reg0000EFDCId",
                table: "Regs0035EFDC");

            migrationBuilder.DropColumn(
                name: "Reg0000EFDCId",
                table: "Regs0600EFDC");

            migrationBuilder.DropColumn(
                name: "Reg0000EFDCId",
                table: "Regs0500EFDC");

            migrationBuilder.DropColumn(
                name: "Reg0000EFDCId",
                table: "Regs0140EFDC");

            migrationBuilder.DropColumn(
                name: "Reg0000EFDCId",
                table: "Regs0120EFDC");

            migrationBuilder.DropColumn(
                name: "Reg0000EFDCId",
                table: "Regs0100EFDC");

            migrationBuilder.DropColumn(
                name: "Reg0000EFDCId",
                table: "Regs0035EFDC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0600EFDC",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0500EFDC",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0140EFDC",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0120EFDC",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0100EFDC",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reg0000EFDCId",
                table: "Regs0035EFDC",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Regs0600EFDC_Reg0000EFDCId",
                table: "Regs0600EFDC",
                column: "Reg0000EFDCId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0500EFDC_Reg0000EFDCId",
                table: "Regs0500EFDC",
                column: "Reg0000EFDCId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0140EFDC_Reg0000EFDCId",
                table: "Regs0140EFDC",
                column: "Reg0000EFDCId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0120EFDC_Reg0000EFDCId",
                table: "Regs0120EFDC",
                column: "Reg0000EFDCId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0100EFDC_Reg0000EFDCId",
                table: "Regs0100EFDC",
                column: "Reg0000EFDCId");

            migrationBuilder.CreateIndex(
                name: "IX_Regs0035EFDC_Reg0000EFDCId",
                table: "Regs0035EFDC",
                column: "Reg0000EFDCId");

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
    }
}
