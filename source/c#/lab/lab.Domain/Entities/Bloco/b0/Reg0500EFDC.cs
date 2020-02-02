using lab.Domain.Entities.Enums.Indicadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0500EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public DateTime DtAlteracao { get; set; }
        public IndCodNaturezaGrupoConta CodNatCC { get; set; }
        public char IndCTA { get; set; }
        public int Nivel { get; set; }
        public string CodCTA { get; set; }
        public string NomeCTA { get; set; }
        public string CodCTARef { get; set; }
        public int CNPJEstab { get; set; }
        public int Reg0000EFDCId { get; set; }
        public virtual Reg0000EFDC Reg0000EFDC { get; set; }
    }
}
