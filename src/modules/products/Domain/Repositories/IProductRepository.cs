using System;
using MyInventory2026.src.modules.products.Domain.aggregate;
namespace MyInventory2026.src.modules.products.Domain.Repositories;


public interface IProductRepository
{
    Task<int> Create(Product product);
    Task<List<Product>> GetAll();
    Task<Product?> GetById(int id);
    Task Update(Product product);
    Task Delete(int id);
}
