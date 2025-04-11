using MediatR;
using MichelStore.Domain.Abstractions;
using MichelStore.Domain.Repositories;
using MichelStore.Domain.Specifications.Products;

namespace MichelStore.Application.UseCases.Products.GetById;

// Manipulador
public sealed class Handler(IProductRepository repository)
    : IRequestHandler<Command, Result<Response>>
{
    public async Task<Result<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
        var spec = new GetProductByIdSpecification(request.Id);
        var product = await repository.GetByIdAsync(spec, cancellationToken);

        return product is null
            ? Result.Failure<Response>(new Error("404", "Product not found"))
            : Result.Success(new Response(product.Id, product.Title));
    }
}