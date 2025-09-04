using System;
using MichelStore.Domain.Abstractions.Interfaces;

namespace MichelStore.Domain.Events.ProductEvents;

public record ProductCreated(Guid ProductId, string Title) : IDomainEvent
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public DateTime OccurredOn { get; init; } = DateTime.UtcNow;
}
