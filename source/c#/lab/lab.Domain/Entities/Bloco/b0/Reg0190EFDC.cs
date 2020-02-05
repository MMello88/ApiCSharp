using System;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0190EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public string Unidade { get; set; }
        public string Descrição { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFin { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual User User { get; set; }
    }
}