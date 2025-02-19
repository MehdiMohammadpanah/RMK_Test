using Application.DTOs;
using MediatR;
using Application.Interfaces;
using AutoMapper;

namespace Application.Services.Person.Queries.GetPersonsWithAddresses
{
    public class GetPersonsWithAddressesQueryHandler : IRequestHandler<GetPersonsWithAddressesQuery, List<PersonDto>>
    {
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;

        public GetPersonsWithAddressesQueryHandler(IMapper mapper,IPersonRepository personRepository)
        {
            _mapper = mapper;
            _personRepository = personRepository;
        }

        public async Task<List<PersonDto>> Handle(GetPersonsWithAddressesQuery request,
            CancellationToken cancellationToken)
        {
            var persons = await _personRepository.GetAllWithAddressesAsync(cancellationToken);
            var personDtos = _mapper.Map<List<PersonDto>>(persons);
            return personDtos;
        }
    }
}
