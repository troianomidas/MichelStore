namespace MichelStore.Application.UseCases.Products.GetById;

// Resposta
//
// MediatoR (pattern): dado um 'command' ele sabe quem é o 'handler' desse 'command'
public sealed record Response(Guid Id, string Title);