using lab.Domain.Entities.Enums;

namespace lab.Domain.Entities.Registro
{
    public class UsersGrupo
    {
        public int GrupoUserId { get; set; }
        public virtual GrupoUser GrupoUser { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public AtivoEnum Ativo { get; set; }
    }
}
