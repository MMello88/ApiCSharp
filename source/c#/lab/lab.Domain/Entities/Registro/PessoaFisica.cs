using lab.Domain.Entities.Enums;
using System;
using System.Collections.Generic;

namespace lab.Domain.Entities.Registro
{
    public class PessoaFisica
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string UrlFoto { get; set; }
        public AtivoEnum Ativo { get; set; }
        public DateTime Criacao { get; set; }
        public virtual ICollection<PessoaJuridica> PessoasJuridica { get; set; }
    }
}
