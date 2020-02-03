using System;
using System.Collections.Generic;
using System.Text;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0600EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string CodCCusto { get; set; }
        public string NomeCCusto { get; set; }
        public int Reg0000EFDCId { get; set; }
        public virtual Reg0000EFDC Reg0000EFDC { get; set; }
    }
}