using MediatR;
using MichelStore.Domain.Abstractions;

namespace MichelStore.Application.UseCases.Products.GetById;

// CQRS - Command Query Responsability Segregation
// CQS - Command Query Segregation
// Separa as interações com o banco
//
// Entrada
// Sealed para a classe não poder ser alterada depois
public sealed record Command(Guid Id) : IRequest<Result<Response>>;