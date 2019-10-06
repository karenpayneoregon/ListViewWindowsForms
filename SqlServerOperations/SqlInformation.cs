using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using SqlServerOperations.Classes;

namespace SqlServerOperations
{
    public class SqlInformation : BaseConnectionLibrary.ConnectionClasses.SqlServerConnection
    {
        public SqlInformation()
        {
            DatabaseServer = "KARENS-PC";
            DefaultCatalog = "NorthWindAzure3";
        }

        public Dictionary<string, List<ServerTableItem>> TableDependencies()
        {
            mHasException = false;

            var informationTable = new DataTable();

            var selectStatement = @"
                SELECT	syso.name [Table],
		                sysc.name [Field], 
		                sysc.colorder [FieldOrder], 
		                syst.name [DataType], 
		                sysc.[length] [Length], 
		                CASE WHEN sysc.prec IS NULL THEN 'NULL' ELSE CAST(sysc.prec AS VARCHAR) END [Precision],
                CASE WHEN sysc.scale IS null THEN '-' ELSE sysc.scale END [Scale], 
                CASE WHEN sysc.isnullable = 1 THEN 'True' ELSE 'False' END [AllowNulls], 
                CASE WHEN sysc.[status] = 128 THEN 'True' ELSE 'False' END [Identity], 
                CASE WHEN sysc.colstat = 1 THEN 'True' ELSE 'False' END [PrimaryKey],
                CASE WHEN fkc.parent_object_id is NULL THEN 'False' ELSE 'True' END [ForeignKey], 
                CASE WHEN fkc.parent_object_id is null THEN '(none)' ELSE obj.name  END [RelatedTable],
                CASE WHEN ep.value is NULL THEN '(none)' ELSE CAST(ep.value as NVARCHAR(500)) END [Description]
                FROM [sys].[sysobjects] AS syso
                JOIN [sys].[syscolumns] AS sysc on syso.id = sysc.id
                LEFT JOIN [sys].[systypes] AS syst ON sysc.xtype = syst.xtype and syst.name != 'sysname'
                LEFT JOIN [sys].[foreign_key_columns] AS fkc on syso.id = fkc.parent_object_id and sysc.colid = fkc.parent_column_id    
                LEFT JOIN [sys].[objects] AS obj ON fkc.referenced_object_id = obj.[object_id]
                LEFT JOIN [sys].[extended_properties] AS ep ON syso.id = ep.major_id and sysc.colid = ep.minor_id and ep.name = 'MS_Description'
                WHERE syso.type = 'U' AND  syso.name != 'sysdiagrams'
                ORDER BY [Table], FieldOrder, Field;";

            using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand() {Connection = cn})
                {
                    cmd.CommandText = selectStatement;

                    try
                    {

                        cn.Open();

                        informationTable.Load(cmd.ExecuteReader());
                    }
                    catch (Exception e)
                    {
                        mHasException = true;
                        mLastException = e;
                    }

                }
            }

            var result = from row in informationTable.AsEnumerable()
                group row by row.Field<string>("Table") into grp
                select new
                {
                    TableName = grp.Key,
                    Rows = grp,
                    Count = grp.Count() 
                };

            var tableDictionary = new Dictionary<string, List<ServerTableItem>>();

            foreach (var topItem in result)
            {

                if (!tableDictionary.ContainsKey(topItem.TableName))
                {
                    tableDictionary[topItem.TableName] = new List<ServerTableItem>();
                }

                foreach (var row in topItem.Rows)
                {
                    tableDictionary[topItem.TableName].Add(new ServerTableItem()
                    {
                        Table = topItem.TableName,
                        Field = row.Field<string>("Field"),
                        FieldOrder = row.Field<short>("FieldOrder"),
                        DataType = row.Field<string>("DataType"),
                        Length = row.Field<short>("Length"),
                        Precision = row.Field<string>("Precision"),
                        Scale = row.Field<int>("Scale"),
                        AllowNulls = row.Field<string>("AllowNulls"),
                        Identity = row.Field<string>("Identity"),
                        PrimaryKey = row.Field<string>("PrimaryKey"),
                        ForeignKey = row.Field<string>("ForeignKey"),
                        RelatedTable = row.Field<string>("RelatedTable"),
                        Description = row.Field<string>("Description")
                    });
                }
            }

            return tableDictionary;
        }

        public List<Product> Products(int pIdentifier)
        {
            mHasException = false;

            var productList = new List<Product>();

            var selectStatement =
                @"
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
                ORDER BY P.ProductName;";

            using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand() {Connection = cn})
                {
                    cmd.CommandText = selectStatement;
                    cmd.Parameters.AddWithValue("@CategoryIdentifier", pIdentifier);

                    try
                    {
                        cn.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            productList.Add(new Product()
                            {
                                ProductId = reader.GetInt32(0),
                                ProductName = reader.GetString(1),
                                SupplierId = reader.GetInt32(2),
                                Supplier = reader.GetString(3),
                                Phone = reader.GetString(4),
                                CategoryId = reader.GetInt32(5),
                                UnitPrice = reader.GetDecimal(6),
                                UnitsInStock = reader.GetInt16(7) //reader[7] as decimal? ?? default(decimal)
                            });

                        }
                    }
                    catch (Exception e)
                    {
                        mHasException = true;
                        mLastException = e;
                    }
                }
            }

            return productList;
        }

        public List<Category> Categories()
        {
            mHasException = false;

            var categoryList = new List<Category>();
            var selectStatement = "SELECT CategoryID,CategoryName FROM dbo.Categories";

            using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand() {Connection = cn})
                {
                    cmd.CommandText = selectStatement;
                    try
                    {
                        cn.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            categoryList.Add(new Category()
                            {
                                CategoryId = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                        }
                    }
                    catch (Exception e)
                    {
                        mHasException = true;
                        mLastException = e;
                    }
                }
            }

            return categoryList;
        }

        public Supplier GetSuppliers(int pIdentifier)
        {
            mHasException = false;

            var supplier = new Supplier();

            var selectStatement = 
                "SELECT SupplierID,CompanyName,ContactName,ContactTitle,Phone,[Address] AS Street,City,PostalCode,Country " + 
                "FROM dbo.Suppliers " + 
                "WHERE SupplierID = @SupplierId";


            using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand() {Connection = cn})
                {
                    cmd.Parameters.AddWithValue("@SupplierId", pIdentifier);

                    try
                    {
                        cn.Open();
                        var reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            supplier.SupplierId = pIdentifier;
                            supplier.CompanyName = reader.GetString(0);
                            supplier.ContactName = reader.GetString(1);
                            supplier.ContactTitle = reader.GetString(2);
                            supplier.Phone = reader.GetString(3);
                            supplier.Address = reader.GetString(4);
                            supplier.City = reader.GetString(5);
                            supplier.PostalCode = reader.GetString(6);
                            supplier.Country = reader.GetString(7);
                        }
                    }
                    catch (Exception e)
                    {
                        mHasException = true;
                        mLastException = e;
                    }
                }
            }

            return supplier;

        }

    }
}
