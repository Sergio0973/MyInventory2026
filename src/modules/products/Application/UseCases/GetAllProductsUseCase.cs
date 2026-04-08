using System;

using MyInventory2026.src.modules.products.Application.Interfaces;
using MyInventory2026.src.modules.products.Domain.aggregate;

namespace MyInventory2026.src.modules.products.Application.UseCases;

public class GetAllProductsUseCase
{
    private readonly IProductService _service;

    public GetAllProductsUseCase(IProductService service)
    {
        _service = service;
    }

    public async Task<List<Product>> Execute()
    {
        return await _service.GetAll();
    }
}