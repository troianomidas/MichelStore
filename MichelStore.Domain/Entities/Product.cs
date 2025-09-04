using MichelStore.Domain.Abstractions;
using MichelStore.Domain.Events.ProductEvents;

namespace MichelStore.Domain.Entities;

public class Product : AggregateRoot
{
    public string Title { get; private set; } = string.Empty;
    public bool IsActive { get; private set; }

    private Product() { }

    public static Product Create(string title)
    {
        var product = new Product
        {
            Title = title
        };

        product.AddDomainEvent(new ProductCreated(product.Id, title));

        return product;
    }
}
