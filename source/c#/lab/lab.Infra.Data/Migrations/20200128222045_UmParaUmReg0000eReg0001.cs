using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class UmParaUmReg0000eReg0001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Reg0001EFDCId",
                table: "Regs0000EFDC",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Regs0001EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(maxLength: 4, nullable: false, defaultValue: "0000"),
                    IndicadorMovimento = table.Column<int>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0001EFDC", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Regs0000EFDC_Reg0001EFDCId",
                table: "Regs0000EFDC",
                column: "Reg0001EFDCId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0000EFDC_Regs0001EFDC_Reg0001EFDCId",
                table: "Regs0000EFDC",
                column: "Reg0001EFDCId",
                principalTable: "Regs0001EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regs0000EFDC_Regs0001EFDC_Reg0001EFDCId",
                table: "Regs0000EFDC");

            migrationBuilder.DropTable(
                name: "Regs0001EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0000EFDC_Reg0001EFDCId",
                table: "Regs0000EFDC");

            migrationBuilder.DropColumn(
                name: "Reg0001EFDCId",
                table: "Regs0000EFDC");
        }
    }
}
