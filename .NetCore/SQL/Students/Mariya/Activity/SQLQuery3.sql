create database employmanagement;
go
use employmanagement
go

create table employ(
id int primary key,
name varchar (100),
salary int);
go

create  proc employ_system(
@id as int,
@name as varchar(100),
@salary as int)
as 
begin

insert into employ (id,name,salary)
values(@id,@name,@salary)
end 
go

exec employ_system 8,'mariya',2000

select * from employ;
go
create trigger employes 
on employ 
after insert
as 
begin
print 'data inserted'
end
go



