using Domain.Attributes;

namespace Domain.PersonDetails
{
    [Auditable]

    public class Address
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
      
        public Guid PersonId { get; set; } 
        public Person Person { get; set; } 

    }

}
