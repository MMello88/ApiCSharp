using System;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0450EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public string CodInf { get; set; }
        public string Txt { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFin { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual User User { get; set; }
    }
}