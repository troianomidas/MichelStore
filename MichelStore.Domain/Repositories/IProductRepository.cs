using MichelStore.Domain.Abstractions;
using MichelStore.Domain.Entities;

namespace MichelStore.Domain.Repositories;

public interface IProductRepository : IRepository<Product>
{
    Task<Product?> GetByIdAsync(Specification<Product> specification, CancellationToken cancellationToken = default);
    Task CreateAsync(Product product, CancellationToken cancellationToken);
}