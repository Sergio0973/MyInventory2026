using System;

using MyInventory2026.src.modules.products.Domain.aggregate;

namespace MyInventory2026.src.modules.products.Application.Interfaces;

public interface IProductService
{
    Task<int> Create(string codeInv, string nameProduct, int stock, int stockMin, int stockMax);
    Task<List<Product>> GetAll();
    Task<Product?> GetById(int id);
    Task Update(int id, string codeInv, string nameProduct, int stock, int stockMin, int stockMax);
    Task Delete(int id);
}
