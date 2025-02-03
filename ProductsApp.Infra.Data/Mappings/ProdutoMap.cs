using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsApp.Domain.Models;

namespace ProductsApp.Infrastructure.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            // Nome da tabela
            builder.ToTable("PRODUTO");

            // Chave primária
            builder.HasKey(p => p.Id);

            // Propriedades
            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedNever(); // Evita que o EF gere o ID automaticamente

            builder.Property(p => p.Nome)
                .HasColumnName("NOME")
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(p => p.Preco)
                .HasColumnName("PRECO")
                .IsRequired()
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.Property(p => p.Quantidade)
                .HasColumnName("QUANTIDADE")
                .IsRequired();

            builder.Property(p => p.DataHoraCadastro)
                .HasColumnName("DATAHORACADASTRO")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.Ativo)
                .HasColumnName("ATIVO")
                .IsRequired();

            builder.Property(p => p.CategoriaId)
                .HasColumnName("CATEGORIA_ID")
                .IsRequired();

            // Relacionamentos
            builder.HasOne(p => p.Categoria)
                .WithMany(c => c.Produtos) // Presume que a classe Categoria tem a coleção Produtos
                .HasForeignKey(p => p.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict); // Evita exclusão em cascata
        }
    }
}
