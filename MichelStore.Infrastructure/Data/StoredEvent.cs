using System;

namespace MichelStore.Infrastructure.Data;

public class StoredEvent
{
    public Guid Id { get; set; }
    public string Type { get; set; } = string.Empty;
    public string Data { get; set; } = string.Empty;
    public DateTime OccurredOn { get; set; }
}
