using System;

namespace MyInventory2026.src.modules.products.Domain.valueObject;

public sealed record ProductCode
{
    public string Value { get; }

    private ProductCode(string value)
    {
        Value = value;
    }

    public static ProductCode Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Product code cannot be empty.", nameof(value));
        }

        return new ProductCode(value.Trim());
    }

    public override string ToString() => Value;
}
