using lab.Domain.Entities.Cadastro.Auxiliar;

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
        public int Reg0000EFDCId { get; set; }
        public virtual Reg0000EFDC Reg0000EFDC { get; set; }
        public virtual Reg0145EFDC Reg0145EFDC { get; set; }
    }
}