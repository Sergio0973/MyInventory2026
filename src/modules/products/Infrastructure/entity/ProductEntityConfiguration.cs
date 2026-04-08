using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyInventory2026.src.modules.products.Infrastructure.entity;

public class ProductEntityConfiguration : IEntityTypeConfiguration<ProductEntity>
{
    public void Configure(EntityTypeBuilder<ProductEntity> builder)
    {
        builder.ToTable("products");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.CodeInv)
            .HasMaxLength(10)
            .IsRequired();

        builder.Property(p => p.NameProduct)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.Stock).IsRequired();
        builder.Property(p => p.StockMin).IsRequired();
        builder.Property(p => p.StockMax).IsRequired();
    }
}