using System;

using MyInventory2026.src.modules.products.Application.Interfaces;
using MyInventory2026.src.modules.products.Domain.aggregate;

namespace MyInventory2026.src.modules.products.Application.UseCases;

public class GetProductByIdUseCase
{
    private readonly IProductService _service;

    public GetProductByIdUseCase(IProductService service)
    {
        _service = service;
    }

    public async Task<Product?> Execute(int id)
    {
        return await _service.GetById(id);
    }
}
