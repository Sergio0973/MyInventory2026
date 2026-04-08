using System;

using MyInventory2026.src.modules.products.Application.Interfaces;

namespace MyInventory2026.src.modules.products.Application.UseCases;

public class CreateProductUseCase
{
    private readonly IProductService _service;

    public CreateProductUseCase(IProductService service)
    {
        _service = service;
    }

    public async Task<int> Execute(string codeInv, string nameProduct, int stock, int stockMin, int stockMax)
    {
        return await _service.Create(codeInv, nameProduct, stock, stockMin, stockMax);
    }
}
