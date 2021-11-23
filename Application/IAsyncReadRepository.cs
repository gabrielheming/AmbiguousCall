using System.Threading;
using System.Threading.Tasks;
using Ardalis.Specification;

namespace Application
{
    public interface IAsyncReadRepository<T> : IReadRepositoryBase<T> where T : class
    {
        Task<bool> AnyAsync(ISpecification<T> specification, CancellationToken cancellationToken = default);
        Task<bool> AnyAsync(CancellationToken cancellationToken = default);
    }
}