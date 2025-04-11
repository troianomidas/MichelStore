using System.Linq.Expressions;
using MichelStore.Domain.Abstractions;
using MichelStore.Domain.Entities;

namespace MichelStore.Domain.Specifications.Products;

public class GetProductByIdSpecification(Guid id) : Specification<Product>
{
    public override Expression<Func<Product, bool>> ToExpression()
        => product => product.Id == id;
}