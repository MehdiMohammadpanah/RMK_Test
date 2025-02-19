using Domain.PersonDetails;

namespace Application.Interfaces
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetAllWithAddressesAsync(CancellationToken cancellationToken);

    }
}
