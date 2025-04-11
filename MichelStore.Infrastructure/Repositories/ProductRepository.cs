using MichelStore.Domain.Abstractions;
using MichelStore.Domain.Entities;
using MichelStore.Domain.Repositories;
using MichelStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MichelStore.Infrastructure.Repositories;

public class ProductRepository(AppDbContext context) : IProductRepository
{
    public async Task<Product?> GetByIdAsync(Specification<Product> specification,
        CancellationToken cancellationToken = default)
        => await context.Products.Where(specification.ToExpression()).FirstOrDefaultAsync(cancellationToken);

    public async Task CreateAsync(Product product, CancellationToken cancellationToken)
        =>
            await context.Products.AddAsync(product, cancellationToken);
}