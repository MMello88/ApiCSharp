using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace lab.Infra.Data.Migrations
{
    public partial class addtabelasiniciais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CdMunicipio = table.Column<string>(maxLength: 7, nullable: false),
                    Nome = table.Column<string>(maxLength: 150, nullable: false),
                    Uf = table.Column<string>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CdPais = table.Column<string>(maxLength: 5, nullable: false),
                    Nome = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PessoasFisica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 250, nullable: false),
                    Sobrenome = table.Column<string>(maxLength: 300, nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    UrlFoto = table.Column<string>(maxLength: 150, nullable: true),
                    Ativo = table.Column<int>(nullable: false, defaultValue: 1),
                    Criacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoasFisica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PessoasJuridica",
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
                    MunicipioId = table.Column<int>(nullable: false),
                    PessoaFisicaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoasJuridica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoasJuridica_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PessoasJuridica_PessoasFisica_PessoaFisicaId",
                        column: x => x.PessoaFisicaId,
                        principalTable: "PessoasFisica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PessoasJuridica_MunicipioId",
                table: "PessoasJuridica",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoasJuridica_PessoaFisicaId",
                table: "PessoasJuridica",
                column: "PessoaFisicaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "PessoasJuridica");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "PessoasFisica");
        }
    }
}
