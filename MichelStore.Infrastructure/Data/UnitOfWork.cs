using MichelStore.Domain.Abstractions.Interfaces;

namespace MichelStore.Infrastructure.Data;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public async Task CommitAsync()
        =>
            await context.SaveChangesAsync();
}