using Persistence.Contexts;
using Application.Interfaces;
using Domain.PersonDetails;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class PersonRepository: IPersonRepository
    {
        private readonly DataBaseContext _context;

        public PersonRepository(DataBaseContext context)
        {
            _context = context;
        }
        public async Task<List<Person>> GetAllWithAddressesAsync(CancellationToken cancellationToken)
        {
            return await _context.Persons
                .Include(p => p.Addresses)
                .ToListAsync(cancellationToken);
        }   
    }
}
