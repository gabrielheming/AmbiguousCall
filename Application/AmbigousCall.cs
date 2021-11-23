using System.Threading;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public class AmbigousCall
    {
        private readonly IAsyncRepository<MyEntity> myEntityRepository;

        public AmbigousCall(IAsyncRepository<MyEntity> myEntityRepository)
        {
            this.myEntityRepository = myEntityRepository;
        }

        public async Task Handle(CancellationToken cancellationToken = default)
        {
            await myEntityRepository.ListAsync(cancellationToken);
        }
    }
}