using Application.DTOs;
using Application.Interfaces.Contexts;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Person.Queries.GetPersonList;

public class GetPersonListQueryHandler : IRequestHandler<GetPersonListQuery, List<PersonDto>>
{
    private readonly IDataBaseContext _context;
    private readonly IMapper _mapper;

    public GetPersonListQueryHandler(IDataBaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<PersonDto>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
    {
        return await _context.Persons
            .ProjectTo<PersonDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }
}