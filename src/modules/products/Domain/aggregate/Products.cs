using System;

namespace MyInventory2026.src.modules.products.Domain.aggregate;

public class Product
{
    public int Id { get; private set; }
    public string CodeInv { get; private set; }
    public string NameProduct { get; private set; }

    public int Stock { get; private set; }
    public int StockMin { get; private set; }
    public int StockMax { get; private set; }

    public Product(string codeInv, string nameProduct, int stock, int stockMin, int stockMax)
    {
        CodeInv = codeInv;
        NameProduct = nameProduct;
        Stock = stock;
        StockMin = stockMin;
        StockMax = stockMax;
    }

    public void Update(string codeInv, string nameProduct, int stock, int stockMin, int stockMax)
    {
        CodeInv = codeInv;
        NameProduct = nameProduct;
        Stock = stock;
        StockMin = stockMin;
        StockMax = stockMax;
    }
}
