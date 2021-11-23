using Ardalis.Specification;

namespace Application
{
    public interface IAsyncRepository<T> : IAsyncReadRepository<T>, IRepositoryBase<T> where T : class
    {
    }
}