namespace SqlServerOperations.Classes
{
    /// <summary>
    /// Container to store primary keys in a ListViewItem used
    /// in the project BasicListViewGroupsExample
    /// </summary>
    public class ProductTag
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
    }
}