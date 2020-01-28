using System;
using System.Collections.Generic;

namespace lab.Domain.Entities.Cadastro.Referencias
{
    public class Ref511
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }
        public string IndNcmAtividade { get; set; }
        public float? AliqAtividade { get; set; }
    }
}