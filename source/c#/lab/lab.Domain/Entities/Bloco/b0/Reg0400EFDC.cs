using lab.Domain.Entities.Cadastro.Auxiliar;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0400EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public string CodNat { get; set; }
        public string DescricaoNat { get; set; }
        public int Reg0140EFDCId { get; set; }
        public virtual Reg0140EFDC Reg0140EFDC { get; set; }
    }
}