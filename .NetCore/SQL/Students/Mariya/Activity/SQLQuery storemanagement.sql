create database storemanagement
create table purchase
(
  id int primary key,
item_id int,
quantity int,
amount int);
insert into purchase values(1,101,10,2000);
insert into purchase values(2,102 ,11,4000);
insert into purchase values(3,103,12,5000);


select * from purchase

create table stock
(
  id int,
item_id int,
quantity int

)

select * from stock

create table sales
( 
  id int primary key,
item_id int,
quantity int,
amount int
)
insert into sales values(1,101,8,2000);
insert into sales values(2,102 ,5,4000);
insert into sales values(3,103,3,5000);
select * from sales
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
go
Create trigger [less_stock] on [dbo].[Sales] for insert
as
begin
print 'decreased'
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

