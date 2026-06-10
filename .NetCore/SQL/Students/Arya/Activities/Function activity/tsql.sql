create database companymanagement;
go

use companymanagement
go

create table companyname(
id int primary key,
name varchar(50),
remarks varchar (30)
);

go

create proc company_master_insert(
@name as varchar(50),
@remarks as varchar (30)
)
as 
declare @id as int 
begin
select @id = (select isnull(max (id),0)+1 from companyname)
insert into companyname (id,name,remarks)
values(@id,@name,@remarks);
end 
go

exec company_master_insert 'Anju','Added'

select * from companyname
go

create proc company_master_update
(@id as int,
@name as varchar(50),
@remarks as varchar(30)
)
as
begin
update companyname 
set name = @name,
remarks = @remarks
where id = @id
end
go
exec company_master_update 1,'sanjay','added'
select * from companyname

go

CREATE PROC [dbo].[deleteProc]
(@id int)
as
begin
 EXEC ('delete from '+'companyname' + ' where '  +'id'+ '=' +@id)
END
EXEC deleteproc 1



