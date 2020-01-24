using System;
using System.Collections.Generic;

namespace lab.Domain.Entities.Cadastro.Referencias
{
    public class Ref711
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public string IndTipoAtividade { get; set; }
        public string IndAjuste { get; set; }
        public string Grupo { get; set; }
        public string IndOutros { get; set; }
    }
}