namespace MichelStore.Domain.Abstractions.Interfaces;

public interface IUnitOfWork
{
    Task CommitAsync();
}