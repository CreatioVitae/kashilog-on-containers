namespace DomainObject.Kashilog.Enterprise {
    public class Company {

        public int CompanyId { get; set; }

        public string CompanyName { get; set; } = default!;

        public string ZipCode { get; set; } = default!;

        public string Country { get; set; } = default!;

        public string City { get; set; } = default!;

        public string Address { get; set; } = default!;

        public string TelephoneNumber { get; set; } = default!;
    }
}
