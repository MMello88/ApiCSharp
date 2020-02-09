using lab.Domain.Entities.Bloco.b0;
using lab.Domain.Entities.Enums.Indicadores;
using System;

namespace lab.Domain.Entities.Bloco.bA
{
    public class RegA111EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public string NumProcesso { get; set; }
        public IndicadorOrigemProcesso IndicadorOrigemProcesso { get; set; }
		public virtual RegA100EFDC RegA100EFDC { get; set; }
    }
}
