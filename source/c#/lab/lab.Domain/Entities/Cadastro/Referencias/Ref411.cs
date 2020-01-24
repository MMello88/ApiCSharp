using System;
using System.Collections.Generic;

namespace lab.Domain.Entities.Cadastro.Referencias
{
    public class Ref411
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Modelo { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
    }
}