namespace SqlServerOperations.Classes
{
    public class Countries
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public override string ToString() => CountryName;

    }

}
