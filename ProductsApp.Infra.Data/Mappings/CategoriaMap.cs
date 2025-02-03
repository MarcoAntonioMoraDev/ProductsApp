using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsApp.Domain.Models;

namespace ProductsApp.Infrastructure.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            // Nome da tabela
            builder.ToTable("CATEGORIA");

            // Chave primária
            builder.HasKey(c => c.Id);

            // Propriedades
            builder.Property(c => c.Id)
                .HasColumnName("ID");
                //.IsRequired()
                //.ValueGeneratedNever(); // Evita que o EF gere o ID automaticamente

            builder.Property(c => c.Nome)
                .HasColumnName("NOME")
                .IsRequired()
                .HasMaxLength(150);

        }
    }
}
