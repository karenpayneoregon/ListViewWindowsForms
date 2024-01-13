namespace BasicListViewGroupsExampleCore.Models;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int SupplierId { get; set; }
    public string Supplier { get; set; }
    public string Phone { get; set; }
    public int CategoryId { get; set; }
    public decimal? UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
    /// <summary>
    /// Container for ListView item to store primary keys
    /// </summary>
    public ProductTag IdentifiersTag => new ProductTag()
    {
        CategoryId = CategoryId,
        SupplierId = SupplierId,
        ProductId = ProductId
    };

    public override string ToString()
    {
        return $"{ProductName}";
    }
}