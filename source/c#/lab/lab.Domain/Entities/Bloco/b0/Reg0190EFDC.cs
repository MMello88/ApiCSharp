using lab.Domain.Entities.Cadastro.Auxiliar;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0190EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public string Unidade { get; set; }
        public string Descrição { get; set; }
        public int Reg0140EFDCId { get; set; }
        public virtual Reg0140EFDC Reg0140EFDC { get; set; }
    }
}