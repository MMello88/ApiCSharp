using lab.Domain.Entities.Cadastro.Auxiliar;
using lab.Domain.Entities.Enums;
using lab.Domain.Entities.Registro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab.Infra.Data.Config
{
    class PessoaJuridicaConfiguration : IEntityTypeConfiguration<PessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<PessoaJuridica> builder)
        {
            builder.HasKey(pj => pj.Id);
            builder.Property(pj => pj.Nome).HasMaxLength(450).IsRequired();
            builder.Property(pj => pj.NomeFantasia).HasMaxLength(450).IsRequired();
            builder.Property(pj => pj.Matriz).HasDefaultValue(MatrizEnum.Não);
            builder.Property(pj => pj.Endereco).HasMaxLength(250).IsRequired();
            builder.Property(pj => pj.Numero).HasMaxLength(10).IsRequired();
            builder.Property(pj => pj.Complemento).HasMaxLength(100);
            builder.Property(pj => pj.Bairro).HasMaxLength(150).IsRequired();
            builder.Property(pj => pj.CEP).HasMaxLength(10).IsRequired();
            builder.Property(pj => pj.Telefone).HasMaxLength(15);
            builder.Property(pj => pj.Celular).HasMaxLength(15).IsRequired();
            builder.Property(pj => pj.Email).HasMaxLength(250).IsRequired();
            builder.Property(pj => pj.InscricaoEstadual).HasMaxLength(20);
            builder.Property(pj => pj.Cnpj).HasMaxLength(20).IsRequired();
            builder.Property(pj => pj.CNAE).HasMaxLength(9);
            builder.Property(pj => pj.InscricaoMunicipal).HasMaxLength(20);
            builder.Property(pj => pj.NrSuframa).HasMaxLength(9);
            builder.Property(pj => pj.NaturezaJuridica);
            builder.Property(pj => pj.NomeContato).HasMaxLength(150);
            builder.Property(pj => pj.WebSite).HasMaxLength(200);
            builder.Property(pj => pj.DmContribuicao).HasDefaultValue(ContribuicaoEnum.Nao).IsRequired();
            
        }
    }
}
