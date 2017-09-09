/**************************************************
* 1. Products
***************************************************/
--Id, Name
SET IDENTITY_INSERT ssp.Products ON
DELETE ssp.Products
INSERT INTO ssp.Products(Id, Name, Rank, CreatedBy, CreatedOn) VALUES(1, 'iPad', 0, 'Script', GETDATE())
INSERT INTO ssp.Products(Id, Name, Rank, CreatedBy, CreatedOn) VALUES(2, 'iPhone 7', 0, 'Script', GETDATE())
INSERT INTO ssp.Products(Id, Name, Rank, CreatedBy, CreatedOn) VALUES(3, 'Samsung S5', 0, 'Script', GETDATE())
SET IDENTITY_INSERT ssp.Products OFF