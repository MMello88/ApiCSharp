using lab.Domain.Entities.Registro;
using System;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0400EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public string CodNat { get; set; }
        public string DescricaoNat { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFin { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual User User { get; set; }
    }
}