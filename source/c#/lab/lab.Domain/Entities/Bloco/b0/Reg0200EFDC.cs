using lab.Domain.Entities.Registro;
using lab.Domain.Entities.Enums.Indicadores;
using System;

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
        public virtual Reg0190EFDC Reg0190EFDC { get; set; }
        public virtual TipoItem TipoItem { get; set; }
        public string CodNcm { get; set; }
        public string ExIpi { get; set; }
        public int CodGen { get; set; }
        public int CodLst { get; set; }
        public int AliqIcms { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFin { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual User User { get; set; }
        public virtual Reg0205EFDC Reg0205EFDC { get; set; }
        public virtual Reg0206EFDC Reg0206EFDC { get; set; }
        public virtual Reg0208EFDC Reg020EFDC { get; set; }
    }
}