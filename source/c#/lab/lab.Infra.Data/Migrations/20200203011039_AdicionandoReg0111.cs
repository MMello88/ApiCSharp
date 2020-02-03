using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class AdicionandoReg0111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Reg0111EFDCId",
                table: "Regs0110EFDC",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reg0111EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(nullable: true),
                    RecBruNCumTribMI = table.Column<int>(nullable: false),
                    RecBruNCumNaoTribMI = table.Column<int>(nullable: false),
                    RecBruNCumExp = table.Column<int>(nullable: false),
                    RecBruNCum = table.Column<int>(nullable: false),
                    RecBruNCumTotal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reg0111EFDC", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Regs0110EFDC_Reg0111EFDCId",
                table: "Regs0110EFDC",
                column: "Reg0111EFDCId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regs0110EFDC_Reg0111EFDC_Reg0111EFDCId",
                table: "Regs0110EFDC",
                column: "Reg0111EFDCId",
                principalTable: "Reg0111EFDC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regs0110EFDC_Reg0111EFDC_Reg0111EFDCId",
                table: "Regs0110EFDC");

            migrationBuilder.DropTable(
                name: "Reg0111EFDC");

            migrationBuilder.DropIndex(
                name: "IX_Regs0110EFDC_Reg0111EFDCId",
                table: "Regs0110EFDC");

            migrationBuilder.DropColumn(
                name: "Reg0111EFDCId",
                table: "Regs0110EFDC");
        }
    }
}
