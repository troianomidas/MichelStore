using MediatR;
using MichelStore.Domain.Abstractions;
using MichelStore.Domain.Abstractions.Interfaces;
using MichelStore.Domain.Entities;
using MichelStore.Domain.Repositories;

namespace MichelStore.Application.UseCases.Products.Create;

public class Handler(IProductRepository repository, IUnitOfWork unitOfWork, IEventStore eventStore) : IRequestHandler<Command, Result<Response>>
{
    public async Task<Result<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
        var product = Product.Create(request.Title);

        await repository.CreateAsync(product, cancellationToken);
        await unitOfWork.CommitAsync();

        foreach (var domainEvent in product.DomainEvents)
            await eventStore.AppendAsync(domainEvent, cancellationToken);

        product.ClearDomainEvents();

        return Result.Success(new Response("Produto criado com sucesso"));
    }
}
