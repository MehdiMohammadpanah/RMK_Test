namespace Application.Services.PersonService;

public interface IPersonService
{
    Task<List<Domain.PersonDetails.Person>> GetPerson();
}