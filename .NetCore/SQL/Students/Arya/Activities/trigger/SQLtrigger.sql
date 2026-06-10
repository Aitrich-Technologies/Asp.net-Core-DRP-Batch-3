create database Employmanagement;
go
use Employmanagement
go

CREATE TABLE Employee (
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(100),
    EmpSalary DECIMAL(10, 2)
);

go
create proc Employee_list(
@EmpID int ,
@EmpName varchar (100),
@EmpSalary decimal (10,2)
)

as
begin
insert into Employee(EmpID,EmpName,EmpSalary )
values(@EmpID,@EmpName,@EmpSalary)
end
go
exec Employee_list 6,'Appu','10000'
select * from Employee;

go
create trigger employee_insert on Employee
after insert
as
begin
print 'Employee added successfully'
end
go

go
create proc Employee_master_update
(@EmpID as int,
 @EmpName as varchar(50),
 @EmpSalary as varchar(30)
)
as
begin 
update Employee
set EmpName  = @EmpName,
EmpSalary = @EmpSalary
where EmpID = @EmpID
end
go
exec Employee_master_update 2,'Appu',7000
select * from Employee;

go
create trigger employee_update on Employee
after update
as
begin
print 'Employee updated successfully'
end
go

CREATE PROC [dbo].[deleteProc]
(@EmpID int)
as
begin
 EXEC ('delete from '+'Employee' + ' where '  +'EmpID'+ '=' +@EmpID)
END
EXEC deleteproc 1

go
create trigger employee_delete on Employee
after delete
as
begin
print 'Employee deleted successfully'
end
go



