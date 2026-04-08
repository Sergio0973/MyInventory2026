using System;

using MyInventory2026.src.modules.products.Infrastructure.entity;
using MyInventory2026.src.shared.context;

namespace MyInventory2026.src.modules.products.Application.UseCases;

public class AssignProviderToProductUseCase
{
    private readonly AppDbContext _context;

    public AssignProviderToProductUseCase(AppDbContext context)
    {
        _context = context;
    }

    public async Task Execute(string providerId, int productId)
    {
        var relation = new ProviderProductEntity
        {
            ProviderId = providerId,
            ProductId = productId
        };

        _context.ProviderProducts.Add(relation);
        await _context.SaveChangesAsync();
    }
}
