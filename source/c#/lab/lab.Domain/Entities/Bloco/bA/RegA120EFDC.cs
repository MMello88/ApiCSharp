using lab.Domain.Entities.Bloco.b0;
using lab.Domain.Entities.Enums.Indicadores;
using System;

namespace lab.Domain.Entities.Bloco.bA
{
    public class RegA120EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public decimal VlTotalServico { get; set; }
        public decimal VlBcPis { get; set; }
        public decimal VlPisImportacao { get; set; }
        public DateTime DtPgtoPisImportacao { get; set; }
        public decimal VlBcCofins { get; set; }
        public decimal VlCofinsImportacao { get; set; }
        public DateTime DtPgtoCofinsImportacao { get; set; }
        public IndicadorLocalExecucaoServico IndicadorLocalExecucaoServico { get; set; }
        public virtual RegA100EFDC RegA100EFDC { get; set; }
    }
}
