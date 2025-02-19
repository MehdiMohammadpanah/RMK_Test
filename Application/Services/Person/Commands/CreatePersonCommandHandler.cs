using Application.DTOs;
using Application.Interfaces.Contexts;
using Domain.PersonDetails;
using FluentValidation;
using MediatR;

namespace Application.Services.Person.Commands;

public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, Guid>
{
    private readonly IDataBaseContext _context;

    public CreatePersonCommandHandler(IDataBaseContext context)
    {
        _context = context;
    }

    public async Task<Guid> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
    {
        var person = new Domain.PersonDetails.Person() { FullName = request.FullName };

        if (request.Addresses != null && request.Addresses.Any())
        {
            person.Addresses = request.Addresses.Select(a => new Address()
            {
                Street = a.Street,
                City = a.City
                
            }).ToList();
        }

        _context.Persons.Add(person); 
        await _context.SaveChangesAsync(cancellationToken);
        return person.Id;
    }

    public class CreatePersonCommandValidator : AbstractValidator<CreatePersonCommand>
    {
        public CreatePersonCommandValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("لطفا نام و نام خ را وارد کنید")
                .MaximumLength(100).WithMessage("حد اکثر کاراکتر 100");

            RuleForEach(x => x.Addresses).SetValidator(new AddressDtoValidator()); 
        }
    }
    public class AddressDtoValidator : AbstractValidator<AddressDto> 
    {
        public AddressDtoValidator()
        {
            RuleFor(x => x.Street)
                .NotEmpty().WithMessage("خیابان الزامی")
                .MaximumLength(200).WithMessage("حد اکثر کاراکتر مجاز 200");

            RuleFor(x => x.City)
                .NotEmpty().WithMessage("شهر الزاامی")
                .MaximumLength(100).WithMessage("جد اکثر کاراکتر 100");
        }
    }
}