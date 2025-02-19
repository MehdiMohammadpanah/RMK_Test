using Application.DTOs;
using Application.Services.Person.Commands;
using Application.Services.Person.Queries.GetPersonsWithAddresses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreatePersonCommand command)
        {
            var personId = await _mediator.Send(command);
            return Ok(personId);
        }
       
        [HttpGet("address")]
        public async Task<IActionResult> GetWithAddress()
        {
            var people = await _mediator.Send(new GetPersonsWithAddressesQuery());
            return Ok(people);
        }
        [HttpGet]
        public async Task<ActionResult<List<PersonDto>>> GetAll()
        {
            var query = new GetPersonsWithAddressesQuery();
            var result = await _mediator.Send(query); 
            return Ok(result);
        }
    }
}
