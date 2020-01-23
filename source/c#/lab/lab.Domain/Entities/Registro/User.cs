using lab.Domain.Entities.Bloco.b0;
using lab.Domain.Entities.Enums;
using System;
using System.Collections.Generic;

namespace lab.Domain.Entities.Registro
{
    public class User
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string UrlFoto { get; set; }
        public AtivoEnum Ativo { get; set; }
        public DateTime Criacao { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public virtual ICollection<UsersGrupo> UsersGrupo { get; set; }
        public virtual Reg0000EFDC Reg0000EFDC { get; set; }

    }
}
