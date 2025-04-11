namespace MichelStore.Domain.Abstractions;

// Esta classe terá dois casos: certo e errado
// Serve para evitar jogaar nulos para a tela
public record Error(string Code, string Message)
{
    public static Error None = new(string.Empty, string.Empty);
    public static Error NullValue = new("Error.NullValue", "Um valor nulo foi fornecido.");
}