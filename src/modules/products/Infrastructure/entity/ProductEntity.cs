using System;

namespace MyInventory2026.src.modules.products.Infrastructure.entity;

public class ProductEntity
{
    public int Id { get; set; }
    public string CodeInv { get; set; } = string.Empty;
    public string NameProduct { get; set; } = string.Empty;

    public int Stock { get; set; }
    public int StockMin { get; set; }
    public int StockMax { get; set; }
}
