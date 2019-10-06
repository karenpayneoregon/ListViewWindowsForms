namespace SqlServerOperations.Classes
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
