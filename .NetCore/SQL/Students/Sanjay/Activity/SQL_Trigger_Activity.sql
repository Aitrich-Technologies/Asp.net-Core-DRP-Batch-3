create database storemanagements;
GO
USE storemanagements
GO

CREATE TABLE Purchase
(
id int PRIMARY KEY,
item_id int,
quantity int,
amount decimal
)

CREATE TABLE Stock
(id int,
item_id int,
quantity int
)

CREATE TABLE Sales
(id int PRIMARY KEY,
item_id int,
quantity int,
amount decimal
)

GO
CREATE PROC Purchase_Table_Insert
(
@item_id AS int,
@quantity AS int,
@amount AS decimal
)
AS
declare @id as int
BEGIN
SELECT  @id= (SELECT ISNULL(MAX(id),0)+1 FROM Purchase)
INSERT INTO Purchase(id, item_id, quantity, amount)
values (@id, @item_id, @quantity, @amount)
END 
GO
EXEC Purchase_Table_Insert 109,7,7000
SELECT * FROM Purchase



GO
CREATE PROC Stock_Table_Insert
(
@item_id AS int,
@quantity AS int
)
AS
declare @id as int
BEGIN
SELECT  @id= (SELECT ISNULL(MAX(id),0)+1 FROM Stock)
INSERT INTO Stock(id, item_id, quantity)
values (@id, @item_id, @quantity)
END 
GO
EXEC Stock_Table_Insert 105,11
SELECT * FROM Stock


GO
CREATE PROC Sales_Table_Insert
(
@item_id AS int,
@quantity AS int,
@amount AS decimal
)
AS
declare @id as int
BEGIN
SELECT  @id= (SELECT ISNULL(MAX(id),0)+1 FROM Sales)
INSERT INTO Sales(id, item_id, quantity, amount)
values (@id, @item_id, @quantity, @amount)
END 
EXEC Sales_Table_Insert 109,7,10000
SELECT * FROM Sales



go
Create trigger [add_stock] on [dbo].[Purchase] for insert
as
begin
PRINT 'Stock Increased'
declare @qty as float,@item_no as bigint,@id as bigint,@stock as float
select @qty=(select quantity from inserted)
select @item_no=(select item_id from inserted)
set @stock=(select count(*) from stock where item_id=@item_no)
if(@stock>0)
begin
update stock set quantity=quantity+@qty where item_id=@item_no
end
else
begin
set @id=(select isnull(max(id),0)+1 from stock)
insert into stock values(@id,@item_no,@qty)
end
end

drop trigger [add_stock]


GO
Create trigger [less_stock] on [dbo].[Sales] for insert
as
begin
PRINT 'Stock Reduced'
declare @qty as float,@item_no as bigint,@id as bigint,@stock as float
select @qty=(select quantity from inserted)
select @item_no=(select item_id from inserted)
set @stock=(select count(*) from stock where item_id=@item_no)
if(@stock>0)
begin
update stock set quantity=quantity-@qty where item_id=@item_no
end
else
begin
set @id=(select isnull(max(id),0)+1 from stock)
insert into stock values(@id,@item_no,@qty)
end
end
