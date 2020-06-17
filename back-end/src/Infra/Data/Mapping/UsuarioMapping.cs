using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("TB_Usuarios", "dbo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)")
                .HasColumnName("Nome");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnType("varchar(50)")
                .HasColumnName("Email");

            builder.Property(x => x.Telefone)
                .IsRequired()
                .HasColumnType("varchar(14)")
                .HasColumnName("Telefone");

            builder.Property(x => x.Endereco)
                .IsRequired()
                .HasColumnType("varchar(100)")
                .HasColumnName("Endereco");

            builder.Property(x => x.Cidade)
                .IsRequired()
                .HasColumnType("varchar(20)")
                .HasColumnName("Cidade");

            builder.Property(x => x.Sexo)
                .IsRequired()
                .HasColumnType("varchar(20)")
                .HasColumnName("Sexo");

            builder.HasOne(x => x.Perfil)
                .WithMany(x => x.Usuarios);
        }
    }
}
