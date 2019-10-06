namespace SqlServerOperations.Classes
{
    public class Contact
    {
        public int CustomerIdentifier { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneTypeDescription { get; set; }
        public string PhoneNumber { get; set; }
        public string CountryName { get; set; }
        public string[] ItemArray => new[]
        {
            CompanyName,
            FirstName,
            LastName,
            PhoneNumber,
            CountryName
        };

    }
}
