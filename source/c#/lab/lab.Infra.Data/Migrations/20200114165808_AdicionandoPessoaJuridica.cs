using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class AdicionandoPessoaJuridica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Criacao",
                table: "PessoaFisicas",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2020, 1, 11, 16, 13, 35, 755, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.CreateTable(
                name: "PessoaJuridica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 450, nullable: false),
                    NomeFantasia = table.Column<string>(maxLength: 450, nullable: false),
                    Matriz = table.Column<int>(nullable: false, defaultValue: 0),
                    Endereco = table.Column<string>(maxLength: 250, nullable: false),
                    Numero = table.Column<string>(maxLength: 10, nullable: false),
                    Complemento = table.Column<string>(maxLength: 100, nullable: true),
                    Bairro = table.Column<string>(maxLength: 150, nullable: false),
                    CEP = table.Column<string>(maxLength: 10, nullable: false),
                    Telefone = table.Column<string>(maxLength: 15, nullable: true),
                    Celular = table.Column<string>(maxLength: 15, nullable: false),
                    Email = table.Column<string>(maxLength: 250, nullable: false),
                    InscricaoEstadual = table.Column<string>(maxLength: 20, nullable: true),
                    Cnpj = table.Column<string>(maxLength: 20, nullable: false),
                    CNAE = table.Column<string>(maxLength: 9, nullable: true),
                    InscricaoMunicipal = table.Column<string>(maxLength: 20, nullable: true),
                    NrSuframa = table.Column<string>(maxLength: 9, nullable: true),
                    NaturezaJuridica = table.Column<int>(nullable: false),
                    NomeContato = table.Column<string>(maxLength: 150, nullable: true),
                    WebSite = table.Column<string>(maxLength: 200, nullable: true),
                    DmContribuicao = table.Column<int>(nullable: false, defaultValue: 0),
                    PessoaFisicaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaJuridica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaJuridica_PessoaFisicas_PessoaFisicaId",
                        column: x => x.PessoaFisicaId,
                        principalTable: "PessoaFisicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PessoaJuridica_PessoaFisicaId",
                table: "PessoaJuridica",
                column: "PessoaFisicaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PessoaJuridica");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Criacao",
                table: "PessoaFisicas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 11, 16, 13, 35, 755, DateTimeKind.Local).AddTicks(5542),
                oldClrType: typeof(DateTime));
        }
    }
}
