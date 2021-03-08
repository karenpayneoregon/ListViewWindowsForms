namespace SqlServerOperations.Classes
{
    public class ContactContactDevices
    {
        public int Identifier { get; set; }
        public int? ContactIdentifier { get; set; }
        public int? PhoneTypeIdenitfier { get; set; }
        public string PhoneNumber { get; set; }
        public bool? Active { get; set; }

    }
}
