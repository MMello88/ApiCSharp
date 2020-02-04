using lab.Domain.Entities.Cadastro.Auxiliar;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0450EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public string CodInf { get; set; }
        public string Txt { get; set; }
        public int Reg0140EFDCId { get; set; }
        public virtual Reg0140EFDC Reg0140EFDC { get; set; }
    }
}