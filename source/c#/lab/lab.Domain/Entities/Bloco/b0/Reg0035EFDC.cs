
using lab.Domain.Entities.Registro;
using System;

namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0035EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public int CodSCP { get; set; }
        public string DescSCP { get; set; }
        public string InfoCompl { get; set; }
        public DateTime DtIni { get; set; }
        public DateTime DtFin { get; set; }
        public int PessoaJuridicaId { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}