using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MuOnline.Domain.Entities;

namespace MuOnline.EF.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario", "site");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.AggregateId);
            builder.Property(x => x.DataCriacao);
            builder.Property(x => x.Nome);
            builder.Property(x => x.NomeUsuario);
            builder.Property(x => x.Senha);
            builder.Property(x => x.Email);
            builder.Property(x => x.Telefone);
            builder.Property(x => x.DataNascimento);
            builder.Property(x => x.EmailConfirmado);
            builder.Property(x => x.Ativo);
            builder.Property(x => x.PerfilId);

            builder
                .HasOne(x => x.Perfil)
                .WithMany()
                .HasPrincipalKey(x=>x.Id)
                .HasForeignKey(x => x.PerfilId);
        }
    }
}