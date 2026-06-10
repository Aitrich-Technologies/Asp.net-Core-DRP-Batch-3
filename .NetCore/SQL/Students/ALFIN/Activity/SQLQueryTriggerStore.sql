CREATE DATABASE storemanagement;

go
use storemanagement 
go

create table purchase(
id int primary key,
item_id int,
quantity int,
amount int)

go
create proc purchase_insert(
@item_id as int,
@quantity as int,
@amount as int)
as
declare @id as int
begin
select @id=(select isnull(MAX(id),0)+1 from purchase)
insert into purchase(id,item_id,quantity,amount)
values(@id,@item_id,@quantity,@amount)
end
go
EXEC purchase_insert 101,10,2000


select * from purchase;


go
create table stock(
id int,
item_id int,
quantity int);

go
create proc stock_insert(
@item_id as int,
@quantity as int)
as
declare @id as int
begin
select @id = (select isnull(MAX(id),0)+1 from stock)
insert into stock(id,item_id,quantity)
values(@id,@item_id,@quantity)
end
go
EXEC stock_insert 101,7

select * from stock;

go
create table sales(
id int,
item_id int,
quantity int,
amount int)

go
create proc sales_insert(
@item_id as int,
@quantity as int,
@amount int)
as
declare @id as int
begin
select @id = (select isnull(MAX(id),0)+1 from sales)
insert into sales(id,item_id,quantity,amount)
values(@id,@item_id,@quantity,@amount)
end
EXEC sales_insert 101,7,20000

select * from sales;

go
Create trigger [add_stock] on [dbo].[Purchase] for insert
as
begin
print 'increase'
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
drop trigger [add_stock] ;

go
Create trigger [less_stock] on [dbo].[Sales] for insert
as
begin
print 'decrease'
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
drop trigger  [less_stock];

go
Create trigger [add_stock] on [dbo].[Purchase] for insert
as
begin
print 'increased successfull'
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




