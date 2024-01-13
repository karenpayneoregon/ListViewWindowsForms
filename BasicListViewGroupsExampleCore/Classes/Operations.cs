using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicListViewGroupsExampleCore.Models;
using Dapper;

namespace BasicListViewGroupsExampleCore.Classes;
internal class Operations
{
    private IDbConnection _cn;

    public Operations()
    {
        _cn = new SqlConnection(ConnectionString());
    }

    public List<Category> Categories() 
        => _cn.Query<Category>("SELECT CategoryID,CategoryName as Name FROM dbo.Categories").ToList();

    public Supplier GetSupplier(int id)
        => _cn.Query<Supplier>(
            """
            SELECT SupplierID,CompanyName,ContactName,ContactTitle,Phone,[Address] AS Street,City,PostalCode,Country 
            FROM dbo.Suppliers 
            WHERE SupplierID = @SupplierId
            """, new { SupplierId = id})
            .FirstOrDefault();

    public List<Supplier> Suppliers()
        => _cn.Query<Supplier>(
                """
                SELECT SupplierID,CompanyName,ContactName,ContactTitle,Phone,[Address] AS Street,City,PostalCode,Country
                FROM dbo.Suppliers
                """)
            .ToList();
    public List<Product> Products(int id)
    {
        var selectStatement = 
            """
            SELECT   P.ProductID ,
                     P.ProductName ,
                     P.SupplierID ,
                     S.CompanyName AS Supplier ,
                     S.Phone ,
                     P.CategoryID ,
                     P.UnitPrice ,
                     P.UnitsInStock
            FROM     dbo.Products AS P
                     INNER JOIN dbo.Suppliers AS S ON P.SupplierID = S.SupplierID
            WHERE    P.CategoryID = @CategoryIdentifier
            ORDER BY P.ProductName;
            """;

        return _cn.Query<Product>(selectStatement, new { CategoryIdentifier = id }).ToList();
    }
}
