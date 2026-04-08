using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyInventory2026.src.modules.products.Infrastructure.entity;

public class ProviderProductConfiguration : IEntityTypeConfiguration<ProviderProductEntity>
{
    public void Configure(EntityTypeBuilder<ProviderProductEntity> builder)
    {
        builder.ToTable("provider_products");

        builder.HasKey(pp => new { pp.ProviderId, pp.ProductId });

        builder.Property(pp => pp.ProviderId)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(pp => pp.ProductId)
            .IsRequired();
    }
}
