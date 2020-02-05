using lab.Domain.Entities.Registro;
using lab.Domain.Entities.Enums.Indicadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0120EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public DateTime MesRefer { get; set; }
        public InfoComplementar InfoCompl { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFin { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual User User { get; set; }
    }
}