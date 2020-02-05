using lab.Domain.Entities.Registro;
using System;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0110EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public int CodIncTrib { get; set; }
        public int IndAproCred { get; set; }
        public int CodTipoCont { get; set; }
        public int IndRegCum { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFin { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual User User { get; set; }
        public virtual Reg0111EFDC Reg0111EFDC { get; set; }
    }
}