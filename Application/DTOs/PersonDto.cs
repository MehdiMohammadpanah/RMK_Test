namespace Application.DTOs
{
    public class PersonDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public List<AddressDto> Addresses { get; set; } = new List<AddressDto>();
    }
}
