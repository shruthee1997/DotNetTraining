Create Procedure GetCustomersByCountry

(@country varchar(30))

As

Select CustomerID, ContactName,CompanyName,Address,Country from Customers Where Country = @country;

Go

 

Execute GetCustomersByCountry 'USA';

 

Create Procedure GetProductsBYCategoryID

(@categoryID int)

As

Select p.ProductID, p.ProductName, p.UnitPrice, p.QuantityPerUnit, c.CategoryID, c.CategoryName

from Products p INNER JOIN Categories c ON p.CategoryID=p.CategoryID and c.CategoryID= @categoryID;

Go

 

Execute GetProductsBYCategoryID '1';

 

Alter Procedure Getinfo

(@date1 date, @date2 date, @countOrder int output)

 

As

 

Select @countOrder=(OrderID) from Orders Where OrderDate Between @date1 And @date2;

 

Go

 

Declare @count as int;

Declare @date1  as date, @date2  as date;

 

set @date1 = '01/20/1996';

set @date2 = '01/20/2000';

 

Execute Getinfo @date1, @date2, @count output;

print 'Total number of orders placed: ' + Convert(varchar(10),@count);