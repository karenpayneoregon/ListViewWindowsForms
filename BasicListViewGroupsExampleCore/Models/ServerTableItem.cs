namespace BasicListViewGroupsExampleCore.Models;

public class ServerTableItem
{
    public string Table { get; set; }
    public string Field { get; set; }
    public short? FieldOrder { get; set; }
    public string DataType { get; set; }
    public short? Length { get; set; }
    public string Precision { get; set; }
    public int Scale { get; set; }
    public string AllowNulls { get; set; }
    public string Identity { get; set; } = String.Empty;
    public string PrimaryKey { get; set; }
    public string ForeignKey { get; set; } = String.Empty;
    public string RelatedTable { get; set; }
    public string Description { get; set; }
    public override string ToString()
    {
        return Field;
    }
}