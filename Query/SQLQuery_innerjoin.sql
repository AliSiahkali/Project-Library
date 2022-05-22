select * from Product
select * from Stor
select * from Customer

select Product.ProductID,
       Product.ProductName,
	   Stor.StoreID,
	   Stor.Count,
	   Customer.Fullname,

	   from Product inner join Stor on Product.ProductID=Stor.ProductID
	   inner join Customer on Stor.StoreID=Customer.StoreID