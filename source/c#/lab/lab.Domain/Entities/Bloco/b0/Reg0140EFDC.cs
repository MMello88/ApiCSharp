using lab.Domain.Entities.Cadastro.Auxiliar;
using System;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0140EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public string CodEstab { get; set; }
        public string Nome { get; set; }
        public int CNPJ { get; set; }
        public string UF { get; set; }
        public string IE { get; set; }
        public int MunicipioId { get; set; }
        public virtual Municipio Municipio { get; set; }
        public string IM { get; set; }
        public string Suframa { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFin { get; set; }
        public virtual Reg0145EFDC Reg0145EFDC { get; set; }
    }
}