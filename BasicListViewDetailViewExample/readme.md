# Basic ListView: DetailView with SQL-Server

A basic example for reading data from SQL-Server, populate and set Tag property to the primary key for the row which allows on selection to get more information on the current row.
![Image](assets/F1.jpg)

Underlying SELECT statement which filters to one contact type.
```sql
SELECT   Cust.CustomerIdentifier ,
         Cust.CompanyName ,
         cont.FirstName ,
         cont.LastName ,
         PT.PhoneTypeDescription ,
         CCD.PhoneNumber ,
         Countries.CountryName
FROM     Customers AS Cust
         INNER JOIN dbo.Contact AS cont ON Cust.ContactIdentifier = cont.ContactIdentifier
         INNER JOIN dbo.ContactContactDevices AS CCD ON cont.ContactIdentifier = CCD.ContactIdentifier
         INNER JOIN dbo.PhoneType AS PT ON CCD.PhoneTypeIdenitfier = PT.PhoneTypeIdenitfier
         INNER JOIN dbo.Countries ON Cust.CountryIdentfier = Countries.id
WHERE    ( Cust.ContactTypeIdentifier = 7 )
ORDER BY Cust.CompanyName;
```
### Code to populate

Population of data is abstracted to a concrete class to keep things clean.

```csharp
private void Form1_Shown(object sender, EventArgs e)
{
    var dataOperations = new SqlInformation();
    var contacts = dataOperations.GetOwnerContacts();

    ownerContactListView.BeginUpdate();
    foreach (var contact in contacts)
    {

        ownerContactListView.Items.Add(
            new ListViewItem(contact.ItemArray)
            {
                Tag = contact.CustomerIdentifier
            });

    }

    ownerContactListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    ownerContactListView.EndUpdate();

    ownerContactListView.FocusedItem = ownerContactListView.Items[0];
    ownerContactListView.Items[0].Selected = true;
    ActiveControl = ownerContactListView;

}
```
