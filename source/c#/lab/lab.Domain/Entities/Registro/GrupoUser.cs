using System.Collections.Generic;

namespace lab.Domain.Entities.Registro
{
    public class GrupoUser
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public virtual ICollection<UsersGrupo> UsersGrupo { get; set; }
    }
}
