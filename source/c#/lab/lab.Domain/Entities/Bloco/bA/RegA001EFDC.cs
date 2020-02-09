using lab.Domain.Entities.Enums.Indicadores;
using lab.Domain.Entities.Registro;
using System;

namespace lab.Domain.Entities.Bloco.bA
{
    public class RegA001EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public IndicadorMovimento IndicadorMovimento { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFin { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual User User { get; set; }
    }
}
