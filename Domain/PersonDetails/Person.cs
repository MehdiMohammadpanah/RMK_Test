using Domain.Attributes;

namespace Domain.PersonDetails
{
    [Auditable]

    public class Person
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
