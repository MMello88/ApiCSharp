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
        public string MesRefer { get; set; }
        public InfoComplementar InfoCompl { get; set; }
        public int Reg0000EFDCId { get; set; }
        public virtual Reg0000EFDC Reg0000EFDC { get; set; }
    }
}
