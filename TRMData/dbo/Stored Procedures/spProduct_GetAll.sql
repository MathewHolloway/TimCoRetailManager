CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS
BEGIN
set nocount on;

	select Id, ProductName, [Description], RetailPrice, QuantityInStock
	from [dbo].[Product]
	order by ProductName;
END