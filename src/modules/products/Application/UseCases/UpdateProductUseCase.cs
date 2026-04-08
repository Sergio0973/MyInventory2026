using System;
using MyInventory2026.src.modules.products.Application.Interfaces;

namespace MyInventory2026.src.modules.products.Application.UseCases;

public class UpdateProductUseCase
{
    private readonly IProductService _service;

    public UpdateProductUseCase(IProductService service)
    {
        _service = service;
    }

    public async Task Execute(int id, string codeInv, string nameProduct, int stock, int stockMin, int stockMax)
    {
        await _service.Update(id, codeInv, nameProduct, stock, stockMin, stockMax);
    }
}
