using MediatR;
using Application.DTOs;

namespace Application.Services.Person.Queries.GetPersonList
{
 
        public class GetPersonListQuery : IRequest<List<PersonDto>>
        {
        }
}

