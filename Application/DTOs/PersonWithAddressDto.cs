namespace Application.DTOs
{
    public class PersonWithAddressDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public List<AddressDto> Addresses { get; set; }
    }
}
