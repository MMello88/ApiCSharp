using lab.Domain.Entities.Cadastro.Auxiliar;
using lab.Domain.Entities.Cadastro.Referencias;
using lab.Domain.Entities.Enums.Indicadores;
using System;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0000
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
        public string NOME { get; set; }
        public int CNPJ { get; set; }
        public int MunicipioId { get; set; }
        public virtual Municipio Municipio { get; set; }
        public string SUFRAMA { get; set; }
        public IndicadorNaturezaPessoaJuridicaEnum IND_NAT_PJ { get; set; }
        public IndicadorTipoAtividadePreponderanteEnum IND_ATIV { get; set; }
    }
}