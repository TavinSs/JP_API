using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain;

namespace Modelo.Infra.Mapeamento
{
    public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome).HasColumnType("varchar(50)");
        }
    }
}
