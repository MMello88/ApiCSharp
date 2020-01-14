using lab.Domain.Entities.Cadastro.Auxiliar;
using lab.Domain.Entities.Enums;

namespace lab.Domain.Entities.Registro
{
    public class PessoaJuridica
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public MatrizEnum Matriz { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public int MunicipioId { get; set; }
        public Municipio Municipio { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Cnpj { get; set; }
        public string CNAE { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string NrSuframa { get; set; }
        public int NaturezaJuridica { get; set; }
        public string NomeContato { get; set; }
        public string WebSite { get; set; }
        public ContribuicaoEnum DmContribuicao { get; set; }
        public int PessoaFisicaId { get; set; }
        public virtual PessoaFisica PessoaFisica { get; set; }
    }
}
