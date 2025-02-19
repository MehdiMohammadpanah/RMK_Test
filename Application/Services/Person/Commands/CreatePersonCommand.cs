using Application.DTOs;
using MediatR;

namespace Application.Services.Person.Commands
{
    public class CreatePersonCommand : IRequest<Guid>
    {
        public string FullName { get; set; }
        public List<AddressDto> Addresses { get; set; }
    }
}
