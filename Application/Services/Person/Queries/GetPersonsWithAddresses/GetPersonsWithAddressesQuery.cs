using MediatR;
using Application.DTOs;

namespace Application.Services.Person.Queries.GetPersonsWithAddresses
{

    public class GetPersonsWithAddressesQuery : IRequest<List<PersonDto>>
    {

    }
    
}
