using lab.Domain.Entities.Registro;
using System.Collections.Generic;

namespace lab.Domain.Entities.Cadastro.Auxiliar
{
    public class Municipio
    {
        public int Id { get; private set; }
        public string CdMunicipio { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }

        /* Refrências */
        public virtual ICollection<PessoaJuridica> PessoasJuridica { get; set; }
    }
}
