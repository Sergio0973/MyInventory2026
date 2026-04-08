using System;

using Microsoft.EntityFrameworkCore;
using MyInventory2026.src.modules.products.Domain.aggregate;
using MyInventory2026.src.modules.products.Domain.Repositories;
using MyInventory2026.src.modules.products.Infrastructure.entity;
using MyInventory2026.src.shared.context;

namespace MyInventory2026.src.modules.products.Infrastructure.repository;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<int> Create(Product product)
    {
        var entity = new ProductEntity
        {
            CodeInv = product.CodeInv,
            NameProduct = product.NameProduct,
            Stock = product.Stock,
            StockMin = product.StockMin,
            StockMax = product.StockMax
        };

        _context.Products.Add(entity);
        await _context.SaveChangesAsync();

        return entity.Id;
    }

    public async Task<List<Product>> GetAll()
    {
        return await _context.Products
            .Select(p => new Product(p.CodeInv, p.NameProduct, p.Stock, p.StockMin, p.StockMax))
            .ToListAsync();
    }

    public async Task<Product?> GetById(int id)
    {
        var entity = await _context.Products.FindAsync(id);

        if (entity == null) return null;

        return new Product(entity.CodeInv, entity.NameProduct, entity.Stock, entity.StockMin, entity.StockMax);
    }

    public async Task Update(Product product)
    {
        var entity = await _context.Products.FindAsync(product.Id);

        if (entity == null) return;

        entity.CodeInv = product.CodeInv;
        entity.NameProduct = product.NameProduct;
        entity.Stock = product.Stock;
        entity.StockMin = product.StockMin;
        entity.StockMax = product.StockMax;

        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var entity = await _context.Products.FindAsync(id);

        if (entity == null) return;

        _context.Products.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
