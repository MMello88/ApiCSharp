using System;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0600EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string CodCCusto { get; set; }
        public string NomeCCusto { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFin { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual User User { get; set; }
    }
}