using MichelStore.Domain.Abstractions;
using MichelStore.Domain.Abstractions.Interfaces;

namespace MichelStore.Domain.Entities;

public class Product : Entity, IAggregateRoot
{
    public string Title { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}