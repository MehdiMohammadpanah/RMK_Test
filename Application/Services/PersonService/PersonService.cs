using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.PersonService
{
    public class PersonService: IPersonService
    {
        private readonly IDataBaseContext _context;

        public PersonService(IDataBaseContext  context)
        {
            _context = context;
        }

        public async Task<List<Domain.PersonDetails.Person>> GetPerson()
        {
            return await _context.Persons
                .Include(p => p.Addresses).ToListAsync();
        }
    }
}
