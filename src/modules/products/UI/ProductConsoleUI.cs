using System;

using MyInventory2026.src.modules.products.Application.UseCases;

namespace MyInventory2026.src.modules.products.UI;

public class ProductConsoleUI
{
    private readonly CreateProductUseCase _create;
    private readonly GetAllProductsUseCase _getAll;

    public ProductConsoleUI(
        CreateProductUseCase create,
        GetAllProductsUseCase getAll)
    {
        _create = create;
        _getAll = getAll;
    }

public async Task Create()
{
    Console.WriteLine("Code:");
    var code = Console.ReadLine() ?? "";

    Console.WriteLine("Name:");
    var name = Console.ReadLine() ?? "";

    Console.WriteLine("Stock:");
    var stock = int.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Stock Min:");
    var stockMin = int.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Stock Max:");
    var stockMax = int.Parse(Console.ReadLine() ?? "0");

    var id = await _create.Execute(code, name, stock, stockMin, stockMax);

    Console.WriteLine($"Product created with ID: {id}");
}

    public async Task ShowAll()
    {
        var products = await _getAll.Execute();

        foreach (var p in products)
        {
            Console.WriteLine($"{p.Id} - {p.NameProduct} - Stock: {p.Stock}");
        }
    }
}
