using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class PerfilMapping : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.ToTable("TB_Perfil", "dbo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NomePerfil)
                .IsRequired()
                .HasColumnType("varchar(100)")
                .HasColumnName("NomePerfil");

            builder.HasMany(x => x.Usuarios)
                .WithOne(x => x.Perfil)
                .HasForeignKey(x => x.PerfilId);
        }

    }
}
