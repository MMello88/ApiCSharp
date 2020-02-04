using lab.Domain.Entities.Cadastro.Auxiliar;
using lab.Domain.Entities.Enums.Indicadores;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0200EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public string CodItem { get; set; }
        public string DescricaoItem { get; set; }
        public string CodBarra { get; set; }
        public string CodAntItem { get; set; }
        public string UnidInv { get; set; }
        public virtual TipoItem TipoItem { get; set; }
        public string CodNcm { get; set; }
        public string ExIpi { get; set; }
        public int CodGen { get; set; }
        public int CodLst { get; set; }
        public int AliqIcms { get; set; }
        public int Reg0140EFDCId { get; set; }
        public virtual Reg0140EFDC Reg0140EFDC { get; set; }
    }
}