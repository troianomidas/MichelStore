using MediatR;
using MichelStore.Domain.Abstractions;

namespace MichelStore.Application.UseCases.Products.Create;

public sealed record Command(string Title): IRequest<Result<Response>>;