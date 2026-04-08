using System;

using MyInventory2026.src.modules.products.Infrastructure.entity;
using MyInventory2026.src.shared.context;

namespace MyInventory2026.src.modules.products.Application.UseCases;

public class RemoveProviderFromProductUseCase
{
    private readonly AppDbContext _context;

    public RemoveProviderFromProductUseCase(AppDbContext context)
    {
        _context = context;
    }

    public async Task Execute(string providerId, int productId)
    {
        var relation = await _context.ProviderProducts
            .FindAsync(providerId, productId);

        if (relation == null) return;

        _context.ProviderProducts.Remove(relation);
        await _context.SaveChangesAsync();
    }
}
