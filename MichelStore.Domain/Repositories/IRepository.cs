using MichelStore.Domain.Abstractions;
using MichelStore.Domain.Abstractions.Interfaces;

namespace MichelStore.Domain.Repositories;


// abstrações podem ficar no Domain desde que suas implementações fiquem fora
public interface IRepository<T> where T : IAggregateRoot;