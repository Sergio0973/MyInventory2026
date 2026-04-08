using System;

namespace MyInventory2026.src.modules.products.Domain.valueObject;

public sealed record ProductId
{
    public int Value { get; }

    private ProductId(int value)
    {
        Value = value;
    }

    public static ProductId Create(int value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("Product id must be greater than 0.", nameof(value));
        }

        return new ProductId(value);
    }

    public override string ToString() => Value.ToString();
}
