using lab.Domain.Entities.Registro;
using lab.Domain.Entities.Enums.Indicadores;
using System;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0208EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public CodTabIncidencia CodTabIncidencia { get; set; }
        public string CodGrupo { get; set; }
        public string MarcaComercial { get; set; }
    }
}