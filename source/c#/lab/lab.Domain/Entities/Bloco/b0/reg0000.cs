using lab.Domain.Entities.Cadastro.Auxiliar;
using lab.Domain.Entities.Cadastro.Referencias;
using lab.Domain.Entities.Enums;
using System;

namespace lab.Domain.Entities.Bloco.b0
{
    public class reg0000
    {
        public int Id { get; set; }
        public string REG { get; set; }
        public int ref311Id { get; set; }
        public ref311 COD_VER { get; set; }
        public TipoEscrituracaoEnum TIPO_ESCRIT { get; set; }
        public IndicadorSituacaoEspecialEnum IND_SIT_ESP { get; set; }
        public string NUM_REC_ANTERIOR { get; set; }
        public DateTime DT_INI { get; set; }
        public DateTime DT_FIN { get; set; }
        public string NOME { get; set; }
        public string CNPJ { get; set; }
        public int MunicipioId { get; set; }
        public Municipio Municipio { get; set; }
        public string SUFRAMA { get; set; }
        public string IND_NAT_PJ { get; set; }
        public string IND_ATIV { get; set; }

    }
}