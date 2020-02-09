using lab.Domain.Entities.Bloco.b0;
using lab.Domain.Entities.Enums.Indicadores;
using lab.Domain.Entities.Registro;
using System;
using System.Collections.Generic;

namespace lab.Domain.Entities.Bloco.bA
{
    public class RegA100EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
		public string CNPJ { get; set; }
        public IndicadorTipoOperacao IndicadorTipoOperacao { get; set; }
        public IndicadorEmitenteDocumento IndicadorEmitenteDocumento { get; set; }
        public virtual Reg0150EFDC Reg0150EFDC { get; set; }
        public SituacaoDocumentoFiscal SituacaoDocumentoFiscal { get; set; }
        public string Ser { get; set; }
        public string Sub { get; set; }
        public string NumDoc { get; set; }
        public string ChaveEletronica { get; set; }
        public DateTime DtEmissaoDoc { get; set; }
        public DateTime DtConclusaoServico { get; set; }
        public decimal VlDocumento { get; set; }
        public IndicadorTipoPagamento IndicadorTipoPagamento { get; set; }
        public decimal VlDesconto { get; set; }
        public decimal VlBcPis { get; set; }
        public decimal VlPis { get; set; }
        public decimal VlBcCofins { get; set; }
        public decimal VlCofins { get; set; }
        public decimal VlPisRetido { get; set; }
        public decimal VlConfinsRetido { get; set; }
        public decimal VlIss { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFin { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual User User { get; set; }
		public virtual ICollection<RegA110EFDC> RegsA110EFDC { get; set; }
		public virtual ICollection<RegA111EFDC> RegsA111EFDC { get; set; }
		public virtual ICollection<RegA120EFDC> RegsA120EFDC { get; set; }
		public virtual ICollection<RegA170EFDC> RegsA170EFDC { get; set; }
    }
}