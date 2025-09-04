using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using MichelStore.Domain.Abstractions.Interfaces;
using MichelStore.Infrastructure.Data;

namespace MichelStore.Infrastructure.Repositories;

public class EventStore(AppDbContext context) : IEventStore
{
    public async Task AppendAsync(IDomainEvent domainEvent, CancellationToken cancellationToken = default)
    {
        var storedEvent = new StoredEvent
        {
            Id = domainEvent.Id,
            Type = domainEvent.GetType().Name,
            Data = JsonSerializer.Serialize(domainEvent),
            OccurredOn = domainEvent.OccurredOn
        };

        await context.StoredEvents.AddAsync(storedEvent, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
}
