using System.Linq.Expressions;
using MichelStore.Domain.Abstractions.Interfaces;

namespace MichelStore.Domain.Abstractions;

public abstract class Specification<T> : ISpecification<T>
{
    // abstrato pois aqui ele não pode ser genérico precisa ser implementado especialmente
    public abstract Expression<Func<T, bool>> ToExpression();

    public bool IsSatisfiedBy(T entity)
    {
        var predicate = ToExpression().Compile();
        return predicate(entity);
    }
}