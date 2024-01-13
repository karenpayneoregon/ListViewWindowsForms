using BasicListViewGroupsExampleCore.Models;

namespace BasicListViewGroupsExampleCore.LanguageExtensions;

/// <summary>
/// Contains project specific extension methods
/// </summary>
public static class ListViewExtensions
{
    /// <summary>
    /// Get primary and foreign keys for a product
    /// within a ListView
    /// </summary>
    /// <param name="sender"></param>
    /// <returns></returns>
    public static ProductTag ProductTag(this ListViewItem sender) => (ProductTag) sender.Tag;
}