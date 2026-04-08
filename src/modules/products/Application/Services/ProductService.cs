using System;
using MyInventory2026.src.modules.products.Application.Interfaces;
using MyInventory2026.src.modules.products.Domain.aggregate;
using MyInventory2026.src.modules.products.Domain.Repositories;
using MyInventory2026.src.modules.products.Domain.valueObject;

namespace MyInventory2026.src.modules.products.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Create(string codeInv, string nameProduct, int stock, int stockMin, int stockMax)
    {
        var code = ProductCode.Create(codeInv);
        var name = ProductName.Create(nameProduct);

        var product = new Product(code.Value, name.Value, stock, stockMin, stockMax);

        return await _repository.Create(product);
    }

    public async Task<List<Product>> GetAll()
    {
        return await _repository.GetAll();
    }

    public async Task<Product?> GetById(int id)
    {
        return await _repository.GetById(id);
    }

    public async Task Update(int id, string codeInv, string nameProduct, int stock, int stockMin, int stockMax)
    {
        var product = await _repository.GetById(id);

        if (product == null)
            throw new Exception("Product not found");

        var code = ProductCode.Create(codeInv);
        var name = ProductName.Create(nameProduct);

        product.Update(code.Value, name.Value, stock, stockMin, stockMax);

        await _repository.Update(product);
    }

    public async Task Delete(int id)
    {
        await _repository.Delete(id);
    }
}
