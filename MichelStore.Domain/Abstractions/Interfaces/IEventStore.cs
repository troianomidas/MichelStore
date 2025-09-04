using System.Threading;
using System.Threading.Tasks;

namespace MichelStore.Domain.Abstractions.Interfaces;

public interface IEventStore
{
    Task AppendAsync(IDomainEvent domainEvent, CancellationToken cancellationToken = default);
}
