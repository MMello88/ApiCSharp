using lab.Domain.Entities.Cadastro.Referencias;
using lab.Domain.Entities.Enums.Indicadores;
using lab.Domain.Entities.Registro;
using System;
using System.Collections.Generic;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0000EFDC
    {
        public int Id { get; set; }
        public string REG { get; set; }
        public int Ref311Id { get; set; }
        public virtual Ref311 Ref311 { get; set; }
        public TipoEscrituracaoEnum TIPO_ESCRIT { get; set; }
        public IndicadorSituacaoEspecialEnum IND_SIT_ESP { get; set; }
        public string NUM_REC_ANTERIOR { get; set; }
        public DateTime DT_INI { get; set; }
        public DateTime DT_FIN { get; set; }
        public IndicadorNaturezaPessoaJuridicaEnum IND_NAT_PJ { get; set; }
        public IndicadorTipoAtividadePreponderanteEnum IND_ATIV { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual User User { get; set; }
        public virtual Reg0001EFDC Reg0001EFDC { get; set; }
        public virtual Reg0110EFDC Regs0110EFDC { get; set; }
    }
}