using System;

using MyInventory2026.src.modules.products.Application.Interfaces;

namespace MyInventory2026.src.modules.products.Application.UseCases;

public class DeleteProductUseCase
{
    private readonly IProductService _service;

    public DeleteProductUseCase(IProductService service)
    {
        _service = service;
    }

    public async Task Execute(int id)
    {
        await _service.Delete(id);
    }
}
