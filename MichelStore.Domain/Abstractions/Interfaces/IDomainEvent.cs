namespace MichelStore.Domain.Abstractions.Interfaces;

public interface IDomainEvent
{
    Guid Id { get; }
    DateTime OccurredOn { get; }
}
