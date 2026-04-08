using System;

namespace MyInventory2026.src.modules.products.Domain.valueObject;

public sealed record ProductName
{
    public string Value { get; }

    private ProductName(string value)
    {
        Value = value;
    }

    public static ProductName Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Product name cannot be empty.", nameof(value));
        }

        return new ProductName(value.Trim());
    }

    public override string ToString() => Value;
}
