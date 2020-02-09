using lab.Domain.Entities.Bloco.b0;
using lab.Domain.Entities.Registro;
using System;

namespace lab.Domain.Entities.Bloco.bA
{
    public class RegA110EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public Reg0450EFDC Reg0450EFDC { get; set; }
        public string TxtComplementar { get; set; }
		public int RegA100EFDCId { get; set; }
		public virtual RegA100EFDC RegA100EFDC { get; set; }
    }
}
