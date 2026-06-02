create database facultymanagement
go
use custommanagement
go
create table employee

(
   ID int,
   Name varchar(5),
   Salary int
   
);
select * from employee;
go

create  proc employ_system(
@id as int,
@name as varchar(100),
@salary as int)
as 
begin
insert into employee (id,name,salary)
values(@id,@name,@salary)
end 
go
exec employ_system 1,'mariy',2000

drop proc employ_system

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


CREATE proc employ_system 
(
@v_id as int,
@v_name as varchar(100),
@v_salary int
)
as
begin
update employee  set Name = @v_name,salary = @v_salary where ID = @v_id
end
go

EXEC employ_system 1,alfin,20000

go
create trigger employes_update
on employee
after update
as
begin
print 'data updated'
end
go

CREATE PROC [dbo].[deleteProc]
(
	@v_id int
	
) AS

BEGIN
		EXEC ('delete from '+'employee' + ' where '  +'ID'+ '=' +@v_id)
END



EXEC deleteproc 1



go
create trigger employes_Delete
on employee
after Delete
as
begin
print 'Deleted'
end
go

select * from employee;
