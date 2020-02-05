using lab.Domain.Entities.Cadastro.Auxiliar;
using System;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0100EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string CRC { get; set; }
        public int CNPJ { get; set; }
        public int CEP { get; set; }
        public string End { get; set; }
        public string Num { get; set; }
        public string Compl { get; set; }
        public string Bairro { get; set; }
        public string Fone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int MunicipioId { get; set; }
        public virtual Municipio Municipio { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFin { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual User User { get; set; }
    }
}