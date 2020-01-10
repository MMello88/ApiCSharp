using lab.Domain.Entities.Enums;
using System;

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

    }
}
