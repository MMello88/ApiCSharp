using lab.Domain.Entities.Bloco.b0;
using lab.Domain.Entities.Cadastro.Referencias;
using lab.Domain.Entities.Enums.Indicadores;

namespace lab.Domain.Entities.Bloco.bA
{
    public class RegA170EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public int NumItem { get; set; }
        public virtual Reg0200EFDC Reg0200EFDC { get; set; }
        public string DescricaoComplementar { get; set; }
        public decimal VlItem { get; set; }
        public decimal VlDesconto { get; set; }
        public virtual Ref431 Ref431 { get; set; }
        public IndicadorOrigemCredito IndicadorOrigemCredito { get; set; }
        public virtual Ref433 Ref433 { get; set; }
        public decimal VlBcPis { get; set; }
        public decimal VlAliqPis { get; set; }
        public decimal VlPis { get; set; }
        public virtual Ref434 Ref434 { get; set; }
        public decimal VlBcCofins { get; set; }
        public decimal VlAliqCofins { get; set; }
        public decimal VlCofins { get; set; }
        public virtual Reg0500EFDC Reg0500EFDC { get; set; }
        public virtual Reg0600EFDC Reg0600EFDC { get; set; }
		public virtual RegA100EFDC RegA100EFDC { get; set; }
    }
}
