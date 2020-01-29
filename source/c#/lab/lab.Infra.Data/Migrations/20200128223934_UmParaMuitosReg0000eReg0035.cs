using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class UmParaMuitosReg0000eReg0035 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regs0035EFDC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Reg = table.Column<string>(maxLength: 4, nullable: false, defaultValue: "0000"),
                    CodSCP = table.Column<int>(maxLength: 14, nullable: false),
                    DescSCP = table.Column<string>(maxLength: 255, nullable: false),
                    InfoCompl = table.Column<string>(maxLength: 255, nullable: false),
                    Reg0000EFDCId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regs0035EFDC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regs0035EFDC_Regs0000EFDC_Reg0000EFDCId",
                        column: x => x.Reg0000EFDCId,
                        principalTable: "Regs0000EFDC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Regs0035EFDC_Reg0000EFDCId",
                table: "Regs0035EFDC",
                column: "Reg0000EFDCId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Regs0035EFDC");
        }
    }
}
